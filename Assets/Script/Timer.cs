using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float waktu = 10;
    public float maxWaktu = 10;
    //public TMP_Text textTimer;
    public bool waktuBerjalan = true;
    public Coroutine hitungTimerCoroutine;

    public Image progressFill;

    void Start()
    {
        StartCoroutine(hitungTimer());
    }

    void Update()
    {
        
            if(hitungTimerCoroutine != null)
            {
                StopCoroutine(hitungTimerCoroutine);
            }
    }
    IEnumerator hitungTimer()
    {
        while (waktuBerjalan)
        {
            waktu++;
            //textTimer.text = waktu.ToString();
            progressFill.fillAmount = waktu / maxWaktu;
            yield return new WaitForSeconds(1);    
        }
    }
}
