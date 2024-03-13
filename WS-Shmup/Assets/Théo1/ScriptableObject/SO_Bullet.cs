using UnityEngine;

[CreateAssetMenu(fileName ="NewBullet", menuName = "Bullet")]
public class SO_Bullet : ScriptableObject
{
    public new string name;

    public float bullet_speed;

    public float cooldown;

    public int damage;

    public float lifeTime;

}
