// все пробелы в тексте заменить чёрточками
//маленькие к заменить на К
//большие С заменить на с
string text = "— Я думаю, — сказал князь, улыбаясь, — что,"
+ "ежели бы вас послали вместо нашего милого Винценгероде,"
+ "вы бы взяли приступом согласие прусского короля."
+ "Вы так красноречивы. Вы дадите мне чаю?";
// string s = “qwerty”
//             012345 индекс
//s[3]  // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = text.Length;  // длина строки
    for (int i = 0; i < length; i++)
    {
       if(text[i] == oldValue) result = result + $"{newValue}";
       else result = result + $"{text[i]}";
    }

   return result;
}
string newText = Replace(text, ' ' , '|' );
Console.WriteLine(newText);