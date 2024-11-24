using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightActivator : MonoBehaviour
{
    public Light targetLight;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger entered by: " + other.name); // Debug message

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player detected! Activating light."); // Debug message
            if (targetLight != null)
            {
                targetLight.enabled = true;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Trigger exited by: " + other.name); // Debug message

        if (other.CompareTag("Player"))
        {
            Debug.Log("Player leaving! Deactivating light."); // Debug message
            if (targetLight != null)
            {
                targetLight.enabled = false;
            }
        }
    }
}
