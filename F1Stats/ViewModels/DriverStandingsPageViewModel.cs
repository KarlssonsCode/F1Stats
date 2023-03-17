using CommunityToolkit.Mvvm.ComponentModel;
using F1Stats.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace F1Stats.ViewModels
{
    internal partial class DriverStandingsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Models.DriverStand> currentDriverStandings;
        [ObservableProperty]
        string position;
        [ObservableProperty] 
        string points;
        [ObservableProperty] 
        string wins;
        [ObservableProperty]
        Driver driver;
        [ObservableProperty]
        public Constructor[] constructors;

        public DriverStandingsPageViewModel()
        {
            CurrentDriverStandings = new  ObservableCollection<Models.DriverStand>();
            var task = Task.Run(() => GetDriverStandingsAsync(CurrentDriverStandings));
        }

        public static async Task<ObservableCollection<Models.DriverStand>> GetDriverStandingsAsync(ObservableCollection<Models.DriverStand> driverStandingsCollection)
        {
            var client = new HttpClient();


            HttpResponseMessage response = await client.GetAsync("http://ergast.com/api/f1/current/driverStandings.json");
            if (response.IsSuccessStatusCode)
            {
                string responseResult = await response.Content.ReadAsStringAsync();
                dynamic driverStandingsData = JsonConvert.DeserializeObject<DriverStandings>(responseResult);
                foreach (DriverStanding driverStanding in driverStandingsData.MRData.StandingsTable.StandingsLists[0].DriverStandings)
                {
                    DriverStand standing = new DriverStand
                    {
                        DriverName = driverStanding.Driver.GivenName + " " + driverStanding.Driver.FamilyName,                        
                        Points = driverStanding.points,
                        Position = driverStanding.position,
                        Wins = driverStanding.wins
                    };
                    driverStandingsCollection.Add(standing);
                }

            }
            return driverStandingsCollection;
        }
    }

    
        

}
