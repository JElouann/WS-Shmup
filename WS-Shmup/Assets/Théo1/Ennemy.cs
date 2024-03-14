using UnityEngine;

public class Ennemy : MonoBehaviour
{
    private int _hp = 100;

    public void LowerHealth(int damage)
    {
        
        if (_hp > 0)
        {
            _hp -= damage;
            Debug.Log(_hp);
        } 
        if (_hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
