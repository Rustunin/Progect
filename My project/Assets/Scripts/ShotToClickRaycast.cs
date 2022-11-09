using UnityEngine;

public class ShotToClickRaycast : MonoBehaviour
{
    public GameObject Bullet;//только для визуализации
    public float Power;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                hit.rigidbody.AddForceAtPosition(ray.direction * Power, hit.point, ForceMode.Impulse);
                Instantiate(Bullet, hit.point, transform.rotation);
            }
        }
    }
}