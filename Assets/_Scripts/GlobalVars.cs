using UnityEngine;
using System.Collections;

public class GlobalVars  {

    //The variables that ever script shoukd be able to acces

    public static int playerHealth = 100;

    // The current save point of the player. When the player dies, they are returned to this waypoint
    public static Vector2 CurrentSavePoint;
}
