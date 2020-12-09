using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class untable : MonoBehaviour
{
    public bool un;
    public GameObject place;
    public void Taking()
    {
        place.SetActive(true);
    }
}
