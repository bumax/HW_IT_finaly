// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Объявляем функцию печати массива
void PrintArray(string[] array)
{
    Console.WriteLine("[{0}]", string.Join(", ", array));
}

// Вводим исходную строку
System.Console.Write("Введите исходную строку: ");
string rawString = Console.ReadLine();

if (rawString != string.Empty)
{

    // Формируем словарь символов, которые хотим удалить из строки:
    char[] symbolsToRemove = { '.', ',', ':', ';', '(', ')', '=' };

    // Удаляем ненужные символы из строки
    foreach (var charToRemove in symbolsToRemove)
    {
        rawString = rawString.Replace(charToRemove.ToString(), "");
    }

    // Разбиваем строку на массив
    var rawWords = rawString.Split(' ');

    // Инициализируем результиующую строку
    var resultString = string.Empty;

    // Проходим по массиву (можно было бы и foreach, но так в соответствии с блок-схемой)
    for (int i = 0; i < rawWords.Length; i++)
    {
        // Если не больше 3х символов в строке, то записываем её в строку и добавляем разделитель
        if (rawWords[i].Length <= 3)
            resultString += rawWords[i] + " ";
    }

    // Проверяем результат, если строка пустая, сообщаем об этом пользователю
    if (resultString != string.Empty)
    {

        // Разбиваем строку в массив
        var resultWords = resultString.Split(' ');
        // Печатаем массив  в консоль
        PrintArray(resultWords);
    }
    else
        Console.WriteLine("В исходной строке все слова длиннее 3х символов!");
}
// Если исходная строка пустая, сообщаем об этом пользователю
else
    Console.WriteLine("Ошибка! Введена пустая строка!");