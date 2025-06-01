using UnityEngine;

public class PlayerLives : MonoBehaviour
{
    public int lives = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.tag == "Enemy")
        {
            Destroy(collision.collider.gameObject);

            lives -= 1;
            if (lives <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
