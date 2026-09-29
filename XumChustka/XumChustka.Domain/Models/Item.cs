using System;
using System.Collections.Generic;
using System.Text;

namespace XumChustka.Domain.Models;

/// <summary>
/// Изделие
/// </summary>

public class Item
{
    public int Id { get; set; }

    /// <summary>
    /// Наименование
    /// </summary>
    public string Name { get; set; } = string.Empty;

    /// <summary>
    /// Материал
    /// </summary>
    public string Material { get; set; } = string.Empty;

    /// <summary>
    /// Id-категории
    /// </summary>
    public int CategoryId { get; set; }

    /// <summary>
    /// Категория
    /// </summary>
    public Category Category { get; set; } = null!;
}
