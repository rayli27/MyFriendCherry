using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int damage;   // Used for projectiles

    public int money;

    public int PRICE = 200;

    public int MAX_HEALTH = 5;
    public int HEALTH;

    public bool bonkable;

    public MoneyProgress progress;
    public Health health;
    public CharacterController2D character;

    public GameMaster gm;

    // Start is called before the first frame update
    void Start()
    {
        bonkable = true;

        money = 0;
        progress.SetMaxMoney(PRICE);

        HEALTH = MAX_HEALTH;
        health.SetMaxHealth(MAX_HEALTH);
    }

    void Update()
    {
        if (HEALTH <= 0)
        {
            this.transform.position = gm.lastCheckPointPos;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy" && bonkable == true)
        {
            bonkable = false;
            HEALTH -= 1;
            health.SetHealth(HEALTH);
            FindObjectOfType<AudioManager>().Play("Damage");
            character.knockbackCount = character.knockbackLength;

            if (transform.position.x < collision.transform.position.x)
            {
                character.knockedtoRight = true;
            }
            else
            {
                character.knockedtoRight = false;
            }
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        bonkable = true;
    }
}
