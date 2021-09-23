using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveLvl : MonoBehaviour
{
   // Start is called before the first frame update
    public lvl_capacity st;
    private void Awake()
    {

        LoadStatsChar();
    }
   
     public void SaveStatsChar()
    {
     
        PlayerPrefs.SetFloat("lvl" + "", st.lvl);
        

    }
    public void LoadStatsChar()
    {
        st.lvl = PlayerPrefs.GetFloat("lvl" + "", st.lvl);
        

    }

}
