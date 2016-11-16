using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using XAsistControlPage.Model.Entities;

namespace XAsistControlPage.View
{
    public partial class SelectStudentDetailPage : ContentPage
    {
        public Student SelectedStudent
        {
            get;
            set;
        }

        public SelectStudentDetailPage(Student selectedStudent)
        {
            InitializeComponent();
            SelectedStudent = selectedStudent;
            this.BindingContext = SelectedStudent;
        }

    }
}
