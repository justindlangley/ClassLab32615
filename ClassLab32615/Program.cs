using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLab32615
{
    enum Ranking
    {
        Beginner,     
        Grasshopper,
        Journeyman,
        RockStar,
        Ninja,
        Jedi
    }
    class Program
    {
        static void Main(string[] args)
        { 
            
            
            var newStudent = new netStudent();
            int totalPoints = 0;
            

            newStudent.comletedProgram();
            newStudent.helpedStudent();

            Ranking totalPoints = Ranking.Beginner;
            
            if (totalPoints <= 5 && totalPoints > 0)
            {
                Console.WriteLine("You are a beginner");
            }
            
            Ranking totalPoints = Ranking.Grasshopper;

            if (totalPoints <= 10 && totalPoints > 5)
            {
                Console.WriteLine("You are a Grasshopper");
            }

            Ranking totalPoints = Ranking.Journeyman;
            
            if (totalPoints <= 15 && totalPoints > 10)
            {
                Console.WriteLine("You are a Journeyman");
            }

            Ranking totalPoints = Ranking.RockStar;

            if (totalPoints <= 20 && totalPoints > 15)
            {
                Console.WriteLine("You are a Rock Star");
            }

            Ranking totalPoints = Ranking.Ninja;

            if (totalPoints <=25 && totalPoints > 20)
            {
                Console.WriteLine("You are a Ninja");
            }
            Ranking totalPoints = Ranking.Jedi;

            if (totalPoints > 25)
            {
                Console.WriteLine("You are a Jedi");
            }
        }
          
    class netStudent
    {
        
        public int totalPoints;
        public string studentName { get; set; }
              
        
        public int completedProgram() 
        {
        int completedProgram;
           return totalPoints += 1;        
        }

        public bool helpedStudent();
        {
          bool helpedStudent = true;
            return totalPoints +2

        }



    }

   }
}    


