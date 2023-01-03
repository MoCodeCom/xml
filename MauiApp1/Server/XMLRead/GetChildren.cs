using MauiApp1.Model.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MauiApp1.Server.XMLRead
{
    internal class GetChildren
    {
        private string _name;
        public GetChildren(string name)
        {
            _name = name;
        }
        public List<Users> ReadXml()
        {
            List<Users> lst = new List<Users>();
            XmlDocument doc = new XmlDocument();
            doc.Load(_name);
            XmlNode node = doc.SelectSingleNode("ArrayOfUsers/Users");
            foreach(XmlNode node2 in node.ChildNodes)
            {
                lst.Add(new Users {
                    UserFirstName = node.FirstChild.ToString(),
                    UserLastName = node.Value.ToString(),
                    HomePhone = node.

                    
                    
                    );
            }

            return lst;

        }
    }
}
