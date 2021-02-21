using ApwData;
using ApwData.General;
using UnityEngine;

namespace AdvancedPhantasyWarz
{
    [CreateAssetMenu(fileName = "NewGroundModValue", menuName = "General/GroundDependendValue", order = 0)]
    public class SoGroundModValue : ScriptableObject, ISoGroundModValueData
    {
        public DefaultGroundModValueData data;
        
        public IGroundModValueData GetData()
        {
            return data;
        }
    }
}