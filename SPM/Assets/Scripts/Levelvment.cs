using UnityEngine;
public class Levelvment : MonoBehaviour
{
    void Update()
    {
        transform.Rotate(new Vector3(0, 45, 0) * Time.deltaTime);
    }
}