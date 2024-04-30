using UnityEngine;

public class CameraStore : MonoBehaviour
{
    public Transform Camera;
    public Transform YellowCar;
    public Transform GreyCar;
    public Transform BlueCar;
    public Transform PurpleCar;
    public Transform RedCar;
    public Transform VanCar;

    public void OnButtonRight()
    {
        transform.position = GreyCar.transform.position;
    }

    public void OnButtonLeft()
    {

    }
}
