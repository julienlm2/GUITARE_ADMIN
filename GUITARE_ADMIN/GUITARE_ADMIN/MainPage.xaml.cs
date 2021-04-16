using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GUITARE_ADMIN
{
    public partial class MainPage : ContentPage
    {

        ServiceReference1.WebService1SoapClient Le_WS;

        public MainPage()
        {
            InitializeComponent();
            Le_WS = new ServiceReference1.WebService1SoapClient(ServiceReference1.WebService1SoapClient.EndpointConfiguration.WebService1Soap12);
            
            


            var commande = new ServiceReference1.Get_Guitare_Result();
            var bois = new ServiceReference1.get_bois_by_id_Result();

            commande = Le_WS.Get_GuitareAsync();

            Etat_commande.Text = commande.Etat_Commande;
            id_Bois.Text = (Le_WS.Get_bois_by_id(commande.idBois).FirstOrDefault().NomBois);
            id_Bois1.Text = (Le_WS.Get_bois_by_id(commande.idBois_1).FirstOrDefault().NomBois);
            id_Bois2.Text = (Le_WS.Get_bois_by_id(commande.idBois_2).FirstOrDefault().NomBois);
            id_Micro.Text = (Le_WS.Get_micro_by_id(commande.idMicro.Value).FirstOrDefault().NomMicro);
            id_Micro1.Text = (Le_WS.Get_micro_by_id(commande.idMicro_1.Value).FirstOrDefault().NomMicro);
            id_Micro2.Text = (Le_WS.Get_micro_by_id(commande.idMicro_2).FirstOrDefault().NomMicro);
            nomVibrato.Text = commande.nomVibrato;
        }
    }
}
