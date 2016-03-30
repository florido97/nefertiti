using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour
{

    public Transform doorTarget;
    public float doorTimeLeft = 10;
    PlayerInteraction playerInterAction;

    private float _timeleft;
    [SerializeField]
    private float speed;
    private Vector2 initalPos;
    private bool doorIsUp = false;

    void Awake()
    {
        initalPos = transform.position;
        playerInterAction = GameObject.Find("Player").GetComponent<PlayerInteraction>();
        playerInterAction.Door += DoorStart;
    }

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
    void DoorStart()
    {
        doorIsUp = true;
    }
}