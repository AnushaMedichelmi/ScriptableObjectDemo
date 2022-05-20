using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarInfoDisplay : MonoBehaviour
{
    public Cars car=new Cars();
    public Text name;
    public Image carImage;
    public Text description;
    public Text rank;
    public Text score;
    void Start()
    {
        this.name.text = car.name;
        carImage.sprite = car.carImage;
        description.text = car.carDescription;
        rank.text = rank.ToString();
        score.text = score.ToString();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
