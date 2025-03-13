using System;
using TMPro;
using UnityEngine;

namespace State
{
    public class PlayerCanvasController : MonoBehaviour
    {
        public TextMeshPro stateText;
        public PlayerController playerController;

        private void Awake()
        {
            playerController.OnChangeState += OnChangeState;
        }

        private void OnDestroy()
        {
            playerController.OnChangeState -= OnChangeState;

        }


        void OnChangeState(StateBase stateBase)
        {
            stateText.text = stateBase.ToString();
        }
    }
}