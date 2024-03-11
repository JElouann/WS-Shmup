using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerChangeWeapon : MonoBehaviour
{
    PlayerInput _input;

    InputAction _change;

    private bool Change = false;

    private int _NbWeapons = 0;
    private int _indice = 0;

    private List<string> Weapons = new List<string>
    {
        "Arme1", "Arme2", "Arme3", "Arme4"
    };


    private void Start()
    {
        _input = GetComponent<PlayerInput>();
        _change = _input.actions.FindAction("Shoot");
        _NbWeapons = Weapons.Count;
        Debug.Log(Weapons[0]);
    }

    private void FixedUpdate()
    {
        if (Change == true)
        {
            Change = false;
            if (_indice == _NbWeapons)
            {
                _indice = 0;
                Debug.Log(Weapons[_indice]);
            }
            else
            {
                Debug.Log(Weapons[_indice]);
            }
        }
    }

    void OnChangeWeapon()
    {
        Change = true;
        _indice++;
    }
}
