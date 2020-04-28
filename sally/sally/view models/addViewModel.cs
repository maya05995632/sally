using System;
using System.Collections.Generic;
using System.Text;

namespace sally.view_models
{
      public class addViewModel
    {

        public List<string> Gender { get; set; }
        public string SelectGender { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

        public addViewModel()
        {
            Gender = new List<string> { "None", "Male", "Female" };
        }
        public System.Windows.Input.ICommand AddItemCommand => new Xamarin.Forms.Command(() =>
        {
            var dbcontext = new services.DatabaseContext();
            var model = new Models.patient
            {
                Name = this.Name,
                Age = int.Parse(Age),
                Gender = SelectGender
            };
            dbcontext.patient.Add(model);
            dbcontext.SaveChanges();
            Xamarin.Forms.Application.Current.MainPage.Navigation.PopAsync();
        }
    }
}
