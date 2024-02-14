using UnityEngine;
using UnityEngine.Events;

namespace Tools
{
    [RequireComponent(typeof(Collider))]
    public class PlayerTriggerArea : MonoBehaviour
    {
        public UnityEvent onPlayerEnterTrigger = null;

        public UnityEvent onPlayerExitTrigger = null;


        private void OnTriggerEnter(Collider Player)
        {
            if (gameObject.tag == "Player")
            {
                onPlayerEnterTrigger?.Invoke();
            }
        }

        private void OnTriggerExit(Collider Player)
        {
            if (gameObject.tag == "Player")
            {
                onPlayerExitTrigger?.Invoke();
            }
        }
    }
}