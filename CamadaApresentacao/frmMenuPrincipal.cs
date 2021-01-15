using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;


namespace CamadaApresentacao
{
    public partial class frmMenuPrincipal : Form
    {
        public string IdFuncionario { get; internal set; }
        public string Nome { get; internal set; }
        public string Sobrenome { get; internal set; }
        public string Acesso { get; internal set; }

        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnProdutos_Click(object sender, EventArgs e)
        {
            subMenuProdutos.Visible = true;
            btnProdutos.BackColor = Color.Blue;

            subMenuVendas.Visible = false;
            SubMenuCompras.Visible = false;
            SubMenuSistema.Visible = false;
            SubMenuConfiguracoes.Visible = false;
            SubMenuFerramentas.Visible = false;
            SubMenuConsultas.Visible = false;

            subMenuVendas.Hide();
            SubMenuCompras.Hide();
            SubMenuSistema.Hide();
            SubMenuConfiguracoes.Hide();
            SubMenuFerramentas.Hide();
            SubMenuConsultas.Hide();

            btnVendas.BackColor = Color.Transparent;
            btnCompras.BackColor = Color.Transparent;
            btnSistema.BackColor = Color.Transparent;
            btnFerramentas.BackColor = Color.Transparent;
            btnConfiguracoes.BackColor = Color.Transparent;
            btnConsultas.BackColor = Color.Transparent;
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }     
               
        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }      
                      
        private void btnVendas_Click(object sender, EventArgs e)
        {
            subMenuVendas.Visible = true;
            btnVendas.BackColor = Color.Blue;

            btnProdutos.BackColor = Color.Transparent;
            btnCompras.BackColor = Color.Transparent;
            btnSistema.BackColor = Color.Transparent;
            btnConfiguracoes.BackColor = Color.Transparent;
            btnConsultas.BackColor = Color.Transparent;
            btnFerramentas.BackColor = Color.Transparent;

            subMenuProdutos.Hide();
            SubMenuCompras.Hide();
            SubMenuSistema.Hide();
            SubMenuConfiguracoes.Hide();
            SubMenuConsultas.Hide();
            SubMenuFerramentas.Hide();
        }
        private void btnVendasProduto_Click(object sender, EventArgs e)
        {
            subMenuVendas.Visible = false;
            subMenuVendas.Hide();
            frmVenda frm = frmVenda.GetInstancia();
            frm.ShowDialog();
            frm.idfuncionario = Convert.ToInt32(this.IdFuncionario);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            subMenuVendas.Visible = false;
            subMenuVendas.Hide();

            frmCliente frm = new frmCliente();
            frm.ShowDialog();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            SubMenuCompras.Visible = true;
            btnCompras.BackColor = Color.Blue;

            btnProdutos.BackColor = Color.Transparent;
            btnVendas.BackColor = Color.Transparent;
            btnSistema.BackColor = Color.Transparent;
            btnConfiguracoes.BackColor = Color.Transparent;
            btnConsultas.BackColor = Color.Transparent;
            btnFerramentas.BackColor = Color.Transparent;

            subMenuVendas.Hide();
            subMenuProdutos.Hide();
            SubMenuSistema.Hide();
            SubMenuConfiguracoes.Hide();
            SubMenuConsultas.Hide();
            SubMenuFerramentas.Hide();
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            SubMenuCompras.Visible = false;
            SubMenuCompras.Hide();

            frmEntrada frm = frmEntrada.GetInstancia();
            frm.Show();
            frm.idfuncionario = Convert.ToInt32(this.IdFuncionario);
                      
        }

      
        private void frmMenuPrincipal_MouseClick(object sender, MouseEventArgs e)
        {
            if (subMenuProdutos.Visible || SubMenuCompras.Visible ||
                subMenuVendas.Visible || SubMenuSistema.Visible ||
                SubMenuConfiguracoes.Visible || SubMenuConsultas.Visible|| SubMenuFerramentas.Visible == true)
            {
                subMenuProdutos.Hide();
                subMenuVendas.Hide();
                SubMenuCompras.Hide();
                SubMenuSistema.Hide();
                SubMenuConfiguracoes.Hide();
                SubMenuConsultas.Hide();
                SubMenuFerramentas.Hide();

                btnProdutos.BackColor = Color.Transparent;
                btnVendas.BackColor = Color.Transparent;
                btnCompras.BackColor = Color.Transparent;
                btnSistema.BackColor = Color.Transparent;
                btnConfiguracoes.BackColor = Color.Transparent;
                btnConsultas.BackColor = Color.Transparent;
                btnFerramentas.BackColor = Color.Transparent;
            }
        }
        private void btnSistema_Click(object sender, EventArgs e)
        {
            SubMenuSistema.Visible = true;
            btnSistema.BackColor = Color.Blue;

            btnProdutos.BackColor = Color.Transparent;
            btnVendas.BackColor = Color.Transparent;
            btnCompras.BackColor = Color.Transparent;
            btnConfiguracoes.BackColor = Color.Transparent;
            btnConsultas.BackColor = Color.Transparent;
            btnFerramentas.BackColor = Color.Transparent;

            subMenuVendas.Hide();
            subMenuProdutos.Hide();
            SubMenuCompras.Hide();
            SubMenuConfiguracoes.Hide();
            SubMenuConsultas.Hide();
            SubMenuFerramentas.Hide();
        }
        private void btnSairSistema_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnConfiguracoes_Click(object sender, EventArgs e)
        {
            SubMenuConfiguracoes.Visible = true;
            btnConfiguracoes.BackColor = Color.Blue;

            btnProdutos.BackColor = Color.Transparent;
            btnVendas.BackColor = Color.Transparent;
            btnSistema.BackColor = Color.Transparent;
            btnCompras.BackColor = Color.Transparent;
            btnConsultas.BackColor = Color.Transparent;
            btnFerramentas.BackColor = Color.Transparent;

            subMenuVendas.Hide();
            subMenuProdutos.Hide();
            SubMenuSistema.Hide();
            SubMenuCompras.Hide();
            SubMenuConsultas.Hide();
            SubMenuFerramentas.Hide();
        }
        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            SubMenuConfiguracoes.Visible = false;
            SubMenuConfiguracoes.Hide();

