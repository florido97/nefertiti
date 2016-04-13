using UnityEngine;
using System.Collections;

public class PitFloor : MonoBehaviour
{
    //The targeting point for when the pitfloor moves
    public Transform pitFloorTarget;

    //players playerInterAction script
    PlayerInteraction playerInterAction;

    //The speed the pitfloor moves
    [SerializeField]
    private float speed;

    //The begin position of the pitfloor
    private Vector2 initalPos;

    //A bool to check if the pitfloor is up (Defealt false)
    private bool pitFloorIsUp = false;

    void Awake()
    {
        //set standard position to the transforms current position
        initalPos = transform.position;

        //find the PlayerInteraction script and add the floorswitch function to the floor delicate
        playerInterAction = GameObject.FindGameObjectWithTag(Tags.PlayerObject).GetComponent<PlayerInteraction>();
        playerInterAction.Floor += FloorSwitch;
    }

    //the update checks if the floor is up and if it is, it moves towards the pitFloorTarget position
    void Update()
    {

        float step = speed * Time.deltaTime;
        if (pitFloorIsUp)
        {
            transform.position = Vector3.MoveTowards(transform.position, pitFloorTarget.position, step);
        }
        else 
        {
            transform.position = Vector3.MoveTowards(transform.position, initalPos, step);
        }
    }

    //A function the playerInterAction uses in its delicate to move the pitFloor
    void FloorSwitch()
    {
        pitFloorIsUp = true;
    }
}