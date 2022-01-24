using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollecter : MonoBehaviour
{
    public int cheeseCount = 0;
    public AudioSource winnerSound;

    [SerializeField] private Text cheeseText;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cheese"))
        {
            Destroy(collision.gameObject);
            cheeseCount++;
            cheeseText.text = "Cheese: " + cheeseCount + " / 5";
        }
    }

    void FixedUpdate()
    {
        if (cheeseCount == 5)
        {
            winnerSound.Play();

            GetComponent<GameControl>().enabled = false;


        }
    }
}
