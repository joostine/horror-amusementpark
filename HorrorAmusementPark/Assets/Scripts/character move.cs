using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public AudioSource AudioPlayer;
    public float moveSpeed = 200f; 
    public float rotationSpeed = 30f;

    void Start()
    {
      AudioPlayer = GetComponent<AudioSource>();
    }

    void Update()
    {
       // Get input for movement
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate rotation based on horizontal input
        float rotationAmount = horizontalInput * rotationSpeed * Time.deltaTime;
        transform.Rotate(Vector3.up, rotationAmount);

        // Calculate movement direction
        Vector3 moveDirection = transform.forward * verticalInput;

        // Move the player
        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}
