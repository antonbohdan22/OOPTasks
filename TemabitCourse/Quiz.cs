using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemabitCourse.Quiz
{
    class Quiz
    {
        private Question[] questions;
        private List<string> userAnswers;
        private int rightAnswersQuantity;

        public Quiz() { }

        public Quiz(Question[] questions)
        {
            this.questions = questions;
            userAnswers = new List<string>();
        }

        public void StartQuiz()
        {
            rightAnswersQuantity = 0;

            Console.WriteLine("Для того, чтобы ответить введите номер варианта ответа");
            foreach (Question question in questions)
            {
                Console.WriteLine(question.CurrentQuestion);
                for (int i = 0; i < question.AnswerOptions.Length; i++)
                    Console.WriteLine(i + 1 + ". " + question.AnswerOptions[i]);
                byte index = 0;
                try
                {
                    index = Convert.ToByte(Console.ReadLine());
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Неправильный формат ввода. Нажмите Enter, чтобы начать сначала или любую другую клавишу, чтобы выйти.");
                    int keyCode = Console.ReadKey().GetHashCode();
                    Console.Clear();
                    if (keyCode == 13) StartQuiz();
                    else Environment.Exit(1);
                }
                userAnswers.Add(question.AnswerOptions[index - 1]);
                if (index - 1 == question.RightAnswerIndex) rightAnswersQuantity++;
            }
            ShowResult();
        }

        private void ShowResult()
        {
            byte index = 0;
            Console.WriteLine("Результат викторины:");
            foreach (Question question in questions)
            {
                string rightAnswer = question.AnswerOptions[question.RightAnswerIndex];
                Console.WriteLine(question.CurrentQuestion);
                Console.WriteLine("Ваш вариант ответа: {0}", userAnswers.ElementAt<string>(index++));
                Console.WriteLine("Правильный вариант ответа: {0}", rightAnswer);
            }
            Console.WriteLine("Количество баллов: {0} из {1}", rightAnswersQuantity, questions.Length);
        }

        public Question[] Questions
        {
            get { return questions; }
            set { questions = value; }
        }

        public int RightAnswersQuantity
        {
            get { return rightAnswersQuantity; }
        }

    }
}
