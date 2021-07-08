using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;

namespace interface_wms
{
    public partial class frmProdutos : Form
    {

        // Métodos

        public void limpaTudo()
        {
            txtNameProd.Clear();
            txtRefProd.Clear();
            txtDescripProd.Clear();
            txtProviderProd.Clear();
            txtExpDateProd.Clear();
            txtWeightProd.Clear();
            txtWeightLiqProd.Clear();
            txtPriceProd.Clear();
            txtQtdeProd.Clear();
            txtQtdeDispProd.Clear();
            txtEANProd.Clear();
            txtCodProd.Clear();
        }

        public void ativar()
        {
            txtNameProd.Enabled = true;
            txtRefProd.Enabled = true;
            txtDescripProd.Enabled = true;
            txtCategProd.Enabled = true;
            txtProviderProd.Enabled = true;
            txtTipoUnid.Enabled = true;
            txtExpDateProd.Enabled = true;
            txtWeightProd.Enabled = true;
            txtWeightLiqProd.Enabled = true;
            txtPriceProd.Enabled = true;
            txtQtdeProd.Enabled = true;
            txtQtdeDispProd.Enabled = true;
            txtEANProd.Enabled = true;
            picIMGProd.Visible = true;
            picIMGProd.Enabled = true;
            string imagem = Application.StartupPath.ToString() + "\\material\\" + "img-padrao.png";
            picIMGProd.ImageLocation = imagem;
            picIMGProd.Load();
        }

        public void desativar()
        {
            txtCodProd.Enabled = true;
            txtNameProd.Enabled = false;
            txtRefProd.Enabled = false;
            txtDescripProd.Enabled = false;
            txtCategProd.Enabled = false;
            txtSubCategProd.Enabled = false;
            txtProviderProd.Enabled = false;
            txtTipoUnid.Enabled = false;
            txtExpDateProd.Enabled = false;
            txtWeightProd.Enabled = false;
            txtWeightLiqProd.Enabled = false;
            txtPriceProd.Enabled = false;
            txtQtdeProd.Enabled = false;
            txtQtdeDispProd.Enabled = false;
            txtEANProd.Enabled = false;
            picIMGProd.Visible = false;
            picIMGProd.Enabled = false;
        }

        public void modonoturno()
        {
            this.BackColor = SystemColors.WindowFrame;
            picBK01.BackColor = SystemColors.WindowText;
            picLogo.BackColor = SystemColors.WindowText;
            lblTitle.ForeColor = SystemColors.Window;
            lblTitle.BackColor = SystemColors.WindowText;
            lblDateTime.ForeColor = SystemColors.Window;
            lblDateTime.BackColor = SystemColors.WindowText;
            lblCompanyName.ForeColor = SystemColors.Window;
            lblCompanyName.BackColor = SystemColors.WindowText;
            lblUser.ForeColor = SystemColors.Window;
            lblUser.BackColor = SystemColors.WindowText;
            mnuSystem.BackColor = SystemColors.WindowFrame;
            arquivoToolStripMenuItem.ForeColor = SystemColors.Window;
            editarToolStripMenuItem.ForeColor = SystemColors.Window;
            exibirToolStripMenuItem.ForeColor = SystemColors.Window;
            picBK02.BackColor = SystemColors.WindowText;
            txtImgLocal.BackColor = SystemColors.WindowText;
            btnMenu.BackColor = SystemColors.WindowText;
            btnSave.BackColor = SystemColors.WindowText;
            btnSave.ForeColor = SystemColors.Window;
            btnCancel.BackColor = SystemColors.WindowText;
            btnCancel.ForeColor = SystemColors.Window;
            grpDataProd.ForeColor = SystemColors.Window;
            txtCodProd.BackColor = SystemColors.WindowText;
            txtNameProd.BackColor = SystemColors.WindowFrame;
            txtRefProd.BackColor = SystemColors.WindowFrame;
            txtDescripProd.BackColor = SystemColors.WindowFrame;
            txtCategProd.BackColor = SystemColors.WindowFrame;
            txtSubCategProd.BackColor = SystemColors.WindowFrame;
            txtProviderProd.BackColor = SystemColors.WindowFrame;
            txtExpDateProd.BackColor = SystemColors.WindowFrame;
            txtWeightProd.BackColor = SystemColors.WindowFrame;
            txtWeightLiqProd.BackColor = SystemColors.WindowFrame;
            txtPriceProd.BackColor = SystemColors.WindowFrame;
            txtTipoUnid.BackColor = SystemColors.WindowFrame;
            txtQtdeProd.BackColor = SystemColors.WindowFrame;
            txtQtdeDispProd.BackColor = SystemColors.WindowFrame;
            txtEANProd.BackColor = SystemColors.WindowFrame;
            txtNameProd.ForeColor = SystemColors.Window;
            txtRefProd.ForeColor = SystemColors.Window;
            txtDescripProd.ForeColor = SystemColors.Window;
            txtCategProd.ForeColor = SystemColors.Window;
            txtSubCategProd.ForeColor = SystemColors.Window;
            txtProviderProd.ForeColor = SystemColors.Window;
            txtExpDateProd.ForeColor = SystemColors.Window;
            txtWeightProd.ForeColor = SystemColors.Window;
            txtWeightLiqProd.ForeColor = SystemColors.Window;
            txtPriceProd.ForeColor = SystemColors.Window;
            txtTipoUnid.ForeColor = SystemColors.Window;
            txtQtdeProd.ForeColor = SystemColors.Window;
            txtQtdeDispProd.ForeColor = SystemColors.Window;
            txtEANProd.ForeColor = SystemColors.Window;
            grpSearchProd.BackColor = SystemColors.WindowFrame;
            grpSearchProd.ForeColor = SystemColors.WindowText;
            lblSearchProd.ForeColor = SystemColors.Window;
            txtSearchProd.BackColor = SystemColors.WindowFrame;
            txtSearchProd.ForeColor = SystemColors.Window;
            dgwListProd.BackgroundColor = SystemColors.WindowFrame;
            btnDelete.BackColor = SystemColors.WindowText;
        }

