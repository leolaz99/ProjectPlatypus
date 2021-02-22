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

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(collision.gameObject);
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
