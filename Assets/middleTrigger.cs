using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class middleTrigger : MonoBehaviour
{
    public Logic logic;
    public birdscript bird;
    public AudioClip ding;
    public AudioSource dingsource;

    // Start is called before the first frame update
    void Start()
    {
        //When you cant something to add it as an object.
        //This grabs the logic script from the gameobject that has the tag logic which is logicmanager in unity.
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
        GameObject birdGameObject = GameObject.FindGameObjectWithTag("Bird");
        if (birdGameObject != null)
        {
            bird = birdGameObject.GetComponent<birdscript>();
        }
        else
        {
            Debug.LogError("Bird object not found!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (bird.birdIsAlive ==
            true)
        {
            if (collision.gameObject.layer == 3)
            {
                //allows us to update the score added for perhaps different levels.
                logic.addScore(1);
                dingsource.clip = ding;
                dingsource.Play();
            }
        }
    }
}
