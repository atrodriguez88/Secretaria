using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;


namespace DXWindowsApplication1
{
    public partial class Principal : RibbonForm
    {
        int bandera;
        public Principal()
        {
            InitializeComponent();
            InitSkinGallery();
            //InitGrid();           
            //login obj = new login();            
            //obj.ShowDialog();
            //bandera = obj.get();
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void iExit_ItemClick(object sender, ItemClickEventArgs e)
        {
           Close();
        }

        private void iHelp_ItemClick(object sender, ItemClickEventArgs e)
        {
           
            System.Diagnostics.Process.Start(@"C:\Users\Migue\Documents\Visual Studio 2012\Projects\Secretaria\Secretaria\Documentos\Manual de Secretarías.pdf");
        }
        

        private void Form1_Load(object sender, EventArgs e)
        {
                    
            //if (bandera == 2)
            //{
            //   ribbonPageGroup4.Visible = false;
            //   ribbonPageGroup1.Visible = false;
            //   ribbonPageGroup5.Visible = false;
            //   ribbonPageGroup10.Visible = false;
            //   ribbonPageGroup12.Visible = false;
            //}
            //if (bandera == 3)
            //{
            //    this.Close();
            //}
        }

        private void inboxItem_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           
        }

        private void iClose_ItemClick(object sender, ItemClickEventArgs e)
        {
            cambiarContrasena cambiar = new cambiarContrasena();
            cambiar.ShowDialog();
        }

        private void navBarItem1_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void iFind_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Migue\Documents\Visual Studio 2012\Projects\DXWindowsApplication1\DXWindowsApplication1\bin\Documentos\Manual de Secretarías.pdf");
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            nuevo_estudiante ex = new nuevo_estudiante();
            ex.MdiParent = this;
            ex.Show();
            
        }

        private void barButtonItem8_ItemClick(object sender, ItemClickEventArgs e)
        {
            buscar_estudiante bus = new buscar_estudiante();
            bus.MdiParent = this;
            bus.Show();
        }

        private void barButtonItem13_ItemClick(object sender, ItemClickEventArgs e)
        {
            facultadForm fac = new facultadForm();
            fac.MdiParent = this;
            fac.Show();
        }

        private void barButtonItem15_ItemClick(object sender, ItemClickEventArgs e)
        {
            carreraForm car = new carreraForm();
            bool abierto = false;

            if (abierto)
            {
                car.Focus();
            }
            car.MdiParent = this;
            car.Show();
        }

        private void barButtonItem14_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem7_ItemClick(object sender, ItemClickEventArgs e)
        {
            cambiarContrasena cambio = new cambiarContrasena();
            cambio.MdiParent = this;
            cambio.Show();
           
        }

        private void ribbonControl_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void barButtonItem17_ItemClick(object sender, ItemClickEventArgs e)
        {
            

        }

        private void barButtonItem18_ItemClick(object sender, ItemClickEventArgs e)
        {
            planForm plan = new planForm();
            plan.MdiParent = this;
            plan.Show();

        }

        private void barButtonItem21_ItemClick(object sender, ItemClickEventArgs e)
        {
             asignaturaForm asign= new asignaturaForm();
             asign.MdiParent = this;
             asign.Show();
        }

        private void barButtonItem19_ItemClick(object sender, ItemClickEventArgs e)
        {
            buscarAsignatura busAsig = new buscarAsignatura();
            busAsig.MdiParent = this;
            busAsig.Show();
            

        }

        private void ribbonControl_SelectedPageChanged(object sender, EventArgs e)
        {
            if (ribbonControlPrincipal.SelectedPage.Text == "Estudiantes")
            {
                xfEstudiante estud = new xfEstudiante();
                estud.MdiParent = this;
                estud.Show();

            }
        }

        private void barButtonItemBuscarC_ItemClick(object sender, ItemClickEventArgs e)
        {
            buscarCarrera carr = new buscarCarrera();
            carr.MdiParent = this;
            carr.Show();
        }

        private void barButtonItem4_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            buscarFacultad busfac = new buscarFacultad();
            busfac.MdiParent = this;
            busfac.Show();
           
        }

        private void barButtonBuscarPlanDeEstudio_ItemClick(object sender, ItemClickEventArgs e)
        {
            buscarPlan busPlan = new buscarPlan();
            busPlan.MdiParent = this;
            busPlan.Show();
        }

        private void barButtonItem2_ItemClick_1(object sender, ItemClickEventArgs e)
        {
            planaPartirdeOtro plan = new planaPartirdeOtro();
            plan.MdiParent = this;
            plan.Show();
        }

        private void barButtonItem4_ItemClick_2(object sender, ItemClickEventArgs e)
        {
            pendientedePlan p = new pendientedePlan();
            p.MdiParent = this;
            p.Show();

        }

        

      
       

    }
}