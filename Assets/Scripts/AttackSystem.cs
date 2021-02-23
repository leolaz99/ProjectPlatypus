using System.Collections;
using UnityEngine;

public class AttackSystem : MonoBehaviour
{
    [SerializeField] float attackTimer;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Enemy")
            Destroy(other.gameObject);
    }

    IEnumerator Attack()
    {
        yield return new WaitForSeconds(attackTimer);
        gameObject.SetActive(false);
    }


    void OnEnable()
    {
        StartCoroutine(Attack());
    }
}