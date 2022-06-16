using System;

namespace Examn
{
    public class Popquiz
    {
        // Class attributes
        public double grade;
        public string[] questions;
        public string studentName;
        public string studentGroup;
        public int studentLevel;

        /**
         * Constructor
         */
        public Popquiz(double grade, string studentName, int studentLevel, string studentGroup, string[] questions)
        {
            this.grade = grade;
            this.questions = questions;
            this.studentName = studentName;
            this.studentLevel = studentLevel;
            this.studentGroup = studentGroup;
        }

        /**
         * GetAnswers
         * Returns the answers, consistent where the index of the answers array is the same as the index of the 
         * questions array
         */
        public string[] GetAnswers()
        {
            string[] answers = { "Amsterdam", "if-else", "H6", "ja", "style", "geen idee" };

            return answers;
        }

        /**
         * CheckAnswers
         * Checks the given questionIndex with the answer in the answers array. 
         */
        public bool CheckAnswer(int questionIndex, string givenAnswer)
        {
            string correctAnswer = this.GetAnswers()[questionIndex];

            if (correctAnswer == givenAnswer)
            {
                return true;
            }

            return false;
        }

        /**
         * GetRandomQuestions
         * Return one random question to ask the student
         */
        public string GetRandomQuestion()
        {
            string returnQuestion = ""; //This was done intentionly due to make Visual Studio not give an error

            return returnQuestion;
        }

        /**
         * ShowQuestions
         * Show all questions in this popquiz
         */
        public void ShowQuestions()
        {
           //Show all the Questions here using a FOR-loop
        }

        /*
         * GetGrade
         * Returns the grade of the popquiz
         */
        public double GetGrade()
        {
            return this.grade;
        }

        /*
         * GetStudentName
         * Return the name of the student
         */
        public string GetStudentName()
        {
            return this.studentName;
        }

        /**
         * GetStudentLevel
         * Return the level of the student (1 to 5)
         */
        public int GetStudentLevel()
        {
            return this.studentLevel;
        }


        /*
         * GetStudentGroup
         * return the group of the student
         */
        public string GetStudentGroup()
        {
            return this.studentGroup;
        }
    }
}