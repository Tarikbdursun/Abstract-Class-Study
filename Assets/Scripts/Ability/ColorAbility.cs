using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class ColorAbility : BaseAbility
    {
        [SerializeField] private MeshRenderer _meshRenderer;
        [SerializeField] private List<Color> colors = new List<Color>();
        
        private int colorIndex = 0;
        
        protected override void SetType()
        {
            MyType = AbilityType.Color;
        }

        public override void PlayYourAbility()
        {
            base.PlayYourAbility();
            ChangeColor();
        }

        public void ChangeColor()
        {
            //changeColor
            _meshRenderer.material.color = colors[colorIndex];
            colorIndex++;
            if (colorIndex>=colors.Count)
            {
                colorIndex = 0;
            }
        }
    }
}