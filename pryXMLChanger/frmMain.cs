using pryXMLChanger.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace pryXMLChanger
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            if (txtDirectorioOriginal.Text != "" && txtDirectorioModificado.Text != "")
            {
                //Extrae la dirección del directorio original y reemplaza las "\" que vienen por default por "\\" que utiliza C#
                string strDirectorioOriginal = txtDirectorioOriginal.Text;
                strDirectorioOriginal = strDirectorioOriginal.Replace(@"\", @"\\");

                //Extrae la dirección del directorio final modificado y reemplaza las "\" que vienen por default por "\\" que utiliza C#
                string strDirectorioModificado = txtDirectorioModificado.Text;
                strDirectorioModificado = strDirectorioModificado.Replace(@"\", @"\\");

                //Verifica que haya un porcentaje ingresado
                if (txtPorcentaje.Text != "")
                {
                    MessageBox.Show("Process started it might take a while depending on your PC, press OK to continue!", "Started", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Carga del types.xml y creación de la lista de nodos
                    XmlDocument docXML = new XmlDocument();

                    docXML.Load(strDirectorioOriginal);

                    XmlNodeList varListaNodosNominal = docXML.DocumentElement.SelectNodes("//nominal");

                    //Extracción del porcentaje ingresado y conversión para multiplicacíón
                    double varPorcentaje = Convert.ToDouble(txtPorcentaje.Text);
                    varPorcentaje = varPorcentaje / 100 + 1;

                    //Para cada nodo de la lista de nodos del types.xml aumenta el nominal de cada tipo de loot por el porcentaje ingresado
                    foreach (XmlNode varNodoNominal in varListaNodosNominal)
                    {
                        double dobNominal = Convert.ToDouble(varNodoNominal.InnerText); //Variable double que almacena el nominal que posteriormente va a ser aumentado
                        dobNominal = dobNominal * varPorcentaje; //Aumento del nominal por el porcentaje ingresado
                        dobNominal = Math.Ceiling(dobNominal); //Redondeo del nominal hacia arriba
                        string strNominalNuevo = Convert.ToString(dobNominal); //Asigno el valor del double dobNominal a una string llamada strNominalNuevo que literalmente va a ser el nuevo nominal aumentado
                        varNodoNominal.InnerText = strNominalNuevo; //Reemplazao del nominal viejo con el aumentado
                        docXML.Save(strDirectorioModificado + "\\types_modified_%" + txtPorcentaje.Text + ".xml"); //Guarda el nominal uno a la vez (¡REVISAR ESTO A LO MEJOR SE PUEDE HACER QUE SE GUARDE TODO JUNTO PORQUE EL PROGRAMA SE PAPEA AL GUARDAR TODO INDIVIDUAL!)
                    }

                    //Selección de nodos del nodo minimum
                    XmlNodeList varListaNodosMin = docXML.DocumentElement.SelectNodes("//min");

                    //Para cada nodo de la lista de nodos del types.xml aumenta el min de cada tipo de loot por el porcentaje ingresado
                    foreach (XmlNode varNodoMin in varListaNodosMin)
                    {
                        double dobMin = Convert.ToDouble(varNodoMin.InnerText); //Variable double que almacena el min que posteriormente va a ser aumentado
                        dobMin = dobMin * varPorcentaje; //Aumento del min por el porcentaje ingresado
                        dobMin = Math.Ceiling(dobMin); //Redondeo del min hacia arriba
                        string strMinNuevo = Convert.ToString(dobMin); //Asigno el valor del double dobMin a una string llamada strNominalNuevo que literalmente va a ser el nuevo nominal aumentado
                        varNodoMin.InnerText = strMinNuevo; //Reemplazao del min viejo con el aumentado
                        docXML.Save(strDirectorioModificado + "\\types_modified_%" + txtPorcentaje.Text + ".xml"); //Guarda el min uno a la vez (¡REVISAR ESTO A LO MEJOR SE PUEDE HACER QUE SE GUARDE TODO JUNTO PORQUE EL PROGRAMA SE PAPEA AL GUARDAR TODO INDIVIDUAL!)
                    }

                    string strDirectorioZombis = strDirectorioModificado + "\\types_modified_%" + txtPorcentaje.Text + ".xml";

                    XmlDocument docXMLZombis = new XmlDocument();

                    docXMLZombis.Load(strDirectorioZombis);

                    XmlNodeList varListaNodosZombis = docXMLZombis.DocumentElement.SelectNodes("type[starts-with(@name,'ZmbF') or starts-with(@name,'ZmbM')]//min");

                    //Resetea el min de los zombis a 1
                    foreach (XmlNode varNodoMinZombis in varListaNodosZombis)
                    {
                        MessageBox.Show(varNodoMinZombis.InnerText);
                        string num = "1";
                        varNodoMinZombis.InnerText = num;
                        docXMLZombis.Save(strDirectorioModificado + "\\types_modified_%" + txtPorcentaje.Text + ".xml"); //Guarda el min uno a la vez (¡REVISAR ESTO A LO MEJOR SE PUEDE HACER QUE SE GUARDE TODO JUNTO PORQUE EL PROGRAMA SE PAPEA AL GUARDAR TODO INDIVIDUAL!)
                    }

                    MessageBox.Show("XML replace process DONE!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information); //Mensaje que notifica que el for finalizó

                    lblEstado.Text = "Process finished go to selected final folder";
                }
                else
                {
                    MessageBox.Show("Percentage field empty, enter a percentage!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //Mensaje en caso de que no ingrese porcentaje
                }
            }
            else
            {
                MessageBox.Show("At least one path field empty, select a path!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error); //Mensaje en caso de que falte un directorio o ambos
            }
        }

        private void txtPorcentaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Prohibición de la entrada de caracteres en el txtPorcentaje que no sean dígitos o de control
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Only accepts numbers!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDirectorio_Click(object sender, EventArgs e)
        {
            //Diálogo para seleccionar la dirección del archivo original funciona parecido al de abrir un frm
            using (OpenFileDialog OpenFileDialog = new OpenFileDialog())
            {
                if (OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDirectorioOriginal.Text = OpenFileDialog.FileName;
                }
            }
        }

        private void btnDirectorioModificado_Click(object sender, EventArgs e)
        {
            //Diálogo para seleccionar la dirección de la carpeta de guardado funciona parecido al de abrir un frm
            using (FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog())
            {
                if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    txtDirectorioModificado.Text = FolderBrowserDialog.SelectedPath;
                }
            }
        }

        private void txtDirectorioOriginal_TextChanged(object sender, EventArgs e)
        {
            if (txtDirectorioOriginal.Text != "")
            {
                txtDirectorioModificado.Enabled = true;
                btnDirectorioModificado.Enabled = true;
                lblDirectorioModificado.Enabled = true;
                if (txtDirectorioModificado.Text != "")
                {
                    lblPorcentaje.Enabled = true;
                    txtPorcentaje.Enabled = true;
                    if (txtPorcentaje.Text != "")
                    {
                        btnAplicar.Enabled = true;
                    }
                }
            }
            else
            {
                txtDirectorioModificado.Enabled = false;
                btnDirectorioModificado.Enabled = false;
                lblDirectorioModificado.Enabled = false;
                lblPorcentaje.Enabled = false;
                txtPorcentaje.Enabled = false;
                btnAplicar.Enabled = false;
            }
        }

        private void txtDirectorioModificado_TextChanged(object sender, EventArgs e)
        {
            if (txtDirectorioModificado.Text != "")
            {
                lblPorcentaje.Enabled = true;
                txtPorcentaje.Enabled = true;
                if (txtPorcentaje.Text != "")
                {
                    btnAplicar.Enabled = true;
                }
            }
            else
            {
                lblPorcentaje.Enabled = false;
                txtPorcentaje.Enabled = false;
                btnAplicar.Enabled = false;
            }
        }

        private void txtPorcentaje_TextChanged(object sender, EventArgs e)
        {
            if (txtPorcentaje.Text != "")
            {
                btnAplicar.Enabled = true;
            }
            else
            {
                btnAplicar.Enabled = false;
            }
        }

        private void btnDescargarOriginal_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog FolderBrowserDialog = new FolderBrowserDialog() {Description = "Select the destination folder for the file"})
            {
                if (FolderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    string strDirectorioTypesOriginal = FolderBrowserDialog.SelectedPath;
                    File.WriteAllText(strDirectorioTypesOriginal + "\\original_types.xml", Resources.original_types);
                    MessageBox.Show("File copied to: " + strDirectorioTypesOriginal, "Copied", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            string strDirectorioOriginal = txtDirectorioOriginal.Text;
            strDirectorioOriginal = strDirectorioOriginal.Replace(@"\", @"\\");

            XmlDocument docXML = new XmlDocument();

            docXML.Load(strDirectorioOriginal);

            string strDirectorioModificado = txtDirectorioModificado.Text;
            strDirectorioModificado = strDirectorioModificado.Replace(@"\", @"\\");


            XmlNodeList varListaNodos = docXML.DocumentElement.SelectNodes("type[starts-with(@name,'ZmbF')]//min");

            //Resetea el min de los zombis a 1
            foreach (XmlNode varNodoMinZombis in varListaNodos)
            {
                varNodoMinZombis.InnerText = "3"; //Reemplazao del min viejo con el aumentado
                docXML.Save(strDirectorioModificado + "\\types_modified_ %" + txtPorcentaje.Text + ".xml"); //Guarda el min uno a la vez (¡REVISAR ESTO A LO MEJOR SE PUEDE HACER QUE SE GUARDE TODO JUNTO PORQUE EL PROGRAMA SE PAPEA AL GUARDAR TODO INDIVIDUAL!)

            }
        }
    }
    }
