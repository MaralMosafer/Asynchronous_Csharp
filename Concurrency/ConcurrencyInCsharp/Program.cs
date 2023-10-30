//Concurrency 
//Thread-Safe (lock $ Monitor)

object token = new();
bool game = false;

Thread task1 = new(Start);
task1.Start();

Thread task2 = new(Start);
task2.Start();

#region *Concurrency
/*void Start()
{
    if (!game)
    {
        Console.WriteLine("Game Started");
        game = true; //unacceptable result
    };
}*/
#endregion

#region Thread-Safe
void Start()
{
    /* Use this to fix the problem:
     
     lock (token)
     {
         if (!game)
         {
             Console.WriteLine("Game Started");
             game = true; 
         };
     }*/

    //or this:
    Monitor.Enter(token);
    try
    {
        if (!game)
        {
            Console.WriteLine("Game Started");
            game = true;
        };
    }
    finally
    {
        Monitor.Exit(token);
    }
}
#endregion