using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WinSreenTrigger : MonoBehaviour{

    void OnTriggerEnter(Collider ChangeScene) {

        //Ik moest een tag toevoegen aan character //if (ChangeScene.gameObject.CompareTag("character")) { 
        if (ChangeScene.gameObject.name == "character") { 

            Application.LoadLevelAdditive(2);

        }
        }
    }

    

