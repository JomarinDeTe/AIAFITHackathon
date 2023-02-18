using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject character1;
    public GameObject character2;
    public GameObject character3;
    public GameObject character4;


    public void character1Selected(){
        character1.SetActive(true);
        character2.SetActive(false);
        character3.SetActive(false);
        character4.SetActive(false);

    }
     public void character2Selected(){
        character1.SetActive(false);
        character2.SetActive(true);
        character3.SetActive(false);
        character4.SetActive(false);

    }
     public void character3Selected(){
        character1.SetActive(false);
        character2.SetActive(false);
        character3.SetActive(true);
        character4.SetActive(false);

    }
     public void character4Selected(){
        character1.SetActive(false);
        character2.SetActive(false);
        character3.SetActive(false);
        character4.SetActive(true);
   
    }


}
