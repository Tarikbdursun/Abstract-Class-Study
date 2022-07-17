using System;
using UnityEngine;

namespace DefaultNamespace
{
    public abstract class BaseAbility : MonoBehaviour
    {
        public AbilityType MyType { get; protected set; }

        public virtual void Init()
        {
            SetType();
        }
        
        protected abstract void SetType();

        public virtual void PlayYourAbility()
        {
            
        }
    }
}