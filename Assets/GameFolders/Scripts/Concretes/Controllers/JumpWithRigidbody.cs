using RunnerPrototype2.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RunnerPrototype2.Movements
{
    public class JumpWithRigidbody
    {
        Rigidbody _playerRigidbody;
        public JumpWithRigidbody(PlayerController playerController)
        {
            _playerRigidbody = playerController.GetComponent<Rigidbody>(); 
        }

        public void FixedTick(float jumpForce)
        {
            if (_playerRigidbody.velocity.y != 0) return;

            _playerRigidbody.velocity = Vector3.zero;
            _playerRigidbody.AddForce(Vector3.up * Time.deltaTime * jumpForce);
        }
    }
}

