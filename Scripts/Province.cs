using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CityBuilder.Overworld
{
    public class Province : MonoBehaviour
    {
        ProvinceData _provinceData;

        public void Init(ProvinceData provinceData)
        {
            _provinceData = provinceData;
        }
    }
}

