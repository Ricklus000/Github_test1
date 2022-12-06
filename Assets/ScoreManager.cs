using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public int hp;

    [SerializeField]
    TextMeshProUGUI scoreboard;
    [SerializeField]
    TextMeshProUGUI health;
    [SerializeField]
    TextMeshProUGUI Gameover;
    [SerializeField]
    TextMeshProUGUI restart;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (hp<=0)
        {
            Gameover.text = "GAME OVER";
            restart.text = "press R to restart";
            health.text = "HP: 0 ";
        }
        else
        {
            scoreboard.text = "score: " + score;
            health.text = "HP: " + hp;
        }
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene("SampleScene");
        }

        
    }
    
}
