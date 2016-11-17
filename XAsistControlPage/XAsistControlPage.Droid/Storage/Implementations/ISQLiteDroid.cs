using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite;
using XAsistControlPage.Storage.Interfaces;
using System.IO;
using Xamarin.Forms;

[assembly: Dependency(typeof(XAsistControlPage.Droid.Storage.Implementations.ISQLiteDroid))]
namespace XAsistControlPage.Droid.Storage.Implementations
{
    public class ISQLiteDroid : ISQLite
    {
        public SQLiteConnection GetConnection()
        {
            SQLitePCL.Batteries.Init();
            var sqliteFilename = "TodoSQLite.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, sqliteFilename);
            //Crear Conexion
            var conn = new SQLite.SQLiteConnection(path);
            //Retorna conexion db
            return conn;
        }
    }
}