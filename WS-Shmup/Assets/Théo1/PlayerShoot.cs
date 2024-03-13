using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    PlayerInput _input;

    InputAction _shoot;

    PlayerChangeWeapon changeWeapon;

    public GameObject bulletPrefabBaseBallet;
    public Transform sockect;

    private string WeaponOnUse;



    private void Start()
    {
        _input = GetComponent<PlayerInput>();
        _shoot = _input.actions.FindAction("Shoot");
        WeaponOnUse = changeWeapon.WeaponUse;
        Debug.Log(WeaponOnUse);
    }

    private void OnShoot()
    {
        switch (WeaponOnUse)
        {
            case "Arme1": //Utilisation de l'arme de base 
                Instantiate(bulletPrefabBaseBallet, sockect.position, transform.rotation);
                break;

            case "Arme2"://Utilisation du Fusils à pompe

                break;

            case "Arme3"://Utilisation du Laser

                break;

            case "Arme4"://Utilisation du Lance Roquettes

                break;

        }
    }
}
