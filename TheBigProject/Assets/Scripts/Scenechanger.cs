using UnityEngine;

public class Scenechanger : MonoBehaviour {
    public void change(string scene)
    {
        Application.LoadLevel(scene);
    }
	
}
