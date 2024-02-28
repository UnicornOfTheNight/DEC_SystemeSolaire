using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptDeplacement : MonoBehaviour
{
	public GameObject objCentre;

	public float a, b, c, r, G, M, alpha, deltaAlpha, vitesseDeRotation, decalage;
	Vector3 centre;

	// Start is called before the first frame update
	void Start()
    {
		
	}

    // Update is called once per frame
    void Update()
    {
        centre = new Vector3(objCentre.transform.position.x + decalage, objCentre.transform.position.y, objCentre.transform.position.z);

		if(name == "Terre" || name == "Lune")
		{
			GetComponent<Rigidbody>().MovePosition(new Vector3(centre.x + a * Mathf.Cos(alpha), centre.y + b * Mathf.Sin(alpha), 0));
		}
		else
		{
			GetComponent<Rigidbody>().MovePosition(new Vector3(centre.x + a * Mathf.Cos(alpha), 0, centre.z + b * Mathf.Sin(alpha)));
		}
		r = Vector3.Distance(objCentre.transform.position, transform.position);
		
		deltaAlpha = (Mathf.Sqrt(Mathf.Abs(2 * G * M * (1 / r - 1 / (2 * a))) * 180 * Time.deltaTime) / Mathf.PI * Mathf.Sqrt(Mathf.Abs((a * a + b * b) / 2)));

		alpha += deltaAlpha;
		//transform.Rotate(0, 2, 0);
    }
}
