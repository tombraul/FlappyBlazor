namespace FlappyBlazor.Models
{
    public class GameManager
    {
        public Bird Bird { get; set; }

        public GameManager()
        {
            Bird = new Bird();
        }
    }
}