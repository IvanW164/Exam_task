// Написать программу, которая из имеющегося массива строк формирует массив из 
// строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно 
// ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не 
// рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

using static System.Console;

string[] Array = { "mazda", "toyota", "vaz", "zaz", "volga", "kia" };

void PrintArray(string[] Array)
{
  Write("["); 
  for (int i = 0; i < Array.Length; i++)
  {
    Write($"\"{Array[i]}\"");
    if (i != Array.Length - 1)
    {
      Write(", ");
    }
  }
  Write("]");
}

int ArraySecond(string[] Array)
{
  int number = 0;
  for (int i = 0; i < Array.Length; i++)
  {
    if (Array[i].Length < 4)
    {
      number++;
    }
  }
  return number;
}

string[] ArrayFinish (string[] Array, int size)
{
  string[] newArray = new string[size];
  int j = 0;
  for (int i = 0; i < Array.Length; i++)
  {
    if (Array[i].Length < 4)
    {
      newArray[j] = Array[i];
      j++;
    }
  }
  return newArray;
}

PrintArray(Array);
int size = ArraySecond(Array);
string[] newArray = ArrayFinish (Array, size);
Write(" --> ");
PrintArray(newArray);