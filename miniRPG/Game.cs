using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniRPG
{
    public class Game
    {
        public string Name_Team_Person { get; set; }
        public string Name_Team_PC { get; }

        static string[] Names_for_PC = {"Пьяные охотники","X-Force","Аненербе","SOS",
                                                     "Лига Злодеев","Название_команды2","Мамба","Анкапы",
                                                     "DTF","маленькое г...0"};
        public List<Hero> Team_Person = new List<Hero>();
        public List<Hero> Team_PC = new List<Hero>();

        public List <Hero> Get_Team_PC()
        {
            return Team_PC;
        }

        public List<Hero> Get_Team_Person()
        {
            return Team_Person;
        }

        public Game(string name)
        {
            Name_Team_Person = name;
            Name_Team_PC = Names_for_PC[Name_choice()];
        }

        static int Name_choice()
        {

            Random randomGenerator = new Random();
            return randomGenerator.Next(1,10);

        }

        // Добавляет на наличие одинаковых героев в команде. Добавление героя в случае отсутствии его в команде.
        public void Check_List(List<Hero> heroes,Hero pick, string mode) 
        {
            int j = 0;
            switch (mode)
           {
                case "Person":
                    {
                        for (int i = 0; i < heroes.Count(); i++)
                        {
                            if (heroes[i].GetType() == pick.GetType())
                                j++;
                        }
                        if (j == 0)
                            heroes.Add(pick);
                        else Console.WriteLine($"Герой {pick.GetType()} у вас уже есть в команде. Выберите другого."); ;
                        break;
                    }
                case "PC":
                    {
                        for (int i = 0; i < heroes.Count(); i++)
                        {
                            if (heroes[i].GetType() == pick.GetType())
                                j++;
                        }
                        if (j == 0)
                            heroes.Add(pick);
                        break;
                    }
            }
        }

    }
}
