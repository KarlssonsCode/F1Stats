using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;


namespace F1Stats.Models
{

    public class Drivers
    {
        public MrdataDrivers MRData { get; set; }
    }

    public class MrdataDrivers
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


    


}
