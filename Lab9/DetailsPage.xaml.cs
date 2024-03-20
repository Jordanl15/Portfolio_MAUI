using Lab9.ViewModel;

namespace Lab9;

public partial class DetailsPage : ContentPage
{
	public DetailsPage(EmployeeViewModel vm)
	{
		InitializeComponent();
		this.BindingContext = vm;
		if(vm.Employee.ID != -1)
		{
			lblPrompt.Text = "Edit Exsisting Record";
			this.Title = "Edit Employee";
		}
		
	}

    private async void Button_Clicked(Object sender, EventArgs e)
    {
		if(SIN.Text?.Length > 0 && SIN.Text?.Length == 9)
		{
			var vm = this.BindingContext as EmployeeViewModel;
			if (vm.Employee.ID == -1)
			{
                vm.Employee.SIN = SIN.Text;
                vm.AddCommand.Execute(null);
            }

			else
				vm.UpdateCommand.Execute(null);
			await Shell.Current.GoToAsync("..");

        }
		else
		{
			bool rtr = (string.IsNullOrEmpty(name.Text)) ? name.Focus() : SIN.Focus();
		}
    }
}
