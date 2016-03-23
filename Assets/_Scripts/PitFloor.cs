using UnityEngine;
using System.Collections;

public class PitFloor : MonoBehaviour
{

    public Transform pitFloorTarget;

<<<<<<< HEAD
    PlayerInteraction interAction;
=======
    Interaction interAction;
>>>>>>> master
    [SerializeField]
    private float speed;
    private Vector2 initalPos;
    private bool pitFloorIsUp = false;

    void Awake()
    {
        initalPos = transform.position;
<<<<<<< HEAD
        interAction = GameObject.Find("Player").GetComponent<PlayerInteraction>();
=======
        interAction = GameObject.Find("Player").GetComponent<Interaction>();
>>>>>>> master
        interAction.Floor += FloorSwitch;
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