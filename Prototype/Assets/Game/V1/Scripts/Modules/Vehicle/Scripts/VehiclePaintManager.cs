using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Game.V1.Extension;

namespace Game.Managers
{
    public class VehiclePaintManager : MonoBehaviour
    {
        public Material[] selectableMaterials;
        public Renderer[] PaintableParts;

        public Material currentMaterial;

        // Start is called before the first frame update
        void Start()
        {
            if(currentMaterial == null)
            {
                currentMaterial = ListExtensions.RandomItem(selectableMaterials);
            }

            ChangeVehicleColor(currentMaterial);
        }

        public void ChangeVehicleColor(Material newMaterial)
        {
            foreach (Renderer part in PaintableParts)
            {
                part.material = newMaterial;
            }
        }
    }
}
