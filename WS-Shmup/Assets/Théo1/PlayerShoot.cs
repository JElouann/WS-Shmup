using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    PlayerInput _input;
    InputAction _shoot;

    PlayerChangeWeapon changeWeapon;

    public GameObject bulletPrefabBaseBullet;
    public GameObject bulletPrefabRocketLauncherBullet;
    public Transform sockect;

    private string WeaponOnUse ;

    private bool IsShoot1 = false;
    private float _cooldown1 = 1.5f;

    private bool IsShoot2 = false; 
    private float _cooldown2 = 5f;

    private bool IsShoot3 = false;
    private float _cooldown3 = 2.5f;

    private void Start()
    {
        _input = GetComponent<PlayerInput>();
        _shoot = _input.actions.FindAction("Shoot");
        changeWeapon = gameObject.GetComponent<PlayerChangeWeapon>();
    }


    private void OnShoot()
    {
        WeaponOnUse = changeWeapon.WeaponUse;
        

        switch (WeaponOnUse)
        {
            case "Arme1": //Utilisation de l'arme de base 

                Instantiate(bulletPrefabBaseBullet, sockect.position, transform.rotation);
                break;

            case "Arme2"://Utilisation du Fusils à pompe
                if (IsShoot1 == true)
                {
                    IsShoot3 = true;
                    ///Instantiate(bulletPrefabShootGun, sockect.position, transform.rotation);
                    StartCoroutine(OnCooldown(_cooldown3, IsShoot3));
                }
                break;

            case "Arme3"://Utilisation du Laser
                if (IsShoot2 == false)
                {
                    IsShoot2 = true;
                    Instantiate(bulletPrefabRocketLauncherBullet, sockect.position, transform.rotation);
                    StartCoroutine(OnCooldown(_cooldown2, IsShoot2));
                }
                break;

            case "Arme4"://Utilisation du Lance Roquettes
                if (IsShoot3 == true)
                {
                    IsShoot3 = true;
                    ///Instantiate(bulletPrefabLazer, sockect.position, transform.rotation);
                    StartCoroutine(OnCooldown(_cooldown3, IsShoot3));
                }
                break;

        }
    }

    private IEnumerator OnCooldown(float CoolDownTime, bool IsShoot)
    {
        yield return new WaitForSeconds(CoolDownTime);
        IsShoot = false;
    }
}
