using UnityEngine;
using DG.Tweening;

public class PlayerLife : MonoBehaviour
{
    public uint life;
    public static PlayerLife instance;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Enemy")
            life--;
    }

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Update()
    {
        if (life <= 0)
            transform.DOMoveY(-2, 10);
    }
}
