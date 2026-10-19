using System;


namespace quiz;

public class Question
{
  public int Id { get; set; }
  public int CategoryId { get; set; }
  public string Explanation { get; set; } = string.Empty;
  public string QuestionText { get; set; } = string.Empty;


}
