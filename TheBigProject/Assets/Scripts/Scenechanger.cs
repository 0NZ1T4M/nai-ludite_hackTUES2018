using UnityEngine;

public class Scenechanger : MonoBehaviour {
    public void change(int scene)
    {
        Application.LoadLevel(scene);
    }
	
}
