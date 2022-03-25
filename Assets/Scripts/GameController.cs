using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    //Constellation Details
    [Header("ConstellationDetails")]
    public Text constellationName;
    public Image constellationImage;
    public Text constellationDescription;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void Constellation(string name, Sprite image, string description)
    {
        //Set the constellation information
        constellationName.text = name;
        constellationImage.sprite = image;
        constellationDescription.text = description;
    }
}