using MauiApp1.Model.Data;
using MauiApp1.Model.Interface;
using MauiApp1.ViewModel.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.ViewModel.DependecyInjectionCls
{
    internal class ModelViewUsers : IModelViewUsers
    {
        
        public List<Users> GetAllUsers()
        {
            List<Users> lst = new List<Users>();
            lst.Add(new Users {
            UserFirstName = "Mohammed",
            UserLastName = "Alfadhel",
            HomePhone = "07460251548",
            Note = "user one"
            });

            lst.Add(new Users
            {
                UserFirstName = "Hasan",
                UserLastName = "Alfadhel",
                HomePhone = "07430251548",
                Note = "user Two"
            });

            lst.Add(new Users
            {
                UserFirstName = "Ahmed",
                UserLastName = "Alfadhel",
                HomePhone = "07460301548",
                Note = "user Three"
            });

            lst.Add(new Users
            {
                UserFirstName = "Rasha",
                UserLastName = "AlMohy",
                HomePhone = "07460253008",
                Note = "user Four"
            });

            return lst;
        }

        public Users GetUser()
        {
            throw new NotImplementedException();
        }
    }
}
