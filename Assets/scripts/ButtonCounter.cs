using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonCounter : MonoBehaviour
{
    public string nextSceneName; // �������� ��������� �����

    private int teapotClicks = 0; // ������� ������� �� ������ Teapot
    private int cofeClicks = 0; // ������� ������� �� ������ COFE
    private int cupClicks = 0; // ������� ������� �� ������ Cup

    // ����� ��� ��������� ������� �� ������ Teapot
    public void TeapotClicked()
    {
        teapotClicks++;
        CheckButtonClicks();
    }

    // ����� ��� ��������� ������� �� ������ COFE
    public void CofeClicked()
    {
        cofeClicks++;
        CheckButtonClicks();
    }

    // ����� ��� ��������� ������� �� ������ Cup
    public void CupClicked()
    {
        cupClicks++;
        CheckButtonClicks();
    }

    // ����� ��� �������� ���������� ������� �� ������ ������
    private void CheckButtonClicks()
    {
        // ���� ��� ��� ������ ���� ������ �� ������ ����
        if (teapotClicks == 1 && cofeClicks == 1 && cupClicks == 1)
        {
            // ��������� ������� �� ��������� �����
            SceneManager.LoadScene(nextSceneName);
        }
    }
}

