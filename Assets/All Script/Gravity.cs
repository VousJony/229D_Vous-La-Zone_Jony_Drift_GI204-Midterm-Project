using UnityEngine;
using System.Collections.Generic;

public class Gravity : MonoBehaviour
{
    private Rigidbody rb;
    private const float G = 0.006674f;

    public static List<Gravity> objectsList = new List<Gravity>();

    [SerializeField] private bool attractPlayers = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        if (objectsList == null)
        {
           objectsList = new List<Gravity>();
        }
        objectsList.Add(this);
    }
    private void FixedUpdate()
    {
        foreach (Gravity obj in objectsList)
        {
            if (obj != this)
            {
                if (attractPlayers || obj.gameObject.CompareTag("Player"))
                {
                    Attract(obj);
                }
            }
        }
    }

    void Attract(Gravity other)
    {   
        Rigidbody otherRb = other.rb;

        Vector3 direction = rb.position - otherRb.position;
        float distance = direction.magnitude;

        if (distance == 0) 
        {
            return;
        }

        float forceMagnitude = G * (rb.mass * otherRb.mass) / Mathf.Pow(distance, 2);
        Vector3 gravityForce = forceMagnitude * direction.normalized;

        otherRb.AddForce(gravityForce);
    }
}
