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

        //public Countries Countries { get; set; }
       
        

        

        public Continents(string _name)
        {
            Name = _name;
            Countries = 0;
            

            CheckCountriesOnContinent();


        }

       
        

        public string Name
        {
            
            get { return name; }
            set
            {
                PlanetEarth allContinents = new PlanetEarth();

                for (int i = 0; i < allContinents.ContinentNames.Count; i++)
                {
                    if (value == allContinents.ContinentNames[i])
                    {
                        name = value;
                    }
                   
                }
                


                
                

            }
        }
        public void CheckCountriesOnContinent()
        {
            
            if (Name == "Asia" )
            {
                Countries = 48;
               
            }

            if (Name == "North-America")
          {
                Countries = 23;
              
            }

           if (Name == "Australia")
            {
                Countries = 6;
                

           }

            if (Name == "South-America")
            {
                Countries = 12;
                

            }

            if (Name == "Europe")
            {
               Countries = 44;
             



            }


            if (Name == "Antarctica")
            {
               Countries = 0;
           ;

            }

          if (Name == "Africa")
            {
                Countries = 54;
            

          }
        }
    }

 }
