using UnityEngine;

public class PlayerHp : MonoBehaviour
{
    public GameOverScreen gameOverScreen;
    private int score = 0;  

    private int hp = 3;


    public void GameOver()
    {
        gameOverScreen.Setup(score);
    }

    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "BulletEnnemy")
        {
            hp--;
        }
        if (other.gameObject.tag == "Ennemy")
        {
            hp--;
        }
        if (hp <= 0)
        {
            Destroy(gameObject);
            GameOver();
        }
    }
}
