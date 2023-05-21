Console.Clear();
Console.Write("insert integer: ");
int num = int.Parse(Console.ReadLine()!);
if(num%2!=0){
    Console.WriteLine($"the {num} integer is odd");
}else Console.WriteLine($"the {num} integer is evev");