using UnityEngine;
using UnityEngine.UI;

public class GenerationToggle : MonoBehaviour
{
    public GameObject toggleObj;
    private Toggle toggle;

    public void Start()
    {
        toggle = GetComponent<Toggle>();
        toggle.isOn = CfgManagement.incorrectGeneration;
    }
    
    public void SetValue(bool value)
    {
        CfgManagement.incorrectGeneration = value;
    }
}
