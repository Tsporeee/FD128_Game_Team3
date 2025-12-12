using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class BeachSlowDown : MonoBehaviour
{

    public FirstPersonController playerController;
    public PlayerHealth health;
    public Collectible legs;
    public Collectible lungs;

    public float damageInterval = 1f;  
    private float damageTimer = 0f;

    private void OnTriggerEnter(Collider other)
    {
        // What should happen if something with the Player tag enters the trigger box?
        if (other.gameObject.tag == "Player" && !legs.isCollected)
        {
            playerController.setWalkSpeed(0.5f);
            playerController.setSprintSpeed(1f);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player") && !lungs.isCollected)
        {
            damageTimer += Time.deltaTime;
            if (damageTimer >= damageInterval)
            {
                health.TakeDamage(10);
                damageTimer = 0f;
            }
        }
    }

        private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player" && !legs.isCollected)
        {
            playerController.setWalkSpeed(5f);
            playerController.setSprintSpeed(7f);
        }
    }
}
