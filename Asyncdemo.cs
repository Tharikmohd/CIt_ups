using System;

class Asyndemo
{

    public static async Task Moviedownload(CancellationToken token)
    {
        for(int movie = 0; movie <=100; movie+=10)
        {
            token.ThrowIfCancellationRequested();
            Console.WriteLine($"Movie Downloading {movie}% ");
            await Task.Delay(1500);
        }
        Console.WriteLine("Movie downloaded successfully");
    }
    public static async Task Main()
    {
        CancellationTokenSource cts = new CancellationTokenSource();

        Console.WriteLine("Movie downloadded starting");
        Console.WriteLine("Press C to cancel the downloading");

        Task key = Task.Run(() =>
        {
            while(!cts.IsCancellationRequested)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                    if(keyInfo.Key == ConsoleKey.C)
                    {
                        cts.Cancel();
                        break;
                    }
                }
            }
        });

        try
        {
            await Moviedownload(cts.Token);
        }
        catch(OperationCanceledException)
        {
            Console.WriteLine("Movie downloading canelled");
        }
        finally
        {
            cts.Dispose();
        }

        await key;

        Console.WriteLine("Movie Completed");

    }
}