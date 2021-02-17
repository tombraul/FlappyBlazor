namespace FlappyBlazor.Models
{
    public class Bird
    {
        public int DistanceFromGround { get; private set; } = 100;

        public void Fall(int gravity)
        {
            DistanceFromGround -= gravity;
        }
    }
}