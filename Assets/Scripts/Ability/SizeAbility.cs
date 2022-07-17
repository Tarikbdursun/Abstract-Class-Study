using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class SizeAbility : BaseAbility
    {
        [SerializeField] private Transform player;
        [SerializeField] private List<float> sizes=new List<float>();
        private int sizesIndex = 0;
        
        protected override void SetType()
        {
            MyType = AbilityType.Size;
        }

        public override void PlayYourAbility()
        {
            base.PlayYourAbility();
            ChangeSize();
        }

        public void ChangeSize()
        {
            player.localScale *= sizes[sizesIndex];
            sizesIndex++;
            if (sizesIndex>=sizes.Count)
            {
                sizesIndex = 0;
            }
        }
    }
}