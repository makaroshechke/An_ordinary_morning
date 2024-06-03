using UnityEngine;
using UnityEngine.UI;

public class DestroyOnClick : MonoBehaviour
{
    private ObjectDestroyer objectDestroyer;

    void Start()
    {
        // Найти компонент ObjectDestroyer на панели
        objectDestroyer = FindObjectOfType<ObjectDestroyer>();

        // Найти компонент Button на этом объекте
        Button button = GetComponent<Button>();

        if (button != null)
        {
            // Добавить обработчик нажатия на кнопку
            button.onClick.AddListener(() => OnButtonClick());
        }
    }

    void OnButtonClick()
    {
        if (objectDestroyer != null)
        {
            // Вызвать метод уничтожения объекта
            objectDestroyer.DestroyObject(gameObject);
        }
    }
}


