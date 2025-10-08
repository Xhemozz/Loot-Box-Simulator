using UnityEngine;
using UnityEngine.InputSystem;

public class MouseClick : MonoBehaviour
{
    private Mouse mouse;
    private Camera mainCamera;
    public Transform spawnPosition;

    private Vector2 mousePosition;
    void Start()
    {
        mainCamera = Camera.main;
        mouse = Mouse.current;
    }

    // Update is called once per frame
    void Update()
    {
        mousePosition = mouse.position.ReadValue();

        if (mouse.leftButton.wasPressedThisFrame)
            ClickedObject(mousePosition);
    }

    private void ClickedObject(Vector2 clickPosition)
    {
        RaycastHit2D hit = Physics2D.GetRayIntersection(mainCamera.ScreenPointToRay(mousePosition));
        if (hit.collider.CompareTag("Chest"))
        {
            Inventory inventory = hit.collider.GetComponent<Inventory>();
            GameObject clone = Instantiate(inventory.SpawnItem(),spawnPosition);
        }
    }
}
