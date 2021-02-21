using System;
using System.Collections.Generic;
using ApwData;
using UnityEngine;

namespace AdvancedPhantasyWarz
{
    [CreateAssetMenu(fileName = "NewDefendingDamageable", menuName = "Entities/Troop/Damageable/GroundModAndDefending", order = 0)]
    public class GroundModDefenseDamageable : ScriptableObject, ISoDamageableData
    {
        public DefendingModDamageableData data;
        
        public ScriptableObject groundModValue;

        public IDamageableData GetData()
        {
            return data;
        }

        private void OnValidate()
        {
            if (groundModValue != null && !(groundModValue is ISoGroundModValueData)) groundModValue = null;
        }
    }
}