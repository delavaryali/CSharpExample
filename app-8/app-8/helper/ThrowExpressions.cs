using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_8
{
    internal class ThrowExpressions
    {
        private static int ThrowUsageInAnExpression(int value = 40)
        {
            return value < 20 ? value : throw new ArgumentOutOfRangeException("Argument value must be less than 20");
        }
    }




    public class MyApiType
    {
        private object _loadedResource;
        private object _someProperty;

        public MyApiType()
        {
            _loadedResource = LoadResource();
            if (_loadedResource == null) throw new InvalidOperationException();
        }

        public object SomeProperty
        {
            get
            {
                return _someProperty;
            }

            set
            {
                if (value == null) throw new ArgumentNullException();
                _someProperty = value;
            }
        }

        private object LoadResource() 
        {
            return null;
        }
    }


    public class MyApiType2
    {
        private static object LoadResource()
        {
            return null;
        }

        private object _loadedResource = LoadResource() ?? throw new InvalidOperationException();
        private object _someProperty;

        public object SomeProperty
        {
            get
            {
                return _someProperty;
            }
            set
            {
                _someProperty = value ?? throw new ArgumentNullException();
            }
        }

       
    }


    public class MyApiType3
    {
        private static object LoadResource()
        {
            return null;
        }

        private object _loadedResource = LoadResource() ?? throw new InvalidOperationException();
        private object _someProperty;

        public object SomeProperty
        {
            get => _someProperty;
            set => _someProperty = value ?? throw new ArgumentNullException();
        }
    }



}
