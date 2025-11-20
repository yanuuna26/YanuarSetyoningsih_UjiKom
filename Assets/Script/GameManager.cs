using System.Collections;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public GameObject musuh1;
    public GameObject musuh2;
    public GameObject musuh3;
    public bool masihSpawn = true;
    public int score;
    public TMP_Text textScore;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(spawnMusuh1());
        StartCoroutine(spawnMusuh2());
        StartCoroutine(spawnMusuh3());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator spawnMusuh1()
    {
        while (masihSpawn)
        {
            yield return new WaitForSeconds(2);
            Vector3 spawnPosition = new Vector3(Random.Range(-8, 8), 5, 0);
            GameObject objectBaru = Instantiate(musuh1, spawnPosition, Quaternion.identity);
        }
    }
    IEnumerator spawnMusuh2()
    {
        while (masihSpawn)
        {
            yield return new WaitForSeconds(3);
            Vector3 spawnPosition = new Vector3(Random.Range(-8, 8), 5, 0);
            GameObject objectBaru = Instantiate(musuh2, spawnPosition, Quaternion.identity);
        }
    }
    IEnumerator spawnMusuh3()
    {
        while (masihSpawn)
        {
            yield return new WaitForSeconds(4);
            Vector3 spawnPosition = new Vector3(Random.Range(-8, 8), 5, 0);
            GameObject objectBaru = Instantiate(musuh3, spawnPosition, Quaternion.identity);
        }
    }
}