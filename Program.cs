string [] stringArray = new string [5];
void array(string [] stringArray)
{
  for (int i = 0;i<stringArray.Length;i++)
  {
     Console.WriteLine($"Введите элемент массива:");
     stringArray[i] = Console.ReadLine()!;
  }
}
string [] symbol(string [] stringArray)
{
  int n = 0;
  for (int i = 0;i<stringArray.Length;i++)
  {
    if(stringArray[i].Length <=3)
    n++;
  else 
   {
     Console.Write($"неккоретный ввод, число должно состоять из 3-х символов или мение)") ;
     break ;
    
   }
  }
  string [] rez = new string [n];
  int j = 0;
  for (int i = 0;i<stringArray.Length;i++)
  {
    if(stringArray[i].Length <=3)
    {
        rez[j] = stringArray[i];
        j++;
    }
  }
  return rez;
}
void printA(string [] stringArray)
{
    for (int i = 0;i<stringArray.Length;i++)
    {
    Console.Write($"{stringArray[i]},");
    }
}
array(stringArray);
printA(symbol(stringArray));
