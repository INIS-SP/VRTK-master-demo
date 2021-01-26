namespace Survival
{
    using UnityEngine.Events;
    using UnityEngine;
    using System;

    public class OnCollisionWith : MonoBehaviour
    {
        [SerializeField] GameObject collideWith;

        [Serializable]
        public class OnCollision : UnityEvent<bool>
        {
        }
        [SerializeField] OnCollision onCollision = new OnCollision();

        private void OnTriggerEnter(Collider other)
        {
            if(other.gameObject == collideWith)
            {
                onCollision.Invoke(true);
            }
        }
    }
}
