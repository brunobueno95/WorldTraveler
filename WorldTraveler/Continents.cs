using System;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldTraveler
{
    internal class Continents
    {
        private string name;

        public int Countries { get; set; }

        public List<string> CountriesAvailableToTravel { get; set; }

        public Continents(string _name)
        {
            Name = _name;
            Countries = 0;
            CountriesAvailableToTravel = new List<string>();
        }


        public string Name
        {
            //|| value == "Europe" || value == "North-America" || "Africa" || "South-America" || "Antarctica" || "Australia"
            get { return name; }
            set
            {
                if (value == "Asia" || value == "Europe" || value == "North-Ameica" || value == "Africa" || value == "South-America" || value == "Antarctica" || value == "Australia")
                {
                    name = value;
                }
                else {
                    value = "invalid";
                    name = value; }
            }
         }
        public void CheckCountriesOnContinent()
        {
            //|| Name == "Europe" || Name == "North-Ameica" || Name == "Africa" || Name == "South-America" || Name == "Antarctica" || Name == "Australia"
            if (Name == "Asia" )
            {
                Countries = 48;
                CountriesAvailableToTravel.Add("India");
                CountriesAvailableToTravel.Add("Japan");
                CountriesAvailableToTravel.Add("Indonesia");
            }

            if (Name == "North-Ameica")
            {
                Countries = 23;
                CountriesAvailableToTravel.Add("United-States");
                CountriesAvailableToTravel.Add("Canada");
                CountriesAvailableToTravel.Add("Mexico");
            }

            if (Name == "Australia")
            {
                Countries = 6;
                CountriesAvailableToTravel.Add("India");
                CountriesAvailableToTravel.Add("Japan");
                CountriesAvailableToTravel.Add("Indonesia");
            }

            if (Name == "South-America")
            {
                Countries = 12;
                CountriesAvailableToTravel.Add("Brasil");
                CountriesAvailableToTravel.Add("Chile");
                CountriesAvailableToTravel.Add("Argentina");
            }

            if (Name == "Europe")
            {
                Countries = 44;
                CountriesAvailableToTravel.Add("Norway");
                CountriesAvailableToTravel.Add("France");
                CountriesAvailableToTravel.Add("Italy");
            }


            if (Name == "Antarctica")
            {
                Countries = 0;
                CountriesAvailableToTravel.Add("Antartica");
               
            }

            if (Name == "Africa")
            {
                Countries = 54;
                CountriesAvailableToTravel.Add("South-Africa");
                CountriesAvailableToTravel.Add("Zimbabwe");
                CountriesAvailableToTravel.Add("Gambia");
            }
        }
    }

 }
