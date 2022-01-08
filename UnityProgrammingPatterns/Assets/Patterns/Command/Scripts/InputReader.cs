﻿using UnityEngine;

namespace Patterns.Command.Scripts
{
    public class InputReader : MonoBehaviour
    {
        public Vector3 ReadInput()
        {
            float x = 0;

            if (Input.GetKey(KeyCode.LeftArrow))
            {
                x = -1;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                x = 1;
            }

            float y = 0;
            if (Input.GetKey(KeyCode.UpArrow))
            {
                y = 1;
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                y = -1;
            }
            
            // Movement
            if (x != 0 || y != 0)
            {
                Vector3 direction = new Vector3(x, y, 0);
                return direction;
            }
            
            return Vector3.zero;
        }

        internal bool ReadUndo()
        {
            return Input.GetKey(KeyCode.Backspace);
        }

        /// <summary>
        /// Used to scale an object up or down based on key pressed.
        /// </summary>
        /// <returns>Amount to scale the object.</returns>
        internal float ReadScale()
        {
            if (Input.GetKey(KeyCode.A))
            {
                return -1f;
            }

            if (Input.GetKey(KeyCode.Q))
            {
                return 1f;
            }

            return 0f;
        }
    }
}