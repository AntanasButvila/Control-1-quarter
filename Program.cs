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