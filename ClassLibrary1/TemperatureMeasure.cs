namespace ClassLibrary1
{
    public class TemperatureMeasure : ITemperatureMeasure
    {
        private Sensor history { get; set; }
        private MeasureCount measure { get; set; }
        
        public TemperatureMeasure(Sensor sensor)
        {
            history = sensor;
            measure = new MeasureCount();

        }

        public void SetValue()
        {
            throw new NotImplementedException();
        }

        public int GetValue()
        {
            throw new NotImplementedException();
        }
    }
}
