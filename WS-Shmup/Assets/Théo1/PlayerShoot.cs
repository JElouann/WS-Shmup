using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Threading.Tasks;

public class PlayerShoot : MonoBehaviour
{
    PlayerInput _input;
    InputAction _shoot;

    PlayerChangeWeapon changeWeapon;

    public GameObject bulletPrefabBaseBullet;
    public GameObject bulletPrefabShotgunBullet;
    public GameObject bulletPrefabLazer;
    public GameObject bulletPrefabRocketLauncherBullet;
    public Transform sockect;

    private string WeaponOnUse ;

    private bool IsShoot1 = false;

    private bool IsShoot2 = false; 

    private bool IsShoot3 = false;

    private void Start()
    {
        _input = GetComponent<PlayerInput>();
        _shoot = _input.actions.FindAction("Shoot");
        changeWeapon = gameObject.GetComponent<PlayerChangeWeapon>();
    }

    
    private async void OnShoot()
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
                    Debug.Log("Tu utilise Arme2");
                }

                break;

            case "Arme3"://Utilisation du Laser
                if (IsShoot2 == false)
                {
                    IsShoot2 = true;
                    Instantiate(bulletPrefabLazer, sockect.position, transform.rotation);
                    await Task.Delay(3000);
                    IsShoot2 = false;
                }
                break;

            case "Arme4"://Utilisation du Lance Roquettes
                if (IsShoot3 == false)
                {
                    IsShoot3 = true;
                    Instantiate(bulletPrefabRocketLauncherBullet, sockect.position, transform.rotation);
                    await Task.Delay(5000);
                    IsShoot3 = false;
                }
                break;
        }
    }
}
