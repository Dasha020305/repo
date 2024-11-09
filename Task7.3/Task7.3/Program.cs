using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите позицию белой ладьи");
            var whiteRookPosition = Console.ReadLine();

            Console.WriteLine("Введите позицию черного коня");
            var blackKnightPosition = Console.ReadLine();

            if (whiteRookPosition == blackKnightPosition)
            {
                Console.WriteLine("Черный конь не может стоять на этой клетке");
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Введите ход белой ладьи");
            var move = Console.ReadLine();

            if (IsWhiteRookCanMove(move, whiteRookPosition, blackKnightPosition))
                Console.WriteLine("Ход разрешен");
            else
                Console.WriteLine("Ход запрещен");

            Console.ReadKey();
        }

        static bool IsWhiteRookStrike(string whiteRookPosition, string position)
        {
            int wr, wc, pr, pc;
            DecodePosition(whiteRookPosition, out wc, out wr);
            DecodePosition(position, out pc, out pr);
            return (wr == pr || wc == pc);
        }

        static bool IsWhiteRookCanMove(string move, string whiteRookPosition, string blackKnightPosition)
        {
            return IsWhiteRookMoveCorrect(move, whiteRookPosition) &&
                   !IsWhiteRookUnderStrike(move, blackKnightPosition);
        }

        static bool IsWhiteRookMoveCorrect(string move, string whiteRookPosition)
        {
            int wc, wr, mc, mr;
            DecodePosition(whiteRookPosition, out wc, out wr);
            DecodePosition(move, out mc, out mr);

            return move != whiteRookPosition && (wc == mc || wr == mr);
        }

        static bool IsWhiteRookUnderStrike(string move, string blackKnightPosition)
        {
            int bc, br, mc, mr;
            DecodePosition(blackKnightPosition, out bc, out br);
            DecodePosition(move, out mc, out mr);

            return ((Math.Abs(mc - bc) == 2 && Math.Abs(mr - br) == 1) ||
                    (Math.Abs(mc - bc) == 1 && Math.Abs(mr - br) == 2));
        }

        static void DecodePosition(string position, out int column, out int row)
        {
            row = int.Parse(position[1].ToString());
            column = (int)position[0] - 0x60;
        }
    }
}