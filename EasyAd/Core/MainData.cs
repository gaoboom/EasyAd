using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EasyAd.Core
{
    /// <summary>
    /// 主表
    /// <remarks>
    /// Created at 2016.10.17
    /// </remarks>
    /// </summary>
    public class MainData
    {
        [Key]
        public int MainDataID { get; set; }

        /// <summary>
        /// 资源名称
        /// </summary>
        [Required(ErrorMessage ="{0}必填")]
        [Display(Name ="资源名称")]
        public string Name { get; set; }

        /// <summary>
        /// 资源类别
        /// </summary>
        [Required(ErrorMessage = "{0}必填")]
        [Display(Name = "资源类别")]
        public string Type { get; set; }

        /// <summary>
        /// 所属行业
        /// </summary>
        [Required(ErrorMessage = "{0}必填")]
        [Display(Name = "所属行业")]
        public string Industry { get; set; }

        /// <summary>
        /// 可投放地区
        /// </summary>
        [Required(ErrorMessage = "{0}必填")]
        [Display(Name = "可投放地区")]
        public string Region { get; set; }

        /// <summary>
        /// 最后更新时间
        /// </summary>
        [Display(Name = "最后更新时间")]
        public DateTime UpdateTime { get; set; }

        /// <summary>
        /// 资源可用状态:可用-1，不可用-0，可直接投放-2
        /// </summary>
        [Required(ErrorMessage = "{0}必填")]
        [Display(Name = "资源可用状态")]
        public int Status { get; set; }
    }
}