using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heightOffest = 10;
    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()

    {
        if (timer < spawnRate) {
            
            timer = timer + Time.deltaTime;
        }
        else
        {
            //once timer is too high it will spawn a pipe, and reset timer.
            //transform sets it to the same value as the object in unity.( the spawners roation is 0 so the pipes arent rotated)
            spawnPipe();
            timer = 0;
        }
        
    }
    void spawnPipe() 
    {
        float lowestPoint = transform.position.y - heightOffest;
        float highestPoint = transform.position.y + heightOffest;
        //when specifying our own numbers for vectors we must use 'new Vector3', and we specify our x,y,z
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation); 
    }
}
