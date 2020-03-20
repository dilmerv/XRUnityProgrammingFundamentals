using Assets.Scripts.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public string VRControllerTest { get; set; }

    void Awake()
    {
        //Debug = Class
        //Debug.Log = Method
        Debug.Log("Awake executed...");

        Player player = new Player();
        player.FullName = "John Doe";
        player.Email = "johndoe@gmail.com";
        player.Age = 25;
        player.UserName = "johndoe";
        player.Weight = 234.2M;

        Debug.Log(player);


        Debug.Log("player.GetFullNameAndUsername()");
        Debug.Log(player.GetFullNameAndUsername());

        player.TookHit();

        player.TookHitIncremental();

        player.TookHit(5);

        VRController leftController = new VRController();
        leftController.IsLeftController = true;
        leftController.Platform = "Left Oculus Quest";

        Debug.Log(leftController);

        VRController rightController = new VRController();
        rightController.IsRightController = true;
        rightController.Platform = "Right Oculus Quest";

        Debug.Log(rightController);
    }

    void Start()
    {
        Debug.Log("Start executed...");
    }

    void Update()
    {
        // Debug.Log("Update executed at: " + Time.deltaTime);
    }
}
