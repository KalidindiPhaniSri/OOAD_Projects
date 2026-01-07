using WarGameFramework.Modules.Units;

namespace WarGameFramework.Tests.Units
{
    public class UnitGroupTests
    {
        [Fact]
        public void AddUnit_ToUnitsGroup()
        {
            var group = new UnitGroup();
            group.AddUnit(new Unit(1));
            var unit = group.GetUnitById(1);
            Assert.NotNull(unit);
            Assert.Equal(1, unit.GetId());
        }

        [Fact]
        public void Add_Null_ToUnitsGroup_ThrowException()
        {
            var group = new UnitGroup();
            void act() => group.AddUnit(null);
            Assert.Throws<ArgumentNullException>(act);
        }

        [Fact]
        public void Remove_Existed_Unit_FromUnitsGroup()
        {
            var group = new UnitGroup();
            group.AddUnit(new Unit(1));
            group.RemoveUnitById(1);
            Assert.Null(group.GetUnitById(1));
        }

        [Fact]
        public void GetAllUnits_AddedTo_UnitGroup()
        {
            var group = new UnitGroup();
            group.AddUnit(new Unit(1));
            group.AddUnit(new Unit(2));
            Assert.Equal(2, group.GetUnits().Count);
        }

        [Fact]
        public void Add_DuplicateUnitsWithSameId_To_UnitGroup()
        {
            var group = new UnitGroup();
            group.AddUnit(new Unit(1));
            group.AddUnit(new Unit(1));
            Assert.Single(group.GetUnits());
        }
    }
}
