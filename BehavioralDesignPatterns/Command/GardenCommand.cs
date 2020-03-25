using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Command
{
    public class GardenCommand : ICommand
    {
        private Garden _garden;
        private GardenActions _gardenAction;
        private string _plant;

        public GardenCommand(Garden garden, GardenActions gardenAction, string plant)
        {
            _garden = garden;
            _gardenAction = gardenAction;
            _plant = plant;
        }

        public bool Execute()
        {
            if (_gardenAction == GardenActions.Plant)
               return _garden.Plant(_plant);
            else
                return _garden.Remove(_plant);
        }

        public void Undo()
        {
            if (_gardenAction == GardenActions.Plant)
                _garden.Remove(_plant);
            else
                _garden.Plant(_plant);
        }
    }
}
