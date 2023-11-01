using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceDemo
{
    internal interface IShape
    {
        //private int id;

        //public int Id
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        //public int id { get; set; }
        //public int MyProperty { get; private set; }

        public void GetDimensions();
        public void CalculateArea();
        public void DisplayArea();
    }
    class Square : IShape
    {
        public void CalculateArea()
        {
            throw new NotImplementedException();
        }

        public void DisplayArea()
        {
            throw new NotImplementedException();
        }

        public void GetDimensions()
        {
            throw new NotImplementedException();
        }
    }

    class Triangle : IShape
    {
        void IShape.CalculateArea()
        {
            throw new NotImplementedException();
        }

        void IShape.DisplayArea()
        {
            throw new NotImplementedException();
        }

        void IShape.GetDimensions()
        {
            throw new NotImplementedException();
        }
    }

    interface IA
    {
        public void A();
        public void B();
    }

    interface IB
    {
        public void C();
        public void A();
    }

    class Demo : IA, IB
    {
        public void A()
        {
            throw new NotImplementedException();
        }

        public void B()
        {
            throw new NotImplementedException();
        }

        void IB.A()
        {
            throw new NotImplementedException();
        }

        void IB.C()
        {
            throw new NotImplementedException();
        }
    }

}









