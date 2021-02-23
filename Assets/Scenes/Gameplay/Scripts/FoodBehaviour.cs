using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBehaviour : MonoBehaviour
{
    [SerializeField] GameObject radarCollider;

    void Update()
    {
        if (radarCollider.activeInHierarchy == false)
        {
            gameObject.SetActive(false);     
        }
    }
}
