using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz
{
    class Question
    {
        private string currentQuestion;
        private string[] answerOptions;
        private int rightAnswerIndex;

        private Question() { }

        public Question(string currentQuestion, string[] answerOptions, int rightAnswerIndex)
        {
            this.currentQuestion = currentQuestion;
            this.answerOptions = answerOptions;
            this.rightAnswerIndex = rightAnswerIndex;
        }

        public string[] AnswerOptions
        {
            get { return answerOptions; }
            set { answerOptions = value; }
        }

        public string CurrentQuestion
        {
            get { return currentQuestion; }
            set { currentQuestion = value; }
        }

        public int RightAnswerIndex
        {
            get { return rightAnswerIndex; }
            set { rightAnswerIndex = value; }
        }
    }
}
