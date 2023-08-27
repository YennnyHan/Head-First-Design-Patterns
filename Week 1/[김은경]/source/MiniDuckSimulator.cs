using UnityEngine;

public class MiniDuckSimulator : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Duck mallard = new MallardDuck();
        mallard.PerformQuack();
        mallard.PerformFly();

        Duck model = new ModelDuck();
        model.PerformFly();
        model.SetFlyBehavior(new FlyRocketPowered());
        model.PerformFly();
    }
}
