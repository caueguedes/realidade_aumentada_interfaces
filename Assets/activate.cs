using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activate : MonoBehaviour {

    public GameObject gbobj;
    public bool status = false;

    // Use this for initialization
    void Start () {
    }

    // Update is called once per frame
    void Update() {
        if(status == false)
        {
            SetAct();
        }
    }

    void SetAct() { 
    gbobj.SetActive(true);
        status = true;


        print("Ativo?");
        print(GameObject.FindGameObjectWithTag("Selector1").activeSelf);
    }



}
