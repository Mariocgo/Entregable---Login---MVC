using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Login.Models.TableViewModels
{
    public class UserTableViewModel
    {
        public int? id { get; set; }
        public String Email { get; set; }
        public int? Edad { get; set; }
    }
}