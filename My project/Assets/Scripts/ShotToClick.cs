using UnityEngine;

public class ShotToClick : MonoBehaviour
{
    public GameObject Bullet;
    public float Power;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject b = Instantiate(Bullet, transform.position, transform.rotation);
            b.GetComponent<Rigidbody>().AddForce(Vector3.forward * Power, ForceMode.Impulse);
        }
    }
}