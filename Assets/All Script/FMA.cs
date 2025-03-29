using UnityEngine;

public class FMA : MonoBehaviour
{
    public float force, mass, acc;



    void CalculateForce()
    {
        mass = GetComponent<Rigidbody>().mass;
        force = mass * acc;

        GetComponent<Rigidbody>().AddForce(force, force, 0);
    }
    private void OnCollisionEnter(Collision player)
    {
        if (player.gameObject.CompareTag("Player"))
        {
            Debug.Log("Im hit");
            acc = 100;
            CalculateForce();

        }
    }
    
}
