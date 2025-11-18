using InventoryConsoleApp.BLL;
using InventoryConsoleApp.Core.Enums;

namespace InventoryConsoleApp.Core
{
    public class InventoryManager()
    {
        private static void InitializeInventory(Inventory inventory)
        {
            var props = new Dictionary<string, object>
            {
                ["instrumentType"] = InstrumentName.GUITAR,
                ["builder"] = Builder.COLLINGS,
                ["model"] = "CJ",
                ["type"] = InstrumentType.ACOUSTIC,
                ["numStrings"] = 6,
                ["topWood"] = Wood.INDIAN_ROSEWOOD,
                ["backWood"] = Wood.SITKA
            };
            inventory.AddInstrument("11277", 3999.95, new InstrumentSpecs(props));

            props["builder"] = Builder.MARTIN;
            props["model"] = "D-18";
            props["topWood"] = Wood.MAHOGANY;
            props["backWood"] = Wood.ADIRONDACK;
            inventory.AddInstrument("122784", 5495.95, new InstrumentSpecs(props));

            props["builder"] = Builder.FENDER;
            props["model"] = "Stratocaster";
            props["type"] = InstrumentType.ELECTRIC;
            props["topWood"] = Wood.ALDAR;
            props["backWood"] = Wood.ALDAR;
            inventory.AddInstrument("V95693", 1499.95, new InstrumentSpecs(props));
            inventory.AddInstrument("V9512", 1549.95, new InstrumentSpecs(props));

            props["builder"] = Builder.GIBSON;
            props["model"] = "Les Paul";
            props["topWood"] = Wood.MAPLE;
            props["backWood"] = Wood.MAPLE;
            inventory.AddInstrument("70108276", 2295.95, new InstrumentSpecs(props));

            props["model"] = "SG '61 Reissue";
            props["topWood"] = Wood.MAHOGANY;
            props["backWood"] = Wood.MAHOGANY;
            inventory.AddInstrument("82765501", 1890.95, new InstrumentSpecs(props));

            props["instrumentType"] = InstrumentName.MANDOLIN;
            props["type"] = InstrumentType.ACOUSTIC;
            props["model"] = "F-5G";
            props["backWood"] = Wood.MAPLE;
            props["topWood"] = Wood.MAPLE;
            // Mandolin doesn’t have numStrings  remove it
            props.Remove("numStrings");
            inventory.AddInstrument("9019920", 5495.99, new InstrumentSpecs(props));

            props["instrumentType"] = InstrumentName.BANJO;
            props["model"] = "RB-3 Wreath";
            // Banjos don't have topWood  remove it
            props.Remove("topWood");
            props["numStrings"] = 5;
            inventory.AddInstrument("8900231", 2945.95, new InstrumentSpecs(props));
        }

        public static void Start()
        {
            Inventory inventory = new();
            InitializeInventory(inventory);
            var specs = new Dictionary<string, object>
            {
                { "builder", Builder.GIBSON },
                { "backWood", Wood.MAPLE }
            };
            var matchedInstruments = inventory.Search(new InstrumentSpecs(specs));
            Console.WriteLine(matchedInstruments.Count);
            if (matchedInstruments.Count < 1)
            {
                Console.WriteLine("Sorry, We don't found any for you");
            }
            else
            {
                Console.WriteLine("You might like these instruments");
                foreach (var instrument in matchedInstruments)
                {
                    var instrumentSpecs = instrument.GetSpecs();
                    var instrumentType =
                        instrumentSpecs.GetStringValue("instrumentType") ?? "Instrument";

                    Console.WriteLine($"We have a {instrumentType} with the following properties");

                    foreach (var property in instrumentSpecs.GetAllProperties())
                    {
                        if (property.Key == "instrumentType")
                            continue;
                        Console.WriteLine(
                            $"{property.Key} : {instrumentSpecs.GetStringValue(property.Key)}"
                        );
                    }
                    Console.WriteLine($"You can have this for ${instrument.GetPrice()}");
                    Console.WriteLine("----");
                }
            }
        }
    }
}
