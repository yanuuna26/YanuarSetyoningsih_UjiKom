using UnityEngine;

public class Karakter : MonoBehaviour
{
    //public Transform posisiKarakter;
    public Vector2 posisiMouse;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float setengahTinggi = Camera.main.orthographicSize;
        float setengahLebar = setengahTinggi * Camera.main.aspect;
        Vector2 posisiMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 posisiKananKiri = new Vector2(posisiMouse.x, transform.position.y); //drag kanan kiri saja
        posisiKananKiri.x = Mathf.Clamp(posisiKananKiri.x, -setengahLebar, setengahLebar); //drag kanan kiri sesuai ukuran scene
        // posisiMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // transform.position = Vector2.MoveTowards(transform.position, posisiMouse, 0.05f);
        transform.position = posisiKananKiri;
    }
}
