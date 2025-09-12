float[] daily_temperatures = [21.5f, 23.7f, 19.6f, 22.5f, 25.3f, 21.7f, 18.9f];

for (int i = 0; i < daily_temperatures.Length-1; i++)
{
  Console.WriteLine(daily_temperatures[i+1] - daily_temperatures[i]);
}