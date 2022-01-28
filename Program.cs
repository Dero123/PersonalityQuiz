using System;

namespace PersonalityQuiz
{
    class Program
    {
        static int AskQuestion(Question)
        {
            // 1.Display the question
            // 2.Loop through each answer and display it
            // 3.Use the GetValidAnswer method to get the user's response
            // 4.Return the user's response
            return -1;
        }

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

        static string GetResult(int score, List<string> results)
        {
            // 1. Initialize finalScore to the sum of the positiveScore and negativeScore.
            // 2. Determine whether the finalScore is greater than or equal to zero.
            // 3. If so return highResult and ask if the user would like to restart the quiz. If yes than return the user to AskQuestion. If no give the user the quiz over screen.
            // 4. If the finalScore is less than zero return lowResult and ask if the user would like to restart the quiz. If yes than return the user to AskQuestion. If no give the user the quiz over screen.
            return -1;
        }


    }
}
