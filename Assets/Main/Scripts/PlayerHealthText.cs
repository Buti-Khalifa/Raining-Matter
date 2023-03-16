using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealthText : MonoBehaviour
{
    public TextMeshProUGUI healthText;
    PlayerHealth playerHealth;

    void Start()
    {
        playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
    }

    void Update()
    {
        if (playerHealth.health == 3)
        {
            healthText.text = "III";
        }
        else if (playerHealth.health == 2)
        {
            healthText.text = "II";
        }
        else if (playerHealth.health == 1)
        {
            healthText.text = "I";
        }
        else if (playerHealth.health == 0)
        {
            healthText.text = "";
        }
    }
}
