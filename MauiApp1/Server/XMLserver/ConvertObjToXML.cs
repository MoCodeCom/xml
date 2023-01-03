using MauiApp1.Model.Data;
using MauiApp1.ViewModel.DependecyInjectionCls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Xml.Serialization;

namespace MauiApp1.Server.XMLserver
{
    internal class ConvertObjToXML
    {
        private List<Users> _lstusers { get; set; }
        private string _xmlStream;
        public ConvertObjToXML(List<Users> lstusers, string xmlStream)
        {
            _lstusers = lstusers;
            _xmlStream = xmlStream;
        } 

        public void convertobjToxml()
        {
            var serializer = new XmlSerializer(typeof(List<Users>));
            using (var sr = new StreamWriter(_xmlStream))
            {
                serializer.Serialize(sr, _lstusers);
            }
            
   
        }
    }
}
