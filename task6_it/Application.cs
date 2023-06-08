using Microsoft.VisualBasic;
using System.Diagnostics;
using System.Reflection;

namespace task6_it
{
    public partial class Application : Form
    {
        List<Type> loadedTypes = new();
        object currObj;


        public Application()
        {
            InitializeComponent();
        }

        private void openbtn_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pathInp.Text = openFileDialog.FileName;
                    
                }
            }
        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            string assemblyPath = "D:\\cloned_repos\\task5_it\\task5_it\\bin\\Debug\\net6.0\\task5_it.dll";
            string interfaceName = "IFiber";
            loadedTypes.Clear();

            Assembly assembly = Assembly.LoadFrom(assemblyPath);

            Type[] types = assembly.GetTypes();

            Type[] interfaceImplementations = types
                .Where(t => t.IsClass && !t.IsAbstract && t.GetInterface(interfaceName) != null)
                .ToArray();

            List<string> classNames = new List<string>();
            foreach (Type implementation in interfaceImplementations)
            {
                classNames.Add(implementation.Name);
                loadedTypes.Add(implementation);
            }
            dropdown.DataSource = classNames;
        }

        private void dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            methodListBox.Items.Clear();
            outputTextBox.Clear();
            currObj = null;

            Type selectedClass = loadedTypes[dropdown.SelectedIndex];

            MethodInfo[] methods = selectedClass.GetMethods();
            methodListBox.Items.AddRange(methods.Select(m => m.Name).ToArray());
        }

        private void executeMethod_Click(object sender, EventArgs e)
        {
            MethodInfo selectedMethod = loadedTypes[dropdown.SelectedIndex].GetMethod(methodListBox.SelectedItem.ToString());

            ParameterInfo[] parameters = selectedMethod.GetParameters();

            object[] arguments = new object[parameters.Length];

            for (int i = 0; i < parameters.Length; i++)
            {
                string userInput = Interaction.InputBox($"Enter parameter {parameters[i].Name}:");
                arguments[i] = Convert.ChangeType(userInput, parameters[i].ParameterType);
            }

            object result = selectedMethod.Invoke(currObj, arguments);
            if (result != null)
            {
                outputTextBox.Text += result.ToString() + "\n";

            }
        }

        private void createObj_Click(object sender, EventArgs e)
        {
            Type selectedClass = loadedTypes[dropdown.SelectedIndex];

            string value = textInput.Text;
            int number = (int)numericInput.Value;

            currObj = Activator.CreateInstance(selectedClass, new object[] { value, number });

            outputTextBox.Text += currObj.ToString() + "\n";
        }
    }
}