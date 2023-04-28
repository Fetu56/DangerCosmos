using System.Collections;
using UnityEngine;

public class CollectableBox : MonoBehaviour
{
    public AudioSource Audio;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            StartCoroutine(PiclUpBox());
        }
    }
    IEnumerator PiclUpBox()
    {
        Audio.Play();
        Time.timeScale = 0.1f;
        DoorOpen.AddBox();
        Debug.Log("Collected box! All count: " + DoorOpen.BoxesCollected);
        yield return new WaitForSeconds(0.11f);
        Time.timeScale = 1f;
        yield return new WaitForSeconds(0.03f);
        Destroy(this.gameObject);
    }
}
