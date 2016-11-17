using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using SQLite;
using XAsistControlPage.Storage.Interfaces;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(XAsistControlPage.iOS.Storage.Implementations.ISQLiteIOS))]
namespace XAsistControlPage.iOS.Storage.Implementations
{
    public class ISQLiteIOS : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            SQLitePCL.Batteries.Init();
            var sqliteFilename = "TodoSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string libraryPath = Path.Combine(documentsPath, "..", "Library");
            var path = Path.Combine(documentsPath, sqliteFilename);
            //Crear Conexion
            var conn = new SQLite.SQLiteConnection(path);
            //Retorna conexion db
            return conn;
        }
    }
}