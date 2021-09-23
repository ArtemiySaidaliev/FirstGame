using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartGameMenu2 : MonoBehaviour
{
    public lvl_capacity sil;
    public SaveLvl sv;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
       if (Input.GetKeyDown(KeyCode.R))
        {
            sil.lvl=0;
            sv.SaveStatsChar();
            Application.LoadLevel("MainMenu");
        } 
    }
}