        public void temapadrao()
        {
            this.BackColor = SystemColors.Window;
            picBK01.BackColor = SystemColors.ButtonFace;
            picLogo.BackColor = SystemColors.ButtonFace;
            lblTitle.ForeColor = SystemColors.ControlDarkDark;
            lblTitle.BackColor = SystemColors.ButtonFace;
            lblDateTime.ForeColor = SystemColors.ControlText;
            lblDateTime.BackColor = SystemColors.ButtonFace;
            lblCompanyName.ForeColor = SystemColors.ControlText;
            lblCompanyName.BackColor = SystemColors.ButtonFace;
            lblUser.ForeColor = SystemColors.ControlText;
            lblUser.BackColor = SystemColors.ButtonFace;
            mnuSystem.BackColor = SystemColors.Window;
            arquivoToolStripMenuItem.ForeColor = SystemColors.GrayText;
            editarToolStripMenuItem.ForeColor = SystemColors.GrayText;
            exibirToolStripMenuItem.ForeColor = SystemColors.GrayText;
            picBK02.BackColor = SystemColors.ButtonFace;
            txtImgLocal.BackColor = SystemColors.ButtonFace;
            btnMenu.BackColor = SystemColors.ButtonShadow;
            btnSave.BackColor = SystemColors.ControlLight;
            btnSave.ForeColor = SystemColors.WindowFrame;
            btnCancel.BackColor = SystemColors.ControlLight;
            btnCancel.ForeColor = SystemColors.WindowFrame;
            grpDataProd.ForeColor = SystemColors.WindowFrame;
            txtCodProd.BackColor = SystemColors.GradientActiveCaption;
            txtNameProd.BackColor = SystemColors.Window;
            txtRefProd.BackColor = SystemColors.Window;
            txtDescripProd.BackColor = SystemColors.Window;
            txtCategProd.BackColor = SystemColors.Window;
            txtSubCategProd.BackColor = SystemColors.Window;
            txtProviderProd.BackColor = SystemColors.Window;
            txtExpDateProd.BackColor = SystemColors.Window;
            txtWeightProd.BackColor = SystemColors.Window;
            txtWeightLiqProd.BackColor = SystemColors.Window;
            txtPriceProd.BackColor = SystemColors.Window;
            txtTipoUnid.BackColor = SystemColors.Window;
            txtQtdeProd.BackColor = SystemColors.Window;
            txtQtdeDispProd.BackColor = SystemColors.Window;
            txtEANProd.BackColor = SystemColors.Window;
            txtNameProd.ForeColor = SystemColors.WindowText;
            txtRefProd.ForeColor = SystemColors.WindowText;
            txtDescripProd.ForeColor = SystemColors.WindowText;
            txtCategProd.ForeColor = SystemColors.WindowText;
            txtSubCategProd.ForeColor = SystemColors.WindowText;
            txtProviderProd.ForeColor = SystemColors.WindowText;
            txtExpDateProd.ForeColor = SystemColors.WindowText;
            txtWeightProd.ForeColor = SystemColors.WindowText;
            txtWeightLiqProd.ForeColor = SystemColors.WindowText;
            txtPriceProd.ForeColor = SystemColors.WindowText;
            txtTipoUnid.ForeColor = SystemColors.WindowText;
            txtQtdeProd.ForeColor = SystemColors.WindowText;
            txtQtdeDispProd.ForeColor = SystemColors.WindowText;
            txtEANProd.ForeColor = SystemColors.WindowText;
            grpSearchProd.BackColor = SystemColors.Window;
            grpSearchProd.ForeColor = SystemColors.WindowText;
            lblSearchProd.ForeColor = SystemColors.WindowText;
            txtSearchProd.BackColor = SystemColors.Window;
            txtSearchProd.ForeColor = SystemColors.WindowText;
            dgwListProd.BackgroundColor = SystemColors.Window;
            btnDelete.BackColor = SystemColors.ButtonShadow;
        }

