using System.Drawing;
using UnityEngine;

public class EndGameZone : MonoBehaviour
{
    private GameManager gameManager;



    private void OnCollisionEnter(Collision player)
    {
        if (player.gameObject.CompareTag("Player"))
        {
            gameManager.GameOver();
            Debug.Log("Game End");
        }
    }
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
