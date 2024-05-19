using UnityEngine;

public class RotateOnProximity : MonoBehaviour
{
    public float rotationSpeed = 50f; // Speed at which the object rotates

    private bool shouldRotate = false;

    void Update()
    {
        if (shouldRotate)
        {
            transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            shouldRotate = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            shouldRotate = false;
        }
    }
}