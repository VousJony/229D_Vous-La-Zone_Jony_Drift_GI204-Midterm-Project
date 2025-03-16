using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    public Transform firePoint;
    public GameObject vfxFirePoint, vfxHitPoint;
    void Start()
    {
    }

    void Update()
    {
        Shooting();
    }
    void Shooting()
    {
        Debug.DrawRay(firePoint.position, transform.forward * 30f, Color.green);
        RaycastHit hit;
        if (Physics.Raycast(firePoint.position, transform.forward, out hit, 30f))
        {
            Debug.DrawRay(firePoint.position, transform.forward * 30f, Color.red);
        }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(vfxFirePoint, firePoint.position, Quaternion.identity);
                Instantiate(vfxHitPoint, hit.point, Quaternion.identity);

                if (hit.collider.name == "Enemy")
                {
                    Enemy enemy = hit.collider.GetComponent<Enemy>();

                    if (enemy != null)
                    {
                        enemy.TakeDamage(2);
                    }

                }
                if (hit.collider.name == "Obstacle")
            {
                hit.collider.GetComponent<Rigidbody>().AddTorque(Vector3.up * 10);
                hit.collider.GetComponent<Rigidbody>().AddForce(Vector3.up * 10);
            }

        }
    }
}