        public void chamarCat()
        {
            try
            {
                string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + Application.StartupPath + @"\BDP2-WMSV2.mdb";
                OleDbConnection connect = new OleDbConnection(StrConexao);
                connect.Open();

                System.Data.OleDb.OleDbDataAdapter cat = new System.Data.OleDb.OleDbDataAdapter("SELECT ID,NOME FROM g5_Categoria",connect);
                DataTable categoria = new DataTable();
                cat.Fill(categoria);

                int b = Convert.ToInt32(categoria.Rows.Count);

                    txtCategProd.Items.Clear();


                for (int i = 0; i<b; i++) {
                    txtCategProd.Items.Add(categoria.Rows[i][1]);
                }
                txtCategProd.Items.Add("Nova categoria");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void chamarSubCat()
        {
            try
            {
                string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + Application.StartupPath + @"\BDP2-WMSV2.mdb";
                OleDbConnection connect = new OleDbConnection(StrConexao);
                connect.Open();

                System.Data.OleDb.OleDbDataAdapter subcat = new System.Data.OleDb.OleDbDataAdapter("SELECT g5_subcategoria.ID,g5_subcategoria.NOME FROM g5_SubCategoria INNER JOIN g5_categoria on g5_subcategoria.categoria = g5_categoria.CodCateg WHERE g5_categoria.nome LIKE '"+txtCategProd.Text+"'", connect);
                DataTable subcategoria = new DataTable();
                subcat.Fill(subcategoria);

                int b = Convert.ToInt32(subcategoria.Rows.Count);

                txtSubCategProd.Items.Clear();


                for (int i = 0; i < b; i++)
                {
                    txtSubCategProd.Items.Add(subcategoria.Rows[i][1]);
                }
                txtSubCategProd.Items.Add("Nova sub categoria");

            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void executaConsulta(string SQL)
        {
            string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + Application.StartupPath + @"\BDP2-WMSV2.mdb";
            OleDbConnection connect = new OleDbConnection(StrConexao);
            connect.Open();
            OleDbCommand comando = new OleDbCommand(SQL, connect);
            comando.ExecuteNonQuery();
            connect.Close();
        }

        static int procuraCateg(string categ)
        {
            string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + Application.StartupPath + @"\BDP2-WMSV2.mdb";
            OleDbConnection connect = new OleDbConnection(StrConexao);
            connect.Open();


            OleDbDataAdapter codCat = new OleDbDataAdapter("SELECT codCateg from g5_categoria WHERE nome = '" + categ + "'", connect);
            DataTable tableCat = new DataTable();

            codCat.Fill(tableCat);

            int codigoCategoria = Convert.ToInt32(tableCat.Rows[0][0]);


            connect.Close();
            return codigoCategoria;

        }

        static string converteDate(DateTime data)
        {
            string var = Convert.ToString(data);
            return var;
        }

        static string converteInt(int valor)
        {
            string var = Convert.ToString(valor);
            return var;
        }

        static string converteDouble(double valor)
        {
            string var = Convert.ToString(valor);
            return var;
        }

        static int procuraSubCateg(string subCateg)
        {
                string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + Application.StartupPath + @"\BDP2-WMSV2.mdb";
                OleDbConnection connect = new OleDbConnection(StrConexao);
                connect.Open();


                OleDbDataAdapter codSubCat = new OleDbDataAdapter("SELECT codSubCateg from g5_Subcategoria WHERE nome = '" + subCateg + "'", connect);
                DataTable tableSubCat = new DataTable();

                codSubCat.Fill(tableSubCat);

                int codigoSubCategoria = Convert.ToInt32(tableSubCat.Rows[0][0]);


                connect.Close();
                return codigoSubCategoria;

        }

        private int chamarImgCode(int codigo)
        {
            string pasta = Application.StartupPath + @"\BDP2-WMSV2.mdb";

            string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

            OleDbConnection connec = new OleDbConnection(StrConexao);

            string imgcode = "SELECT imagem FROM g5_produto WHERE g5_produto.CodigoProduto = " + txtCodProd.Text;

            connec.Open();
            DataTable dados = new DataTable();

            OleDbDataAdapter adpt = new OleDbDataAdapter(imgcode, connec);

            adpt.Fill(dados);
            connec.Close();

            int codigoimg = (int)dados.Rows[0][0];
            return codigoimg;
        }

        private Image CopiarIMG(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }


        // Implementação dos botões
        public frmProdutos()
        {
            InitializeComponent();
            chamarCat();
            chamarSubCat();
        }


        public void btnMenu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Módulo disponível apenas na versão Beta.", "FAWS WMS");
        }

        public void picIMGProd_Click(object sender, EventArgs e)
        {
            openBrowser.Title = "Selecionar Imagem do Produto";
            openBrowser.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            var existe = false;
            if (openBrowser.ShowDialog() != DialogResult.Cancel)
            {
                
                if (existe == true)
                {
                    existe = false;
                    Bitmap image = new Bitmap(openBrowser.FileName);
                    picIMGProd.Image.Save(Application.StartupPath.ToString() + "\\img-products\\" + chamarImgCode(Convert.ToInt32(txtCodProd.Text)) + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    txtImgLocal.Text = Convert.ToString(chamarImgCode(Convert.ToInt32(txtCodProd.Text)));
                    picIMGProd.BackColor = Color.Black;

                }
                else
                {
                    existe = true;
                    Bitmap image = new Bitmap(openBrowser.FileName);
                    picIMGProd.Image.Save(Application.StartupPath.ToString() + "\\img-products\\" + txtImgLocal.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    picIMGProd.BackColor = Color.Black;
                }
                
            }

        }

        public void picIMGProd_MouseHover(object sender, EventArgs e)
        {
            ToolTip hover = new ToolTip();
            hover.SetToolTip(picIMGProd, "Clique para inserir ou editar a imagem do produto");
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            txtNameProd.Focus();
            try
            {
                //gerando código da img:
                Random codeimg = new Random();
                int codigoimg = codeimg.Next(0, 9999);
                txtImgLocal.Text = Convert.ToString(codigoimg);
                dgwListProd.Rows.Clear();
                btnSearch.Enabled = false;
                dgwListProd.Enabled = false;
                txtSearchProd.Enabled = false;
                lblInstructions.Text = "* preenchimento obrigatório. ** preenchimento automático.  Ao finalizar, clique em Salvar.";
                lblInstructions.Font = new Font("Segoe UI", 9, FontStyle.Bold);
                lblInstructions.Location = new Point(34, 30);
                limpaTudo();
                chamarCat();

                ativar();
                grpDataProd.Enabled = true;
                
                txtCodProd.Enabled = false;
                txtRefProd.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                
                limpaTudo();
                txtProviderProd.Text = "não disponível";
                txtProviderProd.Enabled = false;
                txtNameProd.Focus();
                txtNameProd.TabIndex = 1;
                btnEditImage.Enabled = true;
                btnEditImage.Visible = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }
        
        private void txtCodProd_TextChanged(object sender, EventArgs e)
        {
            try {

                if (txtCodProd.Text != "")
                {
                    btnEditProd.Enabled = true;
                    btnDelete.Enabled = true;
                    string pasta = Application.StartupPath + @"\BDP2-WMSV2.mdb";

                    string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + pasta;

                    OleDbConnection connec = new OleDbConnection(StrConexao);

                    string SQL = "SELECT g5_produto.nome, g5_produto.Referencia, g5_produto.Descricao, g5_categoria.nome, g5_subcategoria.nome, g5_produto.Fornecedor, g5_produto.Validade,g5_produto.PesoBrut,g5_produto.PesoLiq,g5_produto.PrecoProduto,g5_produto.PrecoTipo,g5_produto.Quantidade,g5_produto.QtdeDisponivel,g5_produto.CodigoEAN, g5_produto.Imagem FROM(g5_produto INNER JOIN(g5_subCategoria inner join g5_categoria on g5_subCategoria.Categoria = g5_categoria.CodCateg) on g5_produto.SubCategoria = g5_SubCategoria.CodSubCateg) WHERE g5_produto.CodigoProduto = "+txtCodProd.Text+";";

                    connec.Open();
                    DataTable dados = new DataTable();

                    OleDbDataAdapter adpt = new OleDbDataAdapter(SQL, connec);

                    adpt.Fill(dados);
                    connec.Close();

                    int rf = (int)dados.Rows[0][1];
                    string referencia = converteInt(rf);
                    txtRefProd.Text = referencia;

                    double pb = (double)dados.Rows[0][7];
                    string pesobruto = converteDouble(pb);
                    txtWeightProd.Text = pesobruto;

                    double pl = (double)dados.Rows[0][8];
                    string pesoLiquido = converteDouble(pl);
                    txtWeightLiqProd.Text = pesoLiquido;

                    double pc = (double)dados.Rows[0][9];
                    string preco = converteDouble(pc);
                    txtPriceProd.Text = preco;

                    DateTime val = (DateTime)dados.Rows[0][6];
                    string validade = converteDate(val);
                    txtExpDateProd.Text = validade;

                    txtNameProd.Text = (string)dados.Rows[0][0];
                    txtDescripProd.Text = (string)dados.Rows[0][2];
                    txtCategProd.SelectedItem = (string)dados.Rows[0][3];
                    chamarSubCat();
                    txtSubCategProd.SelectedItem = (string)dados.Rows[0][4];
                    txtEANProd.Text = (string)dados.Rows[0][13];
                    //txtProviderProd.Text = (string)dados.Rows[0][5];
                    txtTipoUnid.Text = (string)dados.Rows[0][10];
                    txtQtdeProd.Text = Convert.ToString((Int16)dados.Rows[0][11]);
                    txtQtdeDispProd.Text = Convert.ToString((Int16)dados.Rows[0][12]);
                    int codigoimg = (int)dados.Rows[0][14]; 

                    string imagem = Application.StartupPath.ToString() + "\\img-products\\" + codigoimg + ".png";
                    txtImgLocal.Text = Convert.ToString(codigoimg);
                    picIMGProd.ImageLocation = imagem;
                    picIMGProd.Load();
                    picIMGProd.Visible = true;
                }
                else
                {
                    btnEditProd.Enabled = false;
                    btnDelete.Enabled = false;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        private void btnEditProd_Click(object sender, EventArgs e)
        {
            try
            {
                ativar();
                txtRefProd.Enabled = false;
                txtCodProd.Enabled = false;
                txtEANProd.Enabled = false;
                txtCategProd.Enabled = false;
                txtSubCategProd.Enabled = false;
                txtProviderProd.Enabled = false;
                btnSave.Enabled = false;
                btnSaveChanges.Enabled = true;
                btnNew.Enabled = false;
                picIMGProd.Load();
                picIMGProd.Visible = true;
                try {
                    Image imagem = CopiarIMG(Application.StartupPath.ToString() + "\\img-products\\" + Convert.ToString(chamarImgCode(Convert.ToInt32(txtCodProd.Text))) + ".png");
                    picIMGProd.Image = imagem;                    
                }
                catch
                {
                    MessageBox.Show("erro");
                }
                
                btnCancel.Enabled = true;
                dgwListProd.Rows.Clear();
                btnSearch.Enabled = false;
                dgwListProd.Enabled = false;
                txtSearchProd.Enabled = false;
                btnEditImage.Visible = true;
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var result = MessageBox.Show("Tem certeza que deseja excluir o produto " + txtNameProd.Text + "?", "FAWS WMS", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    picIMGProd.Dispose();
                    File.Delete(Application.StartupPath.ToString() + "\\img-products\\" + chamarImgCode(Convert.ToInt32(txtCodProd.Text)) + ".png");
                    string img = "DELETE * FROM g5_Imagem WHERE codigo = " + chamarImgCode(Convert.ToInt32(txtCodProd.Text));
                    executaConsulta(img);
                    string SQL = "DELETE * FROM g5_Produto WHERE CodigoProduto LIKE '" + txtCodProd.Text + "'";
                    executaConsulta(SQL);
                    MessageBox.Show("Produto excluído com sucesso", "FAWS WMS");
                    lblInstructions.Text = "Para cadastrar um produto, clique em Novo.";
                    lblInstructions.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    btnNew.Enabled = true;
                    btnCancel.Enabled = false;
                    btnSave.Enabled = false;
                    btnSaveChanges.Enabled = false;
                    btnEditImage.Enabled = true;
                    btnEditImage.Visible = true;
                    txtImgLocal.Text = "";
                    btnSearch.Enabled = true;
                    dgwListProd.Enabled = true;
                    txtSearchProd.Enabled = true;
                    string imagem = Application.StartupPath.ToString() + "\\material\\" + "img-padrao.png";
                    picIMGProd.ImageLocation = imagem;
                    picIMGProd.Load();
                    picIMGProd.Visible = true;
                    picIMGProd.Enabled = false;
                    desativar();
                    limpaTudo();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        public void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, descricao, categ, subCateg, fornecedor, tipoUn, cod, val, pesoB, pesoL, preco, qtde, qtdeDisp, ean, imagem;
                nome = txtNameProd.Text;
                descricao = txtDescripProd.Text;
                categ = txtCategProd.Text;
                subCateg = txtSubCategProd.Text;
                fornecedor = txtProviderProd.Text;
                tipoUn = txtTipoUnid.Text;
                val = txtExpDateProd.Text;
                pesoB = txtWeightProd.Text;
                pesoL = txtWeightLiqProd.Text;
                preco = txtPriceProd.Text;
                qtde = txtQtdeProd.Text;
                qtdeDisp = txtQtdeDispProd.Text;
                ean = txtEANProd.Text;
                imagem = Application.StartupPath.ToString() + "\\img-products\\" + txtImgLocal.Text + ".png" ;

                if (nome.Length == 0 || descricao.Length == 0 || categ.Length == 0 || subCateg.Length == 0 ||  tipoUn.Length == 0
                    || val.Length == 0 || pesoB.Length == 0 || pesoL.Length == 0 || preco.Length == 0 || qtde.Length == 0 || qtdeDisp.Length == 0 || ean.Length == 0
                    || picIMGProd.BackColor == Color.White)
                {
                    MessageBox.Show("Preencha todos os campos do formulário para salvar o cadastro.", "FAWS WMS");
                }
                else {
                    int categoria = procuraCateg(categ);
                    int subCategoria = procuraSubCateg(subCateg);

                    Random codprod = new Random();
                    int referencia = codprod.Next(00, 9999);
                    cod = "" + Convert.ToInt32(categoria) + Convert.ToInt32(subCategoria) + referencia;
                    int codigo = Convert.ToInt32(cod);

                    var codigoimg = txtImgLocal.Text;

                    string SQL = "INSERT INTO g5_produto (CodigoProduto,Categoria,SubCategoria,Referencia,Nome,CodigoEAN,Descricao,Validade,PesoLiq,PesoBrut,Quantidade,QtdeDisponivel,PrecoProduto,PrecoTipo, Imagem) VALUES (" + codigo + "," +categoria+ "," + subCategoria + ",'" + referencia + "','" + nome + "','" + ean + "','" +descricao+"','"+val+"','"+pesoL+"','"+pesoB+"','"+qtde+"','"+qtdeDisp+"','"+preco+"','"+ tipoUn + "','" + codigoimg + "')";
                    executaConsulta(SQL);

                    string IMG = "INSERT INTO g5_Imagem (codigo, imagem) VALUES ("+ codigoimg +",'"+ imagem +"')";
                    executaConsulta(IMG);

                    MessageBox.Show("Produto Cadastrado.", "FAWS WMS");
                    limpaTudo();
                    desativar();

                    lblInstructions.Text = "Para cadastrar um produto, clique em Novo.";
                    lblInstructions.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                    txtImgLocal.Text = "";
                    btnSearch.Enabled = true;
                    dgwListProd.Enabled = true;
                    txtSearchProd.Enabled = true;
                    btnEditImage.Visible = false;
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Tem certeza que deseja cancelar?", "FAWS WMS", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                desativar();
                lblInstructions.Text = "Para cadastrar um produto, clique em Novo.";
                lblInstructions.Font = new Font("Segoe UI", 10, FontStyle.Regular);
                btnNew.Enabled = true;
                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                btnSaveChanges.Enabled = false;
                btnEditImage.Enabled = false;
                btnEditImage.Visible = false;
                txtImgLocal.Text = "";
                limpaTudo();
                btnSearch.Enabled = true;
                dgwListProd.Enabled = true;
                txtSearchProd.Enabled = true;
                picIMGProd.Visible = true;
                picIMGProd.Enabled = false;
                string imagem = Application.StartupPath.ToString() + "\\material\\" + "img-padrao.png";
                picIMGProd.ImageLocation = imagem;
                picIMGProd.Load();
            }
        }

        private void txtCategProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
                
                if (txtCategProd.Text == "Nova categoria")
                {
                    Form cadastroCat = new frmAddCateg();
                    cadastroCat.Show();
                }
                txtSubCategProd.Enabled = true;
                chamarSubCat();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void txtCategProd_MouseClick(object sender, MouseEventArgs e)
        {
            chamarCat();
        }

        private void txtSubCategProd_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSubCategProd.Text == "Nova sub categoria")
                {
                    Form cadastroSubCat = new frmAddSubCateg();
                    cadastroSubCat.Show();
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
        }

        private void txtSubCategProd_MouseClick(object sender, MouseEventArgs e)
        {
            chamarSubCat();
        }

        private void tmrDataHora_Tick_1(object sender, EventArgs e)
        {
            lblDateTime.Text = DateTime.Now.ToString("dd/MM/yyyy, HH:mm");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgwListProd.Rows.Clear();

            string folder = Application.StartupPath + @"\BDP2-WMSV2.mdb";
            string StrConexao = @"Provider = Microsoft.Jet.OLEDB.4.0; Data Source = " + folder;

            OleDbConnection connect = new OleDbConnection(StrConexao);

            try
            {
                string consulta = "SELECT g5_produto.ID,g5_produto.CodigoProduto,g5_produto.Nome,g5_produto.Referencia,g5_categoria.Nome,g5_subcategoria.Nome,g5_produto.Quantidade,g5_produto.QtdeDisponivel FROM(g5_subcategoria INNER JOIN(g5_categoria inner join g5_produto on g5_produto.categoria = g5_categoria.codcateg) on g5_produto.SubCategoria = g5_subcategoria.CodSubCateg); ";

                if (txtSearchProd.Text != "")
                {
                    consulta = "SELECT g5_produto.ID,g5_produto.CodigoProduto,g5_produto.Nome,g5_produto.Referencia,g5_categoria.Nome,g5_subcategoria.Nome,g5_produto.Quantidade,g5_produto.QtdeDisponivel FROM(g5_subcategoria INNER JOIN(g5_categoria inner join g5_produto on g5_produto.categoria = g5_categoria.codcateg) on g5_produto.SubCategoria = g5_subcategoria.CodSubCateg) WHERE g5_produto.nome LIKE '" + txtSearchProd.Text + "' OR g5_produto.CodigoProduto LIKE '" + txtSearchProd.Text + "'";
                }

                DataTable dados = new DataTable();
                OleDbDataAdapter adapt = new OleDbDataAdapter(consulta, StrConexao);

                connect.Open();

                adapt.Fill(dados);

                foreach (DataRow linha in dados.Rows)
                {
                    dgwListProd.Rows.Add(linha.ItemArray);
                }

            }
            catch (Exception er)
            {
                dgwListProd.Rows.Clear();
                MessageBox.Show("Erro " + er);
            }
            finally
            {
                connect.Close();
            }
        }

        private void dgwListProd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgwListProd.CurrentCell.ColumnIndex == 1)
            {
                txtCodProd.Text = Convert.ToString(dgwListProd.CurrentCell.Value);
            }
        }

        private void openBrowser_FileOk(object sender, CancelEventArgs e)
        {
            picIMGProd.Image = Image.FromFile(openBrowser.FileName);
        }

        private void txtEANProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)

            {
                e.Handled = true;
            }
        }

        private void txtQtdeProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)

            {
                e.Handled = true;
            }
        }

        private void txtQtdeDispProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)

            {
                e.Handled = true;
            }
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, descricao, tipoUn, val, pesoB, pesoL, preco, qtde, qtdeDisp, codigoimg;
                nome = txtNameProd.Text;
                descricao = txtDescripProd.Text;
                tipoUn = txtTipoUnid.Text;
                val = txtExpDateProd.Text;
                pesoB = txtWeightProd.Text;
                pesoL = txtWeightLiqProd.Text;
                preco = txtPriceProd.Text;
                qtde = txtQtdeProd.Text;
                qtdeDisp = txtQtdeDispProd.Text;
                codigoimg = txtImgLocal.Text;

                if (nome.Length == 0 || descricao.Length == 0 || tipoUn.Length == 0
                    || val.Length == 0 || pesoB.Length == 0 || pesoL.Length == 0 || preco.Length == 0 || qtde.Length == 0 || qtdeDisp.Length == 0 )
                {
                    MessageBox.Show("Preencha todos os campos do formulário para salvar o cadastro.", "FAWS WMS");
                }
                else
                {
                    string SQL = "UPDATE g5_produto SET " +
                        "g5_produto.Nome = '"+nome+"'" +
                        ",g5_produto.Quantidade=" + qtde +
                        ",g5_produto.QtdeDisponivel="+qtdeDisp+
                        ",g5_produto.descricao = '"+descricao+"'"+
                        ",g5_produto.pesoBrut="+pesoB+
                        ",g5_produto.pesoLiq="+pesoL+
                        ",g5_produto.precoProduto="+preco+
                        ",g5_produto.validade='"+val+
                        "' ,g5_produto.precoTipo='"+tipoUn+"' WHERE g5_produto.codigoProduto = "+ txtCodProd.Text;
                    executaConsulta(SQL);
                    
                    try { 

                    string caminhoimg = Application.StartupPath.ToString() + "\\img-products\\" + chamarImgCode(Convert.ToInt32(txtCodProd.Text)) + ".png";

                    string img = "UPDATE g5_imagem SET imagem = '" + caminhoimg + "' WHERE codigo = "+ codigoimg;
                    executaConsulta(img);

                        MessageBox.Show("Alteração feita com sucesso!","Sucesso!");
                        btnNew.Enabled = true;
                        btnCancel.Enabled = false;
                        btnSave.Enabled = false;
                        btnSaveChanges.Enabled = false;
                        btnEditImage.Enabled = false;
                        btnEditImage.Visible = false;
                        txtImgLocal.Text = "";
                        btnSearch.Enabled = true;
                        dgwListProd.Enabled = true;
                        txtSearchProd.Enabled = true;
                        desativar();
                        limpaTudo();
                        picIMGProd.Visible = true;
                        picIMGProd.Enabled = false;
                        string imagem = Application.StartupPath.ToString() + "\\material\\" + "img-padrao.png";
                        picIMGProd.ImageLocation = imagem;
                        picIMGProd.Load();
                    }
                    catch
                    {
                        MessageBox.Show("error");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
                
            }
        }

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNew_MouseHover(object sender, EventArgs e)
        {
            ToolTip hover = new ToolTip();
            hover.SetToolTip(btnNew, "Cadastrar novo produto");
        }

        private void btnEditProd_MouseHover(object sender, EventArgs e)
        {
            ToolTip hover = new ToolTip();
            hover.SetToolTip(btnEditProd, "Editar cadastro ativo");
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            ToolTip hover = new ToolTip();
            hover.SetToolTip(btnDelete, "Excluir cadastro ativo");
        }

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            ToolTip hover = new ToolTip();
            hover.SetToolTip(btnSearch, "Ver todos os produtos cadastrados");
        }

        private void txtWeightProd_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)

            {
                e.Handled = true;
            }
        }

