using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnWebHocLapTrinh.Models
{
    public class BinhLuan
    {
        public int IdBinhLuan { get; set; }
        public string NoiDungBinhLuan { get; set; }
        public User User { get; set; }
    }
}