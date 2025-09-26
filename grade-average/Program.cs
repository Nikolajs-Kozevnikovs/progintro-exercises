int[] grades = { 4, 7, 02, 00, 10, 4, 12 };

int GetGrade(int courseid)
{
  int grade = grades[courseid];

  if (grade > 2)
  {
    return grade;
  }
  else
  {
    throw new Exception($"Warning: Grade is too low: {grade}");
  }
}

int count = 0, sum = 0;

for (int courseid = 0; courseid < grades.Length; courseid++)
{
  try
  {
    sum += GetGrade(courseid);
    count++;
  }
  catch (Exception e)
  {
    Console.WriteLine(e.Message);
  }
}

Console.WriteLine("Average grade is", sum / count);