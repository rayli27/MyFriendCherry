using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Weapon : MonoBehaviour
{
    public Animator anim;
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int maxAmmo = 1;
    private int currentAmmo;
    public float reloadTime = 1f;
    private bool isReloding = false;

    private void Start()
    {
       if (currentAmmo == -1)
        {
            currentAmmo = maxAmmo;
        } 
    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("Fire",false);

        if (isReloding)
        {
            return;
        }
        if(currentAmmo <= 0)
        {
            StartCoroutine(Reload());
            return;
        }
        if (Input.GetButtonDown("Fire1"))
        {
            anim.SetBool("Fire",true);
            Shoot();
            FindObjectOfType<AudioManager>().Play("Shoot");
        }
    }
    IEnumerator Reload()
    {
        isReloding = true;
        yield return new WaitForSeconds(reloadTime);
        currentAmmo = maxAmmo;
        isReloding = false;
    }
    void Shoot ()
    {
        // shooting logic
        currentAmmo--;
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
