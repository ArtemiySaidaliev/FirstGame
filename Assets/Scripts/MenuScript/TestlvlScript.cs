using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestlvlScript : MonoBehaviour
{
        public lvl_capacity sil;
        public GameObject Lvl1;
        public GameObject Lvl2;
        public GameObject Lvl3;
        public GameObject Lvl4;
        public GameObject Lvl5;
        public GameObject Lvl6;
        public GameObject Lvl7;
        public GameObject Lvl8;
        public GameObject Lvl9;
        public GameObject Lvl10;
        public GameObject Lvl11;
        public GameObject Lvl12;
        
        
    // Start is called before the first frame update
    void Start()
    {
        
    }




    // Update is called once per frame
    void Update()
    {
        if(sil.lvl==0){
           Lvl1.SetActive(true);
        }
        if(sil.lvl==1){
           Lvl1.SetActive(false);
           Lvl2.SetActive(true);
        }
          if(sil.lvl==2){
           Lvl1.SetActive(false);
           Lvl2.SetActive(false);
           Lvl3.SetActive(true);
        }
          if(sil.lvl==3){
           Lvl1.SetActive(false);
           Lvl2.SetActive(false);
           Lvl3.SetActive(false);
           Lvl4.SetActive(true);
        }
          if(sil.lvl==4){
           Lvl1.SetActive(false);
           Lvl2.SetActive(false);
           Lvl3.SetActive(false);
           Lvl4.SetActive(false);
           Lvl5.SetActive(true);
        }
         if(sil.lvl==5){
           Lvl1.SetActive(false);
           Lvl2.SetActive(false);
           Lvl3.SetActive(false);
           Lvl4.SetActive(false);
           Lvl5.SetActive(false);
           Lvl6.SetActive(true);
        }
         if(sil.lvl==6){
           Lvl1.SetActive(false);
           Lvl2.SetActive(false);
           Lvl3.SetActive(false);
           Lvl4.SetActive(false);
           Lvl5.SetActive(false);
           Lvl6.SetActive(false);
           Lvl7.SetActive(true);
        }
        if(sil.lvl==7){
           Lvl1.SetActive(false);
           Lvl2.SetActive(false);
           Lvl3.SetActive(false);
           Lvl4.SetActive(false);
           Lvl5.SetActive(false);
           Lvl6.SetActive(false);
           Lvl7.SetActive(false);
           Lvl8.SetActive(true);
        }
        if(sil.lvl==8){
           Lvl1.SetActive(false);
           Lvl2.SetActive(false);
           Lvl3.SetActive(false);
           Lvl4.SetActive(false);
           Lvl5.SetActive(false);
           Lvl6.SetActive(false);
           Lvl7.SetActive(false);
           Lvl8.SetActive(false);
           Lvl9.SetActive(true);
        }
         if(sil.lvl==9){
           Lvl1.SetActive(false);
           Lvl2.SetActive(false);
           Lvl3.SetActive(false);
           Lvl4.SetActive(false);
           Lvl5.SetActive(false);
           Lvl6.SetActive(false);
           Lvl7.SetActive(false);
           Lvl8.SetActive(false);
           Lvl9.SetActive(false);
           Lvl10.SetActive(true);
        }
        if(sil.lvl==10){
           Lvl1.SetActive(false);
           Lvl2.SetActive(false);
           Lvl3.SetActive(false);
           Lvl4.SetActive(false);
           Lvl5.SetActive(false);
           Lvl6.SetActive(false);
           Lvl7.SetActive(false);
           Lvl8.SetActive(false);
           Lvl9.SetActive(false);
           Lvl10.SetActive(false);
           Lvl11.SetActive(true);
        }
        if(sil.lvl==11){
           Lvl1.SetActive(false);
           Lvl2.SetActive(false);
           Lvl3.SetActive(false);
           Lvl4.SetActive(false);
           Lvl5.SetActive(false);
           Lvl6.SetActive(false);
           Lvl7.SetActive(false);
           Lvl8.SetActive(false);
           Lvl9.SetActive(false);
           Lvl10.SetActive(false);
           Lvl11.SetActive(false);
           Lvl12.SetActive(true);
        }
         if (Input.GetKeyDown(KeyCode.D)){
            if(sil.lvl==0){
           Application.LoadLevel("TutorialLvl1");
        }
        if(sil.lvl==1){
           Application.LoadLevel("TutorialLvl2");
        }
          if(sil.lvl==2){
           Application.LoadLevel("TutorialLvl3");
        }
          if(sil.lvl==3){
          Application.LoadLevel("TutorialLvl4");
        }
        if(sil.lvl==4){
          Application.LoadLevel("Normal_Lvl1");
        }
        if(sil.lvl==5){
          Application.LoadLevel("Normal_Lvl2");
        }
         if(sil.lvl==6){
          Application.LoadLevel("Normal_Lvl3");
        }
        if(sil.lvl==7){
          Application.LoadLevel("Normal_Lvl4");
        }
        if(sil.lvl==8){
          Application.LoadLevel("Hard1");
        }
        if(sil.lvl==9){
          Application.LoadLevel("Hard2");
        }
        if(sil.lvl==10){
          Application.LoadLevel("Hard3");
        }
        if(sil.lvl==11){
          Application.LoadLevel("Hard4");
        }
        }
         if (Input.GetKeyDown(KeyCode.RightArrow)){
        if(sil.lvl==0){
           Application.LoadLevel("TutorialLvl1");
        }
        if(sil.lvl==1){
           Application.LoadLevel("TutorialLvl2");
        }
          if(sil.lvl==2){
           Application.LoadLevel("TutorialLvl3");
        }
          if(sil.lvl==3){
          Application.LoadLevel("TutorialLvl4");
        }
        if(sil.lvl==4){
          Application.LoadLevel("Normal_Lvl1");
        }
        if(sil.lvl==5){
          Application.LoadLevel("Normal_Lvl2");
        }
         if(sil.lvl==6){
          Application.LoadLevel("Normal_Lvl3");
        }
        if(sil.lvl==7){
          Application.LoadLevel("Normal_Lvl4");
        }
        if(sil.lvl==8){
          Application.LoadLevel("Hard1");
        }
        if(sil.lvl==9){
          Application.LoadLevel("Hard2");
        }
        if(sil.lvl==10){
          Application.LoadLevel("Hard3");
        }
        if(sil.lvl==11){
          Application.LoadLevel("Hard4");
        }
        }
    }
    public void Onclick(){

        if(sil.lvl==0){
           Application.LoadLevel("TutorialLvl1");
        }
        if(sil.lvl==1){
           Application.LoadLevel("TutorialLvl2");
        }
          if(sil.lvl==2){
           Application.LoadLevel("TutorialLvl3");
        }
          if(sil.lvl==3){
          Application.LoadLevel("TutorialLvl4");
        }
        if(sil.lvl==4){
          Application.LoadLevel("Normal_Lvl1");
        }
        if(sil.lvl==5){
          Application.LoadLevel("Normal_Lvl2");
        }
         if(sil.lvl==6){
          Application.LoadLevel("Normal_Lvl3");
        }
        if(sil.lvl==7){
          Application.LoadLevel("Normal_Lvl4");
        }
        if(sil.lvl==8){
          Application.LoadLevel("Hard1");
        }
        if(sil.lvl==9){
          Application.LoadLevel("Hard2");
        }
        if(sil.lvl==10){
          Application.LoadLevel("Hard3");
        }
        if(sil.lvl==11){
          Application.LoadLevel("Hard4");
        }
    }
}
