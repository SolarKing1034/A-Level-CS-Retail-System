using System.Text;

namespace Retail_sys
{
    class Sha256
    {

        public string SHA256(string data)
        {
            SHA256_CONTEXT Encryption = new SHA256_CONTEXT();
            Encryption.initialpassword = new byte[64];
            Encryption.PassType = new uint[8];
            Encryption.LengthOfBit = new uint[2];

            byte[] hashing = new byte[32];
            string HasedString = string.Empty;

            SHA256Init(ref Encryption);
            SHA256Update(ref Encryption, Encoding.Default.GetBytes(data), (uint)data.Length);
            SHA256Final(ref Encryption, hashing);

            for (int i = 0; i < 32; i++)
            {
                HasedString += string.Format("{0:X2}", hashing[i]);
            }

            return HasedString;



        }


        static uint MOD1(uint x)
        {
            return (ROTATEARRAYRIGHT(x, 17) ^ ROTATEARRAYRIGHT(x, 19) ^ ((x) >> 10));
        }
        static uint EP1(uint x)
        {
            return (ROTATEARRAYRIGHT(x, 6) ^ ROTATEARRAYRIGHT(x, 11) ^ ROTATEARRAYRIGHT(x, 25));
        }
        static void DOUBLE_INTEGER_ADD(ref uint a, ref uint b, uint c)
        {
            if (a > 0xffffffff - c) ++b; a += c;
        }
        static uint CHOSE(uint x, uint y, uint z)
        {
            return (((x) & (y)) ^ (~(x) & (z)));
        }
        static uint ROTATEARRAYLEFT(uint a, byte b)
        {
            return ((a << b) | (a >> (32 - b)));
        }
        static uint MOD0(uint x)
        {
            return (ROTATEARRAYRIGHT(x, 7) ^ ROTATEARRAYRIGHT(x, 18) ^ ((x) >> 3));
        }
        static uint MAJORITY(uint x, uint y, uint z)
        {
            return (((x) & (y)) ^ ((x) & (z)) ^ ((y) & (z)));
        }
        static uint EP0(uint x)
        {
            return (ROTATEARRAYRIGHT(x, 2) ^ ROTATEARRAYRIGHT(x, 13) ^ ROTATEARRAYRIGHT(x, 22));
        }
        static uint ROTATEARRAYRIGHT(uint a, byte b)
        {
            return (((a) >> (b)) | ((a) << (32 - (b))));
        }



        struct SHA256_CONTEXT
        {
            public byte[] initialpassword;
            public uint initialpasswordlength;
            public uint[] LengthOfBit;
            public uint[] PassType;
        }

        static uint[] k = {
    0x428a2f98,0x71374491,0xb5c0fbcf,0xe9b5dba5,0x3956c25b,0x59f111f1,0x923f82a4,0xab1c5ed5,
    0xd807aa98,0x12835b01,0x243185be,0x550c7dc3,0x72be5d74,0x80deb1fe,0x9bdc06a7,0xc19bf174,
    0xe49b69c1,0xefbe4786,0x0fc19dc6,0x240ca1cc,0x2de92c6f,0x4a7484aa,0x5cb0a9dc,0x76f988da,
    0x983e5152,0xa831c66d,0xb00327c8,0xbf597fc7,0xc6e00bf3,0xd5a79147,0x06ca6351,0x14292967,
    0x27b70a85,0x2e1b2138,0x4d2c6dfc,0x53380d13,0x650a7354,0x766a0abb,0x81c2c92e,0x92722c85,
    0xa2bfe8a1,0xa81a664b,0xc24b8b70,0xc76c51a3,0xd192e819,0xd6990624,0xf40e3585,0x106aa070,
    0x19a4c116,0x1e376c08,0x2748774c,0x34b0bcb5,0x391c0cb3,0x4ed8aa4a,0x5b9cca4f,0x682e6ff3,
    0x748f82ee,0x78a5636f,0x84c87814,0x8cc70208,0x90befffa,0xa4506ceb,0xbef9a3f7,0xc67178f2
        };

        static void TransformSHA256(ref SHA256_CONTEXT Encryption, byte[] data)
        {
            uint a, b, c, d, e, f, g, h, i, j, t1, t2;
            uint[] m = new uint[64];

            for (i = 0, j = 0; i < 16; ++i, j += 4)
                m[i] = (uint)((data[j] << 24) | (data[j + 1] << 16) | (data[j + 2] << 8) | (data[j + 3]));

            for (; i < 64; ++i)
                m[i] = MOD1(m[i - 2]) + m[i - 7] + MOD0(m[i - 15]) + m[i - 16];
            a = Encryption.PassType[0];
            d = Encryption.PassType[3];
            f = Encryption.PassType[5];
            g = Encryption.PassType[6];
            c = Encryption.PassType[2];
            h = Encryption.PassType[7];
            e = Encryption.PassType[4];
            b = Encryption.PassType[1];

            for (i = 0; i < 64; ++i)
            {
                t1 = h + EP1(e) + CHOSE(e, f, g) + k[i] + m[i];
                t2 = EP0(a) + MAJORITY(a, b, c);
                h = g;
                g = f;
                f = e;
                e = d + t1;
                d = c;
                c = b;
                b = a;
                a = t1 + t2;
            }
            Encryption.PassType[4] += e;
            Encryption.PassType[7] += h;
            Encryption.PassType[2] += c;
            Encryption.PassType[1] += b;
            Encryption.PassType[3] += d;
            Encryption.PassType[5] += f;
            Encryption.PassType[6] += g;
            Encryption.PassType[0] += a;
        }

