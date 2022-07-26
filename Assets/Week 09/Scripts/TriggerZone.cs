using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TrentLeitch
{
    public class TriggerZone : MonoBehaviour
        {
        public delegate void TriggerAction();
        public static event TriggerAction OnTrigger;

        // Detect when the sphere hits this trigger
        // Debug.log something
        // teleport the sphere away

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("lol a " + other.name + " has passed through the trigger zone");
            //other.transform.position = new Vector3(0, 2, 0);

            if(OnTrigger != null)
            {
                OnTrigger();
            }
        }
        
    }
}

