using UnityEngine;
using System.Collections;
using System;

public class NextLevelWall : MonoBehaviour
{
    public int nextLevelNumber;

    PlayerInteraction interAction;

    // Use this for initialization
    void Start()
    {
        interAction = GameObject.Find("Player").GetComponent<PlayerInteraction>();
        interAction.NextLevel += NextLevel;
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
