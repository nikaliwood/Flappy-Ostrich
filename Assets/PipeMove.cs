using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMove : MonoBehaviour
{
    public float moveSpeed = 20;
    public float deadzone = -45;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //multiplying by Time.deltaTime ensures that game will move at same speed no matter framerate of device.
        transform.position = transform.position + (Vector3.left * moveSpeed) *Time.deltaTime;
        if (transform.position.x < deadzone)
        {
            Debug.Log("Pipe Deleted");
            //Pipe is using the PipeMove script so pipe will be deleted.
            Destroy(gameObject);
        }
    }
}
