using UnityEngine;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        quackBehavior = new DefaultQuack();
        flyBehavior = new FlyWithWings();
    }

    public override void Display()
    {
        Debug.Log("저는 물오리입니다");
    }
}
