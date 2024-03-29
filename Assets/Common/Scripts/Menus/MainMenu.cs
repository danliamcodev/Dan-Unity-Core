using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using YourCompany.Managers;

namespace YourCompany.UI.Menus
{
    public class MainMenu : MonoBehaviour
    {
        [Header("References")]
        [SerializeField] SoundManager _soundManager;
        [Header("Components")]
        [SerializeField] AudioClip _bgm;

        private void Start()
        {
            _soundManager.PlayBGM(_bgm);
        }
    }
}