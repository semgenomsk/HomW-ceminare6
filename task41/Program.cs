// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"

// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int Readnumber(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int countOfPositive = 0;

while (true)
{
    string answer = Console.ReadLine();
    if (answer == "stop") //если ответ пользователя - стоп слово
    {
        break;
    }
    else
    {
        int.TryParse(answer,out int answerNumber);
        if (answerNumber > 0)
        {
            countOfPositive++;
        }
    }
}

Console.WriteLine(countOfPositive);