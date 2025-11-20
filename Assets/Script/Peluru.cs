using UnityEngine;

public class Peluru : MonoBehaviour
{
    public float speed = 5f;
    public float PeluruLifeTime = 2f;
    public GameManager gameManager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Destroy(gameObject, PeluruLifeTime);
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(0, speed * Time.deltaTime, 0);
    }
     public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("musuh"))
        {
            //Debug.Log("Terkena musuh");
            gameManager.score += 10;
            gameManager.textScore.text = gameManager.score.ToString();
            Destroy(gameObject);
        }
    }

    
}
