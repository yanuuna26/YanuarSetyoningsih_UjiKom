using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float waktu = 0;
    public float maxWaktu = 10;
    //public TMP_Text textTimer;
    public bool waktuBerjalan = true;
    public Coroutine hitungTimerCoroutine;

    public Image progressFill;

    public GameManager gameManager;

    void Start()
    {
        hitungTimerCoroutine = StartCoroutine(hitungTimer());
    }

    void Update()
    {
            if(waktu >= maxWaktu)
            {
                StopCoroutine(hitungTimerCoroutine);
                Time.timeScale = 0f;
                PlayerPrefs.SetInt("ScoreAkhir", gameManager.score);
                SceneManager.LoadScene("GameOver");
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
