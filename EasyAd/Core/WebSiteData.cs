using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyAd.Core
{
    /// <summary>
    /// WebSite data model
    /// <remarks>
    /// Created at 2016.10.18
    /// </remarks>
    /// </summary>
    public class WebSiteData
    {
        [Key]
        public int WebSiteDataID { get; set; }

        /// <summary>
        /// 网站类别
        /// </summary>
        [Required(ErrorMessage = "{0}必填")]
        [Display(Name = "网站类别")]
        public string SiteType { get; set; }

        /// <summary>
        /// 网站月均UV
        /// </summary>
        [Required(ErrorMessage = "{0}必填")]
        [Display(Name = "月均独立访客量")]
        public float UVperMonth { get; set; }

        /// <summary>
        /// 网站月均PV
        /// </summary>
        [Required(ErrorMessage = "{0}必填")]
        [Display(Name = "月均页面浏览量")]
        public float PVperMonth { get; set; }

        /// <summary>
        /// 网站人均PV
        /// </summary>
        [Required(ErrorMessage = "{0}必填")]
        [Display(Name = "人均页面浏览量")]
        public float PVperUser { get; set; }

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