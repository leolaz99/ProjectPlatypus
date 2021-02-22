using UnityEngine;

public class Radar : MonoBehaviour
{
    [SerializeField] KeyCode turnLeftKey;
    [SerializeField] KeyCode turnRightKey;
    
    [SerializeField] GameObject radarCollider;
    [SerializeField] GameObject radarPivot;   
    [SerializeField] float degrees;

    void Update()
    {
        if (Input.GetKey(turnLeftKey))
        {
            radarCollider.SetActive(true);
            radarPivot.transform.Rotate(Vector3.up, -degrees * Time.deltaTime);        
        }

        if (Input.GetKey(turnRightKey))
        {
            radarCollider.SetActive(true);
            radarPivot.transform.Rotate(Vector3.up, degrees * Time.deltaTime);
        }
        
        
        if (Input.GetKeyUp(turnLeftKey))
        {
            radarCollider.SetActive(false);
        }

        if (Input.GetKeyUp(turnRightKey))
        {
            radarCollider.SetActive(false);
        }
    }
}
