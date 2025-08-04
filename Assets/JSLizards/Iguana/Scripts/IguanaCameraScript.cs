//using UnityEngine;
//using System.Collections;

//public class IguanaCameraScript : MonoBehaviour {
//	public GameObject target;
//	public float turnSpeed=.1f;
//	public GameObject iguanaCamera;
//	float cameraAngleX=180f;
//	float cameraAngleY=0f;
//	public float cameraDistance=9f;

//	public void Start(){
//		Quaternion arotation = Quaternion.identity;
//		Vector3 eua = Vector3.zero;
//		eua.y = 360f-cameraAngleY;
//		eua.z = 0f;
//		eua.x = 180f+cameraAngleX;
//		arotation.eulerAngles = eua;
//		transform.localRotation= arotation;
//	}

//	void Update(){
//        //if (Input.GetKey (KeyCode.Mouse1)) {
//        //	cameraAngleY+= Input.GetAxis("Mouse X");
//        //	cameraAngleX+= Input.GetAxis("Mouse Y");
//        //}

//        if (Input.GetKey(KeyCode.Mouse1))
//        {
//            cameraAngleY += Input.GetAxis("Mouse X");
//            cameraAngleX += Input.GetAxis("Mouse Y");

//            // Limit horizontal rotation to -90° to +90°
//            cameraAngleY = Mathf.Clamp(cameraAngleY, -90f, 90f);
//        }
//        CameraRotationX ();
//		CameraRotationY ();
//		cameraDistance=cameraDistance+Input.GetAxis ("Mouse ScrollWheel");
//		iguanaCamera.transform.localPosition = new Vector3 (0,cameraDistance,-2f*cameraDistance);
//	}

//	//public void TargetSet(GameObject aTarget){
//	//	target = aTarget;
//	//}

//	public void CameraRotationX(){
//		Quaternion arotation = Quaternion.identity;
//		Vector3 eua = Vector3.zero;
//		eua.y = 360f-cameraAngleY;
//		eua.z = 0f;
//		eua.x = 180f+cameraAngleX;
//		arotation.eulerAngles = eua;
//		transform.localRotation= arotation;
//	}
//	public void CameraRotationY(){
//		Quaternion arotation = Quaternion.identity;
//		Vector3 eua = Vector3.zero;
//		eua.y = 360f-cameraAngleY;
//		eua.z = 0f;
//		eua.x = 180f+cameraAngleX;
//		arotation.eulerAngles = eua;
//		transform.localRotation= arotation;
//	}
//	void FixedUpdate(){
//		transform.position = Vector3.Lerp (transform.position,target.transform.position,Time.deltaTime*10f);
//	}
//}

using UnityEngine;

public class IguanaCameraScript : MonoBehaviour
{
    public Transform target;         // Drag the iguana Root here
    public Transform iguanaCamera;   // Drag the Camera here
    public float rotationSpeed = 3f;
    public float cameraDistance = 9f;

    private float cameraAngleY = 0f;

    void Update()
    {
        // 1. Always follow the iguana's position
        transform.position = target.position;

        // 2. Rotate horizontally with mouse movement
        float mouseX = Input.GetAxis("Mouse X");
        cameraAngleY += mouseX * rotationSpeed;

        // Only horizontal rotation
        transform.rotation = Quaternion.Euler(0f, cameraAngleY, 0f);

        // 3. Position the camera behind the iguana
        iguanaCamera.localPosition = new Vector3(0, cameraDistance, -2f * cameraDistance);
    }
}