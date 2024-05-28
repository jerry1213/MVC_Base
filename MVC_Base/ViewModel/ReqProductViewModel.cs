using MVC_Base.Models;

namespace MVC_Base.ViewModel;

public class ReqProductViewModel
{
    /// <summary>
    /// 產品名稱
    /// </summary>
    public string? ProductName { get; set; }

    /// <summary>
    /// 單位數量
    /// </summary>
    public string? QuantityPerUnit { get; set; }

    /// <summary>
    /// 單價
    /// </summary>
    public decimal? UnitPrice { get; set; }

    /// <summary>
    /// 庫存單位
    /// </summary>
    public short? UnitsInStock { get; set; }

    /// <summary>
    /// 訂購單位
    /// </summary>
    public short? UnitsOnOrder { get; set; }

    /// <summary>
    /// 再訂購級別
    /// </summary>
    public short? ReorderLevel { get; set; }

    /// <summary>
    /// 停產
    /// </summary>
    public bool Discontinued { get; set; }

    /// <summary>
    /// 類別
    /// </summary>
    public string? Category { get; set; }

    /// <summary>
    /// 供應商
    /// </summary>
    public string? Supplier { get; set; }
}
