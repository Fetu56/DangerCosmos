using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
    public AudioSource Audio;
    public static uint BoxesCollected { get; private set; }
    public static bool canPass;
    public static bool skip = false;
    public static void AddBox(uint i = 1)
    {
        BoxesCollected += i;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && (BoxesCollected >= 10 || skip))
        {
            Audio?.Play();
            Debug.Log("Door opened, welcome stranger");
            BoxesCollected = 0;
            canPass = true;
            StartCoroutine(OpenDoor());
        }
    }
    private IEnumerator OpenDoor()
    {
        for(int i = 0; i < 1000; i++)
        {
            this.transform.position += new Vector3(0, 0.02f, 0);
            yield return new WaitForSeconds(0.01f);
        }
    }
}
