using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyAd.Core
{
    /// <summary>
    /// 微信信息表
    /// <remarks>
    /// Created at 2016.10.17
    /// </remarks>
    /// </summary>
    public class WeixinData
    {
        [Key]
        public int WeixinDataID { get; set; }

        /// <summary>
        /// 微信账号
        /// </summary>
        [Required(ErrorMessage = "{0}必填")]
        [Display(Name = "微信账号")]
        public string Account { get; set; }

        /// <summary>
        /// 账号类别
        /// </summary>
        [Required(ErrorMessage = "{0}必填")]
        [Display(Name = "账号类别")]
        public string AccountType { get; set; }

        /// <summary>
        /// 粉丝数
        /// </summary>
        [Required(ErrorMessage = "{0}必填")]
        [Display(Name = "粉丝数")]
        public int FunsNum { get; set; }

        /// <summary>
        /// 推广模式
        /// </summary>
        [Required(ErrorMessage = "{0}必填")]
        [Display(Name = "推广模式")]
        public string AdMode { get; set; }

        /// <summary>
        /// 推广价格
        /// </summary>
        [Required(ErrorMessage = "{0}必填")]
        [Display(Name = "推广价格")]
        public string AdPrice { get; set; }

        /// <summary>
        /// 对应主表数据ID
        /// </summary>
        public virtual MainData MainData { get; set; }
    }
}