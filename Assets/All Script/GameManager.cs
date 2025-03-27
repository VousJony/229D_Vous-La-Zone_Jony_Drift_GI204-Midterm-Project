using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public List<GameObject> targets;

    [Header("UI Elements")]
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreTextSummay;


    public GameObject titleScreen;
    public GameObject gameOverScreen;
    public GameObject scoreScreen;
    public GameObject creditScreen;
    public Button playButton;
    public Button restartButton;
    public Button creditButton;

    private int score;
    private bool isGameActive = true;
  

    void Awake()
    {
        playButton.onClick.AddListener(() => { PlayGame(); });
        restartButton.onClick.AddListener(() => { Restart(); });
        creditButton.onClick.AddListener(() => { CreditShow(); });
        
    }
    void Start()
    {
        gameOverScreen.SetActive(false);
        scoreScreen.SetActive(false);
        titleScreen.SetActive(true);
    }

    void StartGame(bool difficulty)
    {
        
        titleScreen.SetActive(false);
        
    }



  

    public void UpdateScore(int score)
    {
        this.score += score;
        scoreText.text = this.score.ToString();
        scoreTextSummay.text = this.score.ToString();
    }
    public void GameEnd()
    {
        Debug.Log("Jony End");
        gameOverScreen.SetActive(true);
        scoreScreen.SetActive(false);
    }
    public void Restart()
    {
        /*SceneManager.LoadScene("Main");*/
        var activeScene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(activeScene.name);
    }

    public void PlayGame()
    {
        titleScreen.SetActive(false);
        scoreScreen.SetActive(true);
    }

    public void CreditShow()
    {
        scoreScreen.SetActive(false);
        gameOverScreen.SetActive(false);
        creditScreen.SetActive(true);
    }
}


