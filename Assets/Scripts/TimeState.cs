public abstract class TimeState
{
    public abstract void Update();
}

public class InClass : TimeState
{
    public override void Update()
    {
        Core.UI.output_remain_time = "지금 수업 중입니다!";
    }
}

public class Before : TimeState
{
    private double remain;

    public Before(double remain)
    {
        this.remain = remain;
    }

    public override void Update()
    {
        Core.UI.output_remain_time = $"수업 시작 전까지 {(int) remain}분 남았습니다.";
    }
}
