using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selector : MonoBehaviour {

    public GameObject menu;
    public GameObject Item1;
    public GameObject Item2;
    public GameObject Item3;
    public GameObject Item4;
    public GameObject Item5;
    public GameObject Item6;
    public GameObject Item7;
    public GameObject Item8;


    // Use this for initialization
    void Start()
    {
      //  Item2.SetActive(false);
   //     Item3.SetActive(false);
    }

    public void Desativar()
    {
        menu.SetActive(false);
    }

    public void Cancel()
    {
        Item1.SetActive(false);
        Item2.SetActive(false);
        Item3.SetActive(false);
        Item4.SetActive(false);
        Item5.SetActive(false);
        Item6.SetActive(false);
        Item7.SetActive(false);
        Item8.SetActive(false);
    }

    public void LoadItem1()
    {
        Item1.SetActive(true);
        Item2.SetActive(false);
        Item3.SetActive(false);
        Item4.SetActive(false);
        Item5.SetActive(false);
        Item6.SetActive(false);
        Item7.SetActive(false);
        Item8.SetActive(false);
    }

    public void LoadItem2()
    {
        Item1.SetActive(false);
        Item2.SetActive(true);
        Item3.SetActive(false);
        Item4.SetActive(false);
        Item5.SetActive(false);
        Item6.SetActive(false);
        Item7.SetActive(false);
        Item8.SetActive(false);
    }

    public void LoadItem3()
    {
        Item1.SetActive(false);
        Item2.SetActive(false);
        Item3.SetActive(true);
        Item4.SetActive(false);
        Item5.SetActive(false);
        Item6.SetActive(false);
        Item7.SetActive(false);
        Item8.SetActive(false);
    }

    public void LoadItem4()
    {
        Item1.SetActive(false);
        Item2.SetActive(false);
        Item3.SetActive(false);
        Item4.SetActive(true);
        Item5.SetActive(false);
        Item6.SetActive(false);
        Item7.SetActive(false);
        Item8.SetActive(false);
    }

    public void LoadItem5()
    {
        Item1.SetActive(false);
        Item2.SetActive(false);
        Item3.SetActive(false);
        Item4.SetActive(false);
        Item5.SetActive(true);
        Item6.SetActive(false);
        Item7.SetActive(false);
        Item8.SetActive(false);
    }

    public void LoadItem6()
    {
        Item1.SetActive(false);
        Item2.SetActive(false);
        Item3.SetActive(false);
        Item4.SetActive(false);
        Item5.SetActive(false);
        Item6.SetActive(true);
        Item7.SetActive(false);
        Item8.SetActive(false);
    }

    public void LoadItem7()
    {
        Item1.SetActive(false);
        Item2.SetActive(false);
        Item3.SetActive(false);
        Item4.SetActive(false);
        Item5.SetActive(false);
        Item6.SetActive(false);
        Item7.SetActive(true);
        Item8.SetActive(false);
    }

    public void LoadItem8()
    {
        Item1.SetActive(false);
        Item2.SetActive(false);
        Item3.SetActive(false);
        Item4.SetActive(false);
        Item5.SetActive(false);
        Item6.SetActive(false);
        Item7.SetActive(false);
        Item8.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }

}