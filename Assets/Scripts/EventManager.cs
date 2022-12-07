using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CairneyDaniel
{


    public class EventManager : MonoBehaviour
    {
        //This will contain all of our events 
        //Event delegates have two parts
        // the DELAGATE which is the "type of event"
        // the EVENT itself, which gets announced 

        //This is the type of event
        public delegate void VoidDelagate();

        // This is the event itself
        public static VoidDelagate OnTeleportEvent;
        public static VoidDelagate OnColourChangeEvent;
    }   

}
