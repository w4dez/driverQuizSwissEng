using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace quiz;

public class SerializeToJson
{
  private static void SaveJson<T>(string fileName, T obj)
  {
    File.WriteAllText(fileName, JsonSerializer.Serialize(obj, new JsonSerializerOptions
    {
      WriteIndented = true
    }));
  }

  public static void GenerateData()
  {
    var user = new User
    {
      Id = 1,
      FirstName = "John",
      LastName = "Doe",
      IsAdmin = false
    };
    SaveJson("User.json", user);

    var questions = new List<Question>
        {
            new Question { Id = 1, CategoryId = 1, QuestionText = "What does a round red sign with a white horizontal bar mean?", Explanation = "" },
            new Question { Id = 2, CategoryId = 1, QuestionText = "What does an inverted triangle sign with a red border mean?", Explanation = "" },
            new Question { Id = 3, CategoryId = 1, QuestionText = "What does a yellow diamond-shaped sign indicate?", Explanation = "" },
            new Question { Id = 4, CategoryId = 1, QuestionText = "What does a blue circular sign with a white arrow pointing up mean?", Explanation = "" },
            new Question { Id = 5, CategoryId = 1, QuestionText = "What does a red circle with a white horizontal line inside mean?", Explanation = "" },
            new Question { Id = 6, CategoryId = 1, QuestionText = "What does a triangular sign with a red border and a pedestrian symbol mean?", Explanation = "" },
            new Question { Id = 7, CategoryId = 1, QuestionText = "What does a circular sign with a red border and the number '50' mean?", Explanation = "" },

            new Question { Id = 8, CategoryId = 2, QuestionText = "At an intersection without signs, who has the right of way?", Explanation = "" },
            new Question { Id = 9, CategoryId = 2, QuestionText = "You are turning left at an intersection. Who has right of way?", Explanation = "" },
            new Question { Id = 10, CategoryId = 2, QuestionText = "A pedestrian is crossing at a zebra crossing. What must you do?", Explanation = "" },
            new Question { Id = 11, CategoryId = 2, QuestionText = "You are entering a roundabout. Who has right of way?", Explanation = "" },
            new Question { Id = 12, CategoryId = 2, QuestionText = "A police officer signals you to stop even though the light is green. What do you do?", Explanation = "" },
            new Question { Id = 13, CategoryId = 2, QuestionText = "You are on a main road. A car wants to enter from a side street. Who has priority?", Explanation = "" },

            new Question { Id = 14, CategoryId = 3, QuestionText = "What is the general speed limit in a residential area (built-up zone)?", Explanation = "" },
            new Question { Id = 15, CategoryId = 3, QuestionText = "What is the recommended speed in a 30 km/h zone?", Explanation = "" },
            new Question { Id = 16, CategoryId = 3, QuestionText = "How fast may you drive on a highway if no speed is posted?", Explanation = "" },
            new Question { Id = 17, CategoryId = 3, QuestionText = "You are driving in heavy fog. How should you adjust your speed?", Explanation = "" },
            new Question { Id = 18, CategoryId = 3, QuestionText = "You are passing a school bus that has stopped with flashing lights. What do you do?", Explanation = "" },

            new Question { Id = 19, CategoryId = 4, QuestionText = "What is the legal blood alcohol limit for drivers in most European countries?", Explanation = "" },
            new Question { Id = 20, CategoryId = 4, QuestionText = "How does alcohol affect driving ability?", Explanation = "" },
            new Question { Id = 21, CategoryId = 4, QuestionText = "You took medicine that causes drowsiness. May you drive?", Explanation = "" },
            new Question { Id = 22, CategoryId = 4, QuestionText = "What happens if you are caught driving under the influence of drugs?", Explanation = "" },

            new Question { Id = 23, CategoryId = 5, QuestionText = "What is the minimum tread depth for car tyres?", Explanation = "" },
            new Question { Id = 24, CategoryId = 5, QuestionText = "When should you switch on your headlights?", Explanation = "" },
            new Question { Id = 25, CategoryId = 5, QuestionText = "How often should you check your tyre pressure?", Explanation = "" },
            new Question { Id = 26, CategoryId = 5, QuestionText = "What does the red oil warning light mean?", Explanation = "" },
            new Question { Id = 27, CategoryId = 5, QuestionText = "When must you use a warning triangle?", Explanation = "" },
            new Question { Id = 28, CategoryId = 5, QuestionText = "What is the purpose of ABS (Anti-lock Braking System)?", Explanation = "" },
            new Question { Id = 29, CategoryId = 5, QuestionText = "How should you adjust your mirrors before driving?", Explanation = "" },
            new Question { Id = 30, CategoryId = 5, QuestionText = "What should you do if your brakes fail while driving?", Explanation = "" },
            new Question { Id = 31, CategoryId = 1, QuestionText = "What does a red triangle with a black exclamation mark mean?", Explanation = "" },
            new Question { Id = 32, CategoryId = 1, QuestionText = "What does a blue square sign with a white 'P' mean?", Explanation = "" },
            new Question { Id = 33, CategoryId = 1, QuestionText = "What does a red circle with a blue background and a red diagonal line mean?", Explanation = "" },
            new Question { Id = 34, CategoryId = 1, QuestionText = "What does a red circle with a blue background and a red X mean?", Explanation = "" },
            new Question { Id = 34, CategoryId = 1, QuestionText = "What does a yellow triangle with a black train symbol mean?", Explanation = "" },
        };
    SaveJson("Question.json", questions);

    var answer = new List<Answer>
        {
            new Answer { Id = 1, QeustionId = 1, AnswerText = "No Entry", IsCorrect = true },
            new Answer { Id = 2, QeustionId = 1, AnswerText = "Stop", IsCorrect = false },
            new Answer { Id = 3, QeustionId = 1, AnswerText = "Yield", IsCorrect = false },
            new Answer { Id = 4, QeustionId = 1, AnswerText = "End of restrictions", IsCorrect = false },

            new Answer { Id = 5, QeustionId = 2, AnswerText = "Yield", IsCorrect = true },
            new Answer { Id = 6, QeustionId = 2, AnswerText = "Stop", IsCorrect = false },
            new Answer { Id = 7, QeustionId = 2, AnswerText = "Priority road", IsCorrect = false },
            new Answer { Id = 8, QeustionId = 2, AnswerText = "No entry", IsCorrect = false },

            new Answer { Id = 9, QeustionId = 3, AnswerText = "Priority road", IsCorrect = true },
            new Answer { Id = 10, QeustionId = 3, AnswerText = "Warning", IsCorrect = false },
            new Answer { Id = 11, QeustionId = 3, AnswerText = "End of priority road", IsCorrect = false },

            new Answer { Id = 12, QeustionId = 4, AnswerText = "Proceed straight ahead only", IsCorrect = true },
            new Answer { Id = 13, QeustionId = 4, AnswerText = "Turn right", IsCorrect = false },
            new Answer { Id = 14, QeustionId = 4, AnswerText = "Turn left", IsCorrect = false },
            new Answer { Id = 15, QeustionId = 4, AnswerText = "Roundabout", IsCorrect = false },

            new Answer { Id = 16, QeustionId = 5, AnswerText = "No Entry", IsCorrect = true },
            new Answer { Id = 17, QeustionId = 5, AnswerText = "Stop", IsCorrect = false },
            new Answer { Id = 18, QeustionId = 5, AnswerText = "No Parking", IsCorrect = false },

            new Answer { Id = 19, QeustionId = 6, AnswerText = "Pedestrian crossing ahead", IsCorrect = true },
            new Answer { Id = 20, QeustionId = 6, AnswerText = "No pedestrians", IsCorrect = false },
            new Answer { Id = 21, QeustionId = 6, AnswerText = "School zone", IsCorrect = false },

            new Answer { Id = 22, QeustionId = 7, AnswerText = "Maximum speed 50 km/h", IsCorrect = true },
            new Answer { Id = 23, QeustionId = 7, AnswerText = "Minimum speed 50 km/h", IsCorrect = false },
            new Answer { Id = 24, QeustionId = 7, AnswerText = "Recommended speed 50 km/h", IsCorrect = false },

            new Answer { Id = 25, QeustionId = 8, AnswerText = "The vehicle on the right", IsCorrect = true },
            new Answer { Id = 26, QeustionId = 8, AnswerText = "The vehicle on the left", IsCorrect = false },
            new Answer { Id = 27, QeustionId = 8, AnswerText = "The faster vehicle", IsCorrect = false },
            new Answer { Id = 28, QeustionId = 8, AnswerText = "The larger vehicle", IsCorrect = false },

            new Answer { Id = 29, QeustionId = 9, AnswerText = "Oncoming traffic and traffic turning right", IsCorrect = true },
            new Answer { Id = 30, QeustionId = 9, AnswerText = "No one, you go first", IsCorrect = false },
            new Answer { Id = 31, QeustionId = 9, AnswerText = "Only pedestrians", IsCorrect = false },

            new Answer { Id = 32, QeustionId = 10, AnswerText = "Stop and let the pedestrian cross", IsCorrect = true },
            new Answer { Id = 33, QeustionId = 10, AnswerText = "Honk and continue", IsCorrect = false },
            new Answer { Id = 34, QeustionId = 10, AnswerText = "Slow down but keep going", IsCorrect = false },

            new Answer { Id = 35, QeustionId = 11, AnswerText = "Traffic already in the roundabout", IsCorrect = true },
            new Answer { Id = 36, QeustionId = 11, AnswerText = "Traffic entering the roundabout", IsCorrect = false },
            new Answer { Id = 37, QeustionId = 11, AnswerText = "The larger vehicle", IsCorrect = false },

            new Answer { Id = 38, QeustionId = 12, AnswerText = "Follow the police officer's signal", IsCorrect = true },
            new Answer { Id = 39, QeustionId = 12, AnswerText = "Follow the traffic light", IsCorrect = false },
            new Answer { Id = 40, QeustionId = 12, AnswerText = "Stop and wait for instructions", IsCorrect = false },

            new Answer { Id = 41, QeustionId = 13, AnswerText = "You have priority", IsCorrect = true },
            new Answer { Id = 42, QeustionId = 13, AnswerText = "The car from the side street", IsCorrect = false },
            new Answer { Id = 43, QeustionId = 13, AnswerText = "Whoever is faster", IsCorrect = false },

            new Answer { Id = 44, QeustionId = 14, AnswerText = "50 km/h", IsCorrect = true },
            new Answer { Id = 45, QeustionId = 14, AnswerText = "30 km/h", IsCorrect = false },
            new Answer { Id = 46, QeustionId = 14, AnswerText = "70 km/h", IsCorrect = false },
            new Answer { Id = 47, QeustionId = 14, AnswerText = "100 km/h", IsCorrect = false },

            new Answer { Id = 48, QeustionId = 15, AnswerText = "30 km/h", IsCorrect = true },
            new Answer { Id = 49, QeustionId = 15, AnswerText = "50 km/h", IsCorrect = false },
            new Answer { Id = 50, QeustionId = 15, AnswerText = "20 km/h", IsCorrect = false },

            new Answer { Id = 51, QeustionId = 16, AnswerText = "The default highway limit of the country", IsCorrect = true },
            new Answer { Id = 52, QeustionId = 16, AnswerText = "Unlimited speed", IsCorrect = false },
            new Answer { Id = 53, QeustionId = 16, AnswerText = "80 km/h", IsCorrect = false },

            new Answer { Id = 54, QeustionId = 17, AnswerText = "Reduce speed to stop within visible distance", IsCorrect = true },
            new Answer { Id = 55, QeustionId = 17, AnswerText = "Turn on high beams and continue", IsCorrect = false },
            new Answer { Id = 56, QeustionId = 17, AnswerText = "Keep the same speed", IsCorrect = false },

            new Answer { Id = 57, QeustionId = 18, AnswerText = "Stop and wait until it's safe", IsCorrect = true },
            new Answer { Id = 58, QeustionId = 18, AnswerText = "Pass slowly", IsCorrect = false },
            new Answer { Id = 59, QeustionId = 18, AnswerText = "Honk and pass", IsCorrect = false },

            new Answer { Id = 60, QeustionId = 19, AnswerText = "0.5 per mille (0.05%)", IsCorrect = true },
            new Answer { Id = 61, QeustionId = 19, AnswerText = "1.0 per mille (0.10%)", IsCorrect = false },
            new Answer { Id = 62, QeustionId = 19, AnswerText = "0.0 per mille", IsCorrect = false },

            new Answer { Id = 63, QeustionId = 20, AnswerText = "It slows reaction time and impairs judgement", IsCorrect = true },
            new Answer { Id = 64, QeustionId = 20, AnswerText = "It improves concentration", IsCorrect = false },
            new Answer { Id = 65, QeustionId = 20, AnswerText = "It has no effect", IsCorrect = false },

            new Answer { Id = 66, QeustionId = 21, AnswerText = "No, you must not drive", IsCorrect = true },
            new Answer { Id = 67, QeustionId = 21, AnswerText = "Yes, if you drive slowly", IsCorrect = false },
            new Answer { Id = 68, QeustionId = 21, AnswerText = "Only at night", IsCorrect = false },

            new Answer { Id = 69, QeustionId = 22, AnswerText = "License suspension, fines and possible criminal charges", IsCorrect = true },
            new Answer { Id = 70, QeustionId = 22, AnswerText = "Only a warning", IsCorrect = false },
            new Answer { Id = 71, QeustionId = 22, AnswerText = "No consequences", IsCorrect = false },

            new Answer { Id = 72, QeustionId = 23, AnswerText = "1.6 mm", IsCorrect = true },
            new Answer { Id = 73, QeustionId = 23, AnswerText = "0.5 mm", IsCorrect = false },
            new Answer { Id = 74, QeustionId = 23, AnswerText = "3.0 mm", IsCorrect = false },

            new Answer { Id = 75, QeustionId = 24, AnswerText = "Whenever visibility is reduced", IsCorrect = true },
            new Answer { Id = 76, QeustionId = 24, AnswerText = "Only at night", IsCorrect = false },
            new Answer { Id = 77, QeustionId = 24, AnswerText = "Only in tunnels", IsCorrect = false },

            new Answer { Id = 78, QeustionId = 25, AnswerText = "At least once a month", IsCorrect = true },
            new Answer { Id = 79, QeustionId = 25, AnswerText = "Once a year", IsCorrect = false },
            new Answer { Id = 80, QeustionId = 25, AnswerText = "Only when a tyre looks flat", IsCorrect = false },

            new Answer { Id = 81, QeustionId = 26, AnswerText = "Low oil pressure – stop the engine", IsCorrect = true },
            new Answer { Id = 82, QeustionId = 26, AnswerText = "Low fuel", IsCorrect = false },
            new Answer { Id = 83, QeustionId = 26, AnswerText = "Low tyre pressure", IsCorrect = false },

            new Answer { Id = 84, QeustionId = 27, AnswerText = "When your vehicle breaks down on the road", IsCorrect = true },
            new Answer { Id = 85, QeustionId = 27, AnswerText = "Whenever you park", IsCorrect = false },
            new Answer { Id = 86, QeustionId = 27, AnswerText = "Only on highways", IsCorrect = false },

            new Answer { Id = 87, QeustionId = 28, AnswerText = "Prevents wheels from locking during braking", IsCorrect = true },
            new Answer { Id = 88, QeustionId = 28, AnswerText = "Increases engine power", IsCorrect = false },
            new Answer { Id = 89, QeustionId = 28, AnswerText = "Saves fuel", IsCorrect = false },

            new Answer { Id = 90, QeustionId = 29, AnswerText = "So you can see behind and beside your car with minimal head movement", IsCorrect = true },
            new Answer { Id = 91, QeustionId = 29, AnswerText = "To see the passengers", IsCorrect = false },
            new Answer { Id = 92, QeustionId = 29, AnswerText = "To see your own car", IsCorrect = false },

            new Answer { Id = 93, QeustionId = 30, AnswerText = "Pump the brakes, shift to a lower gear, use handbrake gently, find a safe place to stop", IsCorrect = true },
            new Answer { Id = 94, QeustionId = 30, AnswerText = "Turn off the engine immediately", IsCorrect = false },
            new Answer { Id = 95, QeustionId = 30, AnswerText = "Accelerate to regain control", IsCorrect = false },
        };
    SaveJson("Answer.json", answer);

    var quizResult = new QuizResult
    {
      Id = 1,
      QuizId = 1,
      AnswerId = 1,
      Score = 100
    };
    SaveJson("quizResult.json", quizResult);
  }

  public static List<Question> LoadQuestions()
  {
    if (!File.Exists("Question.json"))
      return new List<Question>();

    var json = File.ReadAllText("Question.json");
    return JsonSerializer.Deserialize<List<Question>>(json) ?? new List<Question>();
  }

  public static List<Answer> LoadAnswers()
  {
    if (!File.Exists("Answer.json"))
      return new List<Answer>();

    var json = File.ReadAllText("Answer.json");
    return JsonSerializer.Deserialize<List<Answer>>(json) ?? new List<Answer>();
  }
}
