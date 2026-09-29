using System;
using System.Collections.Generic;
using System.Text;

namespace XumChustka.Domain.Models;

/// <summary>
/// Категория изделия
/// </summary>

public class Category
{
    public int Id { get; set; }

    /// <summary>
    /// Название категории
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Рекомендуемый вид чистки
    /// </summary>
    public string CleaningType { get; set; } = string.Empty;

    /// <summary>
    /// Стоимость чистки за единицу
    /// </summary>
    public decimal Price { get; set; }
}
