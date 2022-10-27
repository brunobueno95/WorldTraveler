using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldTraveler
{
    internal class Game
    {
        public string readInput;
        Traveler traveler { get; set; }
        public List<Countries> CountriesAvailableToTravel { get; set; }
        public List<Countries> AllCountries { get; set; }

        public Game()
        {
            fullGame();
        }
        public void fullGame()
        {

         

            ContinentOptions(FirstGreeting());
            fillCountriesList();
            CheckTravlerContinentChoice();
            ChoosingACountry();



        }
        public Traveler FirstGreeting()
        {
            Console.WriteLine("Hello, welcome to the our Travel Agency!");

           
            Console.WriteLine("What is your name" );
            var Name = Console.ReadLine();
            Console.WriteLine("What is your age?" );
            var Age = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Wich continent are you from?");
            var WhereFrom = Console.ReadLine();
            Traveler traveler = new Traveler(Name,Age,WhereFrom);
            Console.WriteLine($"Hello {traveler.TravelerName}, I heard you love to travel, since you are {traveler.TravelerAge}" +
                $" we have a list of countries we recommend you to visit");
            return traveler;
            
           
        }


        public void ContinentOptions(Traveler anobj)
        {
            Console.WriteLine("Press A to check all the continents and than write it on the console wich continent are you most interested!");
            var InputContinents = Console.ReadLine();

            anobj.CheckRecomendations();
            if (InputContinents == "A" || InputContinents == "a")
            {
                for(int i =0; i<anobj.RecommendedContinents.Count;i++)
                {
                    Console.WriteLine($"{i} - {anobj.RecommendedContinents[i]}");
                }

                readInput = Console.ReadLine();
                
            }
              
        }
        
        public void CheckTravlerContinentChoice()
        {
            Continents cntChoice = new Continents(readInput);
            
            CountriesAvailableToTravel = AllCountries.FindAll(i => i.Continent == readInput);
            Console.WriteLine($"You have chosen {cntChoice.Name} and there are {cntChoice.Countries} countries on this continent. Press enter to check which ones we have offers to");
            var choosing = Console.ReadLine();
            
            Console.WriteLine("Choose the country you want know more about it by writting the country name");
            for(int i =0;i < CountriesAvailableToTravel.Count; i++ )
            {
                Console.WriteLine($"{i} - {CountriesAvailableToTravel[i].Name}");
                
            }
            readInput = Console.ReadLine();

        }

        public void ChoosingACountry()
        {
            Countries UserChoice = new Countries(readInput);
            Console.WriteLine("");
            Console.WriteLine($"You have chosen {UserChoice.Name}! information about  {UserChoice.Name} ");
            Console.WriteLine($"INFO: {UserChoice.Info}");
        }

        public void fillCountriesList()
        {
            AllCountries = new List<Countries>() { new Countries("India"),
            new Countries("Japan"),new Countries("Indonesia"),new Countries("United-States"),new Countries("Canada"),
            new Countries("Mexico"),new Countries("Australia"),new Countries("New Zealand"),new Countries("Brasil"),
            new Countries("Chile"),new Countries("Argentina"),new Countries("Norway"),new Countries("France"),
            new Countries("Italy"),new Countries("Antartica"),new Countries("South-Africa"),new Countries("Zimbabwe"),
            new Countries("Gambia")};
        }
       
    }
}
