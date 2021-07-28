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

          
    }
    public void makeFclover()
    {
        Vector3 cloverM = new Vector3(Random.Range(-60.0f, 60.0f), 200.0f, 250);
        fourrg.gravityScale = Random.Range(1, 10);
        Instantiate(f_clover, cloverM, Quaternion.identity);
        
        fourgametime = 0;
    }
    public void makeTclover()
    {
        Vector3 threeM = new Vector3(Random.Range(-60.0f, 60.0f), 200.0f, 250);
        threerg.gravityScale = Random.Range(7, 15);
         Instantiate(t_clover, threeM, Quaternion.identity);
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
            Vector3 luckyM = new Vector3(Random.Range(-60.0f, 60.0f), 200.0f, 250);
            luckyrg.gravityScale = Random.Range(6, 10);
            Instantiate(lucky, luckyM, Quaternion.identity);
            yield return new WaitForSeconds(1);
            i++;
            

        }
     

    }
 


    // IEnumerator colorchange()
    // {
    //    for(int i=)
    // }

}
