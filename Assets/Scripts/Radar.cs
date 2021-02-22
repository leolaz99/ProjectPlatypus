using UnityEngine;

public class Radar : MonoBehaviour
{
    [SerializeField] KeyCode turnLeftKey;
    [SerializeField] KeyCode turnRightKey;
    
    [SerializeField] GameObject radarCollider;
    [SerializeField] GameObject radarPivot;

    [SerializeField] float leftMaxAngle;
    [SerializeField] float rightMaxAngle;
    [SerializeField] float degrees;

    void Update()
    {
        if (Input.GetKey(turnLeftKey))
        {
            radarCollider.SetActive(true);

            if (radarPivot.transform.rotation.eulerAngles.y >= leftMaxAngle)
                radarPivot.transform.Rotate(Vector3.up, -degrees * Time.deltaTime);                              
        }

        if (Input.GetKey(turnRightKey))
        {
            radarCollider.SetActive(true);
            if (radarPivot.transform.rotation.eulerAngles.y <= rightMaxAngle)
                radarPivot.transform.Rotate(Vector3.up, degrees * Time.deltaTime);
        }
        
        
        if (Input.GetKeyUp(turnLeftKey))
        {
            radarCollider.SetActive(false);
            radarPivot.transform.eulerAngles = new Vector3(0, 0, 0);
        }

        if (Input.GetKeyUp(turnRightKey))
        {
            radarCollider.SetActive(false);
            radarPivot.transform.eulerAngles = new Vector3(0, 0, 0);
        }
    }
}
