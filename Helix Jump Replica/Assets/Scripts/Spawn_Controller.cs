using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Spawn_Controller : MonoBehaviour
{
    [SerializeField] private bool isPassed;
    [SerializeField] private GameObject spawned;
    [SerializeField] private Transform spawner;
    [SerializeField] private GameObject[] prefabs;
    [SerializeField] private int randomPrefab;
    [SerializeField] GameObject danger;
    [SerializeField] private Material matDanger;
    [SerializeField] private int dangerZone;
    private int min = 0;
    private int max = 360;


    private void Start()
    {
        randomPrefab = Random.Range(0, prefabs.Length);
        danger = prefabs[randomPrefab];
        if (dangerZone == 0)
        {
            danger.GetComponent<Renderer>().sharedMaterial = matDanger;
        }
    }

    private void Update()
    {
        DangerChecker();
    }

    private void OnTriggerEnter(Collider collision)
    {
        
        if (collision.gameObject.name == "Player")
        {
            isPassed = true;
        }        
        if (isPassed)
        {
            Instantiate(spawned,spawner.position,Quaternion.Euler(new Vector3(0,Random.Range(min,max),0)));
            isPassed = false;
        }
        Destroy(transform.parent.gameObject,5f);
        
        
    }

    private void DangerChecker()
    {
        for (int i = 0; i < 6; i++)
        {
            if (prefabs[i].GetComponent<Renderer>().material.color == matDanger.color)
            {
                dangerZone++;
                Debug.Log("danger checker");
            }
        }
        
    }
    
}
    