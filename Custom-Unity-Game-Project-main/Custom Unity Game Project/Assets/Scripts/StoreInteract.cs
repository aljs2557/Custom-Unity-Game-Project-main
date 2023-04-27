using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreInteract : MonoBehaviour
{
    public GameObject Store;
    public PlayerHealth health;
    public FirstPersonMovement speed;
    public EnemyHealth damage;

    // Start is called before the first frame update
    void Start()
    {
        Store.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Store.SetActive(true);
            Time.timeScale = 0;
        }
    }

    public void closeStore()
    {
        Store.SetActive(false);
        Time.timeScale = 1;
    }

    public void UpdgradeHealth()
    {

    }
}
