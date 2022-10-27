using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldTraveler
{
    internal class Countries
    {
        public string Continent { get; set; }

        private string name;
        public string Info { get; set; }
        //public List<Country> Countries { get; set; }
        



        public Countries(string _name)
        {
            Name = _name;
            Info = "";
           
            Continent = "";
            SetAllInfo();
        }
      
        public string Name
        {
            get { return name; }
            set
            {

                {
                    if(value == "India" || value == "Japan" || value == "Indonesia" || value == "United-States" ||
                        value == "Canada" || value == "Mexico" || value == "Australia" || value == "New Zealand" ||
                        value == "Brasil" || value == "Chile" || value == "Argentina" || value == "Norway" ||
                        value == "France" || value == "Italy" || value == "Antarctica" || value == "South-Africa" ||
                        value == "Zimbabwe" || value == "Gambia")
                    {
                        name = value;
                    }

                    else
                    {
                        name = "invalid";
                    }
                }
                    
                
                
                    
                
            }
        }
  
    public  void SetAllInfo()
        {
            if(Name == "India")
            {
                Info = "country that occupies the greater part of South Asia. Its capital is New Delhi, " +
                    " Its government is a constitutional republic " +
                    "that represents a highly diverse population consisting of thousands of ethnic groups " +
                    "and likely hundreds of languages. With roughly one-sixth of the world’s total population," +
                    " India is the second most populous country, after China.";
                
                Continent = "Asia";
            }
            if (Name == "Japan")
            {
                Info = "Complexity and contrast are the keynotes of life in Japan—a country possessing" +
                    " an intricate and ancient cultural tradition yet one that, since 1950, has emerged" +
                    " as one of the world’s most economically and technologically advanced societies. ";
             
                Continent = "Asia";
            }
            if (Name == "Indonesia")
            {
                Info = " Indonesia is the world's largest archipelagic state and the 14th-largest country" +
                    " by area, at 1,904,569 square kilometres (735,358 square miles). With over 275 million" +
                    " people, Indonesia is the world's fourth-most populous country and the most populous" +
                    " Muslim-majority country. Java, the world's most populous island, is home to more than" +
                    " half of the country's population.";
                
                Continent = "Asia";
            }
            if (Name == "United-States")
            {
                Info = "need to put some info here";
                
                Continent = "North-America";
            }
            if (Name == "Canada")
            {
                Info = "need to put some info here";
               
                Continent = "North-America";
            }
            if (Name == "Mexico")
            {
                Info = "need to put some info here";
                
                Continent = "North-America";
            }
            if (Name == "Australia")
            {
                Info = "need to put some info here";
                
                Continent = "Oceania";
            }
            if (Name == "New Zealand")
            {
                Info = "need to put some info here";
               
                Continent = "Oceania";
            }
            if (Name == "Brasil")
            {
                Info = "need to put some info here";
                
                Continent = "South-America";
            }
            if (name == "Chile")
            {
                Info = "need to put some info here";
                
                Continent = "South-America";
            }
            if (name == "Argentina")
            {
                Info = "need to put some info here";
                
                Continent = "South-America";
            }
            if (name == "Norway")
            {
                Info = "need to put some info here";
               
                Continent = "Europe";
            }
            if (name == "France")
            {
                Info = "need to put some info here";
               
                Continent = "Europe";
            }
            if (name == "Italy")
            {
                Info = "need to put some info here";
                
                Continent = "Europe";
            }
            if (name == "Antarctica")
            {
                Info = "need to put some info here";
                
                Continent = "Antarctica";
            }
            if (name == "South-Africa")
            {
                Info = "need to put some info here";
                
                Continent = "Africa";
            }
            if (name == "Zimbabwe") 
            {
                Info = "need to put some info here";
                
                Continent = "Africa";
            }
            if (name == "Gambia")
            {
                Info = "need to put some info here";
               
                Continent = "Africa";
            }
           
        }
    

  
    }
}
