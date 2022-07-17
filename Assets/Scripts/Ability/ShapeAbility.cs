using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public class ShapeAbility : BaseAbility
    {
        [SerializeField] private List<Mesh> meshes=new List<Mesh>();
        private int meshesIndex = 0;
        [SerializeField] private bool hasShapeAbilityContidion;
        
        
        [SerializeField] private MeshFilter playerMeshFilter;
        
        protected override void SetType()
        {
            MyType = AbilityType.Shape;
        }

        public override void PlayYourAbility()
        {
            base.PlayYourAbility();
            ChangeShape();
        }

        public void ChangeShape()
        {
            if (!hasShapeAbilityContidion) return;
            playerMeshFilter.mesh = meshes[meshesIndex];
            meshesIndex++;
            if (meshesIndex>=meshes.Count)
            {
                meshesIndex = 0;
            }
        }
        
    }
}