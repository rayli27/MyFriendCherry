using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SummerSound : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Summer");
    }
}
