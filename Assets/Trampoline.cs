using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    [Range(100, 10000)]
    public float bounceHigh; // Renamed variable to camelCase for consistency.

    private void OnCollisionEnter(Collision collision)
    {
        // Get the GameObject that collided with the trampoline.
        GameObject bouncer = collision.gameObject; // Fixed capitalization of 'gameObject'.

        // Get the Rigidbody from the colliding GameObject.
        Rigidbody rb = bouncer.GetComponent<Rigidbody>();

        // Check if the Rigidbody is present to avoid errors.
        if (rb != null)
        {
            // Apply an upward force to the Rigidbody.
            rb.AddForce(Vector3.up * bounceHigh, ForceMode.Impulse); // Used ForceMode.Impulse for instant force.
        }
    }
}
