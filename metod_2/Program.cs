// Метод 2 принимает и НЕ возвращает
void Method2(string msg)
{
  Console.WriteLine(msg);  
}
//Вызов метода
//Method2(msg: "Текст сообщения"); именованные аргументы
//Method2("Текст сообщения");


void Method21(string msg, int count)
{
  int i = 0;
  while (i<count)
  {
    Console.WriteLine(msg); 
    i++;
  }
}
//Вызов метода
Method21(msg: "Текст сообщения", count: 5);