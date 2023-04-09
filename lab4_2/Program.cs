public class Task1
{
    public event EventHandler TaskCompleted;

    public void Run()
    {
        Console.WriteLine("Running Task 1...");
        // Виконати код дії Task1

        OnTaskCompleted(EventArgs.Empty);
    }

    protected virtual void OnTaskCompleted(EventArgs e)
    {
        TaskCompleted?.Invoke(this, e);
    }
}

public class Task2
{
    public event EventHandler TaskCompleted;

    public void Run()
    {
        Console.WriteLine("Running Task 2...");
        // Виконати код дії Task2

        OnTaskCompleted(EventArgs.Empty);
    }

    protected virtual void OnTaskCompleted(EventArgs e)
    {
        TaskCompleted?.Invoke(this, e);
    }
}

public class Task3
{
    public event EventHandler TaskCompleted;

    public void Run()
    {
        Console.WriteLine("Running Task 3...");
        // Виконати код дії Task3

        OnTaskCompleted(EventArgs.Empty);
    }

    protected virtual void OnTaskCompleted(EventArgs e)
    {
        TaskCompleted?.Invoke(this, e);
    }
}
