using UnityEngine;

public class birdscript : MonoBehaviour
{
    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public Logic logic;
    public bool birdIsAlive = true;
    public AudioClip flap;
    public AudioSource flapsource;

    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    void Update()
    {
        bool isInPositionRange = (myRigidBody.position.y > -47.6f && myRigidBody.position.y < 48.2f);

        if (birdIsAlive && isInPositionRange && (Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)))
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
            flapsource.clip = flap;
            flapsource.Play();
        }
        if (!isInPositionRange && birdIsAlive)
        {
            birdIsAlive = false;
            logic.gameOver();
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {

        birdIsAlive = false;
        logic.gameOver();
    }
}
