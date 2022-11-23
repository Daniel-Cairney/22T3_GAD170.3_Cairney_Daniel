using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CairneyDaniel
{


    public class RespawnButon : MonoBehaviour
    {
        public void OnButtonClick()
        {
            SceneManager.LoadScene("Big Hole");
        }
        
    
    }


}
