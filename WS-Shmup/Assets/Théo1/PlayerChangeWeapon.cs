using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PlayerChangeWeapon : MonoBehaviour
{
    PlayerInput _input;

    InputAction _change;

    [SerializeField] private TextMeshProUGUI TextWeaponUse;

    private int _NbWeapons = 0;
    public string WeaponUse;
    private int _indice = 0;

    private List<string> Weapons = new List<string>
    {
        "Arme : 1", "Arme : 2", "Arme : 3", "Arme : 4"
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
            TextWeaponUse.text = WeaponUse;
        }
        else
        {
            WeaponUse = Weapons[_indice];
            TextWeaponUse.text = WeaponUse;
        }   
    }
}
