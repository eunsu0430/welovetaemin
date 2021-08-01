using System.Collections;
using System.Collections.Generic;
using Mapbox.Unity;
using UnityEngine;

public class Player : MonoBehaviour {

	private int xp = 0;
	private int lvl = 1;
	private List<GameObject> droids = new List<GameObject>();

	public int Xp {
		get { return xp; }
	}

	public int Lvl {
		get { return lvl; }
	}

	public List<GameObject> Droids {
		get { return droids; }
	}

	// Use this for initialization
	void Start () {
		determineLvl();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void AddXp(int xpToAdd) {
		xp += Mathf.Max(0, xpToAdd);
	}

	public void addDroid(GameObject droid) {
		droids.Add(droid);
	}

	private void determineLvl() {
		lvl = (xp / 100) + 1;
	}
}
