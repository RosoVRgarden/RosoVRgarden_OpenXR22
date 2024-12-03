using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ColorObject : MonoBehaviour
{

    public InputActionReference colorReference = null;
    private MeshRenderer meshRenderer = null;

    void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
		//
    }

    // Update is called once per frame
    void Update()
    {
        float value = colorReference.action.ReadValue<float>();
        UpdateColor(value);
    }

    void UpdateColor(float value)
    {
        meshRenderer.material.color = new Color(value, value, value);
    }
}
