using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DoAnWebHocLapTrinh.Models
{
    public class BaiDang
    {
        public int IdBaiDang { get; set; }
        public string NoiDungBaiDang { get; set; }
        public User User { get; set; }
       
    }
}