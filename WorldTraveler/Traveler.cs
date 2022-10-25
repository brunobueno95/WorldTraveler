using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldTraveler
{
    internal class Traveler :PlanetEarth
    {
        public string TravelerName { get; set; }
        public int TravelerAge { get; set; }

        public string From { get; set; }

        public List<string> RecommendedContinents = new List<string>();


        public Traveler(string _name, int _age, string _from)
        {
            TravelerName = _name;
            TravelerAge = _age;
            From = _from;
        }

        public string Description()
        {
            return $"Hey {TravelerName}. You are {TravelerAge} and you come from {From}";
        }

        public void CheckRecomendations()
        {
            RecommendedContinents = ContinentNames;
            RecommendedContinents.Remove(From);
            if(TravelerAge <= 25)
            {
                RecommendedContinents.Remove("Africa");
                RecommendedContinents.Remove("Antarctica");
            }
           else if (TravelerAge > 25 && TravelerAge <=35)
            {
                RecommendedContinents.Remove("Europe");
                RecommendedContinents.Remove("Australia");
            }

            else if (TravelerAge > 35 && TravelerAge <= 75)
            {
                RecommendedContinents.Remove("Europe");
                RecommendedContinents.Remove("Australia");
                RecommendedContinents.Remove("Africa");
                RecommendedContinents.Remove("Antarctica");
                RecommendedContinents.Remove("South America");
                RecommendedContinents.Remove("North America");
            }

         
        }

    }
}