        private void dgwListProd_MouseHover(object sender, EventArgs e)
        {
            ToolTip hover = new ToolTip();
            hover.SetToolTip(dgwListProd, "Dê um duplo clique sobre o código desejado para ver todas as informações do cadastro");
        }

        private void grpSearchProd_MouseHover(object sender, EventArgs e)
        {
            ToolTip hover = new ToolTip();
            hover.SetToolTip(grpSearchProd, "Dê um duplo clique sobre o código desejado para ver todas as informações do cadastro");
        }

        private void btnEditImage_Click(object sender, EventArgs e)
        {
            picIMGProd.Enabled = true;
            picIMGProd.Visible = true;
            openBrowser.Title = "Selecionar Imagem do Produto";
            openBrowser.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            var existe = false;
            if (openBrowser.ShowDialog() != DialogResult.Cancel)
            {

                if (existe == true)
                {
                    existe = false;
                    Bitmap image = new Bitmap(openBrowser.FileName);
                    picIMGProd.Image.Save(Application.StartupPath.ToString() + "\\img-products\\" + chamarImgCode(Convert.ToInt32(txtCodProd.Text)) + ".png", System.Drawing.Imaging.ImageFormat.Png);
                    txtImgLocal.Text = Convert.ToString(chamarImgCode(Convert.ToInt32(txtCodProd.Text)));

                }
                else
                {
                    existe = true;

                    Bitmap image = new Bitmap(openBrowser.FileName);
                    picIMGProd.Image.Save(Application.StartupPath.ToString() + "\\img-products\\" + txtImgLocal.Text + ".png", System.Drawing.Imaging.ImageFormat.Png);
                }
            }
        }

