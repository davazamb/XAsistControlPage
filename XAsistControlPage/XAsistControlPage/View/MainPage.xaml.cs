using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XAsistControlPage.Model.Entities;
using XAsistControlPage.View;
using XAsistControlPage.ViewModel;

namespace XAsistControlPage
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new StudentDirectoryVM();
            lvStudents.ItemSelected += lvStudents_ItemSelected;
        }

        private void lvStudents_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            Student selectedStudent = (Student)e.SelectedItem;
            if (selectedStudent == null)
                return;
            Navigation.PushAsync(new SelectStudentDetailPage(selectedStudent));
            lvStudents.SelectedItem = null;
        }
    }
}
