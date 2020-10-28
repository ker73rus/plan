using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class untable : MonoBehaviour
{
    public bool un;
    [SerializeField] GameObject place;
    void Update()
    {
        if (un == false)
            place.SetActive(true);
        else
        {

        }

    }
}
