using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnManage : MonoBehaviour
{
    public GameObject stopcv;
    public GameObject Topbar;

    // public GameObject exppcv;
    private bool pause = false;
  //  public AudioSource btnclickSound;
    private float fixedDeltatime;

    private void Awake()
    {
        {
            this.fixedDeltatime = Time.fixedDeltaTime;
        }
    }
    void Update()
    {
        if (pause)
        {
            Time.timeScale = 0;

            Topbar.SetActive(false);
            stopcv.SetActive(true);

        }

    }
    public void GPSsceneBtn()
    {
        SceneManager.LoadScene("GPSScene");
    }
    public void restartBtn() //=> startScene
    {
        //btnclickSound.Play();
        if (Time.timeScale == 0)
        {
            stopcv.SetActive(false);
            Topbar.SetActive(true);
            Time.timeScale = 1f;

            pause = false;

        }
        Time.fixedDeltaTime = this.fixedDeltatime * Time.timeScale;

    }
    public void QuitBTN()
    {
        Application.Quit();
    }
    public void StartsceneBTN() //startScene
    {
       // btnclickSound.Play();

        SceneManager.LoadScene("StartScene");
    }
    public void StopBtn()
    {
       // btnclickSound.Play();
        pause = true;


       
     //   Time.fixedDeltaTime = this.fixedDeltatime * Time.timeScale;
    }
}
