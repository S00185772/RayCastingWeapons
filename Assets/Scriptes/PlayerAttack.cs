using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAttack : MonoBehaviour {

    public Weapon[] weapons;
    int activeWeaponIndex = -1;
    Weapon activeWeapon;
	void Start () {

        SetActveWeapon(0);

	}
	
	// Update is called once per frame
	void Update () {

        HandleWeaponSwitching();
        if (Input.GetButtonDown("Fire1"))
        {



            if (activeWeapon)
            {
                activeWeapon.Fire(transform.position);
            }

        }


    }

    private void HandleWeaponSwitching()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            SetActveWeapon(0);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            SetActveWeapon(1);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            SetActveWeapon(2);
        }
    }

    private void SetActveWeapon(int index)
    {
        if(index != activeWeaponIndex)
        {
            if(index >= 0 && index <= weapons.Length)
            {
                if (activeWeapon)
                    Destroy(activeWeapon.gameObject);

                activeWeapon = Instantiate(weapons[index], transform);
                activeWeaponIndex = index;            }
        }

    }
    
}
