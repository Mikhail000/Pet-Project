using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SelectionContainer : MonoBehaviour
{
    public HashSet<IInteractable> selections = new HashSet<IInteractable>();
    
}
