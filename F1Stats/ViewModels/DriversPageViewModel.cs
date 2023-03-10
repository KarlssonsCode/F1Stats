using CommunityToolkit.Mvvm.ComponentModel;
using F1Stats.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace F1Stats.ViewModels
{
    internal partial class DriversPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Models.Drivers> drivers;
        [ObservableProperty]
        string driverId;
        [ObservableProperty]
        string permanentNumber;
        [ObservableProperty]
        string code;
        [ObservableProperty]
        string url;
        [ObservableProperty]
        string givenName;
        [ObservableProperty]
        string familyName;
        [ObservableProperty]
        string dateOfBirth;
        [ObservableProperty]
        string nationality;


        public DriversPageViewModel()
        {
            Drivers = new ObservableCollection<Models.Drivers>();
            var task = Task.Run(() => GetDriversAsync(Drivers));

        }

        //public static async Task<ObservableCollection<Models.Driver>> GetDriversAsync(ObservableCollection<Models.Driver> drivers)
        //{
        //    var client = new HttpClient();
        //    client.BaseAddress = new Uri("https://ergast.com/");
        //    Models.Driver driver = null;

        //    HttpResponseMessage response = await client.GetAsync("api/f1/current/drivers");
        //    while (response.IsSuccessStatusCode)
        //    {
        //        string responseString = await response.Content.ReadAsStringAsync();
        //        driver = JsonSerializer.Deserialize<Models.Driver>(responseString);
        //        driver.PermanentNumber = responseString;
        //        drivers.Add(driver);


        //    }
        //    return drivers;
        //}
        public static async Task<ObservableCollection<Models.Drivers>> GetDriversAsync(ObservableCollection<Models.Drivers> driversCollection)
        {
            var client = new HttpClient();
            Models.Driver drivers = null;

            HttpResponseMessage response = await client.GetAsync("https://ergast.com/api/f1/current/drivers.json");
            if (response.IsSuccessStatusCode)
            {
                string responseResult = await response.Content.ReadAsStringAsync();
                //driversCollection = JsonSerializer.Deserialize<Models.Driver>(responseResult);
                driversCollection = JsonSerializer.Deserialize<ObservableCollection<Models.Drivers>>(responseResult);
                int x = 1;
            }
            return driversCollection;
        }


    }
}
