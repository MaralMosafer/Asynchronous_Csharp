
#region methods
static async void CallMethod()
{
    string filePath = "TextFile1.txt";
    Task<int> task = ReadFile(filePath);

    Console.WriteLine("Work 1");
    Console.WriteLine("Work 2");
    Console.WriteLine("Work 3");

    int length = await task;
    Console.WriteLine(" Total length: " + length);

    Console.WriteLine(" After work 1");
    Console.WriteLine(" After work 2");
}

static async Task<int> ReadFile(string file)
{
    int length = 0;

    Console.WriteLine("Start Reading...");
    using (StreamReader reader = new StreamReader(file))
    {
        string s = await reader.ReadToEndAsync();

        length = s.Length;
    }
    Console.WriteLine("reading is completed");
    return length;
}
#endregion

Task task = new Task(CallMethod);
task.Start();
task.Wait();
Console.ReadLine();

/* synch result
 Start Reading...
reading is completed
Work 1
Work 2
Work 3
 Total length: 221
 After work 1
 After work 2
 */

/* async result
 Start Reading...
Work 1
Work 2
Work 3
reading is completed
 Total length: 221
 After work 1
 After work 2
 */