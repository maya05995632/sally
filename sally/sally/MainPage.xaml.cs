using sally.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace sally
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        //public List<Models.Students> Students { get; set; }
        private List<models.patient> _patient;
        public List<models.patient> patient
        {
            get { return _patient; }
            set { _patient = value; OnPropertyChanged(); }
        }

        public MainPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
        protected override void OnAppearing()
        {
            patient = new Services.databaseContext().patient.ToList();
        }
        public ICommand AddItemCommand => new Command(() =>
        {
            Application.Current.MainPage.Navigation.PushAsync(new AddPage());
        });
    }
}
