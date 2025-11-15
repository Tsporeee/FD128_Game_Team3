using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeachSlowDown : MonoBehaviour
{

    public FirstPersonController playerController;
    public Collectible legs;

    private void OnTriggerEnter(Collider other)
    {
        // What should happen if something with the Player tag enters the trigger box?
        if (other.gameObject.tag == "Player" && !legs.isCollected)
        {
            playerController.setWalkSpeed(0.5f);
            playerController.setSprintSpeed(1f);
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
