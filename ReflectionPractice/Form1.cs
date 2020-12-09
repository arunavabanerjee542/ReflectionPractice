using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace ReflectionPractice
{
    public partial class methodbox : Form
    {
        public methodbox()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchbox_Click(object sender, EventArgs e)
        {

            string classname = classbox.Text;

            Type type = Type.GetType(classname);

           MethodInfo[] methods =  type.GetMethods();

            foreach(MethodInfo m in methods )
            {
                METHODS.Items.Add(m);
            }

            ConstructorInfo[] cons = type.GetConstructors();

            foreach (ConstructorInfo mm in cons )
            {
                constructors.Items.Add(mm.ToString());
            }

            PropertyInfo[] prop = type.GetProperties();

            foreach (PropertyInfo p in prop)
            {
                properties.Items.Add(p);
            }



        }
    }
}
