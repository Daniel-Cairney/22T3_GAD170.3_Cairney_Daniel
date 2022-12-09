using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
namespace CairneyDaniel
{


    public class BlockActivator : MonoBehaviour
    {
        private GameObject block;
        [SerializeField] private Material Intangible;
        [SerializeField] private Material Tangible;


        private void Start()
        {
            block = gameObject;
        }


        private void TurnTangible()
        {
            if (block.GetComponent<BoxCollider>().enabled == true)
            {
                // disable the box collider
                // and change the block to "Intangible"

                block.GetComponent<BoxCollider>().enabled = false;

                block.GetComponent<MeshRenderer>().material = Intangible;
            }
        }

        private void TurnIntangible()
        {
            if (block.GetComponent<BoxCollider>().enabled == false)
            {
                // disable the box collider
                // and change the block to "Intangible"

                block.GetComponent<BoxCollider>().enabled = true;

                block.GetComponent<MeshRenderer>().material = Tangible;
            }



        }

        private void OnEnable()
        {
            EventManager.OnButtonEnable += TurnTangible;
            EventManager.OnButtonDisable += TurnIntangible;
        }

        private void OnDisable()
        {
            EventManager.OnButtonEnable -= TurnTangible;
            EventManager.OnButtonDisable -= TurnIntangible;
        }
    }


}