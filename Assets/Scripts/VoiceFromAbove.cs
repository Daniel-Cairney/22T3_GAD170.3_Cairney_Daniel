using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CairneyDaniel
{


    public class VoiceFromAbove : MonoBehaviour
    {

        private GameObject voiceFromAbove;
        private GameObject Player;
        private void OnCollisionEnter(Collision collision)
        {
            if (collision.collider == null) Destroy(voiceFromAbove);


        }

    }
}