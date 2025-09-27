using System;

namespace Lab1
{
    internal class Tasks
    {
        public void SumLastNums()
        {
            Console.WriteLine("Сумма последних двух знаков числа.");
            int num;
            do
            {
                InputValidation.GetInt32(out num, "Введите число, не превышающее размерность int (2.147.483.647 по модулю) и состоящее из двух или более разрядов: ");
            }
            while (Math.Abs(num) < 10);

            Console.WriteLine($"Результат: {sumLastNums(num)}");
        }

        public int sumLastNums(int x)
        {
            return (Math.Abs(x) % 10) + ((Math.Abs(x) / 10) % 10);
        }

        public void IsPositive()
        {
            Console.WriteLine("Есть ли позитив?");
            int num;
            InputValidation.GetInt32(out num, "Введите число, не превышающее размерность int (2.147.483.647 по модулю): ");
            Console.WriteLine($"Результат: {isPositive(num).ToString().ToLower()}");
        }

        public bool isPositive(int x)
        {
            return x > 0;
        }

        public void IsUpperCase()
        {
            Console.WriteLine("Это большая бува в диапозоне от 'A' до 'Z'?");
            char ch;
            InputValidation.GetChar(out ch, "Введите символ: ");
            Console.WriteLine($"Результат: {isUpperCase(ch).ToString().ToLower()}");
        }

        public bool isUpperCase(char x)
        {
            return ('A' <= x) && (x <= 'Z');
        }

        public void IsDivisor()
        {
            Console.WriteLine("Одно из чисел делит другое нацело?");
            int num1, num2;
            InputValidation.GetInt32(out num1, "Введите первое число, не превышающее размерность int (2.147.483.647 по модулю): ");
            InputValidation.GetInt32(out num2, "Введите второе число, не превышающее размерность int (2.147.483.647 по модулю): ");
            Console.WriteLine($"Результат: {isDivisor(num1, num2).ToString().ToLower()}");
        }

        public bool isDivisor(int a, int b)
        {
            return (a % b == 0) || (b % a == 0);
        }

        public void LastNumSum()
        {
            Console.WriteLine("Сумма пяти последовательно введённых чисел");
            int num1, num2;
            string result = "";
            InputValidation.GetInt32(out num1, "Введите первое число, не превышающее размерность int (2.147.483.647 по модулю): ");
            InputValidation.GetInt32(out num2, "Введите второе число, не превышающее размерность int (2.147.483.647 по модулю): ");
            result += $"{num1}+{num2} это {lastNumSum(num1, num2)}\n";
            num1 = lastNumSum(num1, num2);
            InputValidation.GetInt32(out num2, "Введите третье число, не превышающее размерность int (2.147.483.647 по модулю): ");
            result += $"{num1}+{num2} это {lastNumSum(num1, num2)}\n";
            num1 = lastNumSum(num1, num2);
            InputValidation.GetInt32(out num2, "Введите четвёртое число, не превышающее размерность int (2.147.483.647 по модулю): ");
            result += $"{num1}+{num2} это {lastNumSum(num1, num2)}\n";
            num1 = lastNumSum(num1, num2);
            InputValidation.GetInt32(out num2, "Введите пятое число, не превышающее размерность int (2.147.483.647 по модулю): ");
            result += $"{num1}+{num2} это {lastNumSum(num1, num2)}\n";
            Console.WriteLine(result + $"Итого {lastNumSum(num1, num2)}");
        }

        public int lastNumSum(int a, int b)
        {
            return (a % 10) + (b % 10);
        }

        public void SafeDiv()
        {
            Console.WriteLine("Безопасное деление.");
            int num1, num2;
            InputValidation.GetInt32(out num1, "Введите первое число, не превышающее размерность int (2.147.483.647 по модулю): ");
            InputValidation.GetInt32(out num2, "Введите второе число, не превышающее размерность int (2.147.483.647 по модулю): ");
            Console.WriteLine($"Результат: {safeDiv(num1, num2)}");
        }

        public double safeDiv(int x, int y)
        {
            if (y == 0)
            {
                return 0;
            }
            return (double)x / y;
        }

        public void MakeDecision()
        {
            Console.WriteLine("Строка сравнения.");
            int num1, num2;
            InputValidation.GetInt32(out num1, "Введите первое число, не превышающее размерность int (2.147.483.647 по модулю): ");
            InputValidation.GetInt32(out num2, "Введите второе число, не превышающее размерность int (2.147.483.647 по модулю): ");
            Console.WriteLine($"Результат:{makeDecision(num1, num2)}");
        }

