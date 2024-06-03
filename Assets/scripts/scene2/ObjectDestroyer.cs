using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectDestroyer : MonoBehaviour
{
    public GameObject[] objectsToDestroy; // Объекты для уничтожения
    public string nextSceneName; // Название следующей сцены

    private int destroyedCount = 0; // Счетчик уничтоженных объектов

    public void DestroyObject(GameObject obj)
    {
        Destroy(obj);
        destroyedCount++;

        if (destroyedCount >= objectsToDestroy.Length)
        {
            SceneManager.LoadScene(nextSceneName);
        }
    }
}


