namespace FlappyBlazor.Models
{
    public class Bird
    {
        public int DistanceFromGround { get; set; } = 100;

        public void Fall(int gravity)
        {
            DistanceFromGround -= gravity;
        }
    }
}