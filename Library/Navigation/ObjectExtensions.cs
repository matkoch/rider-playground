using System.Diagnostics;

namespace Library.Navigation
{
    public static class ObjectExtensions
    {
        public static T NotNull<T> (
            this T obj,
            string condition = null)
            where T : class
        {
            Trace.Assert(obj != null, condition ?? "obj != null");
            return obj;
        }
    }
}