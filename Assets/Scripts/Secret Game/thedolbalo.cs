using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thedolbalo : MonoBehaviour
{
    void Update()
    {
     transform.position -= Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
}
