using UnityEngine;
using UnityEngine.UI;

public class Hamster : MonoBehaviour
{
    [Header("Movement")]

    [Tooltip("How far the hamster can travel laterally in either direction. This should probably stay put as its hardcoded based on the current wheel size")]
    [SerializeField] float xAllowance = 9;
    [SerializeField] float horizontalSpeed = 7.5f;

    [Header("Sound")]
    [SerializeField] AudioClip carrotSound;
    [SerializeField] AudioClip jumpSound;

    [SerializeField] AudioClip scorchedSound;
    [SerializeField] AudioClip splatSound;

    [SerializeField] new BoxCollider collider;


    private Animator animator;
    private AudioSource sound;

    Wheel wheel;

    ParticleSystem splatter;

    public int carrots = 0;

    private bool waitingForNextLevel = false;

    public Animator[] carrotControllers;

    private bool cantDie = false;

    private int carrotJumpIndex;

    Animator fade;
    void Start()
    {
        fade = FindObjectOfType<FadePanel>().GetComponent<Animator>();
        animator = GetComponent<Animator>();
        sound = GetComponent<AudioSource>();
        wheel = FindObjectOfType<Wheel>();
        splatter = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!waitingForNextLevel) ProcessInput();

        DebugLevelSelect();
    }

    void ProcessInput()
    {
        if (Input.GetKeyDown(KeyCode.Space)) Jump();
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) MoveRight();
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)) MoveLeft();
    }

    void Jump()
    {
        animator.Play("Jump");
    }

    public void PlayJumpSound()
    {
        sound.PlayOneShot(jumpSound);
    }

    void MoveRight()
    {
        float x = horizontalSpeed * Time.deltaTime;
        float proposedXPos = x + transform.position.x;
        x = proposedXPos > xAllowance ? x - (proposedXPos - xAllowance) : x;

        transform.Translate(Vector3.right * x);
    }

    void MoveLeft()
    {
        float x = horizontalSpeed * Time.deltaTime;
        float proposedXPos = transform.position.x - x;

        x = proposedXPos < -xAllowance ? x - (-xAllowance - proposedXPos) : x;

        transform.Translate(Vector3.left * x);
    }

    void DebugLevelSelect()
    {
        for (int i = 1; i < 10; i++)
        {
            if (Input.GetKeyDown($"[{i}]"))
            {
                Levels.StartLevel(i - 1);
            }
        }
    }

    public void GetCarrot()
    {
        carrotControllers[carrots].Play("SlideCarrot");
        sound.PlayOneShot(carrotSound);
        carrots++;

        if (carrots == 5)
        {
            cantDie = true;
            Pause();
            Invoke("LoadNextScene", 3f);
            PlayCarrotJump();
        }
    }


    void PlayCarrotJump()
    {
        carrotControllers[carrotJumpIndex].Play("JumpCarrot");

        if (carrotJumpIndex < carrotControllers.Length - 1)
        {
            carrotJumpIndex++;
            Invoke("PlayCarrotJump", .2f);
        }
    }

    private void LoadNextScene()
    {
        Levels.loadNext = true;
        fade.Play("FadeOut");
    }

    public void Splat()
    {
        if (!waitingForNextLevel)
        {
            Pause();
            // todo - blood splat + sound
            SkinnedMeshRenderer mesh = GetComponentInChildren<SkinnedMeshRenderer>();
            mesh.enabled = false;
            collider.enabled = false;
            sound.PlayOneShot(splatSound);
            splatter.Play();
            Invoke("Die", 2f);
        }

    }

    public void Scorch()
    {
        if (!waitingForNextLevel)
        {
            sound.PlayOneShot(scorchedSound);
            SkinnedMeshRenderer mesh = GetComponentInChildren<SkinnedMeshRenderer>();
            Material charred = Resources.Load("Materials/Flamer") as Material;
            mesh.material = charred;
            Pause();

            Invoke("Die", 2f);
        }

    }

    private void Die()
    {
        if (!cantDie) fade.Play("FadeOut");
    }

    private void Pause()
    {
        animator.SetBool("noAnims", true);
        waitingForNextLevel = true;
        Invoke("StopWheel", .25f);
    }

    private void StopWheel()
    {
        wheel.speed = 0f;
    }
}
