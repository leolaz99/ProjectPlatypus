using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public GameObject followPoint;

    private void Update()
    {
        transform.position = followPoint.transform.position;
    }
}
