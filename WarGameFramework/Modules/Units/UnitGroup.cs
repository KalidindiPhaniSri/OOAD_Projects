namespace WarGameFramework.Modules.Units
{
    public class UnitGroup
    {
        private List<Unit> _unitGroup =  [ ];

        public void AddUnit(Unit? unit)
        {
            ArgumentNullException.ThrowIfNull(unit);

            if (_unitGroup.Any(x => x.GetId() == unit.GetId()))
                return;
            _unitGroup.Add(unit);
        }

        public Unit? GetUnitById(int id)
        {
            return _unitGroup.FirstOrDefault(x => x.GetId() == id);
        }

        public void RemoveUnitById(int id)
        {
            _unitGroup.RemoveAll(x => x.GetId() == id);
        }

        public IReadOnlyList<Unit> GetUnits()
        {
            return _unitGroup;
        }
    }
}
