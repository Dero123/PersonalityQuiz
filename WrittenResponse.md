# Guessing Game Written Response

The format for this document are taken directly from the AP Computer Science
Principles [Student Handout](../support/ap-csp-student-task-directions.pdf).

## 3a

Provide a written response that does all three of the following:

### 3a i.

Describes the overall purpose of the program.

For people to discover their hidden superpowers 

### 3a ii.

Describes what functionality of the program is demonstrated in the video.

The video demonstrates that my program can display questions and receive answers.

### 3a iii.

Describes the input and output of the program demonstrated in the video.

The user answers two questions then receives a result based on the users answers.

## 3b

Capture and paste two program code segments you developed during the
administration of this task that contain a list (or other collection type) being
used to manage complexity in your program.

### 3b i.

The first program code segment must show how data have been stored in the list.

```csharp
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

```

### 3b ii.

The second program code segment must show the data in the same list being used,
such as creating new data from the existing data or accessing multiple elements
in the list, as part of fulfilling the program's purpose.

```csharp
foreach (string answer in question.answers)
            {
                Console.WriteLine($"{optionNumbers}. {answer}");
                optionNumbers = optionNumbers + 1;
            }
```

### 3b iii.

Then provide a written response that does all three of the following:

Identifies the name of the list being used in this response

The list is stored in the variable "FireQuestion.answers"

### 3b iv.

Describes what the data contained in the list represents in your program

The list of all my answers in my fire question.

### 3b v.

Explains how the selected list manages complexity in your program code by
explaining why your program code could not be written, or how it would be
written differently, if you did not use the list.

The list makes it possible to easily add several new answers to the list later on. Without the list I would need to compensate with much more code therefore managing the complexity of my program.

## 3c.

Capture and paste two program code segments you developed during the
administration of this task that contain a student-developed procedure that
implements an algorithm used in your program and a call to that procedure.

### 3c i.

The first program code segment must be a student-developed procedure that:

- [ ] Defines the procedure's name and return type (if necessary)
- [ ] Contains and uses one or more parameters that have an effect on the functionality of the procedure
- [ ] Implements an algorithm that includes sequencing, selection, and iteration

```csharp
public static int AskQuestion(Question question)
        {
            
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

            
            return select;
        }
```

### 3c ii.

The second program code segment must show where your student-developed procedure is being called in your program.

```csharp
score = score + AskQuestion(TravelQuestion);
```

### 3c iii.

Describes in general what the identified procedure does and how it contributes to the overall functionality of the program.

 Given a question for the user to answer, displays a question then loops through each answer to display it. Receive the users response then return the users response. This procedure gives the user questions to be answered.

### 3c iv.

Explains in detailed steps how the algorithm implemented in the identified procedure works. Your explanation must be detailed enough for someone else to recreate it.

1.Display the question
2.Loop through each answer and display it
3.Use the GetValidAnswer method to get the user's response
4.Return the user's response

## 3d

Provide a written response that does all three of the following:

### 3d i.

Describes two calls to the procedure identified in written response 3c. Each call must pass a different argument(s) that causes a different segment of code in the algorithm to execute.

First call:

AskQuestion(null)

Second call:

Question question3 = new Question();
question3.question = "What is your favorite animal?";
question3.answers.Add("Wolf");
question3.answers.Add("Panda");

### 3d ii.

Describes what condition(s) is being tested by each call to the procedure

Condition(s) tested by the first call:
 
**TODO: Complete this section**

Condition(s) tested by the second call:

**TODO: Complete this section**

### 3d iii.

Result of the first call:

**TODO: Complete this section**

Result of the second call:

**TODO: Complete this section**