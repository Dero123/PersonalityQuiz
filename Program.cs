using System;
using System.Collections.Generic; // Feedback(jcollard 2022-01-28): This allow us to use List

// Feedback(jcollard 2022-02-02): You're doing great, Derek! Keep up the good work.
// I think you are ready to start implementing your methods. I would recommend starting
// with: GetResult

// Feedback(jcollard 2022-02-04): Great job! Your tests look awesome. You're ready to start 
// implementing your methods in Program.cs
namespace PersonalityQuiz
{
    class Program
    {
        static void Main(string[] args)
        {

            if (args.Length > 0 && args[0] == "test")
            {
                TestAll();
                return;
            }


            int score = 0;
            // Feedback(jcollard 2022-01-28): Daniel, you're off to a great
            // start! I've gone ahead and done a few corrections as well as
            // added a handful of TODO comments. You sould complete the TODO
            // comments before moving on to Part 2.2.

            // Example(jcollard 2022-01-28): Below is an example of using the
            // Question class to create three questions. 

            // Construct a new Question object
            // Question woodChuckQuestion = new Question();
            Question TravelQuestion = new Question();

            // Next, set the question to be an actual question.
            // woodChuckQuestion.question = "How much wood could a woodchuck chuck if a woodchuck could chuck wood?";
            TravelQuestion.question = "Do you like to go to new places or prefer to stay in one place";

            // Next, add answers to the question
            // woodChuckQuestion.answers.Add("As much wood as a woodchuck could chuck if a woodchuck could chuck wood.");
            // woodChuckQuestion.answers.Add("Uh... 14?");
            // woodChuckQuestion.answers.Add("None. Clearly the woodchuck is a manifestation of all your fears.");
            TravelQuestion.answers.Add("Travel to new places.");
            TravelQuestion.answers.Add("Stay in one Place");

            // AskQuestion(woodChuckQuestion);
            score = score + AskQuestion(TravelQuestion);

            // Question foodQuestion = new Question();
            Question FireQuestion = new Question();

            // Next, set the question to be an actual question.
            // foodQuestion.question = "What is your favorite food?";
            FireQuestion.question = "If a building was on fire and you had to save people in the building from burning, how would you do it?";


            // Next, add answers to the question
            // foodQuestion.answers.Add("Wood");
            // foodQuestion.answers.Add("Woodchuck");
            // foodQuestion.answers.Add("Banana water");
            FireQuestion.answers.Add("Stop the Fire.");
            FireQuestion.answers.Add("Get the people in the building out of the fire.");

            // AskQuestion(foodQuestion);
            score = score + AskQuestion(FireQuestion);

            List<string> results = new List<string>();
            results.Add("You can control time!");
            results.Add("You can control space!");
            string result = GetResult(score, results);
            Console.WriteLine($"{result}");
        }

        public static void TestAll()
        {
            bool testAskQuestion = TestAskQuestion.RunTest();
            Console.WriteLine($"Test AskQuestion(question): {testAskQuestion}");

            bool testGetResult = TestGetResult.RunTest();
            Console.WriteLine($"Test GetResult(score,result): {testGetResult}");

            bool testGetValidAnswer = TestGetValidAnswer.RunTest();
            Console.WriteLine($"Test GetValidAnswer(answers): {testGetValidAnswer}");
        }


        /// <summary>
        /// Given a question for the user to answer, 
        /// displays a question then loops through each answer to display it.
        /// Receive the users response then return the users response.
        /// </summary>
        /// <param name="question">The question to display to the user</param>
        /// <returns>The users response</returns>
        public static int AskQuestion(Question question)
        {
            // TODO(jcollard 2022-02-11): Currently, none of your methods meet
            // the proficient requirement. However, this method **almost** meets
            // all the requirements for a proficient. All that you need to do is
            // validate the input parameter question. You can do this with a
            // null check and by checking that the answers list has at least 1 element:

            if (question == null)
            {
                throw new Exception("You cannot pass in a null value.");
            }

            if (question.answers.Count == 0)
            {
                throw new Exception("You cannot pass in a list with 0 elements.");
            }


           
            Console.WriteLine(question.question);
            int optionNumbers = 1;


            foreach (string answer in question.answers)
            {
                Console.WriteLine($"{optionNumbers}. {answer}");
                optionNumbers = optionNumbers + 1;
            }

            int select = GetValidAnswer(question.answers);

            // 1.Display the question
            // 2.Loop through each answer and display it
            // 3.Use the GetValidAnswer method to get the user's response
            // 4.Return the user's response
            return select;
        }


        /// <summary>
        /// Validates that there is at least 1 possible answer with an 
        /// exception thrown if the list is empty. Display a message asking
        /// the user to select an option otherwise. Store the users response
        /// and validate that the choice is a possible answer. If so returns
        /// the users choice. Otherwise displays an error message.
        /// </summary>
        /// <param name="answers">Answers a list of answers</param>
        /// <returns>The users choice</returns>
        static int GetValidAnswer(List<string> answers)
        {

            int userChoice;

            do
            {
                Console.Write("Select an answer: ");
                string input = Console.ReadLine();
                bool isANumber = int.TryParse(input, out userChoice);

                if (isANumber == false)
                {
                    Console.Error.WriteLine("You did not enter a number.");
                }
                else if (userChoice <= 0 || userChoice > answers.Count)
                {
                    Console.WriteLine("Not a valid choice.");
                }
            }
            while (userChoice <= 0 || userChoice > answers.Count);

            if (userChoice == 1)
            {
                return -1;
            }
            else
            {
                return 1;
            }

        }


        /// <summary>
        /// Gets finalScore from positiveScore and negativeScore. Determines 
        /// the result to return based on whether finalScore is greater than 
        /// or equal to zero. Returns the corresponding result to finalScore.
        /// </summary>
        /// <param name="score">The index of the score</param>
        /// <param name="results">A list of results</param>
        /// <returns>The users results</returns>
        public static string GetResult(int score, List<string> results)
        {
            if (score >= 0)
            {
                return results[0];
            }
            else
            {
                return results[1];
            }
            // 1. Initialize finalScore to the sum of the positiveScore and negativeScore.
            // 2. Determine whether the finalScore is greater than or equal to zero.
            // 3. If so return highResult and ask if the user would like to restart the quiz. If yes than return the user to AskQuestion. If no give the user the quiz over screen.
            // 4. If the finalScore is less than zero return lowResult and ask if the user would like to restart the quiz. If yes than return the user to AskQuestion. If no give the user the quiz over screen.



 
        }


    }

    // Feedback(jcollard 2022-01-28): I added this Question class for you.
    // It couples a string and List<string> together. This helps keep the question
    // and list of answers logically together.
    class Question
    {

        public string question;
        public List<string> answers = new List<string>();
    }
}
