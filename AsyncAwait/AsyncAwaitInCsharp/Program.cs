//async - await =>C# 5 (2012)


DoWorks();
Console.ReadKey();


#region methods
static async void DoWorks()
{
    var w1 = WorkOne();
    await w1; //first
    var w2 = WorkTwo();
    var w3 = WorkThree();
    Task.WaitAll(w1, w2, w3);
    Console.WriteLine(w1.Result);
    Console.WriteLine(w3.Result);
    Console.WriteLine(w2.Result);
}



static async Task<string> WorkOne() //return string
{
    await Task.Run(() =>
    {
        Thread.Sleep(5000);
        //Console.WriteLine("work one finished in " + DateTime.Now);
    });
    return "work 1 finished in " + DateTime.Now;
}


static async Task<string> WorkTwo()
{
    await Task.Run(() =>
    {
        Thread.Sleep(3000);
    });
    return "work 2 finished in " + DateTime.Now;
}

static async Task<string> WorkThree()
{
    await Task.Run(() =>
    {
        Thread.Sleep(2000);
    });
    return "work 3 finished in " + DateTime.Now;
}

#endregion