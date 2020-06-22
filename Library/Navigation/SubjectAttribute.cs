using System;

namespace Library.Navigation
{
    public class SubjectAttribute : Attribute
    {
        public SubjectAttribute(params Type[] types)
        {

        }
    }
}