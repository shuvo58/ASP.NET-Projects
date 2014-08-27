using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebMdApp_02.Models
{
    public class Advertise
    {
        public int AdvertiseId { set; get; }
        public string AdvertiseTitle { set; get; }
        public string AdvertiseContent { set; get; }
        public string ImagePath { set; get; }
    }
}