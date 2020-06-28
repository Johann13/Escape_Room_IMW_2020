public class MainDoor : DoorAnimator
{
    public GameManager GameManager;

    public override bool CanOpenDoor()
    {
        return isInRange && GameManager.hasDoorKey;
    }


    public override string OpenMsg()
    {
        if (!GameManager.hasDoorKey)
        {
            return "Search the Door Key";
        }

        if (!GameManager.hasLaptop)
        {
            return "You need your Laptop as well!";
        }

        return base.OpenMsg();
    }
}