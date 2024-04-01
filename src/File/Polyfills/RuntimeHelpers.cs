#if NETFRAMEWORK
namespace System.Runtime.CompilerServices
{
    public static class RuntimeHelpers
    {
        // For a value of type System.Range to be used in an array element access expression, the following member must be present:
        public static T[] GetSubArray<T>(T[] array, System.Range range);
    }
}
#endif
