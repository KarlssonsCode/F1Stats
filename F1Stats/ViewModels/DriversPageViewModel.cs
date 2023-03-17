using CommunityToolkit.Mvvm.ComponentModel;
using F1Stats.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.Input;
using Newtonsoft.Json;

namespace F1Stats.ViewModels
{
    internal partial class DriversPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Models.Driver> currentDrivers;
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
            CurrentDrivers = new ObservableCollection<Models.Driver>();
            var task = Task.Run(() => GetDriversAsync(CurrentDrivers));

        }
        public static async Task<ObservableCollection<Models.Driver>> GetDriversAsync(ObservableCollection<Models.Driver> driversCollection)
        {
            var client = new HttpClient();


            HttpResponseMessage response = await client.GetAsync("https://ergast.com/api/f1/current/drivers.json");
            if (response.IsSuccessStatusCode)
            {
                string responseResult = await response.Content.ReadAsStringAsync();
                Drivers driversData = JsonConvert.DeserializeObject<Drivers>(responseResult);
                foreach (Driver driver in driversData.MRData.DriverTable.Drivers)
                {
                    driversCollection.Add(driver);
                }

            }
            return driversCollection;
        }


    }
}
