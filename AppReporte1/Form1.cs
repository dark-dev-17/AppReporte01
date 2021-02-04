using AppReporte1.Logic.Controllers;
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

namespace AppReporte1
{
    public partial class Form1 : Form
    {
        protected Generacion Generacion;
        public Form1()
        {
            InitializeComponent();
            groupBox3.Visible = false;
            Generacion = new Generacion();
            lab_estatus.Text = "Bienvenido a reportes 1.0!";
        }

        public async Task Generar()
        {
            if (DateTime.Parse(Dat_inicio.Value.ToString("yyy-MM-dd")) > DateTime.Parse(Dat_fin.Value.ToString("yyy-MM-dd")))
            {
                lab_estatus.Text = "Error, la fecha de inicio es mayor a la fecha de termino!";
            }


            MemoryStream myStream = new MemoryStream(); ;
            TipoReporte tipoReporte = TipoReporte.Inventario;
            await Task.Run(() =>
            {
                try
                {
                    lab_estatus.Invoke(new Action(() => lab_estatus.Text = "Generando reporte"));

                    if (Opt_inventario.Checked)
                        tipoReporte = TipoReporte.Inventario;
                    else if (Opt_VentasEjectuvio.Checked)
                        tipoReporte = TipoReporte.VentasEjecutivo;
                    else if (Opt_VentasArticulos.Checked)
                        tipoReporte = TipoReporte.VentasProducto;

                    myStream = Generacion.FillInVentario(
                        Opt_fibremex.Checked ? Sociedad.Fibremex : Sociedad.Optronics,
                        tipoReporte,
                        DateTime.Parse(Dat_inicio.Value.ToString("yyy-MM-dd")),
                        DateTime.Parse(Dat_fin.Value.ToString("yyy-MM-dd"))
                    );

                    lab_estatus.Invoke(new Action(() => lab_estatus.Text = "Terminando reporte"));
                }
                catch (DbManagerDark1.Exceptions.DarkExceptionSystem ex)
                {
                    lab_estatus.Invoke(new Action(() => lab_estatus.Text = ex.Message));
                }
                catch (DbManagerDark1.Exceptions.DarkExceptionUser ex)
                {
                    lab_estatus.Invoke(new Action(() => lab_estatus.Text = ex.Message));
                }
            });

            lab_estatus.Text = "Guardando reporte";
            SaveFileDialog saveFileDialog1 = new SaveFileDialog
            {
                Title = "Guardar reporte",
                Filter = ".xlsx Files (*.xlsx)|*.xlsx",
                FileName = $"{(tipoReporte == TipoReporte.Inventario ? (Opt_fibremex.Checked ? "Fib" : "Opt") : "Gen")}_{tipoReporte.ToString()}_{DateTime.Now.ToString("yyyyMMddHHmmss")}",
                OverwritePrompt = true,
            };
            // If the file name is not an empty string open it for saving.
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllBytes(saveFileDialog1.FileName, myStream.ToArray());
            }
            lab_estatus.Text = "Complete!";

        }

        private async void Btn_exportar_Click(object sender, EventArgs e)
        {
            await Generar();
        }

        public void ValidOptiosn(object sender, EventArgs e)
        {
            if(Opt_VentasArticulos.Checked || Opt_VentasEjectuvio.Checked)
            {
                groupBox3.Visible = true;
                Opt_fibremex.Checked = true;
                Opt_optronics.Checked = true;

                Opt_fibremex.Enabled = false;
                Opt_optronics.Enabled = false;
            }
            else
            {
                groupBox3.Visible = false;

                Opt_fibremex.Checked = true;
                Opt_optronics.Checked = false;

                Opt_fibremex.Enabled = true;
                Opt_optronics.Enabled = true;
            }
        }
    }
}
