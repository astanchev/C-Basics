using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemontNaPlochki
{
    class RemontNaPlochki
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Въведете дължина на страна от площадката: ");
            double sideLenght = double.Parse(Console.ReadLine());
            //Console.WriteLine("Въведете широчина на една плочка: ");
            double widthTile = double.Parse(Console.ReadLine());
            //Console.WriteLine("Въведете дължина на една плочка: ");
            double lenghtTile = double.Parse(Console.ReadLine());
            //Console.WriteLine("Въведете широчина на пейката: ");
            double widthBench = double.Parse(Console.ReadLine());
            //Console.WriteLine("Въведете дължина на пейката: ");
            double lenghtBench = double.Parse(Console.ReadLine());
            double numberTiles = ((sideLenght* sideLenght) - (widthBench * lenghtBench)) / (widthTile* lenghtTile);
            double timeForWork = numberTiles * 0.2;
            Console.WriteLine(/*"Необходимите плочки са: {0}", */numberTiles);
            Console.WriteLine(/*"Необходимите време е: {0}", */timeForWork);

        }
    }
}
