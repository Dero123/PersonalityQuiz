using System;
using System.Collections.Generic;

namespace PersonalityQuiz
{
    class TestGetResult
    {
        public static bool RunTest()
        {
            int testScore = -4;

            List<string> testResults = new List<string>();
            testResults.Add("Kanye");
            testResults.Add("Bob the Builder");

            string result = Program.GetResult(testScore, testResults);
            if (result != "Kanyes")
            {
                Console.Error.WriteLine($"We expected the result to be 'Kanye' but we actually got {result}.");
                return false;
            }
            
             int testScore2 = 8;

            List<string> testResults2 = new List<string>();
            testResults.Add("Joseph");
            testResults.Add("Josh");

            string result2 = Program.GetResult(testScore2, testResults2);
            if (result != "Josh")
            {
                Console.Error.WriteLine($"We expected the result to be 'Josh' but we actually got {result}.");
                return false;
            }

            int testScore3 = 0;

            List<string> testResults3 = new List<string>();
            testResults.Add("Alexandria");
            testResults.Add("Hannibal");
            testResults.Add("Julius");

            string result3 = Program.GetResult(testScore3, testResults3);
            if (result != "Alexandria" || result != "Hannibal")
            {
                Console.Error.WriteLine($"We expected the result to be 'Alexandria' or 'Hannibal' but we actually got {result}.");
                return false;
            }


            return true;
        }
    }
}
