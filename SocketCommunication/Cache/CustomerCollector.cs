using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;

namespace SocketCommunication.Cache
{
    public class CustomEventArgs : EventArgs
    {
        private Customer _customer;

        public Customer _Customer
        {
            get { return _customer; }
            set { _customer = value; }
        }

    }
    public class CustomerCollector
    {
        public static event EventHandler<CustomEventArgs> OnAddEventHandler = null;
        public static event EventHandler<CustomEventArgs> OnRemoveEventHandler = null;
        /// <summary>
        /// 
        /// </summary>
        private static List<Customer> _customers;
        /// <summary>
        /// 
        /// </summary>
        public static List<Customer> _Customers
        {
            get { return _customers; }
            set { _customers = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        public static void Init()
        {
            _Customers = new List<Customer>();
        }
        /// <summary>
        /// 
        /// </summary>
        private static Customer newCustomer = null;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oldCustomer"></param>
        /// <returns></returns>
        private static bool existContent(Customer oldCustomer)
        {
            Console.WriteLine("以下为检测是否存在该customer");

            return ((newCustomer._UId == oldCustomer._UId) &&
                (newCustomer.IPAddress == oldCustomer.IPAddress) &&
                (newCustomer.Port == oldCustomer.Port));
                
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        public static Customer IsExist(Customer customer)
        {
            #region
            lock(customer)
            { 
                newCustomer = customer;
                if (_Customers.Count > 0)
                    return _Customers.Find(existContent);
                else
                    return null;
            }
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        private static string _findUid = "";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="oldCustomer"></param>
        /// <returns></returns>
        private static bool matchUID(Customer oldCustomer)
        {
            #region

            return (_findUid == oldCustomer._UId.ToString());
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="UId"></param>
        /// <returns></returns>
        public static List<Customer> FindCustomers(string UId)
        {
            #region
            _findUid = UId;
            return _Customers.FindAll(matchUID);
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        public static void Add(Customer customer)
        {
            #region
            _Customers.Add(customer);
            if(OnAddEventHandler != null)
                OnAddEventHandler(null, new CustomEventArgs { _Customer = customer });
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        public static void Remove(Customer customer)
        {
            #region
            foreach (Customer temp in _customers)
            {
                if (temp._UId == customer._UId &&
                    temp.IPAddress == customer.IPAddress &&
                    temp.Port == customer.Port)
                {
                    if (OnRemoveEventHandler != null)
                        OnRemoveEventHandler(null, new CustomEventArgs { _Customer = temp });
                    _customers.Remove(temp);

                    break;
                }
            }
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="customerSocket"></param>
        public static void Remove(Socket customerSocket)
        {
            #region
            System.Net.IPEndPoint endremotepoint = (System.Net.IPEndPoint)customerSocket.RemoteEndPoint;
            string ipaddress = "";
            int port = -1;
            ipaddress = endremotepoint.Address.ToString();
            port = endremotepoint.Port;
            foreach (Customer temp in _customers)
            {
                if (temp.IPAddress == ipaddress &&
                    temp.Port == port)
                {
                    if (OnRemoveEventHandler != null)
                        OnRemoveEventHandler(null, new CustomEventArgs { _Customer = temp });
                    _customers.Remove(temp);
                    break;
                }
            }
            #endregion
        }
        /// <summary>
        /// 
        /// </summary>
        public static void ViewToConsole()
        {
            Console.Write(ToString());
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static string ToString()
        {
            #region
            StringBuilder str = new StringBuilder();
            object[] param = new object[5];
            foreach (Customer temp in _customers)
            {
                param[0] = temp._UId;
                param[1] = temp.IPAddress;
                param[2] = temp.Port;
                param[3] = temp._LogonTime;
                param[4] = temp._UpdateTime;

                str.AppendLine(string.Format("UID:{0},IPAddress:{1},ClientPort:{2},LoginTime:{3},UpdateTime:{4}",
                    param));
            }
            return str.ToString();
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="customer"></param>
        public static void UpdateUserTime(Customer customer)
        {
            #region
            lock (typeof(CustomerCollector))
            { 
                Customer findcustomer = CustomerCollector.IsExist(customer);
                if (findcustomer != null)
                    findcustomer._UpdateTime = DateTime.Now;
            }
            #endregion
        }
        
    }
}
