using CommunityToolkit.Mvvm.ComponentModel;
using F1Stats.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace F1Stats.ViewModels
{
    internal partial class ConstructorStandingsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Models.ConstructorStand> currentConstructorStandings;
        [ObservableProperty]
        string position;
        [ObservableProperty]
        string points;
        [ObservableProperty]
        string constructorName;
        [ObservableProperty]
        public Constructor[] constructors;


        public ConstructorStandingsPageViewModel()
        {
            CurrentConstructorStandings = new ObservableCollection<Models.ConstructorStand>();
            var task = Task.Run(() => GetConstructorStandingsAsync(CurrentConstructorStandings));

        }

        public static async Task<ObservableCollection<Models.ConstructorStand>> GetConstructorStandingsAsync(ObservableCollection<Models.ConstructorStand> constructorStandingsCollection)
        {
            var client = new HttpClient();


            HttpResponseMessage response = await client.GetAsync("https://ergast.com/api/f1/current/constructorStandings.json");
            if (response.IsSuccessStatusCode)
            {

                string responseResult = await response.Content.ReadAsStringAsync();
                dynamic constructorStandingsData = JsonConvert.DeserializeObject<ConstructorStandings>(responseResult);
                foreach (ConstructorStanding constructorStanding in constructorStandingsData.MRData.StandingsTable.StandingsLists[0].ConstructorStandings)
                {
                    ConstructorStand standing = new ConstructorStand
                    {
                        ConstructorName = constructorStanding.Constructor.name,
                        Points = constructorStanding.points,
                        Position = constructorStanding.position,
                        Wins = constructorStanding.wins,
                        ConstructorId = constructorStanding.Constructor.constructorId                       
                    };
                    constructorStandingsCollection.Add(standing);
                }

            }
            return constructorStandingsCollection;
        }
    }
}
