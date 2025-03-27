using UnityEngine;
using UnityEngine.EventSystems;


public class ScoreCount : MonoBehaviour
{
    

    public int point;
    private GameManager gameManager;

    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }
    

    private void OnCollisionEnter(Collision Player)
    {
        if (Player.gameObject.CompareTag("Player"))
        {
            gameManager.UpdateScore(point);
            Destroy(gameObject);
            Debug.Log("+1");
            
        }
    }
}