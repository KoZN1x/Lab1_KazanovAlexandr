namespace Lab1_KazanovAlexandr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var Bool = new Bool();
            Bool.OperatorsCheck(true, false);
            var Byte = new Byte();
            Byte.OperatorsCheck(1, 2);
            var SByte = new SByte();
            SByte.OperatorsCheck(1, 2);
            var Short = new Short();
            Short.OperatorsCheck(1, 2);
            var UShort = new UShort(); 
            UShort.OperatorsCheck(1, 2);
            var Int = new Int();
            Int.OperatorsCheck(1, 2);
            var UInt = new UInt();
            UInt.OperatorsCheck(1, 2);
            var Long = new Long();
            Long.OperatorsCheck(1, 2);
            var ULong = new ULong();
            ULong.OperatorsCheck(1, 2);
            var Double = new Double();
            Double.OperatorsCheck(1, 2);
            var Float = new Float();
            Float.OperatorsCheck(1, 2);
            var Char = new Char();
            Char.OperatorsCheck('1', '2');
        }
    }
}