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
   // public bool touchcontrol = false;
    //  public GameObject backgroundcolor;
    //  public GameObject lettercolor;
    // Start is called before the first frame update
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
            fourgametime += Time.deltaTime;
            Vector3 cloverM = new Vector3(Random.Range(-166.0f, 166.0f), 532.0f, 671);
            fourrg.gravityScale = Random.Range(1, 10);
            Instantiate(f_clover, cloverM, Quaternion.identity);
            fourgametime = 0;
            
            // StartCoroutine(CreatecloverRoutine());
        }
        if (miniStart && threegametime >1f)
        {
            fourgametime += Time.deltaTime;
            Vector3 threeM = new Vector3(Random.Range(-166.0f, 166.0f), 532.0f, 671);
            threerg.gravityScale = Random.Range(6, 15);
            Instantiate(t_clover, threeM, Quaternion.identity);
            
            threegametime = 0;


            // StartCoroutine(CreatecloverRoutine());
        }


        if (gamecount >= 4)
        {
           // touchcontrol = true;
            gamecount = 0;
            miniStart = false;
            startC.SetActive(true);
            f_clover.SetActive(false);
           t_clover.SetActive(false);
            lucky.SetActive(true);
            int i = 0;
                StartCoroutine(CreateLucky(i));
            

        }

          
    }

 
    IEnumerator CreateLucky(int i)
    {
        while (i < 24)
        {
            Vector3 luckyM = new Vector3(Random.Range(-166.0f, 166.0f), 532.0f, 671);
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
