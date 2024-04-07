// Введите исходный массив строк
        Console.WriteLine("Введите элементы массива, разделяя их запятыми:");
        string input = Console.ReadLine();
        string[] inputArray = input.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

        // Формирование нового массива из строк, длина которых <= 3
        string[] result = FilterShortStrings(inputArray);

        // Вывод результата
        Console.WriteLine("Результат:");
        foreach (string str in result)
        {
            Console.WriteLine(str);
        }
    

    static string[] FilterShortStrings(string[] inputArray)
    {
        // Подсчет количества строк, удовлетворяющих условию
        int count = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива нужного размера
        string[] result = new string[count];

        // Заполнение нового массива строками, длина которых <= 3
        int index = 0;
        foreach (string str in inputArray)
        {
            if (str.Length <= 3)
            {
                result[index] = str;
                index++;
            }
        }

        return result;
    }

