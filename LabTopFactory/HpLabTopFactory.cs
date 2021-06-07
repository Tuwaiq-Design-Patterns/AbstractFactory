namespace LabTopFactory
{
    public class HpLabTopFactory : ILapTopFactory
    {
        public I2In1LapTop Make2In1LapTop()
        {
            return new Hp2In1LapTopFactory();
        }

        public INormalLapTop MakeNormalLapTop()
        {
            return new HpNormalLabTopFactory();
        }
    }
}