
using MauiApp1.Model.Data;
using MauiApp1.Server.XMLserver;
using MauiApp1.ViewModel.DependecyInjectionCls;
using System.Xml;

namespace MauiApp1.View.HomePage;

public partial class Home : ContentPage
{
	MVUsersDI mvLst = new MVUsersDI(new ModelViewUsers());

    public Home()
	{
		InitializeComponent();
		lstUsers.ItemsSource = mvLst.GetAllUsers();
	
	}

    private void Button_Clicked_WriteXML(object sender, EventArgs e)
    {
		string xmlFileName = "xml_1.xml";
		/*Folder name which contain XML file*/
		string xmlDirName = "DatabaseXml";
		//string strPath = Environment.CurrentDirectory;
		//string strDirParent = Directory.GetParent(strPath).FullName;
		/*strBase is Directory path*/
		string strBase = AppDomain.CurrentDomain.BaseDirectory;
        /*Check wheather file is exist?*/
        bool existXml = Directory.Exists(strBase+xmlDirName);
        

        if (existXml)
		{
			/*path for XML file*/
			string FullPath = strBase + @"\" + xmlDirName + @"\" + xmlFileName;
			/*Check wheather file is exist?*/
            bool existXmlFile = File.Exists(FullPath);
			MemoryStream ms = new MemoryStream();
			if(!existXmlFile)
			{
				/*Creat XML file in the path*/
				XmlWriter.Create(FullPath);
				DisplayAlert("Creating XML file","Create xml file is done.","Close");
                
            }
			else
			{
                /* Converting Object of list to XML*/
                ConvertObjToXML convXML = new ConvertObjToXML(mvLst.GetAllUsers(), FullPath);
                convXML.convertobjToxml();

                DisplayAlert("Converting to XML data", "Converting is done", "Cancel");
            }

		}
		else
		{
			/*Generate new Directory to save XML data*/
			MyDir(strBase, xmlDirName);
			
			DisplayAlert("Database folder","Generating Folder is done in ther Current path is: "+ strBase,"Cancel");
		}

    }


	public void MyDir(string pathDomain, string FolderName)
	{
		DirectoryInfo d = new DirectoryInfo(pathDomain);
		d.CreateSubdirectory(FolderName);
	}

    private void Button_Clicked_ReadXML(object sender, EventArgs e)
    {
		// reader = new XmlReader();
    }
}