using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayMusic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnMouseDown()
    {
        try
        {
            var found = FindObjectsOfType(typeof(AudioSource)) as AudioSource[];
            foreach (var obj in found)
            {
                obj.Stop();
            }

            this.gameObject.GetComponent<AudioSource>().Play();
        }
        catch (Exception) { }
    }
}
