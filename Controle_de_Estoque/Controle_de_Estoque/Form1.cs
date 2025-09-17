using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controle_de_Estoque
{
    public partial class Form1 : Form
    {
        // Variáveis de conexão com o banco de dados.
        string host = "localhost";
        string database = "Controle_de_Estoque";
        string user = "postgres";
        string password = "qwertyuiop";
        private DatabaseConnection dbConnection;

        // Variáveis para gerenciar o item ou coluna selecionada em cada DataGridView
        private int produtoIdSelecionado = 0;
        private int fornecedorIdSelecionado = 0;
        private int categoriaIdSelecionada = 0;
        private DataGridViewRow row = null;
        public Form1()
        {
            InitializeComponent();
            dbConnection = new DatabaseConnection(host, database, user, password); // Inicializa a conexão com o banco de dados usando as variáveis definidas.

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Carrega os ComboBoxes para a aba Produto
            CarregarFornecedoresComboBox();
            CarregarCategoriasComboBox();

            // Carrega os DataGridViews de cada aba
            CarregarFornecedoresDataGridView();
            CarregarCategoriasDataGridView();
            CarregarProdutosDataGridView();
        }

        private void CarregarFornecedoresComboBox()
        {
            try
            {
                // Executa o comando SQL
                string sql = "SELECT id, nome_fornecedor FROM Fornecedor ORDER BY nome_fornecedor";

                using (var conn = dbConnection.GetConnection())
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    // Cria um DataTable para armazenar os dados lidos.
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Configura os dados da ComboBox
                    cbIdfornec.DataSource = dt;
                    cbIdfornec.DisplayMember = "nome_fornecedor";
                    cbIdfornec.ValueMember = "id";

                    //Garante que a ComboBox inicie vazia
                    cbIdfornec.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar a lista de fornecedores. Detalhes: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarCategoriasComboBox()
        {
            try
            {
                // Executa o comando SQL
                string sql = "SELECT id, nome_categoria FROM Categoria ORDER BY nome_categoria";

                using (var conn = dbConnection.GetConnection())
                using (var cmd = new NpgsqlCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    // Cria um DataTable para armazenar os dados lidos.
                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    // Configura os dados da ComboBox
                    cbIdcateg.DataSource = dt;
                    cbIdcateg.DisplayMember = "nome_categoria";
                    cbIdcateg.ValueMember = "id";

                    //Garante que a ComboBox inicie vazia
                    cbIdcateg.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível carregar a lista de categorias. Detalhes: " + ex.Message, "Erro de Conexão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ----------------------------------------------------
        // Métodos para o DataGridView
        // ----------------------------------------------------
        private void CarregarFornecedoresDataGridView()
        {
            try
            {
                // Executa o comando SQL
                string sql = "SELECT id, nome_fornecedor, contato, cnpj FROM Fornecedor ORDER BY nome_fornecedor";

                using (var conn = dbConnection.GetConnection())
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    // Cria um NpgsqlDataAdapter para preencher um DataTable com os dados da consulta.
                    var dataAdapter = new NpgsqlDataAdapter(cmd);
                    var dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // Define o DataTable como a fonte de dados do DataGridView.
                    dataGridViewFornecedor.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar fornecedores: " + ex.Message);
            }
        }

        private void CarregarCategoriasDataGridView()
        {
            try
            {
                // Executa o comando SQL
                string sql = "SELECT id, nome_categoria, descricao FROM Categoria ORDER BY nome_categoria";

                using (var conn = dbConnection.GetConnection())
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    // Cria um NpgsqlDataAdapter para preencher um DataTable com os dados da consulta.
                    var dataAdapter = new NpgsqlDataAdapter(cmd);
                    var dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // Define o DataTable como a fonte de dados do DataGridView.
                    dataGridViewCategoria.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar categorias: " + ex.Message);
            }
        }

        private void CarregarProdutosDataGridView()
        {
            try
            {
                // Executa o comando SQL
                string sql = "SELECT p.id, p.nome_produto, p.quantidade, p.preco_unitario, " +
                             "f.nome_fornecedor, c.nome_categoria, p.id_fornecedor, p.id_categoria " +
                             "FROM Produto p " +
                             "JOIN Fornecedor f ON p.id_fornecedor = f.id " +
                             "JOIN Categoria c ON p.id_categoria = c.id " +
                             "ORDER BY p.id";

                using (var conn = dbConnection.GetConnection())
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    // Cria um NpgsqlDataAdapter para preencher um DataTable com os dados da consulta.
                    var dataAdapter = new NpgsqlDataAdapter(cmd);
                    var dt = new DataTable();
                    dataAdapter.Fill(dt);

                    // Define o DataTable como a fonte de dados do DataGridView.
                    dataGridViewProduto.DataSource = dt;

                    // Oculta as colunas de ID
                    dataGridViewProduto.Columns["id_fornecedor"].Visible = false;
                    dataGridViewProduto.Columns["id_categoria"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao carregar produtos: " + ex.Message);
            }
        }

        // ----------------------------------------------------
        // Métodos para o botão Gravar
        // ----------------------------------------------------
        private void btGravarprod_Click(object sender, EventArgs e)
        {
            try
            {
                // Validação básica para garantir que um item foi selecionado
                if (cbIdfornec.SelectedValue == null || cbIdcateg.SelectedValue == null)
                {
                    MessageBox.Show("Por favor, selecione um fornecedor e uma categoria.");
                    return;
                }

                // Obtem os dados do formulário e instancia a classe Produto usando o construtor
                string nome = tbNomeprod.Text;
                int quantidade = int.Parse(tbQuantprod.Text);
                decimal precoUnitario = decimal.Parse(tbPrecoprod.Text);
                int idFornecedor = (int)cbIdfornec.SelectedValue;
                int idCategoria = (int)cbIdcateg.SelectedValue;

                Produto novoProduto = new Produto(nome, quantidade, precoUnitario, idFornecedor, idCategoria);

                // Cria a string de comando SQL para INSERT
                string sql = "INSERT INTO Produto (nome_produto, quantidade, preco_unitario, id_fornecedor, id_categoria) " +
                             "VALUES (@nome, @quantidade, @preco, @idFornecedor, @idCategoria)";

                // Obtem a conexão e o comando
                using (var conn = dbConnection.GetConnection())
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    // Adiciona os parâmetros
                    cmd.Parameters.AddWithValue("nome", novoProduto.Nome);
                    cmd.Parameters.AddWithValue("quantidade", novoProduto.Quantidade);
                    cmd.Parameters.AddWithValue("preco", novoProduto.PrecoUnitario);
                    cmd.Parameters.AddWithValue("idFornecedor", novoProduto.IdFornecedor);
                    cmd.Parameters.AddWithValue("idCategoria", novoProduto.IdCategoria);

                    // Executar o comando
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produto gravado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar produto: " + ex.Message);
            }

            // Limpa os campos após a gravação
            LimparCamposProduto();

            // Atualiza o DataGridView para exibir o novo item
            CarregarProdutosDataGridView();
        }

        private void btGravarfornec_Click(object sender, EventArgs e)
        {
            // Validação do CNPJ
            if (!mtbCnpjfornec.MaskFull)
            {
                MessageBox.Show("Por favor, digite o CNPJ completo.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Sai do método se o campo não estiver completo
            }

            try
            {
                // Obtem os dados do formulário
                string nome = tbNomefornec.Text;
                string contato = tbContatofornec.Text;

                // Pega o valor do MaskedTextBox e remove os caracteres não numéricos.
                string cnpj = mtbCnpjfornec.Text;

                // Instancia a classe Fornecedor usando o construtor
                Fornecedor novoFornecedor = new Fornecedor(nome, contato, cnpj);

                // Cria a string de comando SQL para INSERT
                string sql = "INSERT INTO Fornecedor (nome_fornecedor, contato, cnpj) " +
                             "VALUES (@nome, @contato, @cnpj)";

                // Obtem a conexão e o comando
                using (var conn = dbConnection.GetConnection())
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    // Adiciona os parâmetros
                    cmd.Parameters.AddWithValue("nome", novoFornecedor.Nome);
                    cmd.Parameters.AddWithValue("contato", novoFornecedor.Contato);
                    cmd.Parameters.AddWithValue("cnpj", novoFornecedor.Cnpj);

                    // Executar o comando
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Fornecedor gravado com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar fornecedor: " + ex.Message);
            }
            //Limpa os campos após a gravação
            LimparCamposFornecedor();

            // Atualiza os DataGridView e ComboBox de fornecedores.
            CarregarFornecedoresDataGridView();
            CarregarFornecedoresComboBox();
        }

        private void btGravarcateg_Click(object sender, EventArgs e)
        {
            try
            {

                // Obtem os dados do formulário
                string nome = tbNomecateg.Text;
                string descricao = tbDescricaocateg.Text;

                // Instancia a classe Categoria usando o construtor
                Categoria novaCategoria = new Categoria(nome, descricao);

                // Cria a string de comando SQL para INSERT
                string sql = "INSERT INTO Categoria (nome_categoria, descricao) " +
                             "VALUES (@nome, @descricao)";

                // Obtem a conexão e o comando
                using (var conn = dbConnection.GetConnection())
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    // Adiciona os parâmetros
                    cmd.Parameters.AddWithValue("nome", novaCategoria.Nome);
                    cmd.Parameters.AddWithValue("descricao", novaCategoria.Descricao);

                    // Executar o comando
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Categoria gravada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao gravar categoria: " + ex.Message);
            }
            // Limpa os campos após a gravação
            LimparCamposCategoria();

            // Atualiza os DataGridView e ComboBox de categorias.
            CarregarCategoriasDataGridView();
            CarregarCategoriasComboBox();
        }

        // ----------------------------------------------------
        // Métodos para Double Click no Data Grid View
        // ----------------------------------------------------
        private void dataGridViewProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se há alguma linha selecionada
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewProduto.Rows.Count - 1)
            {
                // Limpa destaque da linha anterior
                if (row != null)
                    row.DefaultCellStyle.BackColor = dataGridViewProduto.DefaultCellStyle.BackColor;

                // Pega a linha completa que foi clicada
                row = this.dataGridViewProduto.Rows[e.RowIndex];
                row.DefaultCellStyle.BackColor = Color.LightYellow; // Cor de destaque para selecionar

                row.Selected = true;

                // Armazene o ID do produto para uso na atualização e exclusão
                produtoIdSelecionado = (int)row.Cells["id"].Value;

                // Preenche os campos de texto com os dados da linha
                tbIdprod.Text = produtoIdSelecionado.ToString();
                tbNomeprod.Text = row.Cells["nome_produto"].Value.ToString();
                tbQuantprod.Text = row.Cells["quantidade"].Value.ToString();
                tbPrecoprod.Text = row.Cells["preco_unitario"].Value.ToString();

                // Para os ComboBoxes, o `SelectedValue` é definido com base no ID da chave estrangeira.
                cbIdfornec.SelectedValue = Convert.ToInt32(row.Cells["id_fornecedor"].Value);
                cbIdcateg.SelectedValue = Convert.ToInt32(row.Cells["id_categoria"].Value);

            }
          
        }

        private void dataGridViewFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se há alguma linha selecionada
            if (e.RowIndex >= 0)
            {
                // Limpa destaque da linha anterior
                if (row != null)
                    row.DefaultCellStyle.BackColor = dataGridViewProduto.DefaultCellStyle.BackColor;

                // Pega a linha completa que foi clicada
                row = this.dataGridViewFornecedor.Rows[e.RowIndex];
                row.DefaultCellStyle.BackColor = Color.LightYellow; // Cor de destaque para selecionar

                row.Selected = true;

                // Preenche os campos de texto com os dados da linha
                fornecedorIdSelecionado = (int)row.Cells["id"].Value;
                tbIdfornec.Text = fornecedorIdSelecionado.ToString();
                tbNomefornec.Text = row.Cells["nome_fornecedor"].Value.ToString();
                tbContatofornec.Text = row.Cells["contato"].Value.ToString();
                mtbCnpjfornec.Text = row.Cells["cnpj"].Value.ToString();
            }
        }

        private void dataGridViewCategoria_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verifica se há alguma linha selecionada
            if (e.RowIndex >= 0)
            {
                // Limpa destaque da linha anterior
                if (row != null)
                    row.DefaultCellStyle.BackColor = dataGridViewProduto.DefaultCellStyle.BackColor;

                // Pega a linha completa que foi clicada
                row = this.dataGridViewCategoria.Rows[e.RowIndex];
                row.DefaultCellStyle.BackColor = Color.LightYellow; // Cor de destaque para selecionar

                row.Selected = true;

                // Preenche os campos de texto com os dados da linha
                categoriaIdSelecionada = (int)row.Cells["id"].Value;
                tbIdcateg.Text = categoriaIdSelecionada.ToString();
                tbNomecateg.Text = row.Cells["nome_categoria"].Value.ToString();
                tbDescricaocateg.Text = row.Cells["descricao"].Value.ToString();
            }
        }

        // ----------------------------------------------------
        // Métodos para o botão atualizar
        // ----------------------------------------------------
        private void btAtualizarprod_Click(object sender, EventArgs e)
        {
            // Certifique-se de que um produto foi selecionado (o ID não pode ser 0)
            if (produtoIdSelecionado == 0)
            {
                MessageBox.Show("Por favor, selecione um produto para atualizar.");
                return;
            }

            try
            {
                // Pega os dados dos campos
                string nome = tbNomeprod.Text;
                int quantidade = int.Parse(tbQuantprod.Text);
                decimal preco = decimal.Parse(tbPrecoprod.Text);
                int idFornecedor = (int)cbIdfornec.SelectedValue;
                int idCategoria = (int)cbIdcateg.SelectedValue;

                // O comando SQL UPDATE
                string sql = "UPDATE Produto SET nome_produto = @nome, quantidade = @quantidade, " +
                             "preco_unitario = @preco, id_fornecedor = @idFornecedor, id_categoria = @idCategoria " +
                             "WHERE id = @id";

                // Obtém a conexão
                using (var conn = dbConnection.GetConnection())
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    // Adiciona os parâmetros
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.Parameters.AddWithValue("quantidade", quantidade);
                    cmd.Parameters.AddWithValue("preco", preco);
                    cmd.Parameters.AddWithValue("idFornecedor", idFornecedor);
                    cmd.Parameters.AddWithValue("idCategoria", idCategoria);
                    cmd.Parameters.AddWithValue("id", produtoIdSelecionado); // Usa o ID do produto selecionado

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Produto atualizado com sucesso!");

                    // Atualiza o DataGridView para exibir os dados atualizados
                    CarregarProdutosDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar produto: " + ex.Message);
            }
        }

        private void btAtualizarfornec_Click(object sender, EventArgs e)
        {
            // Certifique-se de que um fornecedor foi selecionado (o ID não pode ser 0)
            if (fornecedorIdSelecionado == 0)
            {
                MessageBox.Show("Por favor, selecione um fornecedor para atualizar.");
                return;
            }

            try
            {
                // Pega os dados dos campos
                string nome = tbNomefornec.Text;
                string contato = tbContatofornec.Text;
                string cnpj = mtbCnpjfornec.Text;

                // O comando SQL UPDATE
                string sql = "UPDATE Fornecedor SET nome_fornecedor = @nome, contato = @contato, cnpj = @cnpj WHERE id = @id";

                // Obtém a conexão
                using (var conn = dbConnection.GetConnection())
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    // Adiciona os parâmetros
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.Parameters.AddWithValue("contato", contato);
                    cmd.Parameters.AddWithValue("cnpj", cnpj);
                    cmd.Parameters.AddWithValue("id", fornecedorIdSelecionado);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Fornecedor atualizado com sucesso!");

                    // Atualiza o DataGridView para exibir os dados atualizados
                    CarregarFornecedoresDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar fornecedor: " + ex.Message);
            }

        }

        private void btAtualizarcateg_Click(object sender, EventArgs e)
        {
            // Certifique-se de que uma categoria foi selecionada (o ID não pode ser 0)
            if (categoriaIdSelecionada == 0)
            {
                MessageBox.Show("Por favor, selecione uma categoria para atualizar.");
                return;
            }

            try
            {
                // Pega os dados dos campos
                string nome = tbNomecateg.Text;
                string descricao = tbDescricaocateg.Text;

                // O comando SQL UPDATE
                string sql = "UPDATE Categoria SET nome_categoria = @nome, descricao = @descricao WHERE id = @id";

                // Obtém a conexão
                using (var conn = dbConnection.GetConnection())
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    // Adiciona os parâmetros
                    cmd.Parameters.AddWithValue("nome", nome);
                    cmd.Parameters.AddWithValue("descricao", descricao);
                    cmd.Parameters.AddWithValue("id", categoriaIdSelecionada);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Categoria atualizada com sucesso!");

                    // Atualiza o DataGridView para exibir os dados atualizados
                    CarregarCategoriasDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar categoria: " + ex.Message);
            }
        }

        // ----------------------------------------------------
        // Métodos para o botão Deletar
        // ----------------------------------------------------
        private void btDeletarprod_Click(object sender, EventArgs e)
        {
            // Verifica se um produto foi selecionado (o ID não pode ser 0)
            if (produtoIdSelecionado == 0)
            {
                MessageBox.Show("Por favor, selecione um produto para deletar.");
                return;
            }

            // Cria a mensagem de confirmação com os dados do item
            string mensagem = $"Tem certeza que deseja deletar o seguinte produto? Esta ação não pode ser desfeita.\n\n" +
                              $"ID: {produtoIdSelecionado}\n" +
                              $"Nome: {tbNomeprod.Text}\n" +
                              $"Quantidade: {tbQuantprod.Text}\n" +
                              $"Preço: {tbPrecoprod.Text}";

            // Adiciona uma mensagem de confirmação para o usuário
            DialogResult confirmacao = MessageBox.Show(mensagem, "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    // O comando SQL DELETE
                    string sql = "DELETE FROM Produto WHERE id = @id";

                    // Obtém a conexão
                    using (var conn = dbConnection.GetConnection())
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        // Adiciona o parâmetro do ID do produto
                        cmd.Parameters.AddWithValue("id", produtoIdSelecionado);

                        // Executa o comando
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Produto deletado com sucesso!");

                        // Limpa os campos e atualiza a lista
                        LimparCamposProduto();
                        CarregarProdutosDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar produto: " + ex.Message);
                }
            }
        }

        private void btDeletarfornec_Click(object sender, EventArgs e)
        {
            // Verifica se um fornecedor foi selecionado (o ID não pode ser 0)
            if (fornecedorIdSelecionado == 0)
            {
                MessageBox.Show("Por favor, selecione um fornecedor para deletar.");
                return;
            }

            // Verifica se o fornecedor está vinculado a algum produto
            if (VerificarVinculoFornecedor())
            {
                return;
            }

            // Cria a mensagem de confirmação com os dados do fornecedor
            string mensagem = $"Tem certeza que deseja deletar o seguinte fornecedor? Esta ação não pode ser desfeita.\n\n" +
                              $"ID: {fornecedorIdSelecionado}\n" +
                              $"Nome: {tbNomefornec.Text}\n" +
                              $"Contato: {tbContatofornec.Text}\n" +
                              $"CNPJ: {mtbCnpjfornec.Text}";

            // Adiciona uma mensagem de confirmação para o usuário
            DialogResult confirmacao = MessageBox.Show(mensagem, "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    // O comando SQL DELETE
                    string sql = "DELETE FROM Fornecedor WHERE id = @id";

                    // Obtém a conexão
                    using (var conn = dbConnection.GetConnection())
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        // Adiciona o parâmetro do ID do fornecedor
                        cmd.Parameters.AddWithValue("id", fornecedorIdSelecionado);

                        // Executa o comando
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Fornecedor deletado com sucesso!");

                        // Limpa os campos e atualiza a lista
                        LimparCamposFornecedor();
                        CarregarFornecedoresDataGridView();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar fornecedor: " + ex.Message);
                }
            }
        }

        private void btDeletarcateg_Click(object sender, EventArgs e)
        {
            // Verifica se uma categoria foi selecionada (o ID não pode ser 0)
            if (categoriaIdSelecionada == 0)
            {
                MessageBox.Show("Por favor, selecione uma categoria para deletar.");
                return;
            }

            // Verifica se a categoria está vinculada a algum produto
            if (VerificarVinculoCategoria())
            {
                return;
            }

            // Cria a mensagem de confirmação com os dados da categoria
            string mensagem = $"Tem certeza que deseja deletar a seguinte categoria? Esta ação não pode ser desfeita.\n\n" +
                              $"ID: {categoriaIdSelecionada}\n" +
                              $"Nome: {tbNomecateg.Text}\n" +
                              $"Descrição: {tbDescricaocateg.Text}";

            // Adiciona uma mensagem de confirmação para o usuário
            DialogResult confirmacao = MessageBox.Show(mensagem, "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (confirmacao == DialogResult.Yes)
            {
                try
                {
                    // O comando SQL DELETE
                    string sql = "DELETE FROM Categoria WHERE id = @id";

                    // Obtém a conexão
                    using (var conn = dbConnection.GetConnection())
                    using (var cmd = new NpgsqlCommand(sql, conn))
                    {
                        // Adiciona o parâmetro do ID da categoria
                        cmd.Parameters.AddWithValue("id", categoriaIdSelecionada);

                        // Executa o comando
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Categoria deletada com sucesso!");

                        // Limpa os campos e atualiza a lista
                        LimparCamposCategoria();
                        CarregarCategoriasDataGridView();

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao deletar categoria: " + ex.Message);
                }
            }
        }

        // ----------------------------------------------------
        // Métodos auxiliares para verificar vínculos entre as tabelas
        // ----------------------------------------------------
        private bool VerificarVinculoFornecedor()
        {
            // Verifica se o fornecedor está vinculado a algum produto
            string sqlVerificacao = "SELECT id, nome_produto FROM Produto WHERE id_fornecedor = @id_fornecedor";

            using (var conn = dbConnection.GetConnection())
            {
                using (var cmdVerificacao = new NpgsqlCommand(sqlVerificacao, conn))
                {
                    cmdVerificacao.Parameters.AddWithValue("id_fornecedor", fornecedorIdSelecionado);
                    var produtosVinculados = new DataTable();
                    new NpgsqlDataAdapter(cmdVerificacao).Fill(produtosVinculados);

                    // Se houver produtos vinculados, mostra a mensagem de erro detalhada
                    if (produtosVinculados.Rows.Count > 0)
                    {
                        string listaProdutos = "";
                        foreach (DataRow row in produtosVinculados.Rows)
                        {
                            listaProdutos += $"ID: {row["id"]} / Nome: {row["nome_produto"]}\n";
                        }

                        string mensagemErro = "Não é possível deletar este fornecedor, pois ele está vinculado aos seguintes produtos:\n\n" + listaProdutos +
                                              "\nPor favor, modifique ou delete estes produtos primeiro.";

                        MessageBox.Show(mensagemErro, "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        private bool VerificarVinculoCategoria()
        {
            // Verifica se a categoria está vinculada a algum produto
            string sqlVerificacao = "SELECT id, nome_produto FROM Produto WHERE id_categoria = @id_categoria";

            using (var conn = dbConnection.GetConnection())
            {
                using (var cmdVerificacao = new NpgsqlCommand(sqlVerificacao, conn))
                {
                    cmdVerificacao.Parameters.AddWithValue("id_categoria", categoriaIdSelecionada);
                    var produtosVinculados = new DataTable();
                    new NpgsqlDataAdapter(cmdVerificacao).Fill(produtosVinculados);

                    // Se houver produtos vinculados, mostra a mensagem de erro detalhada
                    if (produtosVinculados.Rows.Count > 0)
                    {
                        string listaProdutos = "";
                        foreach (DataRow row in produtosVinculados.Rows)
                        {
                            listaProdutos += $"ID: {row["id"]} / Nome: {row["nome_produto"]}\n";
                        }

                        string mensagemErro = "Não é possível deletar esta categoria, pois ela está vinculada aos seguintes produtos:\n\n" + listaProdutos +
                                              "\nPor favor, modifique ou delete estes produtos primeiro.";

                        MessageBox.Show(mensagemErro, "Erro de Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return true; // Sai do método sem tentar a exclusão
                    }
                    else
                    {
                        return false;
                    }
                }
            }
        }

        // ----------------------------------------------------
        // Métodos auxiliares para limpar os campos do formulário
        // ----------------------------------------------------
        private void LimparCamposProduto()
        {
            // Limpa todos os campos do formulário da aba de Produtos.
            tbIdprod.Clear();
            tbNomeprod.Clear();
            tbQuantprod.Clear();
            tbPrecoprod.Clear();
            cbIdfornec.SelectedIndex = -1; // Desseleciona o item do ComboBox
            cbIdcateg.SelectedIndex = -1;
            produtoIdSelecionado = 0; // Reseta o ID selecionado
        }

        private void LimparCamposFornecedor()
        {
            // Limpa todos os campos do formulário da aba de Fornecedores.
            tbIdfornec.Clear();
            tbNomefornec.Clear();
            tbContatofornec.Clear();
            mtbCnpjfornec.Clear();
            fornecedorIdSelecionado = 0; // Reseta o ID selecionado
        }

        private void LimparCamposCategoria()
        {
            // Limpa todos os campos do formulário da aba de Categorias.
            tbIdcateg.Clear();
            tbNomecateg.Clear();
            tbDescricaocateg.Clear();
            categoriaIdSelecionada = 0; // Reseta o ID selecionado
        }

        // ----------------------------------------------------
        // Métodos para botão Limpar 
        // ----------------------------------------------------
        private void btLimparprod_Click(object sender, EventArgs e)
        {
            // Chama o método auxiliar para limpar os campos
            LimparCamposProduto(); 
        }

        private void btLimparfornec_Click(object sender, EventArgs e)
        {
            // Chama o método auxiliar para limpar os campos
            LimparCamposFornecedor();
        }

        private void btLimparcateg_Click(object sender, EventArgs e)
        {
            // Chama o método auxiliar para limpar os campos
            LimparCamposCategoria();
        }

    }

    
}
