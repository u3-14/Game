using UnityEngine;

public class ChangeManager : MonoBehaviour
{
    public GameObject dressRoom;
    private Animator anim;

    private void Start()
    {
        anim = dressRoom.GetComponent<Animator>();
    }

    public void OnOff()
    {
        anim.SetTrigger("IsTriggered");
    }
}
