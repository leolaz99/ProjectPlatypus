using UnityEngine;

public class RadarSystem : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Food")
        {
            other.gameObject.transform.GetChild(0).gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Food")
        {
            other.gameObject.transform.GetChild(0).gameObject.SetActive(false);
        }
    }
}
