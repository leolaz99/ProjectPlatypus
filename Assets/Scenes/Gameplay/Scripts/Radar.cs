using UnityEngine;

public class Radar : MonoBehaviour
{
    [SerializeField] KeyCode radarKey;
    
    [SerializeField] GameObject radarCollider;
    [SerializeField] GameObject radarPivot;


    void Update()
    {
        if (Input.GetKey(radarKey))
            radarCollider.SetActive(true);
        
        if (Input.GetKeyUp(radarKey))
        {
            radarCollider.SetActive(false);
        }
    }
}
