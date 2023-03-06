using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnWebHocLapTrinh.Models
{
    public class KhoaHoc
    {
        public int IdKhoaHoc { get; set; }
        public string TenKhoaHoc { get; set; }
        public int CapDo { get; set; }
        public NgonNgu NgonNgu { get; set; }

    }
}