using UnityEngine;
using UnityEngine.SceneManagement; // ��������� ��� ������ �� �������
using UnityEngine.UI; // ��������� ��� ������ � UI

public class SceneSwitcher : MonoBehaviour
{
    // �����, ������� ����� ���������� ��� ������� �� ������
    public void SwitchScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}

