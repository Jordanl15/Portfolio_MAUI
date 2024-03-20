using Lab9.ViewModel;
using Lab9.Model;

namespace Lab9
{
    public partial class MainPage : ContentPage
    {
        internal static MainPage Page;
        private readonly EmployeeViewModel VM;

        public MainPage(EmployeeViewModel vm)
        {
            InitializeComponent();
            this.BindingContext = vm;
            VM = vm;
            Page = this;
        }

        void btnAdd_Clicked(object sender, EventArgs e)
        {
            VM.Employee = new Employee();
            VM.DetailsCommand.Execute(null);
        }

        void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
        {
            VM.Employee = cv.SelectedItem as Employee;
            VM.DetailsCommand.Execute(null);
        }

        
    }
}