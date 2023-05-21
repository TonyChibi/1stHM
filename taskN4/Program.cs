Console.Clear();
bool cond=true;
int max=0;
do{
    Console.Write("insert an integer or 'stop' to end the program:  ");
    string insert = Console.ReadLine()!;
    if (insert.ToLower()=="stop"){
        cond=false;
        Console.WriteLine($"the final maximum is {max}");
    }
    else{
        int num= int.Parse(insert);
        if (num>max)max=num;

        Console.WriteLine($"the current greatest integer is {max}");
    }
}while(cond);