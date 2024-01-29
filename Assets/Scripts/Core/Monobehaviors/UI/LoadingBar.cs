using UnityEngine;
using UnityEngine.UI;

namespace YourProject.Core.UI.Elements
{
    public class LoadingBar : MonoBehaviour
    {
        [Header("Components")]
        [SerializeField] Slider _slider;

        public void ProgressLoadingBar(float p_progress)
        {
            _slider.value = p_progress;
        }
    }
}