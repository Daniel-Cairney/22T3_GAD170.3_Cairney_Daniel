using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CairneyDaniel
{


    public class EventManager : MonoBehaviour
    {
        public delegate void VoidDelegate();
        public static VoidDelegate OnButtonEnable;
        public static VoidDelegate OnButtonDisable;
    }   

}
