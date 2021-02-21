using System;
using ApwData;
using UnityEngine;

namespace AdvancedPhantasyWarz
{
    [CreateAssetMenu(fileName = "NewTroopData", menuName = "Entities/Troop/Troop", order = 0)]
    public class GameTroopData : ScriptableObject
    {
        [Header("Stats")]
        public TroopData data;
        
        [Header("Behaviours")]
        [SerializeReference] ScriptableObject _moveData;
        [SerializeReference] ScriptableObject _damageableData;
        [SerializeReference] ScriptableObject _attackData;
        
        public TroopData GetConstructedData()
        {
            var cData = data;
            cData.name = name;
            cData.attackData = ((ISoAttackData) _attackData).GetData();
            cData.damageableData = ((ISoDamageableData) _damageableData).GetData();
            cData.movableData = ((ISoMovableData) _moveData).GetData();

            return cData;
        }

        private void OnValidate()
        {
            if (_moveData != null && !(_moveData is ISoMovableData)) _moveData = null;
            if (_damageableData != null && !(_damageableData is ISoDamageableData)) _damageableData = null;
            if (_attackData != null && !(_attackData is ISoAttackData)) _attackData = null;
        }
    }

    public interface ISoMovableData
    {
        IMovableData GetData();
    }
    public interface ISoAttackData
    {
        IAttackData GetData();
    }
    public interface ISoDamageableData
    {
        IDamageableData GetData();
    }
}