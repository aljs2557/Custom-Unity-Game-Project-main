using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreInteract : MonoBehaviour
{
    public GameObject Store;
    public PlayerHealth defense;
    public PlayerHealth points;
    public FirstPersonMovement speed;
    public EnHe damage;
    public WeaponSystem firingSpeed;

    public Text fireCost;
    public Text damageCost;
    public Text speedCost;
    public Text defenseCost;
    public Text fireUpgrade;
    public Text speedUpgrade;
    public Text defenseUpgrade;
    public Text damageUpgrade;

    private int fireAmount = 0;
    private int damageAmount = 0;
    private int speedAmount = 0;
    private int defenseAmount = 0;

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

    public int findCost(int check)
    {
        if (check == 0)
        {
            return 50;
        }
        else
        {
            return 50 * (check * 2);
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
        if (fireAmount < 5 && points.getPoints() >= findCost(fireAmount))
        {
            points.setPoints(points.getPoints() - findCost(fireAmount));
            fireAmount++;

            firingSpeed.setFireSpeed(firingSpeed.getFireSpeed() * .5f);
            fireUpgrade.text = fireAmount + "/5";
            if (fireAmount < 5)
            {
                fireCost.text = "Cost: " + findCost(fireAmount) + " points";
            }
            else
            {
                fireCost.text = "Max Level";
            }
            Debug.Log(firingSpeed.getFireSpeed());
        }
    }

    public void UpgradeDamage()
    {
        if (damageAmount < 5 && points.getPoints() >= findCost(damageAmount))
        {
            points.setPoints(points.getPoints() - findCost(damageAmount));
            damageAmount++;

            damageUpgrade.text = damageAmount + "/5";
            if (damageAmount < 5)
            {
                damageCost.text = "Cost: " + findCost(damageAmount) + " points";
            }
            else
            {
                damageCost.text = "Max Level";
            }
            damage.setDamage((int)(damage.getDamage() * 1.5));
            Debug.Log(damage.getDamage());
        }
    }

    public void UpgradeSpeed()
    {
        if (speedAmount < 5 && points.getPoints() >= findCost(speedAmount))
        {
            points.setPoints(points.getPoints() - findCost(speedAmount));
            speedAmount++;

            speedUpgrade.text = speedAmount + "/5";
            if (speedAmount < 5)
            {
                speedCost.text = "Cost: " + findCost(speedAmount) + " points";
            }
            else
            {
                speedCost.text = "Max Level";
            }
            speed.setSpeed((float)(speed.getSpeed() * 1.5));
            speed.setRunningSpeed((float)(speed.getRunningSpeed() * 1.5));
            Debug.Log(speed.getSpeed() + " " + speed.getRunningSpeed());
        }
    }

    public void UpgradeDefense()
    {
        if (defenseAmount < 5 && points.getPoints() >= findCost(defenseAmount))
        {
            points.setPoints(points.getPoints() - findCost(defenseAmount));
            defenseAmount++;

            defenseUpgrade.text = defenseAmount + "/5";
            if (defenseAmount < 5)
            {
                defenseCost.text = "Cost: " + findCost(defenseAmount) + " points";
            }
            else
            {
                defenseCost.text = "Max Level";
            }
            defense.setDefense((int)(defense.getDefense() * .8));
            Debug.Log(defense.getDefense());
        }
    }
}
