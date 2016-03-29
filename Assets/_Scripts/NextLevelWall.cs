using UnityEngine;
using System.Collections;
using System;

public class NextLevelWall : MonoBehaviour
{
    public int nextLevelNumber;

<<<<<<< HEAD
    PlayerInteraction interAction;
=======
    PlayerInteraction playerInterAction;
>>>>>>> f420e9374b74cf17c0eb6c6bc451ad4c0dda7971

    // Use this for initialization
    void Start()
    {
<<<<<<< HEAD
        interAction = GameObject.Find("Player").GetComponent<PlayerInteraction>();
        interAction.NextLevel += NextLevel;
=======
        playerInterAction = GameObject.Find("Player").GetComponent<PlayerInteraction>();
        playerInterAction.NextLevel += NextLevel;
>>>>>>> f420e9374b74cf17c0eb6c6bc451ad4c0dda7971
    }
    // Update is called once per frame
    void Update()
    {

    }
    private void NextLevel()
    {
        Application.LoadLevel(nextLevelNumber);
    }
}
