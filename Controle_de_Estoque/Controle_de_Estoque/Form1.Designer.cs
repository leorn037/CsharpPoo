namespace Controle_de_Estoque
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProduto = new System.Windows.Forms.TabPage();
            this.cbIdcateg = new System.Windows.Forms.ComboBox();
            this.tbPrecoprod = new System.Windows.Forms.TextBox();
            this.tbQuantprod = new System.Windows.Forms.TextBox();
            this.tbNomeprod = new System.Windows.Forms.TextBox();
            this.btLimparprod = new System.Windows.Forms.Button();
            this.btDeletarprod = new System.Windows.Forms.Button();
            this.btAtualizarprod = new System.Windows.Forms.Button();
            this.lbIdcategprod = new System.Windows.Forms.Label();
            this.lbIdfornecprod = new System.Windows.Forms.Label();
            this.lbPrecoprod = new System.Windows.Forms.Label();
            this.lbQuantprod = new System.Windows.Forms.Label();
            this.lbNomeprod = new System.Windows.Forms.Label();
            this.lbIdprod = new System.Windows.Forms.Label();
            this.btGravarprod = new System.Windows.Forms.Button();
            this.dataGridViewProduto = new System.Windows.Forms.DataGridView();
            this.cbIdfornec = new System.Windows.Forms.ComboBox();
            this.tbIdprod = new System.Windows.Forms.TextBox();
            this.tabFornecedor = new System.Windows.Forms.TabPage();
            this.mtbCnpjfornec = new System.Windows.Forms.MaskedTextBox();
            this.tbContatofornec = new System.Windows.Forms.TextBox();
            this.tbNomefornec = new System.Windows.Forms.TextBox();
            this.btLimparfornec = new System.Windows.Forms.Button();
            this.btDeletarfornec = new System.Windows.Forms.Button();
            this.btAtualizarfornec = new System.Windows.Forms.Button();
            this.lbCnpj = new System.Windows.Forms.Label();
            this.lbContato = new System.Windows.Forms.Label();
            this.lbNomefornec = new System.Windows.Forms.Label();
            this.lbIdfornec = new System.Windows.Forms.Label();
            this.btGravarfornec = new System.Windows.Forms.Button();
            this.dataGridViewFornecedor = new System.Windows.Forms.DataGridView();
            this.tbIdfornec = new System.Windows.Forms.TextBox();
            this.tabCategoria = new System.Windows.Forms.TabPage();
            this.tbDescricaocateg = new System.Windows.Forms.TextBox();
            this.tbNomecateg = new System.Windows.Forms.TextBox();
            this.btLimparcateg = new System.Windows.Forms.Button();
            this.btDeletarcateg = new System.Windows.Forms.Button();
            this.btAtualizarcateg = new System.Windows.Forms.Button();
            this.lbDesccateg = new System.Windows.Forms.Label();
            this.lbNomecateg = new System.Windows.Forms.Label();
            this.lbIdcateg = new System.Windows.Forms.Label();
            this.btGravarcateg = new System.Windows.Forms.Button();
            this.dataGridViewCategoria = new System.Windows.Forms.DataGridView();
            this.tbIdcateg = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).BeginInit();
            this.tabFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).BeginInit();
            this.tabCategoria.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProduto);
            this.tabControl1.Controls.Add(this.tabFornecedor);
            this.tabControl1.Controls.Add(this.tabCategoria);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1045, 440);
            this.tabControl1.TabIndex = 0;
            // 
            // tabProduto
            // 
            this.tabProduto.Controls.Add(this.cbIdcateg);
            this.tabProduto.Controls.Add(this.tbPrecoprod);
            this.tabProduto.Controls.Add(this.tbQuantprod);
            this.tabProduto.Controls.Add(this.tbNomeprod);
            this.tabProduto.Controls.Add(this.btLimparprod);
            this.tabProduto.Controls.Add(this.btDeletarprod);
            this.tabProduto.Controls.Add(this.btAtualizarprod);
            this.tabProduto.Controls.Add(this.lbIdcategprod);
            this.tabProduto.Controls.Add(this.lbIdfornecprod);
            this.tabProduto.Controls.Add(this.lbPrecoprod);
            this.tabProduto.Controls.Add(this.lbQuantprod);
            this.tabProduto.Controls.Add(this.lbNomeprod);
            this.tabProduto.Controls.Add(this.lbIdprod);
            this.tabProduto.Controls.Add(this.btGravarprod);
            this.tabProduto.Controls.Add(this.dataGridViewProduto);
            this.tabProduto.Controls.Add(this.cbIdfornec);
            this.tabProduto.Controls.Add(this.tbIdprod);
            this.tabProduto.Location = new System.Drawing.Point(4, 25);
            this.tabProduto.Name = "tabProduto";
            this.tabProduto.Padding = new System.Windows.Forms.Padding(3);
            this.tabProduto.Size = new System.Drawing.Size(1037, 411);
            this.tabProduto.TabIndex = 0;
            this.tabProduto.Text = "Produto";
            this.tabProduto.UseVisualStyleBackColor = true;
            // 
            // cbIdcateg
            // 
            this.cbIdcateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdcateg.FormattingEnabled = true;
            this.cbIdcateg.Location = new System.Drawing.Point(170, 226);
            this.cbIdcateg.Name = "cbIdcateg";
            this.cbIdcateg.Size = new System.Drawing.Size(140, 24);
            this.cbIdcateg.TabIndex = 16;
            // 
            // tbPrecoprod
            // 
            this.tbPrecoprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPrecoprod.Location = new System.Drawing.Point(170, 143);
            this.tbPrecoprod.Name = "tbPrecoprod";
            this.tbPrecoprod.Size = new System.Drawing.Size(140, 22);
            this.tbPrecoprod.TabIndex = 15;
            // 
            // tbQuantprod
            // 
            this.tbQuantprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbQuantprod.Location = new System.Drawing.Point(170, 103);
            this.tbQuantprod.Name = "tbQuantprod";
            this.tbQuantprod.Size = new System.Drawing.Size(140, 22);
            this.tbQuantprod.TabIndex = 14;
            // 
            // tbNomeprod
            // 
            this.tbNomeprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNomeprod.Location = new System.Drawing.Point(170, 63);
            this.tbNomeprod.Name = "tbNomeprod";
            this.tbNomeprod.Size = new System.Drawing.Size(140, 22);
            this.tbNomeprod.TabIndex = 13;
            // 
            // btLimparprod
            // 
            this.btLimparprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparprod.Location = new System.Drawing.Point(170, 326);
            this.btLimparprod.Name = "btLimparprod";
            this.btLimparprod.Size = new System.Drawing.Size(113, 40);
            this.btLimparprod.TabIndex = 12;
            this.btLimparprod.Text = "Limpar";
            this.btLimparprod.UseVisualStyleBackColor = true;
            this.btLimparprod.Click += new System.EventHandler(this.btLimparprod_Click);
            // 
            // btDeletarprod
            // 
            this.btDeletarprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletarprod.Location = new System.Drawing.Point(43, 326);
            this.btDeletarprod.Name = "btDeletarprod";
            this.btDeletarprod.Size = new System.Drawing.Size(113, 40);
            this.btDeletarprod.TabIndex = 11;
            this.btDeletarprod.Text = "Deletar";
            this.btDeletarprod.UseVisualStyleBackColor = true;
            this.btDeletarprod.Click += new System.EventHandler(this.btDeletarprod_Click);
            // 
            // btAtualizarprod
            // 
            this.btAtualizarprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarprod.Location = new System.Drawing.Point(170, 280);
            this.btAtualizarprod.Name = "btAtualizarprod";
            this.btAtualizarprod.Size = new System.Drawing.Size(113, 40);
            this.btAtualizarprod.TabIndex = 10;
            this.btAtualizarprod.Text = "Atualizar";
            this.btAtualizarprod.UseVisualStyleBackColor = true;
            this.btAtualizarprod.Click += new System.EventHandler(this.btAtualizarprod_Click);
            // 
            // lbIdcategprod
            // 
            this.lbIdcategprod.AutoSize = true;
            this.lbIdcategprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdcategprod.Location = new System.Drawing.Point(23, 229);
            this.lbIdcategprod.Name = "lbIdcategprod";
            this.lbIdcategprod.Size = new System.Drawing.Size(104, 16);
            this.lbIdcategprod.TabIndex = 9;
            this.lbIdcategprod.Text = "ID da Categoria:";
            // 
            // lbIdfornecprod
            // 
            this.lbIdfornecprod.AutoSize = true;
            this.lbIdfornecprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdfornecprod.Location = new System.Drawing.Point(23, 186);
            this.lbIdfornecprod.Name = "lbIdfornecprod";
            this.lbIdfornecprod.Size = new System.Drawing.Size(115, 16);
            this.lbIdfornecprod.TabIndex = 8;
            this.lbIdfornecprod.Text = "ID do Fornecedor:";
            // 
            // lbPrecoprod
            // 
            this.lbPrecoprod.AutoSize = true;
            this.lbPrecoprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPrecoprod.Location = new System.Drawing.Point(23, 146);
            this.lbPrecoprod.Name = "lbPrecoprod";
            this.lbPrecoprod.Size = new System.Drawing.Size(95, 16);
            this.lbPrecoprod.TabIndex = 7;
            this.lbPrecoprod.Text = "Preço Unitário:";
            // 
            // lbQuantprod
            // 
            this.lbQuantprod.AutoSize = true;
            this.lbQuantprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuantprod.Location = new System.Drawing.Point(23, 106);
            this.lbQuantprod.Name = "lbQuantprod";
            this.lbQuantprod.Size = new System.Drawing.Size(80, 16);
            this.lbQuantprod.TabIndex = 6;
            this.lbQuantprod.Text = "Quantidade:";
            // 
            // lbNomeprod
            // 
            this.lbNomeprod.AutoSize = true;
            this.lbNomeprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNomeprod.Location = new System.Drawing.Point(23, 66);
            this.lbNomeprod.Name = "lbNomeprod";
            this.lbNomeprod.Size = new System.Drawing.Size(116, 16);
            this.lbNomeprod.TabIndex = 5;
            this.lbNomeprod.Text = "Nome do Produto:";
            // 
            // lbIdprod
            // 
            this.lbIdprod.AutoSize = true;
            this.lbIdprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIdprod.Location = new System.Drawing.Point(23, 26);
            this.lbIdprod.Name = "lbIdprod";
            this.lbIdprod.Size = new System.Drawing.Size(92, 16);
            this.lbIdprod.TabIndex = 4;
            this.lbIdprod.Text = "ID do Produto:";
            // 
            // btGravarprod
            // 
            this.btGravarprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravarprod.Location = new System.Drawing.Point(43, 280);
            this.btGravarprod.Name = "btGravarprod";
            this.btGravarprod.Size = new System.Drawing.Size(113, 40);
            this.btGravarprod.TabIndex = 3;
            this.btGravarprod.Text = "Gravar";
            this.btGravarprod.UseVisualStyleBackColor = true;
            this.btGravarprod.Click += new System.EventHandler(this.btGravarprod_Click);
            // 
            // dataGridViewProduto
            // 
            this.dataGridViewProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProduto.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewProduto.Location = new System.Drawing.Point(325, 26);
            this.dataGridViewProduto.Name = "dataGridViewProduto";
            this.dataGridViewProduto.RowHeadersVisible = false;
            this.dataGridViewProduto.RowHeadersWidth = 51;
            this.dataGridViewProduto.RowTemplate.Height = 24;
            this.dataGridViewProduto.Size = new System.Drawing.Size(687, 367);
            this.dataGridViewProduto.TabIndex = 2;
            this.dataGridViewProduto.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProduto_CellDoubleClick);
            // 
            // cbIdfornec
            // 
            this.cbIdfornec.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdfornec.FormattingEnabled = true;
            this.cbIdfornec.Location = new System.Drawing.Point(170, 183);
            this.cbIdfornec.Name = "cbIdfornec";
            this.cbIdfornec.Size = new System.Drawing.Size(140, 24);
            this.cbIdfornec.TabIndex = 1;
            // 
            // tbIdprod
            // 
            this.tbIdprod.Enabled = false;
            this.tbIdprod.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIdprod.Location = new System.Drawing.Point(170, 23);
            this.tbIdprod.Name = "tbIdprod";
            this.tbIdprod.Size = new System.Drawing.Size(140, 22);
            this.tbIdprod.TabIndex = 0;
            // 
            // tabFornecedor
            // 
            this.tabFornecedor.Controls.Add(this.mtbCnpjfornec);
            this.tabFornecedor.Controls.Add(this.tbContatofornec);
            this.tabFornecedor.Controls.Add(this.tbNomefornec);
            this.tabFornecedor.Controls.Add(this.btLimparfornec);
            this.tabFornecedor.Controls.Add(this.btDeletarfornec);
            this.tabFornecedor.Controls.Add(this.btAtualizarfornec);
            this.tabFornecedor.Controls.Add(this.lbCnpj);
            this.tabFornecedor.Controls.Add(this.lbContato);
            this.tabFornecedor.Controls.Add(this.lbNomefornec);
            this.tabFornecedor.Controls.Add(this.lbIdfornec);
            this.tabFornecedor.Controls.Add(this.btGravarfornec);
            this.tabFornecedor.Controls.Add(this.dataGridViewFornecedor);
            this.tabFornecedor.Controls.Add(this.tbIdfornec);
            this.tabFornecedor.Location = new System.Drawing.Point(4, 25);
            this.tabFornecedor.Name = "tabFornecedor";
            this.tabFornecedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabFornecedor.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tabFornecedor.Size = new System.Drawing.Size(1037, 411);
            this.tabFornecedor.TabIndex = 1;
            this.tabFornecedor.Text = "Fornecedor";
            this.tabFornecedor.UseVisualStyleBackColor = true;
            // 
            // mtbCnpjfornec
            // 
            this.mtbCnpjfornec.Location = new System.Drawing.Point(170, 143);
            this.mtbCnpjfornec.Mask = "99.999.999/9999-99";
            this.mtbCnpjfornec.Name = "mtbCnpjfornec";
            this.mtbCnpjfornec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mtbCnpjfornec.Size = new System.Drawing.Size(140, 22);
            this.mtbCnpjfornec.TabIndex = 33;
            // 
            // tbContatofornec
            // 
            this.tbContatofornec.Location = new System.Drawing.Point(170, 103);
            this.tbContatofornec.Name = "tbContatofornec";
            this.tbContatofornec.Size = new System.Drawing.Size(140, 22);
            this.tbContatofornec.TabIndex = 31;
            // 
            // tbNomefornec
            // 
            this.tbNomefornec.Location = new System.Drawing.Point(170, 63);
            this.tbNomefornec.Name = "tbNomefornec";
            this.tbNomefornec.Size = new System.Drawing.Size(140, 22);
            this.tbNomefornec.TabIndex = 30;
            // 
            // btLimparfornec
            // 
            this.btLimparfornec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLimparfornec.Location = new System.Drawing.Point(170, 326);
            this.btLimparfornec.Name = "btLimparfornec";
            this.btLimparfornec.Size = new System.Drawing.Size(113, 40);
            this.btLimparfornec.TabIndex = 29;
            this.btLimparfornec.Text = "Limpar";
            this.btLimparfornec.UseVisualStyleBackColor = true;
            this.btLimparfornec.Click += new System.EventHandler(this.btLimparfornec_Click);
            // 
            // btDeletarfornec
            // 
            this.btDeletarfornec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDeletarfornec.Location = new System.Drawing.Point(43, 326);
            this.btDeletarfornec.Name = "btDeletarfornec";
            this.btDeletarfornec.Size = new System.Drawing.Size(113, 40);
            this.btDeletarfornec.TabIndex = 28;
            this.btDeletarfornec.Text = "Deletar";
            this.btDeletarfornec.UseVisualStyleBackColor = true;
            this.btDeletarfornec.Click += new System.EventHandler(this.btDeletarfornec_Click);
            // 
            // btAtualizarfornec
            // 
            this.btAtualizarfornec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAtualizarfornec.Location = new System.Drawing.Point(170, 280);
            this.btAtualizarfornec.Name = "btAtualizarfornec";
            this.btAtualizarfornec.Size = new System.Drawing.Size(113, 40);
            this.btAtualizarfornec.TabIndex = 27;
            this.btAtualizarfornec.Text = "Atualizar";
            this.btAtualizarfornec.UseVisualStyleBackColor = true;
            this.btAtualizarfornec.Click += new System.EventHandler(this.btAtualizarfornec_Click);
            // 
            // lbCnpj
            // 
            this.lbCnpj.AutoSize = true;
            this.lbCnpj.Location = new System.Drawing.Point(23, 146);
            this.lbCnpj.Name = "lbCnpj";
            this.lbCnpj.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbCnpj.Size = new System.Drawing.Size(45, 16);
            this.lbCnpj.TabIndex = 24;
            this.lbCnpj.Text = "CNPJ:";
            // 
            // lbContato
            // 
            this.lbContato.AutoSize = true;
            this.lbContato.Location = new System.Drawing.Point(23, 106);
            this.lbContato.Name = "lbContato";
            this.lbContato.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbContato.Size = new System.Drawing.Size(56, 16);
            this.lbContato.TabIndex = 23;
            this.lbContato.Text = "Contato:";
            // 
            // lbNomefornec
            // 
            this.lbNomefornec.AutoSize = true;
            this.lbNomefornec.Location = new System.Drawing.Point(23, 66);
            this.lbNomefornec.Name = "lbNomefornec";
            this.lbNomefornec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbNomefornec.Size = new System.Drawing.Size(139, 16);
            this.lbNomefornec.TabIndex = 22;
            this.lbNomefornec.Text = "Nome do Fornecedor:";
            // 
            // lbIdfornec
            // 
            this.lbIdfornec.AutoSize = true;
            this.lbIdfornec.Location = new System.Drawing.Point(23, 26);
            this.lbIdfornec.Name = "lbIdfornec";
            this.lbIdfornec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbIdfornec.Size = new System.Drawing.Size(118, 16);
            this.lbIdfornec.TabIndex = 21;
            this.lbIdfornec.Text = "ID do Fornecedor: ";
            // 
            // btGravarfornec
            // 
            this.btGravarfornec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGravarfornec.Location = new System.Drawing.Point(43, 280);
            this.btGravarfornec.Name = "btGravarfornec";
            this.btGravarfornec.Size = new System.Drawing.Size(113, 40);
            this.btGravarfornec.TabIndex = 20;
            this.btGravarfornec.Text = "Gravar";
            this.btGravarfornec.UseVisualStyleBackColor = true;
            this.btGravarfornec.Click += new System.EventHandler(this.btGravarfornec_Click);
            // 
            // dataGridViewFornecedor
            // 
            this.dataGridViewFornecedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFornecedor.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewFornecedor.Location = new System.Drawing.Point(325, 26);
            this.dataGridViewFornecedor.Name = "dataGridViewFornecedor";
            this.dataGridViewFornecedor.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewFornecedor.RowHeadersVisible = false;
            this.dataGridViewFornecedor.RowHeadersWidth = 51;
            this.dataGridViewFornecedor.RowTemplate.Height = 24;
            this.dataGridViewFornecedor.Size = new System.Drawing.Size(687, 367);
            this.dataGridViewFornecedor.TabIndex = 19;
            this.dataGridViewFornecedor.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewFornecedor_CellDoubleClick);
            // 
            // tbIdfornec
            // 
            this.tbIdfornec.Enabled = false;
            this.tbIdfornec.Location = new System.Drawing.Point(170, 23);
            this.tbIdfornec.Name = "tbIdfornec";
            this.tbIdfornec.Size = new System.Drawing.Size(140, 22);
            this.tbIdfornec.TabIndex = 17;
            // 
            // tabCategoria
            // 
            this.tabCategoria.Controls.Add(this.tbDescricaocateg);
            this.tabCategoria.Controls.Add(this.tbNomecateg);
            this.tabCategoria.Controls.Add(this.btLimparcateg);
            this.tabCategoria.Controls.Add(this.btDeletarcateg);
            this.tabCategoria.Controls.Add(this.btAtualizarcateg);
            this.tabCategoria.Controls.Add(this.lbDesccateg);
            this.tabCategoria.Controls.Add(this.lbNomecateg);
            this.tabCategoria.Controls.Add(this.lbIdcateg);
            this.tabCategoria.Controls.Add(this.btGravarcateg);
            this.tabCategoria.Controls.Add(this.dataGridViewCategoria);
            this.tabCategoria.Controls.Add(this.tbIdcateg);
            this.tabCategoria.Location = new System.Drawing.Point(4, 25);
            this.tabCategoria.Name = "tabCategoria";
            this.tabCategoria.Size = new System.Drawing.Size(1037, 411);
            this.tabCategoria.TabIndex = 2;
            this.tabCategoria.Text = "Categoria";
            this.tabCategoria.UseVisualStyleBackColor = true;
            // 
            // tbDescricaocateg
            // 
            this.tbDescricaocateg.Location = new System.Drawing.Point(26, 146);
            this.tbDescricaocateg.Name = "tbDescricaocateg";
            this.tbDescricaocateg.Size = new System.Drawing.Size(284, 22);
            this.tbDescricaocateg.TabIndex = 45;
            // 
            // tbNomecateg
            // 
            this.tbNomecateg.Location = new System.Drawing.Point(170, 63);
            this.tbNomecateg.Name = "tbNomecateg";
            this.tbNomecateg.Size = new System.Drawing.Size(140, 22);
            this.tbNomecateg.TabIndex = 44;
            // 
            // btLimparcateg
            // 
            this.btLimparcateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btLimparcateg.Location = new System.Drawing.Point(170, 326);
            this.btLimparcateg.Name = "btLimparcateg";
            this.btLimparcateg.Size = new System.Drawing.Size(113, 40);
            this.btLimparcateg.TabIndex = 43;
            this.btLimparcateg.Text = "Limpar";
            this.btLimparcateg.UseVisualStyleBackColor = true;
            this.btLimparcateg.Click += new System.EventHandler(this.btLimparcateg_Click);
            // 
            // btDeletarcateg
            // 
            this.btDeletarcateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btDeletarcateg.Location = new System.Drawing.Point(43, 326);
            this.btDeletarcateg.Name = "btDeletarcateg";
            this.btDeletarcateg.Size = new System.Drawing.Size(113, 40);
            this.btDeletarcateg.TabIndex = 42;
            this.btDeletarcateg.Text = "Deletar";
            this.btDeletarcateg.UseVisualStyleBackColor = true;
            this.btDeletarcateg.Click += new System.EventHandler(this.btDeletarcateg_Click);
            // 
            // btAtualizarcateg
            // 
            this.btAtualizarcateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btAtualizarcateg.Location = new System.Drawing.Point(170, 280);
            this.btAtualizarcateg.Name = "btAtualizarcateg";
            this.btAtualizarcateg.Size = new System.Drawing.Size(113, 40);
            this.btAtualizarcateg.TabIndex = 41;
            this.btAtualizarcateg.Text = "Atualizar";
            this.btAtualizarcateg.UseVisualStyleBackColor = true;
            this.btAtualizarcateg.Click += new System.EventHandler(this.btAtualizarcateg_Click);
            // 
            // lbDesccateg
            // 
            this.lbDesccateg.AutoSize = true;
            this.lbDesccateg.Location = new System.Drawing.Point(23, 106);
            this.lbDesccateg.Name = "lbDesccateg";
            this.lbDesccateg.Size = new System.Drawing.Size(72, 16);
            this.lbDesccateg.TabIndex = 39;
            this.lbDesccateg.Text = "Descrição:";
            // 
            // lbNomecateg
            // 
            this.lbNomecateg.AutoSize = true;
            this.lbNomecateg.Location = new System.Drawing.Point(23, 66);
            this.lbNomecateg.Name = "lbNomecateg";
            this.lbNomecateg.Size = new System.Drawing.Size(128, 16);
            this.lbNomecateg.TabIndex = 38;
            this.lbNomecateg.Text = "Nome da Categoria:";
            // 
            // lbIdcateg
            // 
            this.lbIdcateg.AutoSize = true;
            this.lbIdcateg.Location = new System.Drawing.Point(23, 26);
            this.lbIdcateg.Name = "lbIdcateg";
            this.lbIdcateg.Size = new System.Drawing.Size(104, 16);
            this.lbIdcateg.TabIndex = 37;
            this.lbIdcateg.Text = "ID da Categoria:";
            // 
            // btGravarcateg
            // 
            this.btGravarcateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold);
            this.btGravarcateg.Location = new System.Drawing.Point(43, 280);
            this.btGravarcateg.Name = "btGravarcateg";
            this.btGravarcateg.Size = new System.Drawing.Size(113, 40);
            this.btGravarcateg.TabIndex = 36;
            this.btGravarcateg.Text = "Gravar";
            this.btGravarcateg.UseVisualStyleBackColor = true;
            this.btGravarcateg.Click += new System.EventHandler(this.btGravarcateg_Click);
            // 
            // dataGridViewCategoria
            // 
            this.dataGridViewCategoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategoria.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewCategoria.Location = new System.Drawing.Point(325, 26);
            this.dataGridViewCategoria.Name = "dataGridViewCategoria";
            this.dataGridViewCategoria.RowHeadersVisible = false;
            this.dataGridViewCategoria.RowHeadersWidth = 51;
            this.dataGridViewCategoria.RowTemplate.Height = 24;
            this.dataGridViewCategoria.Size = new System.Drawing.Size(687, 367);
            this.dataGridViewCategoria.TabIndex = 35;
            this.dataGridViewCategoria.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCategoria_CellDoubleClick);
            // 
            // tbIdcateg
            // 
            this.tbIdcateg.Enabled = false;
            this.tbIdcateg.Location = new System.Drawing.Point(170, 23);
            this.tbIdcateg.Name = "tbIdcateg";
            this.tbIdcateg.Size = new System.Drawing.Size(140, 22);
            this.tbIdcateg.TabIndex = 34;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 460);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Controle de Estoque";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabProduto.ResumeLayout(false);
            this.tabProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProduto)).EndInit();
            this.tabFornecedor.ResumeLayout(false);
            this.tabFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFornecedor)).EndInit();
            this.tabCategoria.ResumeLayout(false);
            this.tabCategoria.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProduto;
        private System.Windows.Forms.TabPage tabFornecedor;
        private System.Windows.Forms.DataGridView dataGridViewProduto;
        private System.Windows.Forms.ComboBox cbIdfornec;
        private System.Windows.Forms.TextBox tbIdprod;
        private System.Windows.Forms.Button btGravarprod;
        private System.Windows.Forms.TabPage tabCategoria;
        private System.Windows.Forms.Label lbIdprod;
        private System.Windows.Forms.Label lbNomeprod;
        private System.Windows.Forms.Label lbQuantprod;
        private System.Windows.Forms.Label lbIdfornecprod;
        private System.Windows.Forms.Label lbPrecoprod;
        private System.Windows.Forms.Label lbIdcategprod;
        private System.Windows.Forms.Button btAtualizarprod;
        private System.Windows.Forms.ComboBox cbIdcateg;
        private System.Windows.Forms.TextBox tbPrecoprod;
        private System.Windows.Forms.TextBox tbQuantprod;
        private System.Windows.Forms.TextBox tbNomeprod;
        private System.Windows.Forms.Button btLimparprod;
        private System.Windows.Forms.Button btDeletarprod;
        private System.Windows.Forms.TextBox tbContatofornec;
        private System.Windows.Forms.TextBox tbNomefornec;
        private System.Windows.Forms.Button btLimparfornec;
        private System.Windows.Forms.Button btDeletarfornec;
        private System.Windows.Forms.Button btAtualizarfornec;
        private System.Windows.Forms.Label lbCnpj;
        private System.Windows.Forms.Label lbContato;
        private System.Windows.Forms.Label lbNomefornec;
        private System.Windows.Forms.Label lbIdfornec;
        private System.Windows.Forms.Button btGravarfornec;
        private System.Windows.Forms.DataGridView dataGridViewFornecedor;
        private System.Windows.Forms.TextBox tbIdfornec;
        private System.Windows.Forms.MaskedTextBox mtbCnpjfornec;
        private System.Windows.Forms.TextBox tbDescricaocateg;
        private System.Windows.Forms.TextBox tbNomecateg;
        private System.Windows.Forms.Button btLimparcateg;
        private System.Windows.Forms.Button btDeletarcateg;
        private System.Windows.Forms.Button btAtualizarcateg;
        private System.Windows.Forms.Label lbDesccateg;
        private System.Windows.Forms.Label lbNomecateg;
        private System.Windows.Forms.Label lbIdcateg;
        private System.Windows.Forms.Button btGravarcateg;
        private System.Windows.Forms.DataGridView dataGridViewCategoria;
        private System.Windows.Forms.TextBox tbIdcateg;
    }
}

