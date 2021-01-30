using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace _02._2_CanRack
{
    class CanRack
    {
        private const int EmptyBin = 0;
        private const int BinSize = 3;

        private int regular = EmptyBin;
        private int orange = EmptyBin;
        private int lemon = EmptyBin;

        private const int DummyArgunment = 0;
        // Constructor for a can rack. The rack starts out full
        public CanRack()
        {
            FillTheCanRack();
        }
        // This method adds a can of the specified flavor to the rack.
        public void AddACanOf(string FlavorOfCanToBeAdded)
        {
            FlavorOfCanToBeAdded = FlavorOfCanToBeAdded.ToUpper();
            Debug.WriteLine("adding a can of {0} flavored soda to the Rack");
            if (FlavorOfCanToBeAdded == "REGULAR") regular = regular + 1;
            else if (FlavorOfCanToBeAdded == "ORANGE") orange = orange + 1;
            else if (FlavorOfCanToBeAdded == "LEMON") lemon = lemon + 1;
            else Debug.WriteLine("Error: Atempt to add an unknown flavor {0}");
        }
        // This method will remove a can of the specified flavor from the rack.
        public void RemoveACanOf(string FlavorOfCanToBeRemoved)
        {
            FlavorOfCanToBeRemoved = FlavorOfCanToBeRemoved.ToUpper();
            Debug.WriteLine("removing a can of {0} flavored soda from the Rack");
            if (FlavorOfCanToBeRemoved == "REGULAR") regular = regular - 1;
            else if (FlavorOfCanToBeRemoved == "ORANGE") orange = orange - 1;
            else if (FlavorOfCanToBeRemoved == "LEMON") lemon = lemon - 1;
            else Debug.WriteLine("Error: Is not possible remove an unknown flavor {0}");
        }
        // This method will fill the can rack.
        public void FillTheCanRack()
        {
            Debug.WriteLine("Filling the can Rack");
            regular = BinSize;
            orange = BinSize;
            lemon = BinSize;
        }
        // This public void will empty the rack of a given flavor.
        public void EmptyCanRackOf(string FlavorOfBinToBeEmptied)
        {
            FlavorOfBinToBeEmptied = FlavorOfBinToBeEmptied.ToUpper();
            Debug.WriteLine("Emptying can rack of flavor {0}", FlavorOfBinToBeEmptied);
            if (FlavorOfBinToBeEmptied == "REGULAR") regular = EmptyBin;
            else if (FlavorOfBinToBeEmptied == "ORANGE") orange = EmptyBin;
            else if (FlavorOfBinToBeEmptied == "LEMON") lemon = EmptyBin;
            else Debug.WriteLine("Error: Atempt to empty rack of unknown flavor {0}");
        }
        // OPTIONAL – returns true if the rack is full of a specified flavor // false otherwise
        public Boolean IsFull(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            Boolean result = false;
            Debug.WriteLine("Checking if can is full of flavor {0}", FlavorOfBinToCheck);
            if (FlavorOfBinToCheck == "REGULAR") result = regular == BinSize;
            else if (FlavorOfBinToCheck == "ORANGE") result = orange == BinSize;
            else if (FlavorOfBinToCheck == "LEMON") result = lemon == BinSize;
            else Debug.WriteLine("Error: Atempt to check status of unknown flavor {0}");
            return result;
        }

        public Boolean IsEmpty(string FlavorOfBinToCheck)
        {
            FlavorOfBinToCheck = FlavorOfBinToCheck.ToUpper();
            Boolean result = false;
            Debug.WriteLine("Checking if can is empty of flavor {0}", FlavorOfBinToCheck);
            if (FlavorOfBinToCheck == "REGULAR") result = regular == EmptyBin;
            else if (FlavorOfBinToCheck == "ORANGE") result = orange == EmptyBin;
            else if (FlavorOfBinToCheck == "LEMON") result = lemon == EmptyBin;
            else Debug.WriteLine("Error: Atempt to check status of unknown flavor {0}");
            return result;
        }
    }
}
