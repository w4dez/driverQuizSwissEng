using System;
using System.Collections.Generic;
using System.Linq;
using quiz;

public class Program
{
  static void Main()
  {
    SerializeToJson.GenerateData();

    List<Question> allQuestions = SerializeToJson.LoadQuestions();
    List<Answer> allAnswers = SerializeToJson.LoadAnswers();

    List<Question> randomQuestions = allQuestions
      .OrderBy(x => Guid.NewGuid())
      .Take(15)
      .ToList();

    int correct = 0;
    int wrong = 0;
    List<Question> wrongQuestions = new List<Question>();

    Console.WriteLine("Driving theory quiz started.");
    Console.WriteLine();

    for (int i = 0; i < randomQuestions.Count; i++)
    {
      Question question = randomQuestions[i];
      List<Answer> qAnswers = new List<Answer>();

      foreach (Answer answer in allAnswers)
      {
        if (answer.QeustionId == question.Id)
        {
          qAnswers.Add(answer);
        }
      }

      qAnswers = qAnswers.OrderBy(x => Guid.NewGuid()).ToList();

      Console.WriteLine("Question " + (i + 1) + " of " + randomQuestions.Count);
      Console.WriteLine(question.QuestionText);

      for (int j = 0; j < qAnswers.Count; j++)
      {
        Console.WriteLine((j + 1) + ". " + qAnswers[j].AnswerText);
      }

      Console.Write("Your answer (1-" + qAnswers.Count + ") or press q to quit: ");
      string? input = InputHelper.ReadLineWithTimeout();

      if (input == null)
      {
        wrong = wrong + 1;
        wrongQuestions.Add(question);
        Console.WriteLine("Time's up");
        Console.WriteLine();
        continue;
      }

      if (input != null && input.ToLower() == "q")
      {
        Console.WriteLine();
        Console.WriteLine("You quit the quiz.");
        return;
      }

      if (int.TryParse(input, out int number) && number >= 1 && number <= qAnswers.Count)
      {
        Answer chosen = qAnswers[number - 1];

        if (chosen.IsCorrect == true)
        {
          correct = correct + 1;
          Console.WriteLine("Right ans!");
        }
        else
        {
          wrong = wrong + 1;
          wrongQuestions.Add(question);
          Console.WriteLine("Wrong");
        }
      }
      else
      {
        wrong = wrong + 1;
        wrongQuestions.Add(question);
        Console.WriteLine("Invalid input");
      }

      Console.WriteLine();
    }

    Console.WriteLine("Quiz is finished!");
    Console.WriteLine("Correct answers: " + correct);
    Console.WriteLine("Wrong answers: " + wrong);
    Console.WriteLine("Score: " + correct + " / " + randomQuestions.Count);

    if (wrongQuestions.Count > 0)
    {

      Console.WriteLine();
      Console.WriteLine("Questions u answered wrong. They need to be reanswered:");
      Console.WriteLine();
      for (int i = 0; i < wrongQuestions.Count; i++)
      {
        Question question = wrongQuestions[i];
        List<Answer> qAnswers = new List<Answer>();

        foreach (Answer answer in allAnswers)
        {
          if (answer.QeustionId == question.Id)
          {
            qAnswers.Add(answer);
          }
        }

        qAnswers = qAnswers.OrderBy(x => Guid.NewGuid()).ToList();

        Console.WriteLine("Question " + (i + 1) + ": " + question.QuestionText);

        for (int j = 0; j < qAnswers.Count; j++)
        {

          Console.WriteLine((j + 1) + ". " + qAnswers[j].AnswerText);
        }

        while (true)
        {
          string? input = InputHelper.ReadLineWithTimeout();

          Console.Write("Try again or press q to quit: ");
          string? tryAgain = Console.ReadLine();

          if (tryAgain != null && tryAgain.ToLower() == "q")
          {
            Console.WriteLine();
            Console.WriteLine("You quit the review.");
            return;
          }

          if (int.TryParse(tryAgain, out int number) && number >= 1 && number <= qAnswers.Count)
          {
            Answer chosen = qAnswers[number - 1];

            if (chosen.IsCorrect == true)
            {
              Console.WriteLine("Correct! Good job.");
              Console.WriteLine();
              break;
            }
            else
            {
              Console.WriteLine("Wrong. Try again.");
            }
          }
          else
          {
            Console.WriteLine("Wrong. Try again.");
          }
        }
      }

      Console.WriteLine("You answered all wrong questions correctly.");
    }
    else
    {
      Console.WriteLine("You got all questions right in the first try!");
    }
  }
}