namespace ParametricFunctionPlot
{
    public class ParametricPoint
    {
        public double T { get; set; }
        public double XFromT { get; set; }
        public double YFromT { get; set; }
        public double XFromY { get; set; }
        public double YFromX { get; set; }

        public object this[string propertyName]
        {
            get { return this.GetType().GetProperty(propertyName).GetValue(this, null); }
            set { this.GetType().GetProperty(propertyName).SetValue(this, value, null); }
        }
    }
}
