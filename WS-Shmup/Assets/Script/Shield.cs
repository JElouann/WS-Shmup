using UnityEngine;
using System.Threading.Tasks;

public class Shield : MonoBehaviour
{
    private GameObject _shield;

    private PlayerHp _playerHp;

    private void Start()
    {
        _shield = GameObject.Find("Shield");
        _playerHp = GameObject.FindObjectOfType<PlayerHp>();
    }

    private async void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag == "BulletEnnemy")
        {
            Destroy(collision.gameObject);
            _shield.SetActive(false);
            await Task.Delay(250);
            _playerHp.shield = false;
        }
        else if (collision.gameObject.tag == "Ennemy")
        {
            _shield.SetActive(false) ;
            _playerHp.shield = false;
        }
        
    }
}
