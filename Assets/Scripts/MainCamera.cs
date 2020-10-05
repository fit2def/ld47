using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour
{
    // Start is called before the first frame update
    Animator animator;

    GameObject instructions;

    UpdateLevelNumber levelText;

    void Start()
    {
        animator = GetComponent<Animator>();
        levelText = FindObjectOfType<UpdateLevelNumber>();
        instructions = GameObject.FindGameObjectWithTag("InstructionsImage");

        levelText.gameObject.SetActive(false);

        if (!Levels.gameJustStarted)
        {
            animator.Play("Init");
            levelText.gameObject.SetActive(true);
            instructions.SetActive(false);
        }
    }

    void Update()
    {
        if (Levels.gameJustStarted && Input.GetKeyDown(KeyCode.Return))
        {
            animator.Play("CameraStart");
            Levels.gameJustStarted = false;
            levelText.gameObject.SetActive(true);
            instructions.SetActive(false);
            FindObjectOfType<RowStamper>().Init();
        }
    }
}
