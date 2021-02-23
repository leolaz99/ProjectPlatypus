using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] KeyCode attackKey;
    [SerializeField] GameObject attackCollider;

    void Update()
    {
        if (Input.GetKeyDown(attackKey))
        {
            attackCollider.SetActive(true);
        }
    }
}
