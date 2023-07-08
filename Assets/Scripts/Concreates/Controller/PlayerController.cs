using Game.Abstracts.Inputs;
using Game.Concrete.Inputs;
using Game.Types.Device;
using UnityEngine;


namespace Game.Concrete.Controller
{
    public class PlayerController : MonoBehaviour
    {
        private IPlayerInput input;
        public DevicePlatform devicePlatform;

        private void Start()
        {
            this.input = devicePlatform == DevicePlatform.Mobile ? new MobileInput() : new ComputerInput();
        }
    }
}