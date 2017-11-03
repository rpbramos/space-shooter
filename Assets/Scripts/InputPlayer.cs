using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputPlayer : MonoBehaviour {
    private Vector2 startInputPosition;
    private Vector2 endInputPosition;
    private float diferenceMouseX;
    private float diferenceMouseY;

    private void Update() {
        GetMouseEventTrigger();

        if (Input.GetMouseButtonDown(0)) {
            CheckSwipeDirection();
        }
    }
    
    private void GetMouseEventTrigger() {
        if (Input.GetMouseButtonDown(0)) {
            startInputPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Debug.Log("Start Position: " + startInputPosition.x + " / " + startInputPosition.y);
        } else if (Input.GetMouseButtonUp(0)) {
            endInputPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            Debug.Log("End Position: " + endInputPosition.x + " / " + endInputPosition.y);
        }
    }

    private void CheckSwipeDirection() {
        diferenceMouseX = CalculateDiferenceBetweenToValues(startInputPosition.x, endInputPosition.x);
        diferenceMouseY = CalculateDiferenceBetweenToValues(startInputPosition.y, endInputPosition.y);

//        if (diferenceMouseX > diferenceMouseY) {
//            if (Direction(startInputPosition.x, endInputPosition.x)) {
//                // swipe right -> left
//                Debug.Log("swipe right -> left");
//            } else {
//                // swipe left -> right
//                Debug.Log("swipe left -> right");
//            }
//        } else {
//            if (Direction(startInputPosition.y, endInputPosition.y)) {
//                // swipe up -> down
//                Debug.Log("swipe up -> down");
//            } else {
//                // swipe down -> up
//                Debug.Log("swipe down -> up");
//            }
//        }
    }

    private static float CalculateDiferenceBetweenToValues (float startPosition, float endPosition) {
        return Mathf.Abs(startPosition - endPosition);
    }

//    private static bool Direction(float startPosition, float endPosition) {
//        return startPosition > endPosition;
//    } 
}
