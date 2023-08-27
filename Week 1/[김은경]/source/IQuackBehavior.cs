using UnityEngine;

public interface IQuackBehavior
{
    public void Quack();
}

public class DefaultQuack : IQuackBehavior
{
    public void Quack()
    {
        Debug.Log("²Ð");
    }
}

public class MuteQuack : IQuackBehavior
{
    public void Quack()
    {
        Debug.Log("<< Á¶¿ë~ >>");
    }
}

public class Squeak : IQuackBehavior
{
    public void Quack()
    {
        Debug.Log("»à");
    }
}
