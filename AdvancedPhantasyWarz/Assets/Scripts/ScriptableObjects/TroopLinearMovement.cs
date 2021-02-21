using ApwData;
using AdvancedPhantasyWarz;
using UnityEngine;

[CreateAssetMenu(fileName = "NewLinearMovement", menuName = "Entities/Troop/Movement/LinearMovement", order = 0)]
public class TroopLinearMovement : ScriptableObject, ISoMovableData
{
    public LinearMoveData data;
    
    public IMovableData GetData()
    {
        return data;
    }
}
