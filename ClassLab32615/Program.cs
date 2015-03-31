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
            
            
            

            Console.WriteLine("How many programs have you completed today?");
            var x = Console.ReadLine();
            var X = int.Parse(x);

            Console.WriteLine("How many students have you helped today?");
            var y = Console.ReadLine();
            var Y = int.Parse(y);
            
           
            Console.WriteLine("Your total points for today are: {0}", newStudent.totalPoints);
            Console.WriteLine("Your rank based on this information is: {0}", newStudent.level);

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

        public Ranking level;
        netStudent newStudent = new netStudent();
        int totalPoints = 0;

        newStudent.totalPoints = (X * 1) + (Y * 2);
        newStudent.calculateRank();

        public void calculateRank()
        {
            if (totalPoints <= 5 && totalPoints > 0)
            {               
                this.level = Ranking.Beginner;
            }

            if (totalPoints <= 10 && totalPoints > 5)
            {            
                this.level = Ranking.Grasshopper;
            }

            if (totalPoints <= 15 && totalPoints > 10)
            {
                this.level = Ranking.Journeyman;
            }

            if (totalPoints <= 20 && totalPoints > 15)
            {
                this.level = Ranking.RockStar;
            }

            if (totalPoints <= 25 && totalPoints > 20)
            {
                this.level = Ranking.Ninja;
            }

            if (totalPoints > 25)
            {
                this.level = Ranking.Jedi;
            }

        }

    }

   }
}    


