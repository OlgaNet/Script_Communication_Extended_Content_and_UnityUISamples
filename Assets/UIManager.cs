using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour 
{
    public Text name, age, location, gender, favoriteCompany;

    private Name _name;
    private AGL _agl;
    private Company _company;

    private void Start()
    {
        _name = GetComponent<Name>(); //tomu scho toy sam GameObject 
        _agl = GameObject.Find("Main Camera").GetComponent<AGL>();
        _company = GameObject.FindGameObjectWithTag("Company").GetComponent<Company>();

        name.text = "Name: " + _name.name;
        age.text = "Age: " + _agl.age;
        gender.text = "Gender: " + _agl.gender;
        location.text = "Location: " + _agl.location;
        favoriteCompany.text = "Favorite Company: " + _company.favoriteCompany;

    }
}
