using BehavioralDesignPatterns.ChainOfResponsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehavioralDesignPatterns.Command
{
    public class Client
    {
        public static void Execute()
        {
            var garden = new Garden(2);

            var commandPlantTree = new GardenCommand(garden, GardenActions.Plant, "tree");
            var commandPlantFlowers = new GardenCommand(garden, GardenActions.Plant, "flowers");
            var commandRemovetTree = new GardenCommand(garden, GardenActions.Remove, "tree");

            var plantTreeButton = new CommandsInvoker(commandPlantTree);
            var plantFlowersButton = new CommandsInvoker(commandPlantFlowers);
            var removeTreeButton = new CommandsInvoker(commandRemovetTree);


            Console.WriteLine(garden.ToString());
            removeTreeButton.Invoke();
            plantTreeButton.Invoke();
            plantTreeButton.Invoke();

            Console.WriteLine(garden.ToString());

            CommandsInvoker.Undo();
            CommandsInvoker.Undo();
            CommandsInvoker.Undo();
            CommandsInvoker.Undo();
            Console.WriteLine(garden.ToString());


        }
    }
}
