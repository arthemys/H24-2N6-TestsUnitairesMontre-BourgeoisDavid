using System.Windows.Forms;

namespace ApplicationMontre
{
    public partial class FrmPrincipal : Form
    {
        public const string APP_INFO = "(Solution)";

        private Montre m_objMontre;

        //==================================
        public FrmPrincipal()
        {
            InitializeComponent();
            Text += APP_INFO;

            m_objMontre = new Montre(9, 05, 42);

            txtAffichageMontre.Text = m_objMontre.ObtenirTempsCourant();
        }

        //============================================================================
        // Evénement associé au tick de l'horloge. À chaque tick, on avance d'une seconde.
        private void btnAvancer_Click(object sender, System.EventArgs e)
        {
            m_objMontre.AvancerUneSeconde();
            txtAffichageMontre.Text = m_objMontre.ObtenirTempsCourant();
        }

        //============================================================================
        private void btnDemarrerArreterHorloge_Click(object sender, System.EventArgs e)
        {
            tmrHorloge.Enabled = !tmrHorloge.Enabled;
        }

        //============================================================================
        private void btnInitialiserMontre_Click(object sender, System.EventArgs e)
        {
            m_objMontre.Heures = 59;
            m_objMontre.Minutes = 59;
            m_objMontre.Secondes = 59;

            txtAffichageMontre.Text = m_objMontre.ObtenirTempsCourant();
        }
        //============================================================================
        private void mnuFichierQuitter_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
