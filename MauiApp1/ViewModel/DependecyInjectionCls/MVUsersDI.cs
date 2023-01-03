using MauiApp1.Model.Data;
using MauiApp1.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModel.DependecyInjectionCls
{
    internal class MVUsersDI
    {
        private IModelViewUsers _modelViewUsers { get; set; }

        public MVUsersDI(IModelViewUsers modelViewUsers)
        {
            _modelViewUsers = modelViewUsers;
        }

        public List<Users> GetAllUsers()
        {
            return _modelViewUsers.GetAllUsers();
        }
    }
}
