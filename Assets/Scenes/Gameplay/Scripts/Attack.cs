using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] KeyCode attackKey;
    [SerializeField] GameObject attackCollider;
    public Animator anim;

    void Update()
    {
        if (Input.GetKeyDown(attackKey))
        {
            attackCollider.SetActive(true);
            anim.SetTrigger("IsAttack");
        }
    }
}
