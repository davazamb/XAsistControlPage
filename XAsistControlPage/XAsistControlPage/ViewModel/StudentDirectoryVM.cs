using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XAsistControlPage.Model.Entities;
using XAsistControlPage.Model.Services;

namespace XAsistControlPage.ViewModel
{
    public class StudentDirectoryVM
    {
        //Coleccion para mostrar el listado de estudiantes
        public ObservableCollection<Student> Students { get; set; }

        bool isBusy = false;
        public bool IsBusy
        {
            get { return isBusy; }
            set { isBusy = value; }
        }
        //LLamados Command
        public Command LoadDirectoryCommand { get; set; }

        //Constructor
        public StudentDirectoryVM ()
        {
            Students = new ObservableCollection<Student>();
            IsBusy = false;
            LoadDirectoryCommand = new Command((obj) => LoadDirectory());
        }

        private async void LoadDirectory()
        {
            if(!IsBusy)
            {
                IsBusy = true;
                await Task.Delay(3000);
                var loadedDirectory = StudentDirectoryService.LoadStudentDirectory();

                foreach (var student in loadedDirectory.Students)
                {
                    Students.Add(student);
                }
                IsBusy = false;
            }
        }
    }
}
