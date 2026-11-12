using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace MyQuizApp
{
    internal class Quiz
    {
        private Question[] _questions;
        private int _score;
        public Quiz(Question[] questions)
        {
            this._questions = questions;
            _score = 0;
        }
        public void StartQuiz()
        {
            Console.WriteLine("Welcome to the Quiz!");
            int questionNumber = 1; //to display question numbers
            foreach (Question question in _questions)
            {
                Console.WriteLine($"Question {questionNumber++}: ");
                DisplayQuestion(question);
                int userChoice = GetUserChoice();
                if (question.IsCoccrectAnswer(userChoice))
                {
                    Console.WriteLine("Correct!");
                    _score++;
                }
                else
                {
                    Console.WriteLine($"Wrong! The correct answer was: {question.Answers[question.CorrectAnswerIndex]}");
                }
            }
            DisplayResult();
        }
        private void DisplayQuestion(Question question)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Question");
            Console.WriteLine(question.QuestionText);
            Console.ResetColor();
            for (int i = 0; i < question.Answers.Length; i++)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("   ");
                Console.Write(i + 1);
                Console.ResetColor();
                Console.WriteLine($". {question.Answers[i]}");
            }


        }
        private int GetUserChoice()
        {
            Console.Write("Your answer (number): ");
            string input = Console.ReadLine();
            int choice = 0;
            while (!int.TryParse(input, out choice) || choice < 1 || choice > 4)
            {
                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4: ");
                input = Console.ReadLine();
            }
            return choice - 1;
        }
        private void DisplayResult()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\nResult\n");
            Console.ResetColor();
            Console.WriteLine($"Quiz fonished. Your score is: {_score} out of {_questions.Length}");
            double percentage = (double)_score / _questions.Length;
            if(percentage >= 8.0)
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Excellent Work!");
                Console.ResetColor();

            }else if (percentage >= 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Good effort!");
                Console.ResetColor();
            }
            else if (percentage < 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Try harder! keep practicing");
                Console.ResetColor();
            }

        }
    }
}