        public String makeDecision(int x, int y)
        {
            if (x == y)
            {
                return $"{x}=={y}";
            }
            else if (x > y)
            {
                return $"{x}>{y}";
            }
            return $"{x}<{y}";
        }

        public void Sum3()
        {
            Console.WriteLine("Можно ли сложить любые два из введённых числа, получив третье?");
            int num1, num2, num3;
            InputValidation.GetInt32(out num1, "Введите первое число, не превышающее размерность int (2.147.483.647 по модулю): ");
            InputValidation.GetInt32(out num2, "Введите второе число, не превышающее размерность int (2.147.483.647 по модулю): ");
            InputValidation.GetInt32(out num3, "Введите третье число, не превышающее размерность int (2.147.483.647 по модулю): ");
            Console.WriteLine($"Результат: {sum3(num1, num2, num3).ToString().ToLower()}");
        }

        public bool sum3(int x, int y, int z)
        {
            if (x + y == z || x + z == y || y + z == x)
            {
                return true;
            }
            return false;
        }

        public void Age()
        {
            Console.WriteLine("Возраст по числу лет.");
            int num;
            InputValidation.GetInt32(out num, "Введите число, не превышающее размерность int (2.147.483.647 по модулю): ");
            Console.WriteLine($"Результат: \"{age(num)}\"");
        }

        public String age(int x)
        {
            if (x % 10 == 1 && x != 11)
            {
                return $"{x} год";
            }
            else if ((x % 10 == 2 || x % 10 == 3 || x % 10 == 4) && (x != 12 & x != 13 & x != 14))
            {
                return $"{x} года";
            }
            return $"{x} лет";
        }

        public void PrintDays()
        {
            string day;
            Console.WriteLine("Какие дни остались до конца недели?");
            Console.WriteLine("Введите день недели: ");
            day = Console.ReadLine();
            Console.WriteLine("результат:");
            printDays(day);
        }

        public void printDays(String x)
        {
            switch (x.ToLower())
            {
                case "понедельник": Console.WriteLine("понедельник\nвторник\nсреда\nчетверг\nпятница\nсуббота\nвоскресенье"); break;
                case "вторник": Console.WriteLine("вторник\nсреда\nчетверг\nпятница\nсуббота\nвоскресенье"); break;
                case "среда": Console.WriteLine("среда\nчетверг\nпятница\nсуббота\nвоскресенье"); break;
                case "четверг": Console.WriteLine("четверг\nпятница\nсуббота\nвоскресенье"); break;
                case "пятница": Console.WriteLine("пятница\nсуббота\nвоскресенье"); break;
                case "суббота": Console.WriteLine("суббота\nвоскресенье"); break;
                case "воскресенье": Console.WriteLine("воскресенье"); break;
                default: Console.WriteLine("это не день недели"); break;
            }
        }

        public void ReverseListNums()
        {
            Console.WriteLine("Все числа от введённого до 0.");
            int num;
            InputValidation.GetInt32(out num, "Введите число, не превышающее размерность int (2.147.483.647 по модулю): ");
            Console.WriteLine($"результат: {reverseListNums(num)}");
        }

        public String reverseListNums(int x)
        {
            string result = "";
            for (int i = x; i >= 0;  i--)
            {
                result += i.ToString();
                result += " ";
            }
            return result;
        }

        public void Pow()
        {
            Console.WriteLine("Возведение x в степень y.");
            int x, y;
            InputValidation.GetInt32(out x, "Введите число (x), не превышающее размерность int (2.147.483.647 по модулю): ");
            InputValidation.GetInt32(out y, "Введите число (y), не превышающее размерность int (2.147.483.647 по модулю): ");
            try
            {
                Console.WriteLine($"результат: {pow(x, y)}");
            }
            catch
            {
                Console.WriteLine("Ошибка! Результат превышает размерность int.");
            }
        }

        public int pow(int x, int y)
        {
            int z = 1;
            for (int i = 0;  i < y; i++)
            {
                z = checked(x*z);
            }
            return z;
        }

        public void EqualNum()
        {
            Console.WriteLine("Все знаки числа одинаковы?");
            int num;
            InputValidation.GetInt32(out num, "Введите число, не превышающее размерность int (2.147.483.647 по модулю): ");
            Console.WriteLine($"результат: {equalNum(num).ToString().ToLower()}");
        }

        public bool equalNum(int x)
        {
            int y = x % 10;
            x /= 10;
            while (x > 0)
            {
                if (y != x % 10)
                {
                    return false;
                }
                x /= 10;
            }
            return true;
        }

        public void LeftTriangle()
        {
            Console.WriteLine("Треугольник введённого вами размером");
            int num;
            InputValidation.GetInt32(out num, "Введите число, не превышающее размерность int (2.147.483.647 по модулю): ");
            leftTriangle(num);
        }

