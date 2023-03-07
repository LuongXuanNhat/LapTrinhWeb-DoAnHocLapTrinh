using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnWebHocLapTrinh.Models
{
    public class NgonNgu
    {
        public int IdNgonNgu { get; set; }
        public string TenNgonNgu { get; set; }
        public DanhMuc DanhMuc { get; set; }
    }
}