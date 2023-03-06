using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DoAnWebHocLapTrinh.Models
{
    public class NgonNgu
    {
        [Key]
        public int IdNgonNgu { get; set; }
        public string TenNgonNgu { get; set; }
        public DanhMuc DanhMuc { get; set; }

    }
}