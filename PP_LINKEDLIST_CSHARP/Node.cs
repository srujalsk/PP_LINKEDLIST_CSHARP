﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LINKEDLIST_CSHARP
{
    public class Node<T>
    {
        #region Variables & Properties
        /// <summary>
        /// Two private variables that will be used as follows
        /// 1. Data of Generic type 
        /// 2. Next node which will refer to next linked node.
        /// </summary>
        private T _Data;
        private Node<T> _Next;
        private Node<T> _FirstNode;

        /// <summary>
        /// Public properties which will be used to access the required data from Node Object.
        /// </summary>
        public T Data {
            get { return _Data; }
            set { _Data = value; }
        }

        /// <summary>
        /// Public properties which will be used to access the required data from Node Object.
        /// </summary>
        public Node<T> Next {
            get { return _Next; }
            set {
                _Next = value;
                if (value != null)
                    value._FirstNode = this.FirstNode;
                else
                    FirstNode = this;
            }
        }

        public Node<T> FirstNode
        {
            get { return _FirstNode; }
            set { _FirstNode = value; }
        }

        #endregion

        #region Constructors
        /// <summary>
        /// Node Object Data Input for it to be initialized
        /// </summary>
        /// <param name="Data">Data parameter will be stored in the object</param>
        public Node(T Data)
        {
            this.Data = Data;
            Next = null;
        }

        /// <summary>
        /// Node Object Data input can be initialized with both the inputs as well
        /// </summary>
        /// <param name="Data">Data parameter will be stored in the object</param>
        /// <param name="Next">Next Linked Node Object will be stored</param>
        public Node(T Data, Node<T> Previous)
        {
            this.Data = Data;
            Previous.Next = this;
        }

        #endregion

        #region Public Methods
        public override string ToString()
        {
            return _Data.ToString();
        }

        public string ListToString()
        {
            Node<T> n1 = FirstNode;
            StringBuilder sb = new StringBuilder();

            while(true)
            {
                sb.Append(n1.ToString());
                if (n1.Next != null)
                    sb.Append(" -> ");
                else
                    break;
                n1 = n1.Next;
            }

            return sb.ToString();
        }

        #endregion

    }
}
