using UnityEngine;

public class ExamplePlayer : MonoBehaviour
{

    public float speed = 10.0f;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

	// Update is called once per frame
	void Update () {


        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        transform.Translate(new Vector3(horizontal, 0, vertical) * speed * Time.fixedDeltaTime);

	    if (Input.GetKeyDown(KeyCode.Escape))
	    {
            Cursor.lockState = Cursor.lockState == CursorLockMode.Locked ? CursorLockMode.None : CursorLockMode.Locked;
            Cursor.visible = !Cursor.visible;
        }
    }
}
