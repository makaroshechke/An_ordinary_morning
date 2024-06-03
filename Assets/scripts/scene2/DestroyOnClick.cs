using UnityEngine;
using UnityEngine.UI;

public class DestroyOnClick : MonoBehaviour
{
    private ObjectDestroyer objectDestroyer;

    void Start()
    {
        // ����� ��������� ObjectDestroyer �� ������
        objectDestroyer = FindObjectOfType<ObjectDestroyer>();

        // ����� ��������� Button �� ���� �������
        Button button = GetComponent<Button>();

        if (button != null)
        {
            // �������� ���������� ������� �� ������
            button.onClick.AddListener(() => OnButtonClick());
        }
    }

    void OnButtonClick()
    {
        if (objectDestroyer != null)
        {
            // ������� ����� ����������� �������
            objectDestroyer.DestroyObject(gameObject);
        }
    }
}


