using UnityEngine;

public class SelfDestructButton : MonoBehaviour
{
    // Метод, который будет вызываться при нажатии на кнопку
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}

