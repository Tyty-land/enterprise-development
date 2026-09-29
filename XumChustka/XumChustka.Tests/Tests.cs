using XumChustka.Domain.Models;
using Xunit;

namespace XumChustka.Tests;

public class Tests
{
    /// <summary>
    /// Тест 1: Заказы в обработке, упорядоченные по дате приема
    /// </summary>
    [Fact]
    public void GetOrdersInProgress_ShouldReturnOrdersOrderedByAcceptDate()
    {
        var result = DataTest.Orders
            .Where(o => o.Status == Status.InProgress)
            .OrderBy(o => o.AcceptDate)
            .ToList();

        Assert.NotEmpty(result);
        Assert.All(result, order => Assert.Equal(Status.InProgress, order.Status));

        for (var i = 0; i < result.Count - 1; i++)
        {
            Assert.True(result[i].AcceptDate <= result[i + 1].AcceptDate);
        }
    }

    /// <summary>
    /// Тест 2: Топ 5 клиентов, сдавших больше всего изделий за заданный период
    /// </summary>
    [Fact]
    public void GetTop5Clients_ByItemsCount_ShouldReturnCorrectClients()
    {
        var startDate = DateTime.Today.AddDays(-30);
        var endDate = DateTime.Today;

        var result = DataTest.Orders
            .Where(o => o.AcceptDate >= startDate && o.AcceptDate <= endDate)
            .GroupBy(o => o.Client)
            .Select(group => new
            {
                Client = group.Key,
                ItemsCount = group.Count()
            })
            .OrderByDescending(x => x.ItemsCount)
            .Take(5)
            .ToList();

        Assert.NotEmpty(result);
        Assert.True(result.Count <= 5);
        if (result.Count > 1)
        {
            Assert.True(result[0].ItemsCount >= result[1].ItemsCount);
        }
    }

    /// <summary>
    /// Тест 3: Клиенты, чьи заказы обрабатывались дольше всего, упорядоченные по ФИО
    /// </summary>
    [Fact]
    public void GetClientsWithLongestOrders_ShouldReturnOrderedByFIO()
    {
        var maxDays = DataTest.Orders.Max(o => o.ExeDays);

        var result = DataTest.Orders
            .Where(o => o.ExeDays == maxDays)
            .Select(o => o.Client)
            .Distinct()
            .OrderBy(c => c.FIO)
            .ToList();

        Assert.NotEmpty(result);
        for (var i = 0; i < result.Count - 1; i++)
        {
            Assert.True(string.Compare(result[i].FIO, result[i + 1].FIO, StringComparison.Ordinal) <= 0);
        }
    }

    /// <summary>
    /// Тест 4: Топ-5 наиболее и наименее популярных категорий изделий за последний год
    /// </summary>
    [Fact]
    public void GetTopAndLeastPopularCategories_ForLastYear_ShouldReturnCorrectData()
    {
        var oneYearAgo = DateTime.Today.AddDays(-365);

        var categoryPopularity = DataTest.Orders
            .Where(o => o.AcceptDate >= oneYearAgo)
            .GroupBy(o => o.Item.Category)
            .Select(group => new
            {
                Category = group.Key,
                OrdersCount = group.Count()
            })
            .ToList();

        var mostPopular = categoryPopularity
            .OrderByDescending(x => x.OrdersCount)
            .Take(5)
            .ToList();

        var leastPopular = categoryPopularity
            .OrderBy(x => x.OrdersCount)
            .Take(5)
            .ToList();

        Assert.NotEmpty(mostPopular);
        Assert.NotEmpty(leastPopular);
        Assert.True(mostPopular.Count <= 5);
        Assert.True(leastPopular.Count <= 5);
    }

    /// <summary>
    /// Тест 5: Клиент, который потратил наибольшую сумму за весь период
    /// </summary>
    [Fact]
    public void GetClientWithMaxTotalSpent_ShouldReturnTopSpendingClient()
    {
        var result = DataTest.Orders
            .GroupBy(o => o.Client)
            .Select(group => new
            {
                Client = group.Key,
                TotalSpent = group.Sum(o => o.Item.Category.Price)
            })
            .OrderByDescending(x => x.TotalSpent)
            .FirstOrDefault();

        Assert.NotNull(result);
        Assert.True(result.TotalSpent > 0);

        Assert.Equal("Иванов Иван Иванович", result.Client.FIO);
        Assert.Equal(7500m, result.TotalSpent);
    }
}
