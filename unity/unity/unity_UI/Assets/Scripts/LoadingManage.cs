using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadingManage : MonoBehaviour
{

    public Slider progressbar;
    public Text loadtext;
    public FadeINOUT _fadeInOut;
    public GameObject fadeinout;
    public Image fadeimg;

    // Start is called before the first frame update
    private void Awake()
    {
        
             fadeimg = fadeinout.transform.GetChild(0).GetComponent<Image>();
    }
    void Start()
    {
        progressbar.value = 0.0f;
        Loadscene("GPSScene");
    }

    public void Loadscene(string nextScene)
    {
        StartCoroutine(CoLoadScene(nextScene));

    }
    private IEnumerator CoLoadScene(string nextScene)
    {
        AsyncOperation asyncOper = SceneManager.LoadSceneAsync(nextScene);
        asyncOper.allowSceneActivation = false;
        while (!asyncOper.isDone)
        {
            yield return null;
            if (progressbar.value < 0.9f)
            {
                progressbar.value = Mathf.MoveTowards(progressbar.value, 0.9f, Time.deltaTime);
            }
            if (asyncOper.progress >= 0.9f)
            {
                progressbar.value = Mathf.MoveTowards(progressbar.value,1f, Time.deltaTime);
            }
            if(progressbar.value>=1f)
            {
                loadtext.text = "wait a second";
                fadeinout.SetActive(true);
                yield return new WaitForSeconds(1f);
                _fadeInOut.FadeOUT_List(fadeimg);
                
                _fadeInOut.FadeIN_List(fadeimg);
             
                asyncOper.allowSceneActivation = true;


            }
        
         
        }
        yield return null;





        //_IsLoading = false;
    }
}
