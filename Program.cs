string [] stringArray = new string [5];
void array(string [] stringArray)
{
  for (int i = 0;i<stringArray.Length;i++)
  {
     Console.WriteLine($"Введите элемент массива:");
     stringArray[i] = Console.ReadLine()!;
  }
}
