using UnityEngine;
using System.Collections;
using System;

public class NextLevelWall : MonoBehaviour
{
    public int nextLevelNumber;

    PlayerInteraction playerInterAction;

    void Start()
    {
        playerInterAction = GameObject.FindGameObjectWithTag(Tags.PlayerObject).GetComponent<PlayerInteraction>();
        playerInterAction.NextLevel += NextLevel;
    }

    private void NextLevel()
    {
        Application.LoadLevel(nextLevelNumber);
    }
}
