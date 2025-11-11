using InventoryConsoleApp.Core.Enums;

namespace InventoryConsoleApp.BLL
{
    public abstract class InstrumentSpecs(
        string model,
        Builder builder,
        InstrumentType type,
        Wood backwood,
        Wood topwood
    )
    {
        private string _model = model;
        private Builder _builder = builder;
        private InstrumentType _type = type;
        private Wood _backwood = backwood;
        private Wood _topwood = topwood;

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
            return _backwood.ToString();
        }

        public string GetBackWood()
        {
            return _topwood.ToString();
        }

        public virtual bool Matches(InstrumentSpecs otherSpecs)
        {
            if (_builder != otherSpecs._builder)
                return false;
            if (!_model.Equals(otherSpecs._model))
                return false;
            if (_type != otherSpecs._type)
                return false;
            if (_backwood != otherSpecs._backwood)
                return false;
            if (_topwood != otherSpecs._topwood)
                return false;
            return true;
        }
    }
}
