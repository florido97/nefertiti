using UnityEngine;
using System.Collections;

public class LevelLoader : MonoBehaviour
{

    private bool playerInZone = false;

    public string levelToLoad;

    void Start()
    {
        playerInZone = false;
    }

    void Update()
    {
        if (Input.GetButtonDown("Interact") && playerInZone)
        {
            Application.LoadLevel(levelToLoad);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == Tags.PlayerObject)
        {
            playerInZone = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.tag == Tags.PlayerObject)
        {
            playerInZone = false;
        }
    }
}
