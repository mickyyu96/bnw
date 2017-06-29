using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_1 : MonoBehaviour {

    public GameObject objectButtonPrefab;
    public GameObject objectButtonContainer;

    private void Start()
    {
        Sprite[] thumbnails = Resources.LoadAll<Sprite>("Level_1");
        foreach (Sprite thumbnail in thumbnails)
        {
            GameObject container = Instantiate(objectButtonPrefab) as GameObject;
            container.GetComponent<Image>().sprite = thumbnail;
            container.transform.SetParent(objectButtonContainer.transform, false);
        }
    }
}