        private void btnEditImage_MouseHover(object sender, EventArgs e)
        {
            ToolTip hover = new ToolTip();
            hover.SetToolTip(picIMGProd, "Clique para inserir ou editar a imagem do produto");
        }

        private void permissõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Suas permissões:\n{ lblUser.Text}\n\n" +
                $"\n[ X ]\tCadastrar novos produtos" +
                $"\n[ X ]\tEditar produtos" +
                $"\n[ X ]\tExcluir produtos", "FAWS WMS");
        }

        private void darkThemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.estado == false){
                Global.estado = true;
                modonoturno();
            }
            else
            {
                temapadrao();
                Global.estado = false;
            }
        }

        public static class Global
        {
            public static bool estado = false;
        }

        private void optionToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para informações e suporte do sistema, entre em contato através de um dos e-mails abaixo:\n\n" +
                "Cassia Yaisa\n(cassia.souza2@fatec.sp.gov.br)\n\n" +
                "Kevin Rickelme\n(kevin.silva15@fatec.sp.gov.br)\n\n" +
                "Lucas Casagrande\n(lucas.santos453@fatec.sp.gov.br)\n\n" +
                "Lucas Bezerra\n(lucas.silva776@fatec.sp.gov.br)\n\n" +
                "Matheus Ribeiro\n(matheus.moita@fatec.sp.gov.br)\n\n" +
                "Samara de Oliveira\n(samara.rodrigues01@fatec.sp.gov.br)", "FAWS WMS - Suporte");
        }
    }
}
