using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace F1Stats.Models
{
    class DriverOld
    {

        [JsonPropertyName("driverId")]
        public string DriverId { get; set; }
        [JsonPropertyName("permanentNumber")]
        public string PermanentNumber { get; set; }
        [JsonPropertyName("code")]
        public string Code { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("givenName")]
        public string GivenName { get; set; }
        [JsonPropertyName("familyName")]
        public string FamilyName { get; set; }
        [JsonPropertyName("dateOfBirth")]
        public string DateOfBirth { get; set; }
        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

    }






    public class Drivers
    {
        public Mrdata MRData { get; set; }
    }

    public class Mrdata
    {
        public string xmlns { get; set; }
        public string series { get; set; }
        public string url { get; set; }
        public string limit { get; set; }
        public string offset { get; set; }
        public string total { get; set; }
        public Drivertable DriverTable { get; set; }
    }

    public class Drivertable
    {
        public string season { get; set; }
        public Driver[] Drivers { get; set; }
    }

    public class Driver
    {
        public string driverId { get; set; }
        public string permanentNumber { get; set; }
        public string code { get; set; }
        public string url { get; set; }
        public string givenName { get; set; }
        public string familyName { get; set; }
        public string dateOfBirth { get; set; }
        public string nationality { get; set; }
    }


}
