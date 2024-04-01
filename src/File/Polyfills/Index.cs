#if NETFRAMEWORK
namespace System
{
    public readonly struct Index
    {
        // To use the "hat" operator (^), the following is required:
        public Index(int value, bool fromEnd);

        // To use the System.Index type as an argument in an array element access, the following member is required:
        int GetOffset(int length);
    }
}
#endif
