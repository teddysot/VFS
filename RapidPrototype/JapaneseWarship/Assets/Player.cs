using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public int Points;
    public TextMeshProUGUI score;
    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + Points.ToString();
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.transform.tag == "Ship")
                {
                    Points++;
                }
            }
        }
    }
}
