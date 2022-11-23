using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CairneyDaniel
{
    

    public class HoleDeath : MonoBehaviour
    {   
        public GameObject Hole;
        private void OnCollisionEnter(Collision collision)
        {

            Debug.Log("Collision");
            SceneManager.LoadScene("Death Screen");
        }

    }
}