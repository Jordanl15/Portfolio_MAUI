using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using Lab9.Model;
using Lab9.Service;

namespace Lab9.ViewModel
{
	public partial class EmployeeViewModel : ObservableObject
	{
		private readonly DataAccess Data;

		[ObservableProperty]
		ObservableCollection<Employee> employees;

		[ObservableProperty]
		Employee employee;

		public EmployeeViewModel(DataAccess Data)
		{
			this.Data = Data;
			Employees = new ObservableCollection<Employee>(Data.GetEmployees());
		}

		[ICommand]
		void Add()
		{
			if (Employee != null)
			{
				Data.Add(Employee);
				Employees = new ObservableCollection<Employee>(Data.GetEmployees());
			}
		}


		[ICommand]
        void Update()
        {
            if (Employee != null)
            {
                Data.Update(Employee);
                Employees = new ObservableCollection<Employee>(Data.GetEmployees());
            }
        }

		[ICommand]
		void Delete(int id)
			=> ConfirmDelete(id);
        
		private async void ConfirmDelete(int id)
		{
			if (await MainPage.Page.DisplayAlert("Delete Record", "Are you sure?", "Yes", "Cancel"))
			{
				Data.Delete(id);
                Employees = new ObservableCollection<Employee>(Data.GetEmployees());
            }
		}

		[ICommand]
		static void Show(Employee employee)
			=> ShowDetails(employee);
		

		private async static void ShowDetails(Employee employee)
		{
			await MainPage.Page.DisplayAlert($"{employee.FullName}",
				$"Date: {employee.DateFormat}\nSIN: {employee.SINFormat}", "Ok");
		}

        [ICommand]
        void Details()
            => NavigateToDetails();


        private async void NavigateToDetails()
        {
			if(employee.ID != -1)
			{
                Dictionary<string, object> records = new() { { "Employee", Employee } };
                await Shell.Current.GoToAsync(nameof(DetailsPage), records);
            }
			else
			{
                
                await Shell.Current.GoToAsync(nameof(DetailsPage));
            }

            
        }
    }
}

