using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public AudioSource bgm_main_menu;
    void Start()
    {
        bgm_main_menu.Play();
    }

    public void OnClickStart()
    {
        SceneManager.LoadScene("GamePlay");
    }

    public void onClickCredit()
    {
        SceneManager.LoadScene("Credits");
    }
}
