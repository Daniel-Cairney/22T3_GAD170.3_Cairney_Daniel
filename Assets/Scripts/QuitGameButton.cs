using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CairneyDaniel
{


    public class QuitGameButton : MonoBehaviour
    {
        public void onButtonPress()
        {
            Application.Quit();
        }
    }
}