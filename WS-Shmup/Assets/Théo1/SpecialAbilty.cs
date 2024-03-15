using UnityEngine;
using System.Threading.Tasks;
using System;
using static UnityEngine.Rendering.DebugUI;

public class SpecialAbilty : MonoBehaviour
{
    [SerializeField] private GameObject _shield;
    private PlayerHp _playerHp;

    private GameObject _player;

    private bool _canuseshield = true;

    private void Start()
    {
        _player = GameObject.Find("PlayerShip");
        _playerHp = GameObject.FindObjectOfType<PlayerHp>();
    }

    private async void OnSpecialAbility()
    {
        _playerHp.shield = true;
        if (_canuseshield == true)
        {
            _shield.SetActive(true);
            _canuseshield = false;
            await Task.Delay(7000);
            _canuseshield = true;
        }
    }
}
