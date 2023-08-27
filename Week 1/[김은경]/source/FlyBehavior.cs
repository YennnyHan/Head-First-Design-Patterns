using UnityEngine;

public interface FlyBehavior
{
    public void Fly();
}

public class FlyWithWings : FlyBehavior
{
    public void Fly()
    {
        Debug.Log("날고 있어요!!");
    }
}

public class FlyNoWay : FlyBehavior
{
    public void Fly()
    {
        Debug.Log("저는 못 날아요");
    }
}

public class FlyRocketPowered : FlyBehavior
{
    public void Fly()
    {
        Debug.Log("로켓 추진으로 날라갑니다");
    }
}