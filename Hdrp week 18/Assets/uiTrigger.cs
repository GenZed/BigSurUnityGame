using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiTrigger : MonoBehaviour

{
    public Canvas uiObj;



    // Start is called before the first frame update
    void Start()
    {
        //uiObj = gameObject.GetComponentInChildren<Canvas>();
        uiObj.enabled = false;

        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }






    






    private void OnTriggerEnter(Collider other)
    {
        if (other.name == "PickupThing")
        {
            uiObj.enabled = true;
        }

        //else if (other.name == "PlayerControllerFPS")
        // {

           // uiObj.enabled = true;
      //  }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.name == "PickupThing")
        {
            uiObj.enabled = false;
        }
          //   else if (other.name == "PlayerControllerFPS")
            //{

              //uiObj.enabled = false;
            //}

        }

    }

