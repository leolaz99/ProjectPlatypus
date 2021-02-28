using DG.Tweening;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public ParticleSystem ps;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Attack")
        {
            ps.Play();
            Destroy(gameObject);
        }          
    }
}
