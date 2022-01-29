using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public delegate void MyEvent (int eventCode);

    public Player1Controller Player1;
    public Player1Controller Player2;

    public TextMeshProUGUI WhiteText;
    public TextMeshProUGUI BlackText;


    public AudioSource  player1WonSound;
    public AudioSource player2WonSound;

    public AudioSource start321;
    public AudioSource BackgroundMusic;

    private int whiteScore = 0;
    private int blackScore = 0;


    // Start is called before the first frame update
    void Start()
    {
        Player1.SetCurrentMoveSpeed(0.0f);
        Player2.SetCurrentMoveSpeed(0.0f);

        start321.Play();
        BackgroundMusic.Play();

        AudioSource ad = gameObject.GetComponent<AudioSource>();
        ad.Play();

        Player1.SetCurrentMoveSpeed(1.0f);
        Player2.SetCurrentMoveSpeed(1.0f);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void EndGame(int looser){

        Player1.SetLocation(new Vector3(-4.0f, 0.05f, 3.5f));
        Player2.SetLocation(new Vector3(4.0f, 0.05f, -3.5f));

        if (looser == 1){
            blackScore += 1;
            BlackText.SetText(blackScore.ToString());

            if (blackScore == 3){
                blackWon();
            }
        }
        else{
            whiteScore += 1;
            WhiteText.SetText(whiteScore.ToString());

            if (whiteScore == 3){
                whiteWon();
            }
            
        }
        Player1.SetCurrentMoveSpeed(0.0f);
        Player2.SetCurrentMoveSpeed(0.0f);

        // p1.SetCurrentMoveSpeed(p1.moveSpeed);
        // p2.SetCurrentMoveSpeed(p2.moveSpeed);
    }

    private void whiteWon(){
        SceneManager.LoadScene(2);
    }

    private void blackWon(){
        SceneManager.LoadScene(3);
    }
}
