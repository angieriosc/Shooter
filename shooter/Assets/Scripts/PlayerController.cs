using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    public float speed = 2.0f;
    private float horizontalInput;
    private float forwardInput;

    /// <summary>
    /// This method is called before the first frame update
    /// </summary>
    void Start()
    {
        // Initialization logic can go here
    }

    /// <summary>
    /// This method is called once per frame
    /// </summary>
    void Update()
    {
        // Get player input for horizontal and vertical movement
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the player based on input
        Vector3 movement = new Vector3(horizontalInput, 0, forwardInput) * speed * Time.deltaTime;
        transform.Translate(movement, Space.World);
    }
}
