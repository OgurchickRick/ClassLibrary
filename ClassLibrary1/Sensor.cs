namespace ClassLibrary1
{
    public class Sensor
    {
        private int value { get; set; }

        public Sensor()
        {
        }

        public void SetValue(int v)
        {
            value = v;
        }

        public int GetValue() 
        {
            return value;
        }
    }
}