using UnityEngine;

public class ShotToClick : MonoBehaviour
{
    public int ammo;//���������� �������� � ��������
    public int allAmmo;//���������� ���� �������� � ���������

    public float ShootSpeed; //�������� ��������
    public float ReloadSpeed; //�������� ����������� 

    public float ReloadTimer = 0.0f; //����� �����������
    public float ShootTimer = 0.0f; //����� ��������

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))//��� ������� �� ����� ������ ����
        {
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            Physics.Raycast(transform.position, fwd, 10);//��������� ��� �����
        }
    }
}