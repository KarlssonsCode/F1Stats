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
    internal partial class ConstructorsPageViewModel : ObservableObject
    {
        [ObservableProperty]
        public ObservableCollection<Models.Constructor> constructors;
        [ObservableProperty]
        string constructorId;
        [ObservableProperty]
        string url;
        [ObservableProperty]
        string name;
        [ObservableProperty]
        string nationality;


        public ConstructorsPageViewModel()
        {
            Constructors = new ObservableCollection<Models.Constructor>();
            var task = Task.Run(() => GetConstructorsAsync(Constructors));
        }
        public static async Task<ObservableCollection<Models.Constructor>> GetConstructorsAsync(ObservableCollection<Models.Constructor> constructorsCollection)
        {
            var client = new HttpClient();


            HttpResponseMessage response = await client.GetAsync("https://ergast.com/api/f1/current/constructors.json");
            if (response.IsSuccessStatusCode)
            {
                string responseResult = await response.Content.ReadAsStringAsync();
                Constructors constructorsData = JsonConvert.DeserializeObject<Constructors>(responseResult);
                foreach (Constructor constructor in constructorsData.MRData.ConstructorTable.Constructors)
                {
                    constructorsCollection.Add(constructor);
                }

            }
            return constructorsCollection;
        }
    }
}
