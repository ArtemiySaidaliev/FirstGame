using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Titri : MonoBehaviour
{
    // Start is called before the first frame update
     public GameObject TextMain;
     public GameObject TextTitri;
      public GameObject CUBE;
         
   

    void Start()
    {
        
    }
    public void On_Click(){
       Destroy(TextMain);
       Destroy(CUBE);
       TextTitri.SetActive(true);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