        public void leftTriangle(int x)
        {
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }

        public void GuessGame()
        {
            Console.WriteLine("Необходимо угадать загаданное число.");
            guessGame();
        }

        public void guessGame()
        {
            
            Random random = new Random();
            int guess = -1, attempts = 1, answer = random.Next(10);
            InputValidation.GetInt32(out guess, "Введите число от 0 до 9: ");
            while (guess != answer)
            {
                attempts++;
                InputValidation.GetInt32(out guess, "Вы не угадали, введите число от 0 до 9: ");
            }
            Console.WriteLine($"Вы угадали!\nКоличество попыток: {attempts}");
        }

        public void FindLast()
        {
            Console.WriteLine("Поиск порядкового номера числа в массиве с конца (если число не найдено - результат -1.");
            Console.WriteLine("Все вами введённые числа не должны превышать размерность int (2.147.483.647 по модулю)");
            int arrSize, num;
            InputValidation.GetInt32(out arrSize, "Введите размер массива: ");
            int[] array = new int[arrSize];
            for (int i = 0; i < arrSize; i++)
            {
                InputValidation.GetInt32(out array[i], $"Введите элемент массива под номером {i}: ");
            }
            InputValidation.GetInt32(out num, "Введите искомое число: ");
            Console.WriteLine($"результат: {findLast(array, num)}");
        }

        public int findLast(int[] arr, int x)
        {
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                if (arr[i] == x)
                {
                    return i;
                }
            }
            return -1;
        }

        public void Add()
        {
            Console.WriteLine("Добавление числа в массив на определённую позицию.");
            int[] array;
            InputValidation.GetInt32Array(out array);
            Console.WriteLine("массив: ");
            Print.PrintInt32Array(array);
            int num, pos;
            InputValidation.GetInt32(out num, "Введите число, которое хотите добавить: ");
            InputValidation.GetInt32WithArea(out pos, "Введите позицию этого числа: ", 0, array.Length);
            array = add(array, num, pos);
            Console.WriteLine("результат: ");
            Print.PrintInt32Array(array);
        }

        public int[] add(int[] arr, int x, int pos)
        {
            int[] arr2 = new int[arr.Length+1];
            for (int i = 0; i < pos; i++)
            {
                arr2[i] = arr[i];
            }
            arr2[pos] = x;
            for (int i = pos;  i < arr.Length; i++)
            {
                arr2[i+1] = arr[i];
            }
            return arr2;
        }

        public void Reverse()
        {
            Console.WriteLine("Вывод массива в обратном порядке.");
            int[] array;
            InputValidation.GetInt32Array(out array);
            Console.WriteLine("массив: ");
            Print.PrintInt32Array(array);
            Console.WriteLine("результат: ");
            reverse(array);
        }

        public void reverse(int[] arr)
        {
            int temp, lenght = arr.Length;
            for (int i = 0; i < (arr.Length / 2); i++)
            {
                temp = arr[i];
                arr[i] = arr[lenght - i - 1];
                arr[lenght - i - 1] = temp;
            }
            Print.PrintInt32Array(arr);
        }

        public void Concat()
        {
            Console.WriteLine("Объединение двух массивов.");
            int[] array1, array2;
            InputValidation.GetInt32Array(out array1);
            Console.WriteLine("массив 1: ");
            Print.PrintInt32Array(array1);
            InputValidation.GetInt32Array(out array2);
            Console.WriteLine("массив 2: ");
            Print.PrintInt32Array(array2);
            Console.WriteLine("результат: ");
            Print.PrintInt32Array(concat(array1, array2));
        }

        public int[] concat(int[] arr1, int[] arr2)
        {
            int[] arr = new int[arr1.Length + arr2.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr[i] = arr1[i];
            }
            for (int i = 0; i < arr2.Length; i++)
            {
                arr[arr1.Length + i] = arr2[i];
            }
            return arr;
        }

        public void DeleteNegative()
        {
            Console.WriteLine("Удаление негативных чисел из массива.");
            int[] array;
            InputValidation.GetInt32Array(out array);
            Console.WriteLine("массив: ");
            Print.PrintInt32Array(array);
            Console.WriteLine("результат: ");
            Print.PrintInt32Array(deleteNegative(array));
        }

        public int[] deleteNegative(int[] arr)
        {
            int num = 0;
            foreach (int i in arr)
            {
                if (i >= 0)
                {
                    num++;
                }
            }
            int[] arr2 = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] >= 0)
                {
                    arr2[arr2.Length - num] = arr[i];
                    num--;
                }
            }
            return arr2;
        }

    }
}
