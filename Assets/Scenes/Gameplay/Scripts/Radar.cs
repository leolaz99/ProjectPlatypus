using UnityEngine;

public class Radar : MonoBehaviour
{
    [SerializeField] KeyCode turnLeftKey;
    [SerializeField] KeyCode turnRightKey;
    
    [SerializeField] GameObject radarCollider;
    [SerializeField] GameObject radarPivot;

    /// <summary>
    /// leftMaxAngle deve essere positivo
    /// </summary>
    [SerializeField] float leftMaxAngle;
    [SerializeField] float rightMaxAngle;

    [SerializeField] float angularSpeed;
    
    Quaternion positiveRotation;

    void Update()
    {
        if (Input.GetKey(turnLeftKey))
        {
            radarCollider.SetActive(true);
            positiveRotation = Quaternion.Euler(radarPivot.transform.rotation.eulerAngles.x, 
                                                -radarPivot.transform.rotation.eulerAngles.y, 
                                                radarPivot.transform.rotation.eulerAngles.z);

            if (positiveRotation.eulerAngles.y <= leftMaxAngle)
                radarPivot.transform.Rotate(Vector3.down, angularSpeed * Time.deltaTime);                              
        }

        if (Input.GetKey(turnRightKey))
        {
            radarCollider.SetActive(true);
            if (radarPivot.transform.rotation.eulerAngles.y <= rightMaxAngle)
                radarPivot.transform.Rotate(Vector3.up, angularSpeed * Time.deltaTime);
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
