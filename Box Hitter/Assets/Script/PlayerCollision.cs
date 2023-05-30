using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public TextMeshProUGUI jumpText;

    
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "PowerUp")
        {
            FindAnyObjectByType<PlayerMovement>().JumpEnable();
            FindAnyObjectByType<JumpScript>().Change();
        }
    }
}
