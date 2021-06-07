namespace LabTopFactory
{
    public class MicrosoftLabTopFactory : ILapTopFactory
    {
        public I2In1LapTop Make2In1LapTop()
        {
            return new Microsoft2In1LapTopFactory();
        }

        public INormalLapTop MakeNormalLapTop()
        {
            return new MicrosoftNormalLabTop();
        }
    }
}