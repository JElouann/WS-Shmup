using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    PlayerInput _input;

    InputAction _shoot;

    PlayerChangeWeapon changeWeapon;

    public GameObject bulletPrefab;
    public Transform sockect;

    private string WeaponOnUse;

    private Vector3 vector3 = new Vector3();


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
                Instantiate(bulletPrefab, sockect.position, transform.rotation);
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
