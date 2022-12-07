using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CairneyDaniel
{



    public class CubeActivator : MonoBehaviour
    {

        void Update()
        {
            // if the player presses E
            if (Input.GetKeyDown(KeyCode.E))
            {
                // announce the events 
                EventManager.OnColourChangeEvent?.Invoke();
                Debug.Log("E has been pressed");
                EventManager.OnTeleportEvent?.Invoke();
            }
        }
    }

}