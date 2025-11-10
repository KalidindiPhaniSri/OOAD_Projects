using InventoryConsoleApp.Core.Enums;

namespace InventoryConsoleApp.BLL
{
    public abstract class InstrumentSpecs(
        string model,
        Builder builder,
        InstrumentType type,
        Wood wood
    )
    {
        private string _model = model;
        private Builder _builder = builder;
        private InstrumentType _type = type;
        private Wood _wood = wood;

        public string GetModel()
        {
            return _model;
        }

        public string GetBuilder()
        {
            return _builder.ToString();
        }

        public string GetInstrumentType()
        {
            return _type.ToString();
        }

        public string GetTopWood()
        {
            return _wood.ToString();
        }

        public string GetBackWood()
        {
            return _wood.ToString();
        }
    }
}
