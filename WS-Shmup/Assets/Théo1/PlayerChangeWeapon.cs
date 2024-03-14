using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerChangeWeapon : MonoBehaviour
{
    PlayerInput _input;

    InputAction _change;

    private int _NbWeapons = 0;
    public string WeaponUse;
    private int _indice = 0;

    private List<string> Weapons = new List<string>
    {
        "Arme1", "Arme2", "Arme3", "Arme4"
    };

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
        _change = _input.actions.FindAction("Shoot");
        _NbWeapons = Weapons.Count;
        WeaponUse = Weapons[_indice];
        Debug.Log(WeaponUse);
    }

    void OnChangeWeapon()
    {
        _indice++;
        if (_indice == _NbWeapons)
        {
            _indice = 0;
            WeaponUse = Weapons[_indice]; 
             Debug.Log(WeaponUse);
        }
        else
        {
            WeaponUse = Weapons[_indice];
            Debug.Log(WeaponUse);
        }   
    }
}
