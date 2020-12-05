using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Runner
    {
        

        static void Main(string[] args)
        {
            Question[] questions = new Question[5];
            questions[0] = new Question("Самая высокая гора на земле?", new string[] { "Джомолунгма", "Монблан", "Ай-Петри" }, 0);
            questions[1] = new Question("Самая высокий водопад на земле?", new string[] { "Ниагара", "Виктория", "Анхель" }, 2);
            questions[2] = new Question("Сколько штатов в Америке?", new string[] { "50", "44", "61" }, 0);
            questions[3] = new Question("Длина окружности земли по экватору?", new string[] { "31 960 км", "40 075 км", "37 818 км" }, 1);
            questions[4] = new Question("Расстояние от Земли до Солнца(миллионов киломметров)?", new string[] { "149.6", "201.9", "120.3" }, 0);
            
            new Quiz(questions).StartQuiz();

            Console.ReadKey();            
        }

        
    }
}
