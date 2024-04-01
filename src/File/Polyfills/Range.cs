#if NETFRAMEWORK
namespace System
{
    // The .. syntax for System.Range will require the System.Range type, as well as one or more of the following members:
    public readonly struct Range
    {
        public Range(System.Index start, System.Index end);
        public static Range StartAt(System.Index start);
        public static Range EndAt(System.Index end);
        public static Range All { get; }
    }
}
#endif
