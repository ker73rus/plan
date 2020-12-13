using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class morginal : MonoBehaviour
{
    [SerializeField] GameObject player;
    public void Close()
    {
        gameObject.SetActive(false);
        player.GetComponent<Player>().check = true;
        
    }

    public void Transport()
    {
        
    }
}
