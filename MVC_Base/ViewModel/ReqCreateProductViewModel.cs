using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;


namespace MVC_Base.ViewModel
{
    [ValidateNever]
    public class ReqCreateProductViewModel
    {
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
        /// 停產
        /// </summary>
        [Display(Name = "停產")]
        public bool Discontinued { get; set; }

    }
}