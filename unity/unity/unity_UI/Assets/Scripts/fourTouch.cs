using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fourTouch : MonoBehaviour
{
    private fourGame fourgameS;
    // Start is called before the first frame update
    void Start()
    {
        fourgameS = FindObjectOfType<fourGame>();
    }

    // Update is called once per frame
    void Update()
    {
       
   
    }
    private void OnMouseDown()
    {

       // if (!fourgameS.touchcontrol)
       // {
            if (gameObject.tag == "four")
            {                
                fourgameS.gamecount++;
                Destroy(this.gameObject);
            }
      //  }
        

    }
}
