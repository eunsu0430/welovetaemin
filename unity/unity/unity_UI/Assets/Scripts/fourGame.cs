using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fourGame : MonoBehaviour
{
    public GameObject startC;
    public GameObject DevelopC;
    public GameObject f_clover;
    private Rigidbody2D fourrg;
    public GameObject lucky;
    private Rigidbody2D luckyrg;
    public GameObject t_clover;
    private Rigidbody2D threerg;
    public bool miniStart = false;
    float fourgametime = 0.0f;
    float threegametime = 0.0f;
    public int gamecount;
    private GameObject F_CLOVER;
    private GameObject T_CLOVER;
    private GameObject LUCKY_CLOVER;
    private bool F_SET = false;
    private bool T_SET = false;
    private bool L_SET = false;

    void Start()
    {
        // StartCoroutine(colorchange());
        fourrg = f_clover.GetComponent<Rigidbody2D>();
        luckyrg = lucky.GetComponent<Rigidbody2D>();
        threerg = t_clover.GetComponent<Rigidbody2D>();
        gamecount = 0;

    }

    // Update is called once per frame
    void Update()
    {

        fourgametime += Time.deltaTime;
        threegametime += Time.deltaTime;
        if (miniStart && fourgametime > 2.0f)
        {

            makeFclover();

            // StartCoroutine(CreatecloverRoutine());
        }
        if (miniStart && threegametime >0.5f)
        {

            // StartCoroutine(CreatecloverRoutine());
            makeTclover();
        }
    

        if (gamecount >= 4)
        {
           // touchcontrol = true;
          
            StartCoroutine(CreateConverse());
            StartCoroutine(CreateLucky());
          

        }
       if (F_SET == true)
        {

            //Debug.Log("f localposition" + F_CLOVER.transform.localPosition.y);
            //Debug.Log("f position" + F_CLOVER.transform.position.y);
            if (F_CLOVER.transform.position.y < 390.0f)
            {
                Debug.Log("ssssssssssssssssssss");
            }
         //   Destroy(F_CLOVER, 3.0f);
               
           
        }
        if (T_SET == true)
        {
            
                Destroy(T_CLOVER, 3.0f);
                T_SET = false;

        }
        if (L_SET == true)
        {
       
                Destroy(LUCKY_CLOVER, 3.0f);
                L_SET = false;
            
        }

          
    }
    public void makeFclover()
    {
        Vector3 cloverM = new Vector3(Random.Range(-120.0f, 120.0f), 400.0f, 500);
        fourrg.gravityScale = Random.Range(1, 10);
       F_CLOVER = Instantiate(f_clover, cloverM, Quaternion.identity);
        
     
        F_SET = true;
        fourgametime = 0;
    }
    public void makeTclover()
    {
        Vector3 threeM = new Vector3(Random.Range(-120.0f, 120.0f), 400.0f, 500);
        threerg.gravityScale = Random.Range(7, 15);
        T_CLOVER= Instantiate(t_clover, threeM, Quaternion.identity);

        T_SET = true;
        threegametime = 0;


    }
    IEnumerator CreateConverse()
    {
        gamecount = 0;
        miniStart = false;
        f_clover.SetActive(false);
        t_clover.SetActive(false);
        lucky.SetActive(true);
        yield return new WaitForSeconds(1);
        startC.SetActive(true);

    }

    IEnumerator CreateLucky()
    {
        int i = 0;
        while (i < 24)
        {
            Vector3 luckyM = new Vector3(Random.Range(-120.0f, 120.0f), 400.0f, 500);
            luckyrg.gravityScale = Random.Range(6, 10);
            LUCKY_CLOVER=Instantiate(lucky, luckyM, Quaternion.identity);
            L_SET = true;
            yield return new WaitForSeconds(1);
            i++;
            

        }
     

    }
 


    // IEnumerator colorchange()
    // {
    //    for(int i=)
    // }

}
