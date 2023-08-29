using UnityEngine;

public class ModelDuck : Duck
{
    public ModelDuck()
    {
        flyBehavior = new FlyNoWay();
        quackBehavior = new DefaultQuack();
    }
    public override void Display()
    {
        Debug.Log("저는 모형 오리입니다");
    }
}
