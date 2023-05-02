using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreInteract : MonoBehaviour
{
    public GameObject Store;
    public PlayerHealth defense;
    public FirstPersonMovement speed;
    public EnHe damage;
    public WeaponSystem firingSpeed;

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
            Cursor.lockState = CursorLockMode.None;
            Time.timeScale = 0;
        }
    }

    public void closeStore()
    {
        Store.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Time.timeScale = 1;
    }

    public void UpdgradeFireSpeed()
    {
        firingSpeed.setFireSpeed(firingSpeed.getFireSpeed() * .5f);
    }

    public void UpgradeDamage()
    {
        damage.setDamage((int)(damage.getDamage() * 1.5));
    }

    public void UpgradeSpeed()
    {
        speed.setSpeed((float)(speed.getSpeed() * 1.5));
        speed.setRunningSpeed((float)(speed.getRunningSpeed() * 1.5));
    }

    public void UpgradeDefense()
    {
        defense.setDefense((int)(defense.getDefense() * .5));
    }
}
