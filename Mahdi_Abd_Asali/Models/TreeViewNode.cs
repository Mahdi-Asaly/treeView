using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Mahdi_Abd_Asali.Models
{
    public class TreeViewNode
    {
        public int id { get; set; }
        public string parent { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public string text { get; set; }
    }
}