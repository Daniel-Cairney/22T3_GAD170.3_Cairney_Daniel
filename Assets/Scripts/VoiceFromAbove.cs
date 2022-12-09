using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CairneyDaniel
{


    public class VoiceFromAbove : MonoBehaviour
    {
        [SerializeField] private GameObject voiceFromAboveprefab;
        private GameObject voiceFromAbove;
        private GameObject Player;
        private void OnTriggerEnter(Collider other)
        {

            if(voiceFromAbove == null)
            {
                // This will create the UI pop up if the player character is inside the trigger volume
                voiceFromAbove = Instantiate(voiceFromAboveprefab);

                
            }

            


        }

        private void OnTriggerExit(Collider other)
        {
            // this will destory the UI pop up if the player character is outside the trigger volume
            Destroy(voiceFromAbove);
        }


    }   
}