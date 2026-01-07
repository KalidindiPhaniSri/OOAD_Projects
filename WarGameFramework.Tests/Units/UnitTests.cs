using WarGameFramework.Modules.Units;
using Xunit;

namespace WarGameFramework.Tests.Units
{
    public class UnitTests
    {
        [Fact]
        public void SetName_GetName_ReturnsSameValue()
        {
            var unit = new Unit(1);
            unit.SetName("War Game");
            var name = unit.GetName();
            Assert.Equal("War Game", name);
        }

        [Fact]
        public void Set_Get_UnitSpecific_Property()
        {
            var unit = new Unit(1);
            unit.SetProperty("Hit Points", 25);
            Assert.Equal(25, unit.GetProperty("Hit Points"));
        }

        [Fact]
        public void Change_Existed_Property_Value()
        {
            var unit = new Unit(1);
            unit.SetProperty("Hit Points", 25);
            unit.SetProperty("Hit Points", 15);
            Assert.Equal(15, unit.GetProperty("Hit Points"));
        }

        [Fact]
        public void Get_NonExisted_Value()
        {
            var unit = new Unit(1);
            Assert.Equal("", unit.GetName());
        }

        [Fact]
        public void Get_Id_Property()
        {
            var unit = new Unit(1);
            Assert.Equal(1, unit.GetId());
        }

        [Fact]
        public void Get_Set_Weapons_Property()
        {
            var unit = new Unit(1);
            var weapon = new Dictionary<string, object> { { "Name", "Sword" }, { "Damage", 25 } };
            unit.SetWeapon(weapon);
            Assert.Single(unit.GetWeapons());
            Assert.Equal(weapon, unit.GetWeapons()[0]);
        }
    }
}
