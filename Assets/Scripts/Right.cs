public class Right
{
    private ExistState exist;

    public Right()
    {
        exist = new UnExist();
    }

    public void OnGo()
    {
        exist.OnGo();
    }

    public void Update()
    {
        exist = exist.Update();
    }
}