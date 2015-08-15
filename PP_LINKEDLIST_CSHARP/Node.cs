using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP_LINKEDLIST_CSHARP
{
    /// <summary>
    /// This is the Node Class which is used to store object which you would like to store in Linked List
    /// </summary>
    /// <typeparam name="T">Used to initialize the type of object which will be stored in Linked List</typeparam>
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

        /// <summary>
        /// Public properties which will be used to access the required data from Node Object.
        /// </summary>
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
        /// Node Object Data input can be initialized and its Previous Node Linking can be initialized as well
        /// </summary>
        /// <param name="Data">Data parameter will be stored in the object</param>
        /// <param name="Previous">Previous Linked Node Object will be stored</param>
        public Node(T Data, Node<T> Previous)
        {
            this.Data = Data;
            Previous.Next = this;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Overridden ToString Method to display data as output in string
        /// </summary>
        /// <returns>String value of Data</returns>
        public override string ToString()
        {
            return _Data.ToString();
        }

        /// <summary>
        /// This method will convert complete List in String Format and then will be displayed
        /// </summary>
        /// <returns>String form of complete List</returns>
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
