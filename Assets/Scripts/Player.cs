using System;
using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class Player : MonoBehaviour
    {
        private PersonalAbilities _personalAbilities;
        
        private void Awake()
        {
            _personalAbilities = gameObject.AddComponent<PersonalAbilities>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.A))
                PlayAbility(AbilityType.Shape);
            else if(Input.GetKeyDown(KeyCode.S))
                PlayAbility(AbilityType.Size);
            else if (Input.GetKeyDown(KeyCode.D))
                PlayAbility(AbilityType.Color);
        }


        private void PlayAbility(AbilityType type)
        {
            var ability = _personalAbilities.GetAbility(type);
            if (ability == null)
            {
                Debug.LogError("Bu ability bulunamadi. -> " + type);
                return;
            }
            
            ability.PlayYourAbility();
        }


        // private ShapeAbility _shapeAbility;
        // private SizeAbility _sizeAbility;
        // private ColorAbility _colorAbility;

        

        // private void Start()
        // {
        //     _shapeAbility = GetComponent<ShapeAbility>();
        //     _sizeAbility = GetComponent<SizeAbility>();
        //     _colorAbility = GetComponent<ColorAbility>();
        // }
        //
        // private void Update()
        // {
        //     if (Input.GetKeyDown(KeyCode.A))
        //     {
        //        
        //         //_shapeAbility.ChangeShape();
        //     }
        //     else if(Input.GetKeyDown(KeyCode.S))
        //     {
        //         //_sizeAbility.ChangeSize();
        //     }
        //     else if (Input.GetKeyDown(KeyCode.D))
        //     {
        //         //_colorAbility.ChangeColor();
        //     }
        // }

    }
}