using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class StartManage : MonoBehaviour
{
    
    public GameObject developcv;
    public GameObject exitcv;
    public bool developclick = false;
    public bool exitclick = false;
    
     Animator ani;
    GameObject developerani;
    

    // Start is called before the first frame update
    void Start()
    {
        developcv.SetActive(false);
        exitcv.SetActive(false);
       
        developerani = developcv.transform.GetChild(0).GetChild(0).gameObject;
        ani = developerani.GetComponent<Animator>();
   
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
            ani.SetBool("letter", true);
        }
    }
    public void exitapp()
    {
        if (exitclick == false)
        {
            exitcv.SetActive(true);
        }
    }


  
   /* public void UnLoadScene()
    {
        if (SceneManager.GetActiveScene().name.Equals(_LoadSceneName) == true)
        {
            _objSpawnCamera.transform.SetParent(transform);
            _objSpawnCamera.transform.localPosition = Vector3.zero;
            _objWallCamers.transform.rotation = Quaternion.Euler(Vector3.zero);

            if (_LoadSceneName.Equals("CakeScene") == true)
            {
                _objCakeScene.SetActive(false);
            }

            var camList = _objGroundCamera.GetComponentsInChildren<Camera>(true);
            foreach (var cam in camList)
            {
                cam.transform.rotation = Quaternion.Euler(new Vector3(90f, 0f, 90f));
            }

            SceneManager.SetActiveScene(SceneManager.GetSceneByName("MainScene"));
            SceneManager.UnloadSceneAsync(_LoadSceneName);
        }
    }*/

}
