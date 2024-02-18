using UnityEngine;
using UnityEngine.UI;
using YourCompany.Variables;

namespace YourCompany.UI.Elements
{
    public class SliderUI : MonoBehaviour
    {
        [Header("Variables")]
        [SerializeField] FloatVariable _value;
        void Start()
        {
            GetComponent<Slider>().value = _value.value;
        }
    }
}