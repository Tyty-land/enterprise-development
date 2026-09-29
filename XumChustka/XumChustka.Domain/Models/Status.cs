using System;
using System.Collections.Generic;
using System.Text;
namespace XumChustka.Domain.Models;

/// <summary>
/// Статус обработки заказа
/// </summary>

public enum Status
{
    Accept, //Принят
    InProgress, //Исполняется
    Completed, //Готов к выдаче
    Given //Выдан

}
