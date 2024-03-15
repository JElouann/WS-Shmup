using UnityEngine;
using UnityEngine.UI;

public class PlayerHp : MonoBehaviour
{
    public GameOverScreen gameOverScreen;
    private int score = 0;  

    private int hp = 3;

    public bool shield = false;

    [SerializeField] private Image SpriteHealthBar1;
    [SerializeField] private Image SpriteHealBar2;
    [SerializeField] private Image SpriteHealBar3;

    public void GameOver()
    {
        gameOverScreen.Setup(score);
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "BulletEnnemy")
        {
            if (!shield)
            {
                hp--;
                Destroy(other.gameObject);
                OnLosingHealth();
            }

        }
        if (other.gameObject.tag == "Ennemy")
        {
            hp--;
            OnLosingHealth();
        }
        if (hp <= 0)
        {
            Destroy(gameObject);
            GameOver();
        }
        if (other.gameObject.tag == "Heal")
        {
            hp++;
            Destroy(other.gameObject);
            OnRegainingHealth();
        }
    }

    private void OnLosingHealth()
    {
        switch (hp)
        { 
            case 2:
                SpriteHealthBar1.gameObject.SetActive(false);
                break; 
            case 1:
                SpriteHealBar2.gameObject.SetActive(false);
                break;
        }
    }

    private void OnRegainingHealth()
    {
        switch (hp)
        {
            case 3:
                SpriteHealthBar1.gameObject.SetActive(true);
                break;
            case 2:
                SpriteHealBar2.gameObject.SetActive(true);
                break;
        }
    }
}
