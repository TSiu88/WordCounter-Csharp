using System;

namespace Counter.Models
{
  public class RepeatCounter
  {
    public string Property { get; set; }
    public RepeatCounter(string property)
    {
      Property = property;
    }
  }
}