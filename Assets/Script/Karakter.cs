using UnityEngine;

public class Karakter : MonoBehaviour
{
    public GameObject posisiKarakter;
    public Vector2 posisiMouse;
    public GameObject peluru;
    public float forceMultiplier = 10.0f;
    public float jumpForce = 5f;
    public Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        geserKarakter();
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            float setengahTinggi = Camera.main.orthographicSize;
            float setengahLebar = setengahTinggi * Camera.main.aspect;
            Vector2 posisiMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 posisiKananKiri = new Vector2(posisiMouse.x, transform.position.y); //drag kanan kiri saja
            posisiKananKiri.x = Mathf.Clamp(posisiKananKiri.x, -setengahLebar, setengahLebar);
            //Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.90f, 10f));
            Instantiate(peluru, posisiKananKiri, Quaternion.identity);
            //rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    public void geserKarakter()
    {
        float setengahTinggi = Camera.main.orthographicSize;
        float setengahLebar = setengahTinggi * Camera.main.aspect;
        Vector2 posisiMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 posisiKananKiri = new Vector2(posisiMouse.x, transform.position.y); //drag kanan kiri saja
        posisiKananKiri.x = Mathf.Clamp(posisiKananKiri.x, -setengahLebar, setengahLebar); //drag kanan kiri sesuai ukuran scene
        transform.position = posisiKananKiri;
    }
}
