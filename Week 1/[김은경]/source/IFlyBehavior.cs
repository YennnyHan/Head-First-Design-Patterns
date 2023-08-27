using UnityEngine;

public interface IFlyBehavior
{
    public void Fly();
}

public class FlyWithWings : IFlyBehavior
{
    public void Fly()
    {
        Debug.Log("날고 있어요!!");
    }
}

public class FlyNoWay : IFlyBehavior
{
    public void Fly()
    {
        Debug.Log("저는 못 날아요");
    }
}

public class FlyRocketPowered : IFlyBehavior
{
    public void Fly()
    {
        Debug.Log("로켓 추진으로 날라갑니다");
    }
}