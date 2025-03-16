using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health = 10;
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Destroy(gameObject);
        }

    }
    void Start()
    {

    }

    public GameObject healthBar;
    void Update()
    {
        healthBar.transform.localScale = new Vector3(health * 0.1f, 0.1f, 0.1f);
    }
}
