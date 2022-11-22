//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через   , ");
int size= Convert.ToInt32(Console.ReadLine());

 int sum = 0;       
        
           int[] array = new int[size];
            for (int i = 0; i < size1; i++)
            {
               array[i] =   size  ;
                   if(array[i]>=0)
                  {
                   sum++;
                  }
            } return array;
        
             Console.WriteLine(string.Join(",",array)); 
             Console.WriteLine("Сумма чисел больше 0 равна"+ sum);
