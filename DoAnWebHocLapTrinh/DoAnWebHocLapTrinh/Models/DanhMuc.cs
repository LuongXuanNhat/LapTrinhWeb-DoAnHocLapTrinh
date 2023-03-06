using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAnWebHocLapTrinh.Models
{
    public class DanhMuc
    {
        [Key]
        public int IdDanhMuc { get; set; }
        public string TenDanhMuc { get; set; }

    }
}