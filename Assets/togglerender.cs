using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class togglerender : MonoBehaviour
{

    public void ToggleVisibility()
    {
        Renderer rend = gameObject.GetComponent<Renderer>();
            rend.enabled = true;

    }




}
