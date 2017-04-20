﻿using System;
using System.Collections.Generic;
using System.Linq;
using Campy.Utils;
using Swigged.LLVM;

namespace Campy.LCFG
{
    public class Value : IComparable
    {
        private ValueRef _value_ref;

        public ValueRef V
        {
            get { return _value_ref; }
            set { _value_ref = value; }
        }

        private Type _type;

        public Type T
        {
            get { return _type; }
            set { _type = value; }
        }

        public Value(ValueRef v)
        {
            _value_ref = v;
            TypeRef t = LLVM.TypeOf(v);
            _type = new Type(t);
        }

        public virtual int CompareTo(object obj)
        {
            throw new ArgumentException("Unimplemented in derived type.");
        }

        public override bool Equals(object obj)
        {
            throw new ArgumentException("Unimplemented in derived type.");
        }

        public static bool Equals(object obj1, object obj2) /* override */
        {
            throw new ArgumentException("Unimplemented in derived type.");
        }
    }


}
