

using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace TriviaQuizKit
{

	public class ToggleButton : MonoBehaviour, IPointerDownHandler
	{
		public ToggleButtonGroup ToggleGroup;
		public Sprite SelectedSprite;
		public Sprite UnselectedSprite;

		private Image image;

		private void Awake()
		{
			image = GetComponent<Image>();
		}

		public void OnPointerDown(PointerEventData pointerEventData)
		{
			ToggleGroup.SetToggle(this);
		}

		public void SetToggled(bool toggled)
		{
			image.sprite = toggled ? SelectedSprite : UnselectedSprite;
		}
	}
}
