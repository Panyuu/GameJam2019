using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    
    // Player Objects
    [SerializeField] GameObject rat;
    [SerializeField] GameObject doctor;
    
    // Speed is asigned on object itself (rats faster than plaguedoctor).
    [SerializeField] int speed;

    private void Start() {

        speed = 7;
    }

    // Update is called once per frame
    void Update()
    {
        moveDoctor();
    }

    public void moveDoctor() {

        if (Input.GetKey(KeyCode.W)) {

            Debug.Log("hi");
            doctor.transform.position = new Vector3(doctor.transform.position.x, 0, doctor.transform.position.z + speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S)) {

            doctor.transform.position = new Vector3(doctor.transform.position.x, 0, doctor.transform.position.z - speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A)) {

            doctor.transform.position = new Vector3(doctor.transform.position.x - speed * Time.deltaTime, 0, doctor.transform.position.z);
        }
        else if (Input.GetKey(KeyCode.D)) {

            doctor.transform.position = new Vector3(doctor.transform.position.x + speed * Time.deltaTime, 0, doctor.transform.position.z);
        }
    
    }
}
