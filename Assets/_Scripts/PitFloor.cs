using UnityEngine;
using System.Collections;

public class PitFloor : MonoBehaviour
{

    public Transform pitFloorTarget;


    PlayerInteraction interAction;
<<<<<<< HEAD


=======
=======
    PlayerInteraction playerInterAction;
>>>>>>> f420e9374b74cf17c0eb6c6bc451ad4c0dda7971
>>>>>>> origin/master
    [SerializeField]
    private float speed;
    private Vector2 initalPos;
    private bool pitFloorIsUp = false;

    void Awake()
    {
        initalPos = transform.position;
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> origin/master

        interAction = GameObject.Find("Player").GetComponent<PlayerInteraction>();

        interAction.Floor += FloorSwitch;
=======
        playerInterAction = GameObject.Find("Player").GetComponent<PlayerInteraction>();
        playerInterAction.Floor += FloorSwitch;
>>>>>>> f420e9374b74cf17c0eb6c6bc451ad4c0dda7971
    }

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
    void FloorSwitch()
    {
        pitFloorIsUp = true;
    }
}