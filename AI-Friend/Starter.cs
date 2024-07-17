namespace AI_Friend;

internal class Starter
{
    [STAThread]
    private static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        _ = new App().Run();
    }
}
