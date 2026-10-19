using System;

namespace quiz;

public class Quiz
{
  public int Id { get; set; }
  public int UserId { get; set; }
  public int Attemp { get; set; }
  public DateTime StartedAt { get; set; }
  public DateTime FinishedAt { get; set; }


}
