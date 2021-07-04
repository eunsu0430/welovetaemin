using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartManage : MonoBehaviour
{
    public GameObject developcv;
    public GameObject exitcv;
    public bool developclick = false;
    public bool exitclick = false;
    // Start is called before the first frame update
    void Start()
    {
        developcv.SetActive(false);
        exitcv.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (exitclick == true)
        {
            exitcv.SetActive(false);
        }
        if (developclick == true)
        {
            developcv.SetActive(false);
        }
    }
    public void developer()
    {
        if (developclick == false)
        {
            developcv.SetActive(true);
        }
    }
    public void exitapp()
    {
        if (exitclick == false)
        {
            exitcv.SetActive(true);
        }
    }
}
