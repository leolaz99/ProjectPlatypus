using DG.Tweening;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Attack")
            transform.DOMoveY(-2, 2);
    }
}
