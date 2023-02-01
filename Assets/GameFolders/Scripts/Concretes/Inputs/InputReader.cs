using RunnerPrototype2.Abstract.Inputs;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace RunnerPrototype2.Inputs
{
    public class InputReader : IInputReader
    {

        PlayerInput _playerInput;
        public float Horizontal { get; private set; }
        public bool IsJump { get; private set; }
        public InputReader(PlayerInput playerInput)
        {
            _playerInput = playerInput;

            //perfomed i�lem oldu�unda demek
            _playerInput.currentActionMap.actions[0].performed += OnHorizontalMove;
            //started ilk basma an� cancled da ��k�� an�d�r
            _playerInput.currentActionMap.actions[1].started += OnJump;
            _playerInput.currentActionMap.actions[1].canceled += OnJump;
        }

        private void OnJump(InputAction.CallbackContext context)
        {
            IsJump = context.ReadValueAsButton();
        }

        private void OnHorizontalMove(InputAction.CallbackContext context)
        {
            Horizontal = context.ReadValue<float>();
        }
    }
}

