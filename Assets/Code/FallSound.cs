using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallSound : MonoBehaviour
{
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Fall");
    }

}
