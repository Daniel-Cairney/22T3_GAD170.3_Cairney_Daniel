using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CairneyDaniel
{

    
    public class Button : MonoBehaviour
    {
        [SerializeField] private Material EnableButtonMaterial;
        [SerializeField] private Material DisableButtonMaterial;
        private MeshRenderer mr;

        private void Start()
        {
            mr = GetComponent<MeshRenderer>();

        }

        private void ButtonEnable()
        {
            // this will change the colour if the button is enabled
            mr.material = EnableButtonMaterial;
        }

        private void ButtonDisable()
        {
            // this will change the colour if the button is disabled
            mr.material = DisableButtonMaterial;
        }

        private void OnEnable()
        {
            EventManager.OnButtonEnable += ButtonEnable;
            EventManager.OnButtonDisable += ButtonDisable;
        }

        private void OnDisable()
        {
            EventManager.OnButtonEnable -= ButtonEnable;
            EventManager.OnButtonDisable -= ButtonDisable;
        }



    } 


   


}
