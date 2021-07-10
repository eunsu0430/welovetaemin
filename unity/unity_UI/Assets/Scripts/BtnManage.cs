using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BtnManage : MonoBehaviour
{


    private StartManage startmg;
    private fourGame fourgame;

    private void Awake()
    {
        {
            startmg = FindObjectOfType<StartManage>();
            //gpsmg = FindObjectOfType<GPSManage>();
            fourgame = FindObjectOfType<fourGame>();
        }
    }
    void Update()
    {
    

    }
    public void StartC_StartBtn()
    {
        SceneManager.LoadScene("GPSScene");
    }
    public void StartC_DeveloperBtn()
    {
        startmg.developclick = false;
        startmg.developer();
    }
    public void StartC_ExitBtn()
    {
        startmg.exitclick = false;
        startmg.exitapp();
    }
    public void eC_DC_BackBtn() /// developclick, exitclick 꺼지기
    {
        startmg.developclick = true;
        startmg.exitclick = true;
    }

    public void ExitC_QuitBTN()
    {
        Application.Quit();
    }
    public void StartsceneBTN() //startScene
    {
       // btnclickSound.Play();

        SceneManager.LoadScene("StartScene");
    }
    /*public void restartBtn() //gpsmanage호출하는 버튼
{


}*/
    /*public void StopBtn() //gps호출 버튼 멈추기
    {
       // btnclickSound.Play();
        gpsmg.pause = true;
        
        //   Time.fixedDeltaTime = this.fixedDeltatime * Time.timeScale;
    }*/



    public void minigameBtn()
    {
        fourgame.miniStart = true;
        fourgame.startC.SetActive(false);
        fourgame.DevelopC.SetActive(false);
        fourgame.f_clover.SetActive(true);
        fourgame.t_clover.SetActive(true);
        fourgame.lucky.SetActive(false);
        // fourgame.touchcontrol = false;
    }
    public void minigameExitBtn()
    {
        fourgame.miniStart = false;
    }
}
