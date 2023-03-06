using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAnWebHocLapTrinh.Models
{
    public class BaiHoc
    {
        [Key]
        public int IdBaiHoc { get; set; }
        public string TenBaiHoc { get; set; }

        public KhoaHoc KhoaHoc { get; set; }

    }
}