using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour
{
    public GameObject bullet;
    public GameObject player;
    public float bullet_speed;
    public float firing_speed = 0.5f;

    bool cooldown = false;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && !cooldown)
        {
            GameObject bullet_clone = Instantiate(bullet, transform.position, Quaternion.identity);
            bullet_clone.SetActive(true);
            Rigidbody rb = bullet_clone.GetComponent<Rigidbody>();
            rb.AddForce(player.transform.forward * bullet_speed * Time.deltaTime);
            cooldown = true;
            StartCoroutine(cooldown_timer());
        }
    }

    IEnumerator cooldown_timer()
    {
        yield return new WaitForSeconds(firing_speed);
        cooldown = false;
    }

    public float getFireSpeed()
    {
        return firing_speed;
    }    

    public void setFireSpeed(float newFireSpeed)
    {
        firing_speed = newFireSpeed;
    }
}
