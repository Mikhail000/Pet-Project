using System.Collections.Generic;
using UnityEngine;
 
namespace Controls
{
    [CreateAssetMenu(menuName = "SelectionSystem/ActionsCommansScheme")]
    public class ActionsCommandsScheme : ScriptableObject
    {
        public List<ActionCommandPair> actionCommandList;
    }
}
