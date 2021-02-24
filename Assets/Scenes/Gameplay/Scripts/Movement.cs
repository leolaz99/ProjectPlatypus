using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] KeyCode key1;
    [SerializeField] KeyCode key2;
    [SerializeField] Rigidbody rb;
    [SerializeField] float thrust;
    bool canFirst = true;
    bool canSecond = true;

    void Update()
    {
        if (DialogueManager.instance.isTalk == false)
        {
            if (Input.GetKeyDown(key1) && canFirst == true)
            {
                rb.AddForce(Vector3.forward * thrust);
                canFirst = false;
                canSecond = true;
            }

            if (Input.GetKeyDown(key2) && canSecond == true)
            {
                rb.AddForce(Vector3.forward * thrust);
                canSecond = false;
                canFirst = true;
            }
        }
    }
}
