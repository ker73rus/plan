using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelEscape : MonoBehaviour
{
    [SerializeField] GameObject player, next;
    
        public void Open()
    {
        next.SetActive(true);
        player.GetComponent<Player>().check = false;
        player.transform.position -= new Vector3(0f, 2f, 0f);
        player.GetComponent<Player>().AnimStop();
    }

}

