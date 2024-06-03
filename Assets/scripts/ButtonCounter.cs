using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCounter : MonoBehaviour
{
    public string nextSceneName; // Название следующей сцены

    private int teapotClicks = 0; // Счетчик нажатий на кнопку Teapot
    private int cofeClicks = 0; // Счетчик нажатий на кнопку COFE
    private int cupClicks = 0; // Счетчик нажатий на кнопку Cup

    // Метод для обработки нажатия на кнопку Teapot
    public void TeapotClicked()
    {
        teapotClicks++;
        CheckButtonClicks();
    }

    // Метод для обработки нажатия на кнопку COFE
    public void CofeClicked()
    {
        cofeClicks++;
        CheckButtonClicks();
    }

    // Метод для обработки нажатия на кнопку Cup
    public void CupClicked()
    {
        cupClicks++;
        CheckButtonClicks();
    }

    // Метод для проверки количества нажатий на каждую кнопку
    private void CheckButtonClicks()
    {
        // Если все три кнопки были нажаты по одному разу
        if (teapotClicks == 1 && cofeClicks == 1 && cupClicks == 1)
        {
            // Выполнить переход на следующую сцену
            SceneManager.LoadScene(nextSceneName);
        }
    }
}

