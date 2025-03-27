using System.Drawing;
using UnityEngine;

public class EndGameZone : MonoBehaviour
{
    private GameManager gameManager;
    public GameObject LittleJony;
    public GameObject CloseJony;


    private void OnCollisionEnter(Collision player)
    {
        if (player.gameObject.CompareTag("Player"))
        {
            Debug.Log("Game End");
            LittleJony.SetActive(true);
            CloseJony.SetActive(false);
        }
    }
}
