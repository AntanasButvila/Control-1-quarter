Console.Write("Введите количество элементов массива: ");

int size = Convert.ToInt32(Console.ReadLine());

string [] array = new string [size];
void GetArray(string [] array)
{
  for (int i = 0; i < array.Length; i++)
  {
     Console.WriteLine($"Введите {i+1} элемент массива");
     array[i] = Console.ReadLine();
  }
}

string [] LessThenThreeOrEqual(string [] array)
{
  int n = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i].Length <= 3)
      n++;
  }
  string [] resultArray = new string [n];
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if(array[i].Length <= 3)
    {
        resultArray[count] = array[i];
        count++;
    }
  }
  return resultArray;
}