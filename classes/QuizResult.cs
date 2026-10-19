using System;

namespace quiz;

public class QuizResult
{
  public int Id { get; set; }
  public int QuizId { get; set; }
  public int AnswerId { get; set; }
  public int Score { get; set; }
}
