using Microsoft.Maui;
using Microsoft.Maui.Controls.Compatibility;
using Syncfusion.Maui.Data;
using Syncfusion.Maui.DataGrid;
using Syncfusion.Maui.DataGrid.Helper;
using System.Diagnostics;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            viewModel.Employees.Add(new Employee()
            {
                EmployeeID = "1002",
                Name = "Sean Jacobson",
                IDNumber = 99,
                ContactID = 199,
                ManagerID = 2,
                LoginID = "sean2",
                Gender = "Male",
                Title = "GM",
                MaritalStatus = "Single",
                HireDate = new DateTime(2023, 01, 03),
                BirthDate = new DateTime(2023, 01, 03),
                SickLeaveHours = 14,
                Salary = 5999,
                EmployeeStatus = true,
                Rating = 1,
            });
        }
    }
}
