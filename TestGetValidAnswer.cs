using System;

namespace PersonalityQuiz
{
    class TestGetValidAnswer
    {
        public static bool RunTest()
        {
             Question answer = new Question();
            answer.question = "What is your favorite food?";
            answer.answers.Add("Chicken");
            answer.answers.Add("Fish");
            Console.WriteLine("Then select a valid option: 2");
            int result = Program.AskQuestion(answer);

            Console.WriteLine("Calling GetValidAnswer. Options not listed however they are 1 and 2.");
            
            if (result != 1)
            {
                Console.Error.WriteLine($"Expected the result to be 1 but was {result}.");
                return false;
            }

         Question answer2 = new Question();
            answer2.question = "What is your favorite band?";
            answer2.answers.Add("Mozart");
            answer2.answers.Add("Metalica");
            answer2.answers.Add("Phish");

            Console.WriteLine("Then select a valid option: 3");
            int result2 = Program.AskQuestion(answer2);
            Console.WriteLine("Calling GetValidAnswer. Options not listed however they are 1, 2, and 3.");
            
            if (result2 != 2)
            {
                Console.Error.WriteLine($"Expected the result to be 2 but was {result2}.");
                return false;
            }

            Question answer3 = new Question();
            answer3.question = "What is your favorite animal?";
            answer3.answers.Add("Wolf");
            answer3.answers.Add("Panda");
            

            Console.WriteLine("Then select a valid option: 1");
            int result3 = Program.AskQuestion(answer3);
            Console.WriteLine("Calling GetValidAnswer. Options not listed however they are 1 and 2.");
            
             if (result3 != 0)
            {
                Console.Error.WriteLine($"Expected the result to be 0 but was {result3}.");
                return false;
            }

            return true;
        }
    }
}

