using DG.Tweening;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public int life;
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
            GetComponent<Movement>().enabled = false;
            GetComponent<Turn>().enabled = false;
            GetComponent<Radar>().enabled = false;
            GetComponent<Eat>().enabled = false;
            GetComponent<Attack>().enabled = false;
            transform.DOMoveY(-2, 5);
            Invoke("GameOver", 5);
        }          
    }

    void GameOver()
    {   
        AudioManager.instance.Stop("GameMusic");
        AudioManager.instance.Play("GameOverMusic");
        SceneManager.LoadScene("Lose");
    }

    IEnumerator InvulnerableTime()
    {
        isInvincible = true;
        yield return new WaitForSeconds(3);
        isInvincible = false;
    }
}
