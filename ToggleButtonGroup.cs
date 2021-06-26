

using System.Collections.Generic;
using UnityEngine;

namespace TriviaQuizKit
{

    public class ToggleButtonGroup : MonoBehaviour
    {
        public List<ToggleButton> Buttons;

        public void SetToggle(ToggleButton toggledButton)
        {
            foreach (var button in Buttons)
            {
                button.SetToggled(button == toggledButton);
            }
        }

        public void SetToggle(int toggledButton)
        {
            for (var i = 0; i < Buttons.Count; i++)
            {
                var button = Buttons[i];
                button.SetToggled(i == toggledButton);
            }
        }
    }
}
