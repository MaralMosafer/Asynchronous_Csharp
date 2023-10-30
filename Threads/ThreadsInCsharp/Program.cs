//Thread

#region CreateThread
Thread task1 = new(TaskOne);
Thread task2 = new(TaskTwo);
Thread task3 = new(TaskThee);

task1.Start();
task2.Start();
task3.Start();
#endregion


#region Methods
static void TaskOne()
{
    for (int i = 1; i <= 5; i++)
        Console.WriteLine($"Task One=>{i}");
    Console.WriteLine($"task1 Id is: {Thread.CurrentThread.ManagedThreadId}");
}
static void TaskTwo()
{
    for (int i = 6; i <= 10; i++)
        Console.WriteLine($"Task Two=>{i}");
    Console.WriteLine($"task2 Id is: {Thread.CurrentThread.ManagedThreadId}");
}
static void TaskThee()
{
    for (int i = 11; i <= 15; i++)
        Console.WriteLine($"Task Thee=>{i}");
    Console.WriteLine($"task3 Id is: {Thread.CurrentThread.ManagedThreadId}");
}
#endregion


