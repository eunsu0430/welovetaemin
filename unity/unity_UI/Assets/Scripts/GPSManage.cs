using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GPS : MonoBehaviour
{
    public GameObject stopcv;
    public GameObject Topbar;
    private float fixedDeltatime;
    private bool pause = false;
    // Start is called before the first frame update

    private void Awake()
    {
        {
            this.fixedDeltatime = Time.fixedDeltaTime;

        }
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (pause)
        {
            Time.timeScale = 0;

            Topbar.SetActive(false);
            stopcv.SetActive(true);

        }
    }
    public void GPSUI() //btnmanage에서호출
    {
        if (Time.timeScale == 0)
        {
            stopcv.SetActive(false);
            Topbar.SetActive(true);
            Time.timeScale = 1f;

            pause = false;

        }
        Time.fixedDeltaTime = this.fixedDeltatime * Time.timeScale;
    }
}