            frmFuncionario frm = new frmFuncionario();
            frm.ShowDialog();
        }
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            SubMenuConsultas.Visible = true;
            btnConsultas.BackColor = Color.Blue;

            subMenuVendas.Visible = false;
            SubMenuCompras.Visible = false;
            SubMenuSistema.Visible = false;
            SubMenuConfiguracoes.Visible = false;
            subMenuProdutos.Visible = false;
            SubMenuFerramentas.Visible = false;

            subMenuVendas.Hide();
            SubMenuCompras.Hide();
            SubMenuSistema.Hide();
            SubMenuConfiguracoes.Hide();
            subMenuProdutos.Hide();
            SubMenuFerramentas.Hide();

            btnVendas.BackColor = Color.Transparent;
            btnCompras.BackColor = Color.Transparent;
            btnSistema.BackColor = Color.Transparent;
            btnConfiguracoes.BackColor = Color.Transparent;
            btnProdutos.BackColor = Color.Transparent;
            btnFerramentas.BackColor = Color.Transparent;
        }
        private void btnVendaData_Click(object sender, EventArgs e)
        {
            SubMenuConsultas.Visible = false;
            SubMenuConsultas.Hide();
            frmVenda frm = new frmVenda();
            frm.ShowDialog();
            frm.OcultarTab();
        }

        private void btnCompraData_Click(object sender, EventArgs e)
        {
            SubMenuConsultas.Visible = false;
            SubMenuConsultas.Hide();
            frmEntrada frm = new frmEntrada();
            
            frm.ShowDialog();
            frm.OcultarTab();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            
             GestaoUsuario();
             lbNome.Text = Nome.ToLower();
             lbAcesso.Text = Acesso;
        }
        private void GestaoUsuario()
        {
            if (Acesso == "Administrador" || Acesso == "Gerente")
            {
                btnProdutos.Enabled = true;
                btnVendas.Enabled = true;
                btnCompras.Enabled = true;
                btnConfiguracoes.Enabled = true;
                btnSistema.Enabled = true;
                btnConsultas.Enabled = true;
            }
            else if(Acesso == "Vendedor")
            {
                btnProdutos.Enabled = true;
                btnVendas.Enabled = true;
                btnCompras.Enabled = false;
                btnConfiguracoes.Enabled = false;
                btnSistema.Enabled = true;
                btnConsultas.Enabled = true;
            }
        }

        private void btnsair_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnsairInferior_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMaximinizar_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {

            SubMenuFerramentas.Visible = true;
            btnFerramentas.BackColor = Color.Blue;

            subMenuVendas.Visible = false;
            SubMenuCompras.Visible = false;
            SubMenuSistema.Visible = false;
            SubMenuConfiguracoes.Visible = false;
            subMenuProdutos.Visible = false;
            SubMenuConsultas.Visible = false;

            subMenuVendas.Hide();
            SubMenuCompras.Hide();
            SubMenuSistema.Hide();
            SubMenuConfiguracoes.Hide();
            subMenuProdutos.Hide();
            SubMenuConsultas.Hide();

            btnVendas.BackColor = Color.Transparent;
            btnCompras.BackColor = Color.Transparent;
            btnSistema.BackColor = Color.Transparent;
            btnConfiguracoes.BackColor = Color.Transparent;
            btnProdutos.BackColor = Color.Transparent;
            btnConsultas.BackColor = Color.Transparent;
        }

        private void btnBeckupBd_Click(object sender, EventArgs e)
        {
            SubMenuFerramentas.Visible = false;
            SubMenuFerramentas.Hide();
        }

        private void btnFornecedores_Click(object sender, EventArgs e)
        {
            SubMenuCompras.Visible = false;
            SubMenuCompras.Hide();
            frmFornecedor fornec = new frmFornecedor();
            fornec.ShowDialog();
        }

       
        private void btnEstoqueProduto_Click(object sender, EventArgs e)
        {
            SubMenuConsultas.Visible = false;
            SubMenuConsultas.Hide();

            Consultas.frmConsulta_Estoque_Produtos frm = new Consultas.frmConsulta_Estoque_Produtos();
            frm.ShowDialog();
        }

        private void btnApresentacao_Click(object sender, EventArgs e)
        {
            subMenuProdutos.Visible = false;
            subMenuProdutos.Hide();
            frmApresentacao form = new frmApresentacao();
            form.ShowDialog();

        }

        private void btnCategorias_Click(object sender, EventArgs e)
        {
            subMenuProdutos.Visible = false;
            subMenuProdutos.Hide();
            frmCategoria form = new frmCategoria();
            form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString();
        }

        private void btnCadastroProduto_Click(object sender, EventArgs e)
        {
            subMenuProdutos.Visible = false;
            subMenuProdutos.Hide();
            frmProduto frm = frmProduto.GetInstancia();
            frm.ShowDialog();
        }
    }

}
