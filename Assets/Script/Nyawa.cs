
using UnityEngine;
using UnityEngine.UI;

public class Nyawa : MonoBehaviour
{

    public float nyawaAwal = 1f;
    public float nyawaAkhir = 0f;
    public Image progressFill;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void nyawaBerkurang()
    {
        nyawaAwal -= 0.1f;
        progressFill.fillAmount = nyawaAwal;
    }
}
