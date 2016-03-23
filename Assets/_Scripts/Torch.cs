using UnityEngine;
using System.Collections;

public class Torch : MonoBehaviour {

    Light light;

    void Start()
    {
        light = GetComponent<Light>();
        StartCoroutine(lightLoop());
    }

    IEnumerator lightLoop()
    {
        light.intensity = Random.Range(3.6f, 4f);
        yield return new WaitForSeconds(0.01f);
        StartCoroutine(lightLoop());
    }
}