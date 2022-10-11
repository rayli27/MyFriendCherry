using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public bool toTheRight;
    public float speed;

    public float scale;

    // Update is called once per frame
    void Update()
    {
        if (toTheRight)
        {
            transform.Translate(2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(-scale, scale);
            FindObjectOfType<AudioManager>().Play("Ant");

        }
        else
        {
            transform.Translate(-2 * Time.deltaTime * speed, 0, 0);
            transform.localScale = new Vector2(scale, scale);
        }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Turn")
        {
            if (toTheRight)
            {
                FindObjectOfType<AudioManager>().Play("Ant");
                toTheRight = false;
            }
            else
            {
                toTheRight = true;
            }
        }
    }
}
