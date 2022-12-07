using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.WSA;

namespace CairneyDaniel
{



    public class ColourChanger : MonoBehaviour
    {

        private void OnEnable()
        {
            EventManager.OnColourChangeEvent += ChangeColor;
        }

        private void OnDisable()
        {
            EventManager.OnColourChangeEvent -= ChangeColor;
        }
        private void ChangeColor()
        {
            // This will change the color of our cube 
            float redValue = Random.Range(0f, 1f);
            float greenValue = Random.Range(0f, 1f);
            float blueValue = Random.Range(0f, 1f);

            gameObject.GetComponent<MeshRenderer>().material.color = new Color(redValue, greenValue, blueValue);


        }


    }
}