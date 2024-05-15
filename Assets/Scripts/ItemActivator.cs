using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ItemActivator : MonoBehaviour
{
    public GameObject[] objectsToActivate;
    public TextMeshProUGUI[] textsToActivate;
    public float activationInterval = 20.0f; // Interval between activations

    void Start()
    {
        HideTextElements();
        StartCoroutine(ActivateObjects());
    }
    void HideTextElements()
    {
        // Loop through all text elements
        foreach (var textElement in textsToActivate)
        {
            // Hide the text element by disabling its component
            textElement.enabled = false;
        }
    }
    IEnumerator ActivateObjects()
    {
        yield return new WaitForSeconds(activationInterval);
        
        for (int i = 0; i < objectsToActivate.Length; i++)
        {
            Destroy(objectsToActivate[i]);
            textsToActivate[i].enabled = true;

            yield return new WaitForSeconds(activationInterval);
        }
    }
}
