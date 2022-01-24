using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControl : MonoBehaviour
{
    public GameObject timeIsUp, restartButton;
    public AudioSource loseSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (TimeLeft.timeLeft <= 0)
        {
            Time.timeScale = 0;
            timeIsUp.gameObject.SetActive(true);
            restartButton.gameObject.SetActive(true);
            loseSound.Play();
        }
    }

    public void restartScene()
    {
        timeIsUp.gameObject.SetActive(false);
        restartButton.gameObject.SetActive(false);
        Time.timeScale = 1;
        TimeLeft.timeLeft = 12f;
        SceneManager.LoadScene("SampleScene");
    }
}
