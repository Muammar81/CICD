using UnityEngine;

public class Cube : MonoBehaviour
{
    private readonly float speed = 20;
    private Material mat;
    private Color c;

    private void Awake()
    {
        mat = GetComponent<Renderer>().material;
        c = Random.ColorHSV();
    }

    private void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
        transform.Rotate(Vector3.left * speed * Time.deltaTime);

        if (mat.color != c)
        {
            mat.color = Color.Lerp(mat.color, c, speed/10 * Time.deltaTime);
        }
        else
        {
            c = Random.ColorHSV();
        }
    }
}
