using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hexadecimal
{
    public class Endian
    {
        public ushort ConvertToBigEndian(ushort littleEndian)
        {
            ushort BigEndian = (ushort)(littleEndian >> 8);
            return BigEndian |= (ushort)(littleEndian << 8);

        }

        public uint ConvertToBigEndian(uint littleEndian)
        {
            uint BigEndian = 0;
            for (int i = 0; i < 4; i++)
            {
                BigEndian |= (uint)(littleEndian & 0x000000ff);
                if (i < 3)
                {
                    BigEndian <<= 8;
                    littleEndian >>= 8;
                }
            }
            return BigEndian;
        }

        public ulong ConvertToBigEndian(ulong littleEndian)
        {
            ulong BigEndian = 0;
            for (int i = 0; i < sizeof(ulong); i++)
            {
                BigEndian |= (uint)(littleEndian & 0x00000000000000ff);
                if (i < sizeof(ulong) - 1)
                {
                    BigEndian <<= 8;
                    littleEndian >>= 8;
                }
            }
            return BigEndian;
        }
    }
}
