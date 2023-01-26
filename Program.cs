// Задача 39: Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
/*
int[] array = GetArray(10, 0, 10);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] resultArray = ReverseArray2(array);
Console.WriteLine($"[{String.Join(",", resultArray)}]");

ReverseArray1(array);
Console.WriteLine($"[{String.Join(",", array)}]");

// ----------Методы---------------
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ReverseArray1(int[] array){
    for(int i = 0; i < array.Length/2; i++){
        int k = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = k;
    }
}

int[] ReverseArray2(int[] array){
    int[] result = new int[array.Length];
    for(int i = 0; i < array.Length; i++){
        result[i] = array[array.Length - i - 1];
    }
    return result;
}






//Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число: ");
int c = int.Parse(Console.ReadLine()!);

if( findElement(a, b, c)){
    Console.WriteLine("Такой треугольник существует.");
}
else {
    Console.WriteLine("Такой треугольник не существует.");
}
//--------метод-----------
bool findElement(int a, int b, int c){
    if(a < b + c && b < a + c && c < a + b){
        return true;
    }
    return false;
}
//Определить, является ли заданное шестизначное число счастливым. 
//(Счастливым называют такое шестизначное число, что сумма его первых трех цифр равна сумме его последних трех цифр).

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
string b = Convert.ToString(a);
if(b.Length == 6){
    if(b[0] + b[1] + b[2] == b[3] + b[4] + b[5]){
        Console.WriteLine("Это счастливое число!");
    }
    else{
        Console.WriteLine("Это не счастливое число!");
    }
}
else{
    Console.WriteLine("Ввели не верное число.");
}

//**Задача 44:** Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
Console.WriteLine("Введите число: .");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
array[0] = 0;
array[1] = 1;

for(int i = 2; i < n; i++){
    array[i] = array[i-2] + array[i-1];

}
Console.WriteLine($"{String.Join(",", array)}");







// задача про те же треугольники
Console.WriteLine("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите первое число: ");
int num2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите первое число: ");
int num3 = int.Parse(Console.ReadLine()!);

if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2)
{
  Console.WriteLine("Yes");
}
else
{
   Console.WriteLine("No"); 






// задача про счастливые числа
void HappyNumber(int number){
    string num = Convert.ToString(number);
    int resOne = 0;
    int resTwo = 0;
    int[] numArray = new int[num.Length];
    for(int i = 0; i < num.Length; i++){
        numArray[i] = num[i];
    }
    int j = numArray.Length - 1;
    for(int i = 0; i < num.Length / 2; i++){
        resOne += Convert.ToInt32(numArray[i]);
        resTwo += Convert.ToInt32(numArray[j]);
        j--;
    }
    if(resOne == resTwo){
        Console.WriteLine($"Число {number} счастливое");
    }
    else{
        Console.WriteLine($"Число {number} НЕсчастливое");
    }
}

int number = 113123;
HappyNumber(number);






// задача про числа фибоначи
void Fibonachi(int N){
    int firstnum = 0;
    int secondnum = 1;
    Console.Write($"{firstnum} ");
    Console.Write($"{secondnum} ");
    int summ = firstnum + secondnum;
   for(int i = 2; i < N; i++){
    Console.Write($"{firstnum + secondnum} ");
    firstnum = secondnum;
    secondnum = summ;
    summ = firstnum + secondnum;
   }
}

Fibonachi(7);

*/





