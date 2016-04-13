using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{
    //the target location for when they door move
    public Transform doorTarget;

    //how long the door stays up
    public float doorTimeLeft = 10;

    //Players playerInterAction script
    PlayerInteraction playerInterAction;

    private float _timeleft;

    //Speed of the door's movement
    [SerializeField]
    private float speed;

    //Initual position of the door
    private Vector2 initalPos;

    //Determans if the door has moved up or not (Defealt false)
    private bool doorIsUp = false;

    void Awake()
    {
        //set the inital position on the door to the door's current position
        initalPos = transform.position;

        //Find the players playerinteraction
        playerInterAction = GameObject.FindGameObjectWithTag(Tags.PlayerObject).GetComponent<PlayerInteraction>();

        //Add the doorstart to the playerInterAction door delicate 
        playerInterAction.Door += DoorStart;
    }

    //The update checks if the doorUp is true. And if it is it, moves the door
    void Update()
    {
        
        float step = speed * Time.deltaTime;
        if (doorIsUp)
        {
            transform.position = Vector3.MoveTowards(transform.position, doorTarget.position, step);
            _timeleft -= Time.deltaTime;
        }
        else 
        {
            transform.position = Vector3.MoveTowards(transform.position, initalPos, step);
        }

        if (_timeleft <= 0)
        {
            doorIsUp = false;
            _timeleft = doorTimeLeft;
        }
    }

    //Start the door's movement
    void DoorStart()
    {
        doorIsUp = true;
    }
}