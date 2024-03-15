using UnityEngine;

public class Ennemy : MonoBehaviour
{
    public int _hp = 100;

    public virtual void LowerHealth(int damage)
    {
        
        if (_hp > 0)
        {
            _hp -= damage;
        } 
        if (_hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
