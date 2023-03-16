using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingItem : MonoBehaviour
{
    PlayerHealth playerHealth;
    public int damageAmount = 1;
    ScoreText scoreText;

    public int scoreToAdd = 1;

    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
        scoreText = GameObject.FindGameObjectWithTag("GameManager").GetComponent<ScoreText>();

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            playerHealth.TakeDamage(damageAmount);
        }
        scoreText.score += scoreToAdd;
        Destroy(gameObject);
    }
}
