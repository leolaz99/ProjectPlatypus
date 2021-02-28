using UnityEngine;
using DG.Tweening;

public class Eat : MonoBehaviour
{
    [SerializeField] KeyCode eatKey;
    [SerializeField] float endPosition;
    [SerializeField] float submergeTime;
    [SerializeField] float emergeTime;
    float initialPosition;
    bool isSub = false;
    public int foodCount = 0;

    public PlayerLife playerLife;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Food")
        {
            AudioManager.instance.Play("EatSFX");
            //if (PlayerLife.instance.life < 3)
            //    PlayerLife.instance.life++;
            //
            //if (playerLife.life < 3)
            //    playerLife.life++;

            foodCount++;

            Destroy(other.gameObject);
        }
    }

    void Update()
    {      
        if (Input.GetKeyDown(eatKey) && isSub == false)
        {
            initialPosition = transform.position.y;
            transform.DOMoveY(endPosition, submergeTime);     
        }
        
        if(transform.position.y == endPosition)
                transform.DOMoveY(initialPosition, emergeTime);

        if (transform.position.y < 0)
            isSub = true;

        if (transform.position.y >= 0)
            isSub = false;
    }
}
