using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab32615
{
    
    
    class Program
    {
        static void Main(string[] args)
        { 
            
            
            var newStudent = new netStudent();
            

            int totalPoints = 0;

            Console.WriteLine("How many programs have you completed today?");
            var x = Console.ReadLine();
            var X = int.Parse(x);

            Console.WriteLine("How many students have you helped today?");
            var y = Console.ReadLine();
            var Y = int.Parse(y);
            totalPoints = (X * 10) + (Y * 2);

            Console.WriteLine("Your total points for today are: {0}", totalPoints);
            Console.ReadLine();

            //newStudent.calculateRank();
            //newStudent.helpedStudent();

            
            
        }   
          
    class netStudent
    {
        
        public int totalPoints;
        public string studentName { get; set; }


        public enum Ranking
        {
            Beginner,
            Grasshopper,
            Journeyman,
            RockStar,
            Ninja,
            Jedi
        }

        private Ranking level;

        public void calculateRank()
        {
            if (totalPoints <= 5 && totalPoints > 0)
            {
                Console.WriteLine("You are a beginner");
                this.level = Ranking.Beginner;
            }


            if (totalPoints <= 10 && totalPoints > 5)
            {
                Console.WriteLine("You are a Grasshopper");
                this.level = Ranking.Grasshopper;
     
            }



            if (totalPoints <= 15 && totalPoints > 10)
            {
                Console.WriteLine("You are a Journeyman");
                this.level = Ranking.Journeyman;
            }

            if (totalPoints <= 20 && totalPoints > 15)
            {
                Console.WriteLine("You are a Rock Star");
                this.level = Ranking.RockStar;
            }


            if (totalPoints <= 25 && totalPoints > 20)
            {
                Console.WriteLine("You are a Ninja");
                this.level = Ranking.Ninja;
            }

            if (totalPoints > 25)
            {
                Console.WriteLine("You are a Jedi");
                this.level = Ranking.Jedi;
            }

        }

    }

   }
}    


