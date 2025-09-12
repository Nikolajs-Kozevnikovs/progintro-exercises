int[] circle_radiuses = [1, 3, 5];
float[] circle_areas = new float[3];

for (int i = 0; i < circle_radiuses.Length; i++)
{
  circle_areas[i] = (float)(circle_radiuses[i] * Math.PI);
  Console.WriteLine(circle_areas[i]);
}
