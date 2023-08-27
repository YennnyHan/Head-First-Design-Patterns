using UnityEngine;

public interface QuackBehavior
{
    public void Quack();
}

public class DefaultQuack : QuackBehavior
{
    public void Quack()
    {
        Debug.Log("²Ð");
    }
}

public class MuteQuack : QuackBehavior
{
    public void Quack()
    {
        Debug.Log("<< Á¶¿ë~ >>");
    }
}

public class Squeak : QuackBehavior
{
    public void Quack()
    {
        Debug.Log("»à");
    }
}
