using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class PersonalAbilities : MonoBehaviour
    {
        private Dictionary<AbilityType, BaseAbility> _abilityDict = new Dictionary<AbilityType, BaseAbility>();

        private void Awake()
        {
            var abilities = GetComponents<BaseAbility>();
            foreach (var ability in abilities)
            {
                ability.Init();
                _abilityDict.Add(ability.MyType, ability);
            }
        }

        public BaseAbility GetAbility(AbilityType targetType)
        {
            if (!_abilityDict.ContainsKey(targetType))
                return null;

            return _abilityDict[targetType];
        }
        
        
        
    }
}