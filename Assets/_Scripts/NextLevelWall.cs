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
<<<<<<< HEAD

        playerInterAction = GameObject.Find("Player").GetComponent<PlayerInteraction>();
=======
        playerInterAction = GameObject.FindGameObjectWithTag(Tags.PlayerObject).GetComponent<PlayerInteraction>();
>>>>>>> b20b94420e0d568f033d0a35fd129021fb9844e6
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
