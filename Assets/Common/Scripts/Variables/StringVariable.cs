using UnityEngine;

namespace YourCompany.Variables
{
    [CreateAssetMenu(fileName = "String Variable", menuName = "Variables/String Variable")]
    public class StringVariable : BaseVariable<string>
    {

    }

    [System.Serializable]
    public class StringReference : BaseReference<string, StringVariable>
    {

    }
}