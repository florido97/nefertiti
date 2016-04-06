using UnityEngine;
using System.Collections;
using System;

public class NextLevelWall : MonoBehaviour
{
    //This Int is the number of the next level
    public int nextLevelNumber;

    //The players interaction script
    PlayerInteraction playerInterAction;

    void Start()
    {
        //getting the players script and adding the nextlevel function
        playerInterAction = GameObject.FindGameObjectWithTag(Tags.PlayerObject).GetComponent<PlayerInteraction>();
        playerInterAction.NextLevel += NextLevel;
    }

    //a function that loads the next level, based on te nextLevelNumber
    private void NextLevel()
    {
        Application.LoadLevel(nextLevelNumber);
    }
}
