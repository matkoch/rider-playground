namespace Refactoring
{
    public class Legacy
    {
        private string myKey = "key";

        public void Foo (bool flag)
        {
            System.String a = WhatAreWeDoing(myKey, true, 1);

            if (flag) DoConditionally(); DoAlways();

            if (!flag)
                DoConditionally();
            DoAlways();
        }

        void DoAlways()
        {
        }

        void DoConditionally()
        {
        }

        string WhatAreWeDoing (string key, bool enableSearch, int retryCount)
        {
            return null;
        }
    }

    public class Controller
    {
    }

    public class Manager
    {
    }

    public class Container
    {
    }

    public enum Type
    {
    }

    public delegate void Handler();

    public interface IMessageSink
    {
    }
}
