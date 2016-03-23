using UnityEngine;
using System.Collections;
using System;

public class NextLevelWall : MonoBehaviour
{
    public int nextLevelNumber;

<<<<<<< HEAD
    PlayerInteraction interAction;
=======
    Interaction interAction;
>>>>>>> master

    // Use this for initialization
    void Start()
    {
<<<<<<< HEAD
        interAction = GameObject.Find("Player").GetComponent<PlayerInteraction>();
=======
        interAction = GameObject.Find("Player").GetComponent<Interaction>();
>>>>>>> master
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
