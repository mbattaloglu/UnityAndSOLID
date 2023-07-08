using Game.Abstracts.Inputs;
using UnityEngine;

namespace Game.Concrete.Inputs
{
    public class ComputerInput : IPlayerInput
    {
        public float Horizontal => Input.GetAxisRaw("Horizontal");
    }
}
