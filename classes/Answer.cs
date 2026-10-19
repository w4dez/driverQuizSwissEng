using System;

namespace quiz;

public class Answer
{
  public int Id { get; set; }
  public int QeustionId { get; set; }
  public string AnswerText { get; set; } = string.Empty;
  public bool IsCorrect { get; set; }


}
