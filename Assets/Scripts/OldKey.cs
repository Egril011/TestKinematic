using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oldKey : MonoBehaviour, IInteractable
{
    public void Interact()
    {
        FindAnyObjectByType<MyPlayer>().CollectOldKey();
        Destroy(gameObject);
    }
}
