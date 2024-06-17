using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;
using JetBrains.Annotations;


public class GameControler : MonoBehaviour
{
    public TMP_Text playerScoreText;
    public TMP_Text PlayerWinText;
    private int PlayerOneScore = 0;
    private int PlayerTwoScore = 0;
    public int pointsTowin;
    public GameObject GameOverScreen;
    public AudioSource scoreSound;


    // Start is called before the first frame update
    void Start()
    {
       Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddScore(bool isPlayerone)
    {
        //Checar quem pontuou
        //Adicionar a pontuação na respectiva variável
        //Atualizar o Text

        if (isPlayerone)
        {
            PlayerOneScore = PlayerOneScore + 1;
            if (PlayerOneScore >= pointsTowin)
            {
                PlayerWinText.text = "Mario wins Kirby foi pelo cano";
                Debug.Log("Vitória do jogador one");
                GameOverScreen.SetActive(true);
                Time.timeScale = 0;
            }

        }
        else
        {
            PlayerTwoScore = PlayerTwoScore + 1;
            if (PlayerTwoScore >= pointsTowin)
            {
                PlayerWinText.text = "Kirby wins Mario foi devorado";
                Debug.Log("Vitória do jogador Two");
                GameOverScreen.SetActive(true);
                Time.timeScale = 0;
            }
        }
        scoreSound.Play();
        playerScoreText.text = PlayerTwoScore.ToString() + "-" + PlayerOneScore.ToString();

    }
    //resetar scene

    public void RestarGame()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
