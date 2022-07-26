using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace TrentLeitch
{
    public class EventManager : MonoBehaviour
    {
        public delegate void ClickAction();

        public static event ClickAction OnClicked;

        private void OnGUI()
        {
            if (GUI.Button(new Rect(Screen.width / 2 - 50, 5, 100, 30), "click"))
            {
                if (OnClicked != null)
                {
                    OnClicked();
                }
            }
        }
    }
}