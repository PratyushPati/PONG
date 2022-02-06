using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public float playerscore;
    public Text playerscoreText;
    public float compscore;
    public Text compscoreText;
    public ballmovement ballmovement;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("left"))
        {
            compscore++;
            ballmovement.resetpoision();
            compscoreText.text = compscore.ToString();
        }
        if (collision.CompareTag("right"))
        {
            playerscore++;
            ballmovement.resetpoision();
            playerscoreText.text = playerscore.ToString();
        }
    }
}
