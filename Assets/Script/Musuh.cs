using UnityEngine;

public class Musuh : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //public GameManager gameManager;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("peluru"))
        {
            //Debug.Log("Terkena peluru");
            Destroy(gameObject);
        }
        if (collision.collider.CompareTag("lantai"))
        {
            //Debug.Log("Terkena lantai");
            //gameManager.sfx_musuh_menang.Play();
            Destroy(gameObject);
        }
        
    }
}
