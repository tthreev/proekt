

using UnityEngine;
using UnityEngine.SceneManagement;

namespace TriviaQuizKit
{

	public class SceneTransition : MonoBehaviour
	{
		public void TravelToScene(string sceneName)
		{
			SceneManager.LoadScene(sceneName);
		}
	}
}
