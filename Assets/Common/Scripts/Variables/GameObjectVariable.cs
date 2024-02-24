
using UnityEngine;

namespace YourCompany.Variables
{
    [CreateAssetMenu(fileName = "GameObject Variable", menuName = "Variables/GameObject Variable")]
    public class GameObjectVariable : BaseVariable<GameObject>
    {
    }

    [System.Serializable]
    public class GameObjectReference : BaseReference<GameObject, GameObjectVariable>
    {
    }
}
