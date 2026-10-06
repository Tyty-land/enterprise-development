using System;
using System.Collections.Generic;
using System.Text;

using XumChustka.Domain.Models;

namespace XumChustka.Tests;

/// <summary>
/// Тестовый набор данных
/// </summary>
public static class DataTest
{
    /// <summary>
    /// 10 Категорий
    /// </summary>
    public static readonly List<Category> Categories = new()
    {
        new Category { Id = 1, Name = "Верхняя одежда", CleaningType = "Сухая химчистка", Price = 1500m },
        new Category { Id = 2, Name = "Деловые костюмы", CleaningType = "Сухая чистка", Price = 1800m },
        new Category { Id = 3, Name = "Платья и юбки", CleaningType = "Деликатная чистка", Price = 1100m },
        new Category { Id = 4, Name = "Рубашки и блузы", CleaningType = "Аквачистка", Price = 600m },
        new Category { Id = 5, Name = "Трикотаж и свитера", CleaningType = "Бережная стирка", Price = 750m },
        new Category { Id = 6, Name = "Кожаные изделия", CleaningType = "Чистка с пропиткой", Price = 3500m },
        new Category { Id = 7, Name = "Обувь", CleaningType = "Комплексная чистка", Price = 2500m },
        new Category { Id = 8, Name = "Постельное белье", CleaningType = "Стирка и глажка", Price = 500m },
        new Category { Id = 9, Name = "Шторы и гардины", CleaningType = "Паровая обработка", Price = 950m },
        new Category { Id = 10, Name = "Пуховики", CleaningType = "Аквачистка с сушкой пера", Price = 2200m }
    };

    /// <summary>
    /// 10 Клиентов
    /// </summary>
    public static readonly List<Client> Clients = new()
    {
        new Client { Id = 1, FIO = "Иванов Иван Иванович", PhoneNumber = "+79231112233" },
        new Client { Id = 2, FIO = "Петров Петр Петрович", PhoneNumber = "+79071023344" },
        new Client { Id = 3, FIO = "Сидорова Анна Сергеевна", PhoneNumber = "+79103334455" },
        new Client { Id = 4, FIO = "Смирнов Алексей Дмитриевич", PhoneNumber = "+79004445566" },
        new Client { Id = 5, FIO = "Кузнецова Елена Владимировна", PhoneNumber = "+79005556677" },
        new Client { Id = 6, FIO = "Попов Максим Олегович", PhoneNumber = "+79056612788" },
        new Client { Id = 7, FIO = "Васильева Ольга Николаевна", PhoneNumber = "+79007778899" },
        new Client { Id = 8, FIO = "Новиков Артем Игоревич", PhoneNumber = "+79278889900" },
        new Client { Id = 9, FIO = "Морозова Екатерина Павловна", PhoneNumber = "+79889990011" },
        new Client { Id = 10, FIO = "Федоров Сергей Александрович", PhoneNumber = "+79140001122" }
    };

    /// <summary>
    /// 10 Изделий
    /// </summary>
    public static readonly List<Item> Items = new()
    {
        new Item { Id = 1, Name = "Пальто демисезонное", Material = "Пух", CategoryId = 1, Category = Categories[0] },
        new Item { Id = 2, Name = "Костюм", Material = "Шерсть", CategoryId = 2, Category = Categories[1] },
        new Item { Id = 3, Name = "Вечернее платье", Material = "Шелк", CategoryId = 3, Category = Categories[2] },
        new Item { Id = 4, Name = "Белая рубашка", Material = "Хлопок", CategoryId = 4, Category = Categories[3] },
        new Item { Id = 5, Name = "Шерстяной свитер", Material = "Шерсть", CategoryId = 5, Category = Categories[4] },
        new Item { Id = 6, Name = "Косуха", Material = "Натуральная кожа", CategoryId = 6, Category = Categories[5] },
        new Item { Id = 7, Name = "Замшевые ботинки", Material = "Замша", CategoryId = 7, Category = Categories[6] },
        new Item { Id = 8, Name = "Постельное бельё", Material = "Хлопок", CategoryId = 8, Category = Categories[7] },
        new Item { Id = 9, Name = "Тюль", Material = "Лен", CategoryId = 9, Category = Categories[8] },
        new Item { Id = 10, Name = "Зимний пуховик", Material = "Полиэстер/Пух", CategoryId = 10, Category = Categories[9] }
    };

    /// <summary>
    /// 12 Заказов
    /// </summary>
    public static readonly List<Order> Orders = new()
    {
        new Order { Id = 1, ClientId = 1, Client = Clients[0], ItemId = 6, Item = Items[5], AcceptDate = DateTime.Today.AddDays(-20), ExeDays = 7, Status = Status.Given },
        new Order { Id = 2, ClientId = 1, Client = Clients[0], ItemId = 7, Item = Items[6], AcceptDate = DateTime.Today.AddDays(-10), ExeDays = 5, Status = Status.Completed },
        new Order { Id = 3, ClientId = 1, Client = Clients[0], ItemId = 1, Item = Items[0], AcceptDate = DateTime.Today.AddDays(-2), ExeDays = 14, Status = Status.InProgress },
        new Order { Id = 4, ClientId = 2, Client = Clients[1], ItemId = 2, Item = Items[1], AcceptDate = DateTime.Today.AddDays(-5), ExeDays = 4, Status = Status.InProgress },
        new Order { Id = 5, ClientId = 2, Client = Clients[1], ItemId = 4, Item = Items[3], AcceptDate = DateTime.Today.AddDays(-1), ExeDays = 2, Status = Status.InProgress },
        new Order { Id = 6, ClientId = 3, Client = Clients[2], ItemId = 3, Item = Items[2], AcceptDate = DateTime.Today.AddDays(-15), ExeDays = 3, Status = Status.Given },
        new Order { Id = 7, ClientId = 3, Client = Clients[2], ItemId = 8, Item = Items[7], AcceptDate = DateTime.Today.AddDays(-14), ExeDays = 3, Status = Status.Given },
        new Order { Id = 8, ClientId = 4, Client = Clients[3], ItemId = 10, Item = Items[9], AcceptDate = DateTime.Today.AddDays(-30), ExeDays = 10, Status = Status.Given },
        new Order { Id = 9, ClientId = 5, Client = Clients[4], ItemId = 5, Item = Items[4], AcceptDate = DateTime.Today.AddDays(-8), ExeDays = 12, Status = Status.Completed },
        new Order { Id = 10, ClientId = 6, Client = Clients[5], ItemId = 9, Item = Items[8], AcceptDate = DateTime.Today.AddDays(-400), ExeDays = 4, Status = Status.Given },
        new Order { Id = 11, ClientId = 7, Client = Clients[6], ItemId = 4, Item = Items[3], AcceptDate = DateTime.Today.AddDays(-4), ExeDays = 1, Status = Status.InProgress },
        new Order { Id = 12, ClientId = 8, Client = Clients[7], ItemId = 1, Item = Items[0], AcceptDate = DateTime.Today.AddDays(-50), ExeDays = 6, Status = Status.Given }
    };
}
