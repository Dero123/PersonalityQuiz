using System;

namespace PersonalityQuiz
{
    class TestAskQuestion
    {
        public static bool RunTest()
        {
            // int AskQuestion(Question question)
            Question question = new Question();
            question.question = "What is your favorite food?";
            question.answers.Add("Chicken");
            question.answers.Add("Fish");
            Console.WriteLine("Calling AskQuestion. Expecting to ask 'What is your favorite food?'");
            Console.WriteLine("You should see 2 options. Try an invalid option by typing 3.");
            Console.WriteLine("Then select a valid option: 2");
            int result = Program.AskQuestion(question);

            if (result != 1)
            {
                Console.Error.WriteLine($"Expected the result to be 1 but was {result}.");
                return false;
            }

            Question question2 = new Question();
            question2.question = "What is your favorite band?";
            question2.answers.Add("Mozart");
            question2.answers.Add("Metalica");
            question2.answers.Add("Phish");

            Console.WriteLine("Calling AskQuestion. Expecting to ask 'What is your favorite band?'");
            Console.WriteLine("You should see 3 options.");
            Console.WriteLine("Then select a valid option: 3");
            int result2 = Program.AskQuestion(question2);

            if (result2 != 2)
            {
                Console.Error.WriteLine($"Expected the result to be 2 but was {result2}.");
                return false;
            }

            Question question3 = new Question();
            question3.question = "What is your favorite animal?";
            question3.answers.Add("Wolf");
            question3.answers.Add("Panda");
            

            Console.WriteLine("Calling AskQuestion. Expecting to ask 'What is your favorite animal?'");
            Console.WriteLine("You should see 2 options.");
            Console.WriteLine("Then select a valid option: 1");
            int result3 = Program.AskQuestion(question3);

            if (result3 != 0)
            {
                Console.Error.WriteLine($"Expected the result to be 0 but was {result3}.");
                return false;
            }


            return true;
        }
    }
}
