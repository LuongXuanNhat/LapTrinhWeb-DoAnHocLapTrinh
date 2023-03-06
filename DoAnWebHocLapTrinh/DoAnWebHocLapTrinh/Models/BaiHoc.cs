using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnWebHocLapTrinh.Models
{
    public class BaiHoc
    {
        public int IdBaiHoc { get; set; }
        public string TenBaiHoc { get; set; }
        public KhoaHoc khoaHoc { get; set; }
    }
}