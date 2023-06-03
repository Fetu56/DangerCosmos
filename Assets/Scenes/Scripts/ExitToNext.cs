using Assets.Scripts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitToNext : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && DoorOpen.canPass)
        {
            Debug.Log("Coming to new level");
            DoorOpen.canPass = false;
            SceneManager.LoadScene((int)Scenes.Game);
        }
    }
}
