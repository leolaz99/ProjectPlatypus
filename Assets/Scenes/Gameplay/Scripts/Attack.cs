using UnityEngine;

public class Attack : MonoBehaviour
{
    [SerializeField] KeyCode attackKey;
    [SerializeField] GameObject attackCollider;
    public Animator anim;

    void ColliderAttack()
    {
        attackCollider.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(attackKey))
        {
            Invoke("ColliderAttack", 0.5f);
            anim.SetTrigger("IsAttack");
        }
    }
}
