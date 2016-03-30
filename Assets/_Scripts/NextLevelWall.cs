using UnityEngine;
using System.Collections;
using System;

public class NextLevelWall : MonoBehaviour
{
    public int nextLevelNumber;

    PlayerInteraction playerInterAction;

    // Use this for initialization
    void Start()
    {
        playerInterAction = GameObject.Find("Player").GetComponent<PlayerInteraction>();
        playerInterAction.NextLevel += NextLevel;
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
