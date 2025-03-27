// notice ... List class requires System.Collections.Generic namespace
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
    // NOTE: TextMeshProUGUI requires "using TMPro"
    public TextMeshProUGUI scoreText;
    // NOTE: TextMeshProUGUI requires "using TMPro"
    

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

        /*hardButton.onClick.AddListener(new UnityEngine.Events.UnityAction(hardButtonClicked));
        mediuButton.onClick.AddListener(new UnityEngine.Events.UnityAction(hardButtonClicked));*/
    }

    /*    void hardButtonClicked()
        {
            StartGame(2);
        }
    */
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
    }
    public void GameOver()
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
}


