using MauiApp1.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModel.Interface
{
    internal interface IModelViewUsers
    {
        List<Users> GetAllUsers();
        Users GetUser();
    }
}
