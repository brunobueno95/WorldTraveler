using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace WorldTraveler
{
    internal class PlanetEarth
    {
        public int ContinentsN { get; private set; }    
        public int Countries { get; private set; }
        public List<string> ContinentNames = new List<string>();
     

        public PlanetEarth()
        {
            ContinentsN = 7;
            Countries = 195;
            ContinentNames.Add("Asia");
            ContinentNames.Add("Europe");
            ContinentNames.Add("North-America");
            ContinentNames.Add("Africa");
            ContinentNames.Add("South-America");
            ContinentNames.Add("Antarctica");
            ContinentNames.Add("Australia");

        }
        
        public void PrintDescription()
        {
            Console.WriteLine($"Welcome to Planet Earth, this planet has {ContinentsN} continents and {Countries} countries! ");
        }


    }
}
