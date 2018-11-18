using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

	void Update () { // usiamo Update e non FixUpdate perchè non faccio uso di forze
        transform.Rotate(new Vector3(0, 0, 45) * Time.deltaTime); // ruota attorno all'asse Z

	}
}
