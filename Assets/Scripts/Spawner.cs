using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    [SerializeField] private GameObject PipePrefab;
    [SerializeField] private float timeToSpawn, minYPosition, maxYPosition;
    private float timer;


    
    void Start()
    {
        timer = timeToSpawn;
    }

    
    void Update()
    {
        if (timer <= 0) 
        {
            timer = timeToSpawn;
            GameObject pipe = Instantiate(PipePrefab, transform.position, Quaternion.identity);
            float rand = Random.Range(minYPosition, maxYPosition);
            pipe.transform.position = new Vector3(pipe.transform.position.x, rand);
        }
        else
        {
            timer -= Time.deltaTime;
        }    
    }




}
