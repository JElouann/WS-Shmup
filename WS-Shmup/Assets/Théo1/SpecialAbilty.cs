using UnityEngine;
using System.Threading.Tasks;
using System;

public class SpecialAbilty : MonoBehaviour
{
    [SerializeField] GameObject Shield;

    private GameObject _player;

    private bool _canuseshield = true;

    private void Start()
    {
        _player = GameObject.Find("PlayerShip");
    }

    private async void OnSpecialAbility()
    {
        if (_canuseshield == true)
        {
            Shield.SetActive(true);
            _canuseshield = false;
            await Task.Delay(7000);
            _canuseshield = true;
        }
    }
}
