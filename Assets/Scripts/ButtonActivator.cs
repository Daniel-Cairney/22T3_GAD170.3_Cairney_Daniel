using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CairneyDaniel
{



    public class ButtonActivator : MonoBehaviour
    {
        private bool isPlayerNearby = false;
        private bool isButtonEnabled = false;
        
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.CompareTag("Player")) 
            {
                isPlayerNearby = true;
                // this allows the button to detect if the player is nearby as it needs to be in order to enable it
            }

        }

        private void OnTriggerExit(Collider other)
        {
            if (other.gameObject.CompareTag("Player"))
            {
                isPlayerNearby = false;
            }
        }
        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.E)&& isPlayerNearby)
            {
                Debug.Log("BUTTON WORKS");

                if (!isButtonEnabled)
                {
                    EventManager.OnButtonEnable?.Invoke();
                    isButtonEnabled = true;
                }

                else
                {
                    EventManager.OnButtonDisable?.Invoke();
                    isButtonEnabled = false;
                }
            }

        }
    }
}
