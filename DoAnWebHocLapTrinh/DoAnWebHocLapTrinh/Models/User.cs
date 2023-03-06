using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnWebHocLapTrinh.Models
{
    public class User
    {
        public int IdUser { get; set; }
        public string TenUser { get; set; }
        public string Email { get; set; }
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
    }
}