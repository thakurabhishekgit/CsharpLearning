using System;

namespace DataTypes
{
    class DataTypesClass
    {
        public static void ShowDataTypes()
        {
            //Integer types 
            // sbyte sb = -128; // 8-bit signed integer 1 byte 
            // byte b = 255; // 8-bit unsigned integer 1 byte
            // short s = -32768; // 16-bit signed integer  2 bytes
            // ushort us = 65535; // 16-bit unsigned integer   2 bytes
            // int i = -2147483648; // 32-bit signed integer   4 bytes
            // uint ui = 4294967295; // 32-bit unsigned integer    4 bytes
            // long l = -9223372036854775808; // 64-bit signed integer 8 bytes
            // ulong ul = 18446744073709551615; // 64-bit unsigned integer 8 bytes

            int ia = -100;
            uint iaa = 100;
            Console.WriteLine($"Integer max and min = {int.MaxValue} and {int.MinValue}");

            long bigNumber = 9223372036L; // 64-bit signed integer
            Console.WriteLine($"Long max and min = {long.MaxValue} and {long.MinValue}");

            
        }
    }
}