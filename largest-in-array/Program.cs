int[] arr = [1, 123, 345, 234, 12, -74];

int maxValue = arr[0];

for (int i = 1; i < arr.Length; i++)
{
  if (arr[i] > maxValue)
  {
    maxValue = arr[i];
  }
}

Console.WriteLine(maxValue);
