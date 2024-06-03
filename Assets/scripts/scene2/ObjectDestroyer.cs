using UnityEngine;
using UnityEngine.SceneManagement;

public class ObjectDestroyer : MonoBehaviour
{
    public GameObject[] objectsToDestroy; // ������� ��� �����������
    public string nextSceneName; // �������� ��������� �����

    private int destroyedCount = 0; // ������� ������������ ��������

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


