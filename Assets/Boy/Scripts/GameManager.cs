using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
     [Header("Panel")]
    public GameObject GameGoalPanel;
    public GameObject ClothesGoalPanel;
    public GameObject FoodsGoalPanel;
    public GameObject ShopPanel;

    public void openGoalPanel(){
        GameGoalPanel.SetActive(true);
    }
    public void closeGoalPanel(){
        GameGoalPanel.SetActive(false);
    }
    public void openClothesPanel(){
        ClothesGoalPanel.SetActive(true);
    }
    public void closeClothesPanel(){
        ClothesGoalPanel.SetActive(false);
    }
      public void opeFoodsPanel(){
        FoodsGoalPanel.SetActive(true);
    }
    public void closeFoodsPanel(){
        FoodsGoalPanel.SetActive(false);
    }
    public void openclosePanel(){

        if (ShopPanel.activeSelf) {
            ShopPanel.SetActive(false);
        }
        else
        {
            ShopPanel.SetActive(true);
        }
    }
}
