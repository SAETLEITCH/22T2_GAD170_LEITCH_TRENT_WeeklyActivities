using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TrentLeitch
{
    public class SphereTeleporter : MonoBehaviour
    {
        private void OnEnable()
        {
            TriggerZone.OnTrigger += Teleport;
            EventManager.OnClicked += Teleport;
        }

        private void OnDisable()
        {
            TriggerZone.OnTrigger -= Teleport;
            EventManager.OnClicked -= Teleport;
        }

        private void Teleport()
        {
            transform.position = new Vector3(0, 6, 0);
        }
    }
}

