using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using SQLite.Config;
using SQLite.Net.Interop;
using Xamarin.Forms;
using UIKit;


[assembly: Dependency(typeof(SQLite.iOS.Config))]
namespace SQLite.iOS
{
    public class Config : IConfig //IMPLEMENTAR XAMARIN FORMS EN USING!!!
    {
        private string directorioDB;
        private ISQLitePlatform plataforma;
        public string DirectorioDB
        {
            get
            {
                if (string.IsNullOrEmpty(directorioDB))
                {
                    var directorio = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                    directorioDB = System.IO.Path.Combine(directorio, "..", "Library");
                }
                return directorioDB;
            }
        }

        public ISQLitePlatform Plataforma
        {
            get
            {
                if(plataforma == null)
                {
                    plataforma = new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();
                }
                return plataforma;
            }
        }
    }
}