using UnityEngine;
using System.Collections;

public class Torch : MonoBehaviour {

    //THe light that is on a torch
    Light light;

    void Start()
    {
        //getting the light
        light = GetComponent<Light>();
        StartCoroutine(lightLoop());
    }

    //A loop that flikker the light
    IEnumerator lightLoop()
    {
        light.intensity = Random.Range(3.6f, 4f);
        yield return new WaitForSeconds(0.01f);
        StartCoroutine(lightLoop());
    }
}