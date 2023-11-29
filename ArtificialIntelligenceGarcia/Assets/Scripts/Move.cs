using UnityEngine;

public class Move : MonoBehaviour 
{
    public Vector3 goal = new Vector3(5, 0, 5);
    public float speed = 1.0f;
    void Start() 
    {
    }
    void LateUpdate() 
    {
        this.transform.Translate(goal.normalized * speed * Time.deltaTime);
    }
}
