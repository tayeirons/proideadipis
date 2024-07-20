public abstract class PostBase
{
    public abstract TPostBuilder Post { get; }

    // An additional abstract method as an example
    public abstract void DisplayPost();
}

public class ConcretePost : PostBase
{
    private readonly TPostBuilder _postBuilder = new TPostBuilder();

    public override TPostBuilder Post => _postBuilder;

    public override void DisplayPost()
    {
        Console.WriteLine(Post.BuildContent());
    }
}

public class TPostBuilder
{
    // Example method in TPostBuilder
    public string BuildContent()
    {
        return "This is a post content.";
    }
}

class Program
{
    static void Main()
    {
        ConcretePost concretePost = new ConcretePost();
        concretePost.DisplayPost();
    }
}
