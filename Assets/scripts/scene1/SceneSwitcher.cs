using UnityEngine;
using UnityEngine.SceneManagement; // Необходим для работы со сценами
using UnityEngine.UI; // Необходим для работы с UI

public class SceneSwitcher : MonoBehaviour
{
    // Метод, который будет вызываться при нажатии на кнопку
    public void SwitchScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}

