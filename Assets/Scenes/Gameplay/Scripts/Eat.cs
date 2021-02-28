using DG.Tweening;
using UnityEngine;

public class Eat : MonoBehaviour
{
    [SerializeField] KeyCode eatKey;
    [SerializeField] float endPosition;
    [SerializeField] float submergeTime;
    [SerializeField] float emergeTime;
    float initialPosition;
    bool isSub = false;
    public int foodCount = 0;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Food")
        {
            AudioManager.instance.Play("EatSFX");
            
            if (PlayerLife.instance.life < 3)
                PlayerLife.instance.life++;

            foodCount++;

            Destroy(collision.gameObject);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(eatKey) && isSub == false)
        {
            initialPosition = transform.position.y;
            isSub = true;
            transform.DOMoveY(endPosition, submergeTime);
        }

        if (transform.position.y == endPosition)
        {
            transform.DOMoveY(initialPosition, emergeTime);
            isSub = false;
        }           
    }
}
