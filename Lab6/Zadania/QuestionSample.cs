using System;
using System.Collections.Generic;


namespace Zadania{

    public class QuestionSample : IQuestion{

        private List<IQuestion> questions = new List<IQuestion>();


        public void Ask(){
            System.Console.WriteLine("Exam Question{");
            foreach(var question in questions){
                question.Ask();
            }
            System.Console.WriteLine("}");

        }

        public void Add(IQuestion question)
        {
            questions.Add(question);
        }

    }


}