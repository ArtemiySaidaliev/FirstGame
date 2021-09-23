using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpScript : MonoBehaviour
{
     public lvl_capacity sil;
     public SaveLvl sv;
     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {  
          sil.lvl++;
          if(sil.lvl==12){
           sv.SaveStatsChar();
           Application.LoadLevel("End");
          }
          sv.SaveStatsChar();
          Application.LoadLevel("MainMenu");
        }
        

    }
}
