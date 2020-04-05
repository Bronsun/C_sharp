using System;
using System.Collections.Generic;

namespace Zadania
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ExamQuestion q1 = new ExamQuestion("Prosze zapisac zasady dynamiki Newtona", 2);
            ExamQuestion q2 = new ExamQuestion("Prosze wyprowadzic wzor na grawitacyjna energie",3);

            QuestionSample s1 = new QuestionSample();
            s1.Add(q1);
            s1.Add(q2);
            s1.Ask();





        }
    }
}
