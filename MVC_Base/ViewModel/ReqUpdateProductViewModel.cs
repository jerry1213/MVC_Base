using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;


namespace MVC_Base.ViewModel
{
    [ValidateNever]
    public class ReqUpdateBuViewModel
    {
        [Display(Name = "ProductID")]
        public string ProductID { get; set; } = null!;

        /// <summary>
        /// 產品名稱
        /// </summary>
        [Display(Name = "產品名稱")]
        public string ProductName { get; set; } = null!;

        /// <summary>
        /// 類別
        /// </summary>
        [Display(Name = "類別")]
        public string? Category { get; set; }

        /// <summary>
        /// 供應商
        /// </summary>
        [Display(Name = "供應商")]
        public string? Supplier { get; set; }

        /// <summary>
        /// 單位數量
        /// </summary>
        [Display(Name = "單位數量")]
        public string QuantityPerUnit { get; set; } = null!;

        /// <summary>
        /// 單價
        /// </summary>
        [Display(Name = "單價")]
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// 庫存單位
        /// </summary>
        [Display(Name = "庫存單位")]
        public short? UnitsInStock { get; set; }

        /// <summary>
        /// 訂購單位
        /// </summary>
        [Display(Name = "訂購單位")]
        public short? UnitsOnOrder { get; set; }

        /// <summary>
        /// 再訂購級別
        /// </summary>
        [Display(Name = "再訂購級別")]
        public short? ReorderLevel { get; set; }

        /// <summary>
        /// 停產
        /// </summary>
        [Display(Name = "停產")]
        public bool Discontinued { get; set; }
    }
}