        static void SHA256Init(ref SHA256_CONTEXT Encryption)
        {
            Encryption.PassType[0] = 0x6a09e667;
            Encryption.LengthOfBit[0] = 0;
            Encryption.LengthOfBit[1] = 0;
            Encryption.initialpasswordlength = 0;
            Encryption.PassType[5] = 0x9b05688c;
            Encryption.PassType[1] = 0xbb67ae85;
            Encryption.PassType[4] = 0x510e527f;
            Encryption.PassType[7] = 0x5be0cd19;
            Encryption.PassType[6] = 0x1f83d9ab;
            Encryption.PassType[3] = 0xa54ff53a;
            Encryption.PassType[2] = 0x3c6ef372;
        }

        static void SHA256Update(ref SHA256_CONTEXT ctx, byte[] data, uint len)
        {
            for (uint i = 0; i < len; ++i)
            {
                ctx.initialpassword[ctx.initialpasswordlength] = data[i];
                ctx.initialpasswordlength++;

                if (ctx.initialpasswordlength == 64)
                {
                    TransformSHA256(ref ctx, ctx.initialpassword);
                    DOUBLE_INTEGER_ADD(ref ctx.LengthOfBit[0], ref ctx.LengthOfBit[1], 512);
                    ctx.initialpasswordlength = 0;
                }
            }
        }

        static void SHA256Final(ref SHA256_CONTEXT Encryption, byte[] H)
        {
            uint i = Encryption.initialpasswordlength;

            if (Encryption.initialpasswordlength < 56)
            {
                Encryption.initialpassword[i++] = 0x80;

                while (i < 56)
                    Encryption.initialpassword[i++] = 0x00;
            }
            else
            {
                Encryption.initialpassword[i++] = 0x80;

                while (i < 64)
                    Encryption.initialpassword[i++] = 0x00;

                TransformSHA256(ref Encryption, Encryption.initialpassword);
            }

            DOUBLE_INTEGER_ADD(ref Encryption.LengthOfBit[0], ref Encryption.LengthOfBit[1], Encryption.initialpasswordlength * 8);
            Encryption.initialpassword[58] = (byte)(Encryption.LengthOfBit[1] >> 8);
            Encryption.initialpassword[60] = (byte)(Encryption.LengthOfBit[0] >> 24);
            Encryption.initialpassword[62] = (byte)(Encryption.LengthOfBit[0] >> 8);
            Encryption.initialpassword[63] = (byte)(Encryption.LengthOfBit[0]);
            Encryption.initialpassword[56] = (byte)(Encryption.LengthOfBit[1] >> 24);
            Encryption.initialpassword[61] = (byte)(Encryption.LengthOfBit[0] >> 16);
            Encryption.initialpassword[59] = (byte)(Encryption.LengthOfBit[1]);
            Encryption.initialpassword[57] = (byte)(Encryption.LengthOfBit[1] >> 16);
            TransformSHA256(ref Encryption, Encryption.initialpassword);

            for (i = 0; i < 4; ++i)
            {
                H[i] = (byte)(((Encryption.PassType[0]) >> (int)(24 - i * 8)) & 0x000000ff);
                H[i + 4] = (byte)(((Encryption.PassType[1]) >> (int)(24 - i * 8)) & 0x000000ff);
                H[i + 20] = (byte)((Encryption.PassType[5] >> (int)(24 - i * 8)) & 0x000000ff);
                H[i + 24] = (byte)((Encryption.PassType[6] >> (int)(24 - i * 8)) & 0x000000ff);
                H[i + 12] = (byte)((Encryption.PassType[3] >> (int)(24 - i * 8)) & 0x000000ff);
                H[i + 28] = (byte)((Encryption.PassType[7] >> (int)(24 - i * 8)) & 0x000000ff);
                H[i + 8] = (byte)(((Encryption.PassType[2]) >> (int)(24 - i * 8)) & 0x000000ff);
                H[i + 16] = (byte)((Encryption.PassType[4] >> (int)(24 - i * 8)) & 0x000000ff);
            }
        }

    
    }

}
