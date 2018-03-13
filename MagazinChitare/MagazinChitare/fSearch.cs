using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MagazinChitare
{
    public partial class fSearch : Form
    {
        Inventory inv;
        internal Inventory Inv { get => inv; set => inv = value; }

        public fSearch()
        {
            InitializeComponent();
            cbTipChitara.Items.Add(Type.Electrica);
            cbTipChitara.Items.Add(Type.Acustica);
            cbTipChitara.Items.Add(Type.PeAburi);
            cbTipChitara.SelectedIndex = 0;
            cbLemnFata.Items.Add(Wood.Stejar);
            cbLemnFata.Items.Add(Wood.Brad);
            cbLemnFata.Items.Add(Wood.Molid);
            cbLemnFata.SelectedIndex = 0;
            cbLemnSpate.Items.Add(Wood.Stejar);
            cbLemnSpate.Items.Add(Wood.Brad);
            cbLemnSpate.Items.Add(Wood.Molid);            
            cbLemnSpate.SelectedIndex = 0;
            cbConstructor.Items.Add(Builder.Romchitara);
            cbConstructor.Items.Add(Builder.Chitaro);            
            cbConstructor.Items.Add(Builder.MelodiaSA);
            cbConstructor.SelectedIndex = 0;
        }
        

        private void biesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bCauta_Click(object sender, EventArgs e)
        {
            List<Guitar> rezultate;
            rezultate = inv.Search(new GuitarSpec((Builder)cbConstructor.SelectedItem, tbModel.Text, (Type)cbTipChitara.SelectedItem, (Wood)cbLemnSpate.SelectedItem, (Wood)cbLemnFata.SelectedItem));
            if (rezultate.Count == 0)
            {
                rtbRezultat.Text = "Ne pare rau, nu am gasit nici o chitara conform criteriilor date.";
            }
            else
            {
                if (rezultate.Count == 1)
                    rtbRezultat.Text = "Am gasit urmatoarea chitara: \n";
                else
                    rtbRezultat.Text = "Am gasit urmatoarele chitare: \n";
                rtbRezultat.Text += "******************************\n";
                for (int i=0; i< rezultate.Count; i++)
                {
                    rtbRezultat.Text += "Constructor: " + Enum.GetName(typeof(Builder), rezultate[i].Spec.Builder) + "\n"
                        + "Tip chitara: " + Enum.GetName(typeof(Type),rezultate[i].Spec.Type) + "\n"
                        + "Model: " + rezultate[i].Spec.Model + "\n"
                        + "Lemn fata: " + Enum.GetName(typeof(Wood),rezultate[i].Spec.TopWood) + "\n"
                        + "Lemn spate: " + Enum.GetName(typeof(Wood), rezultate[i].Spec.BackWood) + "\n"
                        + "Numar serie: " + rezultate[i].SerialNumber + "\n"
                        + "Pentru numai: " + rezultate[i].Price + "lei; \n"
                        + "******************************\n";
                }
            }
        }


    }
}
