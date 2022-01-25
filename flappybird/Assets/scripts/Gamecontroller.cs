using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gamecontroller : MonoBehaviour
{
    public static Gamecontroller instanace;
    public GameObject gameoverText;
    public Text ScoreText;
    public bool gameover = false;
    public float scrollspeed = .5f;

    private int score = 0;

    //public string leveltoload;
    // Start is called before the first frame update
    void Awake()
    {
        if(instanace == null)
        {
            instanace = this;
        }else if(instanace != this)
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(gameover == true && Input.GetMouseButtonDown(0))
        {
            Application.LoadLevel(Application.loadedLevel);
           // SceneManager.GetActiveScene();
        }
    }
    public void Birdscored()
    {
        if (gameover)
        {
            return;
        }
        score++;
        ScoreText.text = "Score: " + score.ToString();
    }
    public void BillDies()
    {
        gameoverText.SetActive(true);
        gameover = true;
    }
}
