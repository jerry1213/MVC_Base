using System.ComponentModel;

namespace MVC_Base.ViewModel
{
    internal class RespBuViewModel
    {
        public string ProductID { get; set; } = null!;

        /// <summary>
        /// 產品名稱
        /// </summary>
        [Description("產品名稱")]
        public string? ProductName { get; set; }

        /// <summary>
        /// 單位數量
        /// </summary>
        [Description("單位數量")]
        public string? QuantityPerUnit { get; set; }

        /// <summary>
        /// 單價
        /// </summary>
        [Description("單價")]
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// 庫存單位
        /// </summary>
        [Description("庫存單位")]
        public short? UnitsInStock { get; set; }

        /// <summary>
        /// 訂購單位
        /// </summary>
        [Description("訂購單位")]
        public short? UnitsOnOrder { get; set; }

        /// <summary>
        /// 再訂購級別
        /// </summary>
        [Description("再訂購級別")]
        public short? ReorderLevel { get; set; }

        /// <summary>
        /// 停產
        /// </summary>
        [Description("停產")]
        public bool Discontinued { get; set; }

        /// <summary>
        /// 類別
        /// </summary>
        [Description("類別")]
        public string? Category { get; set; }

        /// <summary>
        /// 供應商
        /// </summary>
        [Description("供應商")]
        public string? Supplier { get; set; }
    }
}