using System.Collections.Generic;
using System;

namespace Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomScores = {1, 5, 10, 20, 25, 40, 45, 50, 60, 63, 66, 70, 75, 80, 90, 95, 100};

            int numberOfStudent = randomScores.GetLength(0);
            Console.WriteLine("The number of student in class is : {0}", numberOfStudent);

            List<int> studentPassed = new List<int> ();
            List<int> averageScore = new List<int> ();
            List<int> studentFailed = new List<int> ();
            
            int failed = 0;
            int count = 0;
            int random = 0;
        

            
            for (int i = 0; i < randomScores.Length; i++)
            {
                
               if ( randomScores[i] > 70)
               {
                   studentPassed.Add(randomScores[i]);
                
                    count = studentPassed.Count;

               } else if (randomScores[i] > 50 && randomScores[i] < 69)
               {
                   averageScore.Add(randomScores[i]);
                
                    random = averageScore.Count;
               } else if (randomScores[i] < 50)
               {
                   studentFailed.Add(randomScores[i]);
                
                    failed = studentFailed.Count;
               } 

               

            }


            Console.WriteLine("The number of student that score above 70 is : {0}", count);
            Console.WriteLine("The number of student that score between 50 and 69 is : {0}", random);
            Console.WriteLine("The number of student that failed(Scored below 50) is : {0}", failed);


            Console.Write("The scores of all students in class are: ");
            foreach (var item in randomScores)
            {
                
                Console.Write(item + " ");
            }

        
           

            
            
            
        }
    }
}
