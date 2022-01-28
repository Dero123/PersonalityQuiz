using System;
using System.Collections.Generic; // Feedback(jcollard 2022-01-28): This allow us to use List

namespace PersonalityQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
            // Feedback(jcollard 2022-01-28): Daniel, you're off to a great
            // start! I've gone ahead and done a few corrections as well as
            // added a handful of TODO comments. You sould complete the TODO
            // comments before moving on to Part 2.2.

            // Example(jcollard 2022-01-28): Below is an example of using the
            // Question class to create three questions. 

            // Construct a new Question object
            Question woodChuckQuestion = new Question();

            // Next, set the question to be an actual question.
            woodChuckQuestion.question = "How much wood could a woodchuck chuck if a woodchuck could chuck wood?";

            // Next, add answers to the question
            woodChuckQuestion.answers.Add("As much wood as a woodchuck could chuck if a woodchuck could chuck wood.");
            woodChuckQuestion.answers.Add("Uh... 14?");
            woodChuckQuestion.answers.Add("None. Clearly the woodchuck is a manifestation of all your fears.");
            
            Question foodQuestion = new Question();

            // Next, set the question to be an actual question.
            foodQuestion.question = "What is your favorite food?";

            // Next, add answers to the question
            foodQuestion.answers.Add("Wood");
            foodQuestion.answers.Add("Woodchuck");
            foodQuestion.answers.Add("Banana water");

            // Displays the wood chuck question
            Console.WriteLine(woodChuckQuestion.question);

            foreach (string answer in woodChuckQuestion.answers)
            {
                Console.WriteLine(answer);
            }

            // Displays the food question
            Console.WriteLine(foodQuestion.question);

            foreach (string answer in foodQuestion.answers)
            {
                Console.WriteLine(answer);
            }

            
        }

        // TODO(jcollard 2022-01-28): Add documentation comment. To auto generate a template, type `///` just above a method
        static int AskQuestion(Question question)
        {
            // 1.Display the question
            // 2.Loop through each answer and display it
            // 3.Use the GetValidAnswer method to get the user's response
            // 4.Return the user's response
            return -1;
        }

        // TODO(jcollard 2022-01-28): Add documentation comment. To auto generate a template, type `///` just above a method
        static int GetValidAnswer(List<string> answers)
        {
            // 1. Validate that there is at least 1 possible answer.
            // 2. If the list of answers is empty, throw an exception
            // 3. Otherwise, Display a message asking the user to select an option.
            // 4. Store the user's response in a variable name choice
            // 5. Validate that choice is one of the possible answers
            // 6. If it is not a valid answer
            // - Display an error message
            // - Go to 3
            // 7. Otherwise, return the user's choice.
            return -1;
        }

        // TODO(jcollard 2022-01-28): Add documentation comment. To auto generate a template, type `///` just above a method
        static string GetResult(int score, List<string> results)
        {
            // 1. Initialize finalScore to the sum of the positiveScore and negativeScore.
            // 2. Determine whether the finalScore is greater than or equal to zero.
            // 3. If so return highResult and ask if the user would like to restart the quiz. If yes than return the user to AskQuestion. If no give the user the quiz over screen.
            // 4. If the finalScore is less than zero return lowResult and ask if the user would like to restart the quiz. If yes than return the user to AskQuestion. If no give the user the quiz over screen.
            return null; // Feedback(jcollard 2022-01-28): I changed this from `return -1` to `return null`. -1 isn't a valid string so it needed to be changed
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
