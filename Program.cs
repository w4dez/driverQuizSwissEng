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
      .Take(30)
      .ToList();

    int correct = 0;
    int wrong = 0;

    Console.WriteLine("Driving theory quiz started. Answer 30 random questions.");
    Console.WriteLine();

    for (int i = 0; i < randomQuestions.Count; i++)
    {
      Question question = randomQuestions[i];

      List<Answer> answers = allAnswers
        .Where(a => a.QeustionId == question.Id)
        .OrderBy(x => Guid.NewGuid())
        .ToList();

      Console.WriteLine("Question " + (i + 1) + " of " + randomQuestions.Count);
      Console.WriteLine(question.QuestionText);

      for (int j = 0; j < answers.Count; j++)
      {
        Console.WriteLine((j + 1) + ". " + answers[j].AnswerText);
      }

      Console.Write("Your answer (1-" + answers.Count + "): ");
      string? input = Console.ReadLine();

      if (int.TryParse(input, out int number) && number >= 1 && number <= answers.Count)
      {
        Answer chosen = answers[number - 1];

        if (chosen.IsCorrect == true)
        {
          correct = correct + 1;
          Console.WriteLine("Correct!");
        }
        else
        {
          wrong = wrong + 1;
          Console.WriteLine("Wrong!");
        }
      }
      else
      {
        wrong = wrong + 1;
        Console.WriteLine("Invalid input. Counted as wrong.");
      }

      Console.WriteLine();
    }

    Console.WriteLine("Quiz finished!");
    Console.WriteLine("Correct answers: " + correct);
    Console.WriteLine("Wrong answers: " + wrong);
    Console.WriteLine("Score: " + correct + " / " + randomQuestions.Count);
  }
}