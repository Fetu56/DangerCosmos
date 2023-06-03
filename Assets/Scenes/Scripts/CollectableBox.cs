using System.Collections;
using UnityEngine;

public class CollectableBox : MonoBehaviour
{
    public AudioSource Audio;
    public TMPro.TextMeshProUGUI Text;
    public void Start()
    {
        Text = FindObjectOfType<Canvas>().GetComponentInChildren<TMPro.TextMeshProUGUI>();
        Text.color = Color.white;
        Text.text = $"Boxes to left: {DoorOpen.BoxesCollected}/10";
        if (DoorOpen.BoxesCollected >= 10)
        {
            Text.color = Color.green;
        }
    }
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
        Text.text = $"Boxes to left: {DoorOpen.BoxesCollected}/10";
        if(DoorOpen.BoxesCollected >= 10)
        {
            Text.color = Color.green;
        }
    }
}
