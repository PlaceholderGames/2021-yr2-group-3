using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ThirdPersonMovement : MonoBehaviour
{
    public CharacterController controller;
    public Transform cam;
    public GameObject DeathPlane;
    private bool groundedPlayer = true;
    private AudioSource source;
    public float speed = 6f;
    public float pushPower = 2.0f; //push power for moving blocks
    private float playerSpeed = 2.0f;
    private float jumpHeight = 3.0f;
    private float gravityValue = -29.81f;
    private Vector3 playerVelocity;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public Inventory inventory;

    public HUD Hud;

    public GameObject RightHand;

    void Start() {

   
        source = GetComponent<AudioSource>();
        this.source.playOnAwake = false;

        inventory.ItemUsed += Inventory_ItemUsed;
        inventory.ItemRemoved += Inventory_ItemRemoved;
    }
    private void Inventory_ItemRemoved(object sender, InventoryEventArgs e) {

        IInventoryItem item = e.Item;

        GameObject goItem = (item as MonoBehaviour).gameObject;
        goItem.SetActive(true);

        goItem.transform.parent = null;
    }

    private void Inventory_ItemUsed(object sender, InventoryEventArgs e)
    {

        IInventoryItem item = e.Item;

        GameObject goItem = (item as MonoBehaviour).gameObject;
        goItem.SetActive(true);

        goItem.transform.parent = RightHand.transform;

        goItem.transform.position = RightHand.transform.position;

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject == DeathPlane)
        {
            transform.position = new Vector3(-116, -1, 129);
        }
    }

    private IInventoryItem mItemToPickup = null;
    private void OnTriggerEnter(Collider other)
    {
        IInventoryItem item = other.GetComponent<IInventoryItem>();

        if (item != null)
        {
            Hud.OpenMessagePanel("");
            mItemToPickup = item;
        }

        if(other.gameObject.CompareTag("Collectable"))
        {
            Destroy(other.gameObject);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        IInventoryItem item = other.GetComponent<IInventoryItem>();

        if (item != null)
        {

            Hud.CloseMessagePanel();
            mItemToPickup = null;
        }

    }

    void OnControllerColliderHit (ControllerColliderHit hit) //Function for pushing objects
    {
        Rigidbody body = hit.collider.attachedRigidbody;

        if (body == null || body.isKinematic) //Checking for rigidbodies
        {
            return;
        }
            
        if (hit.moveDirection.y < -0.3f) //Preventing the objecting from being pushed downwards or upwards
        {
            return;
        }

        Vector3 pushDir = new Vector3(hit.moveDirection.x, 0, hit.moveDirection.z); //Calculating push direction from move direction

        body.velocity = pushDir * pushPower; //Adding velocity to the pushed object

    }

    // Update is called once per frame
    void Update()
    {
        if (controller.transform.position.y <= -15)
        {
            transform.position = new Vector3(-116, -1, 129);
        }

        if (mItemToPickup != null && Input.GetKeyDown(KeyCode.E))
        {
            inventory.AddItem(mItemToPickup);
            mItemToPickup.OnPickup();
            Hud.CloseMessagePanel();

        }
        groundedPlayer = controller.isGrounded;

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;
        
        if (direction.magnitude >= 0.1f) {

            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            controller.Move(moveDir.normalized * speed * Time.deltaTime);

            
        }

        if (Input.GetKeyDown("space") && groundedPlayer)
        {
            playerVelocity.y = 0;

            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);

            source.Play();

        }

        if (Input.GetKeyDown("K"))
        {
            SceneManager.LoadScene(2);
        }

        if (groundedPlayer == false)
        {
            playerVelocity.y += gravityValue * Time.deltaTime;
            
        }


        controller.Move(playerVelocity * Time.deltaTime);
        source.Play();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }




    //private void OnControllerColliderHit(ControllerColliderHit hit)
    //{
    //    IInventoryItem item = hit.collider.GetComponent<IInventoryItem>();

    //    if (item != null)
    //    {
    //        inventory.AddItem(item);

    //    }

    //}


}
