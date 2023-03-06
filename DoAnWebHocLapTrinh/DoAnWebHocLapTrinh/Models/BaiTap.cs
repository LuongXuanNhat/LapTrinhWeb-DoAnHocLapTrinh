using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAnWebHocLapTrinh.Models
{
    public class BaiTap
    {
        [Key]
        public int IdBaiTap { get; set; }
        public string TenBaiTap { get; set; }
        public string NoiDungBaiTap { get; set; }
        public BaiHoc BaiHoc { get; set; }


    }
}