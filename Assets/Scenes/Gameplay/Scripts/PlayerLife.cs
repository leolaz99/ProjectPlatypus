using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public uint life;
    public static PlayerLife instance;
    private bool isInvincible = false;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy" && isInvincible == false)
        {
            life--;
            StartCoroutine("InvulnerableTime");
        }

    }

    void Awake()
    {
        if (instance == null)
            instance = this;
    }

    void Update()
    {
        if (life <= 0)
        {
            transform.DOMoveY(-2, 5);
            Invoke("GameOver", 5);
        }          
    }

    void GameOver()
    {
        SceneManager.LoadScene("Lose");
    }

    IEnumerator InvulnerableTime()
    {
        isInvincible = true;
        yield return new WaitForSeconds(3);
        isInvincible = false;
    }
}
