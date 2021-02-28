using System.Collections;
using UnityEngine;

public class AttackSystem : MonoBehaviour
{
    [SerializeField] float attackTimer;


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
