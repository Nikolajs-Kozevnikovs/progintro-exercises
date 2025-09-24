float get_diff (float first, float second)
{
  return Math.Abs(first - second);
}


float[] days = [32.1f, 23.5f, -12.7f, 17.6f, 13.9f, 14.0f, 14.5f];
string[] days_names = ["Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"];

for (int i = 1; i < days.Length; i++)
{
  Console.WriteLine($"Difference between {days_names[i-1]} and {days_names[i]} is {Math.Round(get_diff(days[i-1], days[i]), 1)} degrees.");
}


