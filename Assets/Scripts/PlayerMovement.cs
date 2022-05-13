using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    public Interactable focus;
    public Joystick joystick;
    public Button mainButton;
    public float moveSpeed = 5f;

    public Rigidbody2D rb;

    Vector2 movement;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        movement.x = joystick.Horizontal;
        movement.y = joystick.Vertical;

        Debug.DrawLine(transform.position, transform.position + new Vector3(joystick.Horizontal, joystick.Vertical, 0), Color.red);

        RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.position + new Vector3(joystick.Horizontal, joystick.Vertical, 0), 2f);
        if(hit){
            Interactable interactable = hit.collider.GetComponent<Interactable>();
            if (interactable != null) {
                SetFocus(interactable);
            } 
            else{
                RemoveFocus();
            } 
        }
        else{
            RemoveFocus();
        }
    }

    void SetFocus (Interactable newFocus){
        focus = newFocus;

        var colors = mainButton.colors;
        colors.normalColor = Color.white;
        mainButton.colors = colors;
    }

    void RemoveFocus(){
        focus = null;

        
        var colors = mainButton.colors;
        colors.normalColor = Color.grey;
        mainButton.colors = colors;
    }



    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);

        if(movement.x > 0){
            gameObject.transform.localScale = new Vector3(1, 1, 1);
        }
        if(movement.x < 0){
            gameObject.transform.localScale = new Vector3(-1, 1, 1);
        }

        
    }

    public void mainButtonPress(){
        if(focus != null){
            focus.Interact();
        } else {
            GetComponent<PlayerCombat>().attack();
        }
    }
}
