using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using DG.Tweening;
using System;

public class PlayerChangeWeapon : MonoBehaviour
{
    PlayerInput _input;

    InputAction _change;

    [SerializeField] private TextMeshProUGUI TextWeaponUse;

    private int _NbWeapons = 0;
    public string WeaponUse;

    private Color _textCurrentColor;

    private int _indice = 0;

    private List<string> _weapons = new List<string>
    {
        "Arme : 1", "Arme : 2", "Arme : 3", "Arme : 4"
    };

    [SerializeField] private List<Color> _textColor;

    private void Awake()
    {
        _input = GetComponent<PlayerInput>();
        _change = _input.actions.FindAction("Shoot");
        _NbWeapons = _weapons.Count;
        WeaponUse = _weapons[_indice];

        _textCurrentColor = _textColor[_indice];
    }

    void OnChangeWeapon()
    {
        _indice++;
        if (_indice == _NbWeapons)
        {
            _indice = 0;
            WeaponUse = _weapons[_indice];
            TextWeaponUse.text = WeaponUse;

            _textCurrentColor = _textColor[_indice];
            TextWeaponUse.color = _textCurrentColor;
        }
        else
        {
            WeaponUse = _weapons[_indice];
            TextWeaponUse.text = WeaponUse;

            _textCurrentColor = _textColor[_indice];
            TextWeaponUse.color = _textCurrentColor;
        }   
    }
}
