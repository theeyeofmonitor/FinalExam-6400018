using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Transform[] spawnpoints;
    [SerializeField] private GameObject assteroid;
    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0, spawnpoints.Length);
        Transform spawnpoint = spawnpoints[randomIndex];
        Instantiate(assteroid, spawnpoint.position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
