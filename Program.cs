// HOMEWORK

//============================================================================================

// FIRST TASK "Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее."

// Console.Write("Введите первое число: ");
// int num_1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второре число: ");
// int num_2 = Convert.ToInt32(Console.ReadLine());

// if (num_1 > num_2){
//     Console.Write("Большее число: ");
//     Console.WriteLine( num_1);
//     Console.Write("Меньшее число: ");
//     Console.WriteLine( num_2);
// }
//     else if(num_1 < num_2){
//         Console.Write("Большее число: ");
//         Console.WriteLine( num_2);
//         Console.Write("Меньшее число: ");
//         Console.WriteLine( num_1);
//     }
//         else
//         Console.WriteLine("Числа равны");


//============================================================================================
        
// SECOND TASK "Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел."


Console.Write("Введите первое число: ");
int num_1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num_2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num_3 = Convert.ToInt32(Console.ReadLine());
int max = num_1;

if (max < num_2)
    max = num_2;
if (max < num_3)
    max = num_3;

Console.Write("Большее число: ");
Console.Write(max);
