using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class LvlChooseScript : MonoBehaviour
{

    public GameObject Button;//ShieldSpell.SetActive(true);
    public GameObject Canvas;
    public GameObject Text;
    public lvl_capacity sil;
    public SaveLvl sv;
   
   
IEnumerator WaitAndPrint() {   
            
           Vector3 V = Button.transform.localScale;  
           for(int i=0;i<100;i++){     
             V.x -= 0.01f;
             V.y -= 0.01f;         
            Button.transform.localScale = V;
            yield return new WaitForSeconds(0.05f);
           }
           Destroy(Button);
           Destroy(Text);
    }
    
    void Start(){
        if(sil.lvl>=1){
               Destroy(Button);
               Destroy(Text);
               Canvas.SetActive(true);
           }else{
         Canvas.SetActive(true);
         StartCoroutine(WaitAndPrint());
           }
         
         
    }

        //void Awake(){
       //    if(sil.lvl>=1){
        //       Destroy(Button);
        //       Destroy(Text);
        //       Canvas.SetActive(true);
        //   } 
      //  }
    void Update(){
    if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            sil.lvl=0;
            sv.SaveStatsChar();
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

    }
}

