

using UnityEngine;

namespace TriviaQuizKit
{
    public class PlaySound : MonoBehaviour
    {
        public void Play(string soundName)
        {
            SoundManager.Instance.PlaySound(soundName);
        }
    }
}
