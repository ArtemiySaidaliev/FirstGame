using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenuload : MonoBehaviour
{
    // Start is called before the first frame update
    IEnumerator WaitAndPrint() {    
           
            yield return new WaitForSeconds(10);
            Application.LoadLevel("MainMenu");
      
    }
    void Start()
    {
        StartCoroutine(WaitAndPrint());  
    }

}
