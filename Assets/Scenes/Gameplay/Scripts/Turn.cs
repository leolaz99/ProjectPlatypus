using UnityEngine;

public class Turn : MonoBehaviour
{
    [SerializeField] KeyCode turnLeftKey;
    [SerializeField] KeyCode turnRightKey;
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed;

    void Update()
    {
        if (Input.GetKey(turnLeftKey))
        {
            rb.MovePosition(transform.position + (Vector3.left * speed * Time.deltaTime));
        }

        if (Input.GetKey(turnRightKey))
        {
            rb.MovePosition(transform.position + (Vector3.right * speed * Time.deltaTime));
        }
    }
}
