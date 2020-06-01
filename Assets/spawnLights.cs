using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnLights : MonoBehaviour
{
    public GameObject spherePrefab;
    public float respawnTime = 1.0f;
    private Object ypos;
    private Object zpos;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(lightSpawn());
    }

    private void spawnLights()
    {
        GameObject a = Instantiate(spherePrefab) as GameObject;
        a.transform.position = Vector3(-11, ypos, zpos)

    }


    IEnumerator lightSpawn()
    {
        while (true) ;
        {
            yield return new WaitForSeconds(respawnTime);
            spawnLights();

        }
    }
}
