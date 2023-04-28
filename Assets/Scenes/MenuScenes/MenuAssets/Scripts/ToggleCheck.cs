using UnityEngine;
using UnityEngine.UI;

public class ToggleCheck : MonoBehaviour
{
    public GameObject ToggleObj;

    public void Start()
    {
        ToggleObj.SetActive(false);
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F8))
        {
            Debug.Log("CHAOS OPTION UNLOCKED");
            ToggleObj.SetActive(true);
        }
    }
}
