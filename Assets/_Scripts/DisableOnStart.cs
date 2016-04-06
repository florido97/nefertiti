using UnityEngine;
using System.Collections;

public class DisableOnStart : MonoBehaviour
{
    void Start()
    {
        //disables and object when the game starts
        gameObject.SetActive(false);
    }
}
