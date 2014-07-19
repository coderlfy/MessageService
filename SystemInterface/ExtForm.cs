using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

namespace SystemInterface
{
    public class ExtForm : Form
    {
        /// <summary>
        /// 参数串，格式“abc=12-bcd=23”
        /// </summary>
        private string _tag;

        public string _Tag
        {
            get { return _tag; }
            set { _tag = value; }
        }
        /// <summary>
        /// 为窗口属性赋值
        /// </summary>
        /// <param name="extForm"></param>
        protected void AssignToParams(ExtForm extForm)
        {
            #region
            this.split();
            object setforobj = extForm;
            foreach (DictionaryEntry temp in _params)
            {
                string key = temp.Key.ToString();
                int pointindex = key.IndexOf('.');
                PropertyInfo infor = null;
                if (pointindex == -1)
                {
                    infor = extForm.GetType()
                        .GetProperty(temp.Key.ToString());
                }
                else
                {
                    string firstlevelproperty = key.Substring(0, pointindex);
                    string secondlevelproperty = key.Substring(pointindex + 1, key.Length - pointindex - 1);
                    PropertyInfo tempinfor = extForm.GetType()
                        .GetProperty(firstlevelproperty);

                    setforobj = tempinfor.GetValue(extForm, null);
                    infor = tempinfor.PropertyType.GetProperty(secondlevelproperty);

                }

                if (infor != null)
                    infor.SetValue(setforobj,
                        Convert.ChangeType(temp.Value, infor.PropertyType),
                        null);
            }
            #endregion
        }
        /// <summary>
        /// 分割参数串
        /// </summary>
        private void split()
        {
            #region
            string[] expressions = this._Tag.Split('-');

            foreach (string temp in expressions)
            {
                int splitindex = temp.IndexOf('=');
                string propertyname = "", value = "";
                if (splitindex != -1)
                {
                    propertyname = temp.Substring(0, splitindex);
                    value = temp.Substring(splitindex + 1, temp.Length - splitindex - 1);
                    Console.WriteLine("propertyname={0};value={1}", propertyname, value);
                    if (!_params.ContainsKey(propertyname))
                        _params.Add(propertyname, value);
                }

            }
            #endregion
        }
        /// <summary>
        /// 属性与值列表
        /// </summary>
        private Hashtable _params = new Hashtable();
    }
}
