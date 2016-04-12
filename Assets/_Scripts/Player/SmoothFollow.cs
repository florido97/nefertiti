using UnityEngine;
using System.Collections;

//This script is for the playerCam
public class SmoothFollow : MonoBehaviour
{
    //the target of this script
    [SerializeField]
    private GameObject _target;

    //How much the cam can offset at max
    private float _offset = 4f;

    //The fixedupdated checks if the player uses the right thumbstick and offsets accordingly
    void FixedUpdate()
    {
        //Only do this if we have a target
        if (_target != null)
        {
            //The players second thumbstick input
            float x = Input.GetAxis("Horizontal2");
            float y = Input.GetAxis("Vertical2");

            //Sets where the cam needs to go (the target)
            float offsetX = _target.transform.position.x + x * _offset;
            float offsetY = _target.transform.position.y + y * _offset;

            //actually move the cam towards the position 
            transform.position = Vector3.Lerp(transform.position, new Vector3(offsetX, offsetY, transform.position.z), 0.09f);
        }
    }
}
