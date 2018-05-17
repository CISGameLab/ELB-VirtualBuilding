using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour {

    public GameObject player;
    public Transform spawnPoints;

    void OnTriggerEnter(Collider col)
    {
        if(col.transform.tag == "Player")
        {
            player = col.transform.gameObject;
            player.transform.position = spawnPoints.transform.position;
            player.transform.rotation = spawnPoints.transform.rotation;
        }
    }
}
