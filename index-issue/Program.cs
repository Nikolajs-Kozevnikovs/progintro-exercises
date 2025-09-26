int iterationer = 10;
int[] array = {1, 2, 3, 4, 5};
// increment
for (int i=0 ; i<iterationer ; i++) {
  try
  {
    array[i]++;
  }
  catch (IndexOutOfRangeException e)
  {
    continue;
  }
}
// print
for (int i = 0; i < array.Length; i++)
{
  Console.WriteLine(array[i]);
}

// 1. done
// 2. System.IndexOutOfRangeException
// 3. array has five elements, but first for loop iterates from 0 until i >= iterationer (10). This causes array[5]++, which is not possible since it does not exist