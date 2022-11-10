using UnityEngine;

public class ShotToClick : MonoBehaviour
{
    public int ammo;//Количество Патронов в магазине
    public int allAmmo;//Количество всех патронов в инвенторе

    public float ShootSpeed; //Скорость стрельбы
    public float ReloadSpeed; //Скорость перезарядки 

    public float ReloadTimer = 0.0f; //Время перезарядки
    public float ShootTimer = 0.0f; //Время выстрела

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))//При нажатии на Левую Кнопку Мыши
        {
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            Physics.Raycast(transform.position, fwd, 10);//Запускаем луч вперёд
        }
    }
}