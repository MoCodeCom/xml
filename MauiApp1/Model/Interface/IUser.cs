using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Model.Interface
{
    internal interface IUser
    {
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string HomePhone { get; set; }
        public string Note { get; set; }
    }
}
