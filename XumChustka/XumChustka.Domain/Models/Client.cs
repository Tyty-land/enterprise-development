using System;
using System.Collections.Generic;
using System.Text;

namespace XumChustka.Domain.Models;

/// <summary>
/// Клиент
/// </summary>

public class Client
{
    public int Id { get; set; }

    /// <summary>
    /// ФИО клиента
    /// </summary>
    public string FIO { get; set; } = string.Empty;

    /// <summary>
    /// Номер телефона
    /// </summary>
    public string PhoneNumber { get; set; } = string.Empty;
}
