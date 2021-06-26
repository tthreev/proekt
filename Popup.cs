

using System.Collections;
using UnityEngine;
using UnityEngine.Events;

namespace TriviaQuizKit
{

	public class Popup : MonoBehaviour
	{
		[HideInInspector]
		public BaseScreen ParentScreen;

		public UnityEvent OnOpen;
		public UnityEvent OnClose;

		private Animator animator;

		protected virtual void Awake()
		{
			animator = GetComponent<Animator>();
		}

		protected virtual void Start()
		{
			OnOpen.Invoke();
		}

		protected void Close()
		{
			OnClose.Invoke();
			if (ParentScreen != null)
			{
				ParentScreen.ClosePopup();
			}
			if (animator != null)
			{
				animator.Play("Close");
				StartCoroutine(DestroyPopup());
			}
			else
			{
				Destroy(gameObject);
			}
		}

		private IEnumerator DestroyPopup()
		{
			yield return new WaitForSeconds(0.5f);
			Destroy(gameObject);
		}
	}
}
