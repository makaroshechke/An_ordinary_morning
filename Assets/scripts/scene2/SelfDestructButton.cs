using UnityEngine;

public class SelfDestructButton : MonoBehaviour
{
    // �����, ������� ����� ���������� ��� ������� �� ������
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}

