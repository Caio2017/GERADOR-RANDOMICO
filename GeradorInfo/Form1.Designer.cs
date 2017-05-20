namespace GeradorInfo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerarNomes = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkAspasSimples = new System.Windows.Forms.CheckBox();
            this.groupBox11 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMultiplos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumerosAte = new System.Windows.Forms.TextBox();
            this.txtNumerosDe = new System.Windows.Forms.TextBox();
            this.btnGerarNumeros = new System.Windows.Forms.Button();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSeparador = new System.Windows.Forms.TextBox();
            this.txtPalavras = new System.Windows.Forms.TextBox();
            this.btnGerarPalavras = new System.Windows.Forms.Button();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chkParentesesRight = new System.Windows.Forms.CheckBox();
            this.chkParentesesLeft = new System.Windows.Forms.CheckBox();
            this.chkVirgula = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkTxtPreferencia = new System.Windows.Forms.TextBox();
            this.chkPreferencia = new System.Windows.Forms.CheckBox();
            this.chkYahoo = new System.Windows.Forms.CheckBox();
            this.chkOutlook = new System.Windows.Forms.CheckBox();
            this.chkGmail = new System.Windows.Forms.CheckBox();
            this.btnGerarEmail = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.chkIncluirMaskTelCel = new System.Windows.Forms.CheckBox();
            this.btnGerarCel = new System.Windows.Forms.Button();
            this.btnGerarTel = new System.Windows.Forms.Button();
            this.rdoDDDtxt = new System.Windows.Forms.RadioButton();
            this.rdoDDDaleatorio = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDDDs = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdoOnlyHrMin = new System.Windows.Forms.RadioButton();
            this.rdoHrMinSeg = new System.Windows.Forms.RadioButton();
            this.btnGerarHora = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.chkComHoras = new System.Windows.Forms.CheckBox();
            this.dtpAte = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGerarDatas = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDe = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCnjp = new System.Windows.Forms.Button();
            this.rdoIncluirMascaraCpf = new System.Windows.Forms.RadioButton();
            this.rdoApenasNumeros = new System.Windows.Forms.RadioButton();
            this.btnCpf = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkNomeDoMeio = new System.Windows.Forms.CheckBox();
            this.chkComNomeDoFim = new System.Windows.Forms.CheckBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            this.groupBox11.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGerarNomes
            // 
            this.btnGerarNomes.Location = new System.Drawing.Point(28, 86);
            this.btnGerarNomes.Name = "btnGerarNomes";
            this.btnGerarNomes.Size = new System.Drawing.Size(62, 23);
            this.btnGerarNomes.TabIndex = 0;
            this.btnGerarNomes.Text = "Nomes";
            this.btnGerarNomes.UseVisualStyleBackColor = true;
            this.btnGerarNomes.Click += new System.EventHandler(this.btnGerarNomes_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkAspasSimples);
            this.groupBox1.Controls.Add(this.groupBox11);
            this.groupBox1.Controls.Add(this.groupBox10);
            this.groupBox1.Controls.Add(this.groupBox8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 456);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gerar";
            // 
            // chkAspasSimples
            // 
            this.chkAspasSimples.AutoSize = true;
            this.chkAspasSimples.Checked = true;
            this.chkAspasSimples.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAspasSimples.Location = new System.Drawing.Point(273, 26);
            this.chkAspasSimples.Name = "chkAspasSimples";
            this.chkAspasSimples.Size = new System.Drawing.Size(28, 17);
            this.chkAspasSimples.TabIndex = 12;
            this.chkAspasSimples.Text = "\'";
            this.chkAspasSimples.UseVisualStyleBackColor = true;
            // 
            // groupBox11
            // 
            this.groupBox11.Controls.Add(this.label7);
            this.groupBox11.Controls.Add(this.txtMultiplos);
            this.groupBox11.Controls.Add(this.label4);
            this.groupBox11.Controls.Add(this.label3);
            this.groupBox11.Controls.Add(this.txtNumerosAte);
            this.groupBox11.Controls.Add(this.txtNumerosDe);
            this.groupBox11.Controls.Add(this.btnGerarNumeros);
            this.groupBox11.Location = new System.Drawing.Point(267, 278);
            this.groupBox11.Name = "groupBox11";
            this.groupBox11.Size = new System.Drawing.Size(128, 137);
            this.groupBox11.TabIndex = 11;
            this.groupBox11.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Multiplos de";
            // 
            // txtMultiplos
            // 
            this.txtMultiplos.Location = new System.Drawing.Point(66, 84);
            this.txtMultiplos.MaxLength = 20;
            this.txtMultiplos.Name = "txtMultiplos";
            this.txtMultiplos.Size = new System.Drawing.Size(53, 20);
            this.txtMultiplos.TabIndex = 17;
            this.txtMultiplos.Text = "100";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "De:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Até:";
            // 
            // txtNumerosAte
            // 
            this.txtNumerosAte.Location = new System.Drawing.Point(7, 58);
            this.txtNumerosAte.MaxLength = 20;
            this.txtNumerosAte.Name = "txtNumerosAte";
            this.txtNumerosAte.Size = new System.Drawing.Size(111, 20);
            this.txtNumerosAte.TabIndex = 14;
            this.txtNumerosAte.Text = "2000";
            // 
            // txtNumerosDe
            // 
            this.txtNumerosDe.Location = new System.Drawing.Point(6, 24);
            this.txtNumerosDe.MaxLength = 20;
            this.txtNumerosDe.Name = "txtNumerosDe";
            this.txtNumerosDe.Size = new System.Drawing.Size(112, 20);
            this.txtNumerosDe.TabIndex = 13;
            this.txtNumerosDe.Text = "0";
            // 
            // btnGerarNumeros
            // 
            this.btnGerarNumeros.Location = new System.Drawing.Point(22, 108);
            this.btnGerarNumeros.Name = "btnGerarNumeros";
            this.btnGerarNumeros.Size = new System.Drawing.Size(75, 23);
            this.btnGerarNumeros.TabIndex = 12;
            this.btnGerarNumeros.Text = "Numeros";
            this.btnGerarNumeros.UseVisualStyleBackColor = true;
            this.btnGerarNumeros.Click += new System.EventHandler(this.btnGerarNumeros_Click);
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.label8);
            this.groupBox10.Controls.Add(this.txtSeparador);
            this.groupBox10.Controls.Add(this.txtPalavras);
            this.groupBox10.Controls.Add(this.btnGerarPalavras);
            this.groupBox10.Location = new System.Drawing.Point(267, 56);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(125, 216);
            this.groupBox10.TabIndex = 10;
            this.groupBox10.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(4, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Separar por:";
            // 
            // txtSeparador
            // 
            this.txtSeparador.Location = new System.Drawing.Point(76, 10);
            this.txtSeparador.MaxLength = 20;
            this.txtSeparador.Name = "txtSeparador";
            this.txtSeparador.Size = new System.Drawing.Size(42, 20);
            this.txtSeparador.TabIndex = 18;
            this.txtSeparador.Text = "|";
            // 
            // txtPalavras
            // 
            this.txtPalavras.Location = new System.Drawing.Point(10, 36);
            this.txtPalavras.Multiline = true;
            this.txtPalavras.Name = "txtPalavras";
            this.txtPalavras.Size = new System.Drawing.Size(108, 145);
            this.txtPalavras.TabIndex = 17;
            this.txtPalavras.Text = "1|0|true|false|sim|nao";
            // 
            // btnGerarPalavras
            // 
            this.btnGerarPalavras.Location = new System.Drawing.Point(22, 187);
            this.btnGerarPalavras.Name = "btnGerarPalavras";
            this.btnGerarPalavras.Size = new System.Drawing.Size(75, 23);
            this.btnGerarPalavras.TabIndex = 11;
            this.btnGerarPalavras.Text = "Palavras";
            this.btnGerarPalavras.UseVisualStyleBackColor = true;
            this.btnGerarPalavras.Click += new System.EventHandler(this.btnGerarPalavras_Click);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.chkParentesesRight);
            this.groupBox8.Controls.Add(this.chkParentesesLeft);
            this.groupBox8.Controls.Add(this.chkVirgula);
            this.groupBox8.Location = new System.Drawing.Point(144, 8);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(175, 42);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Incluir";
            // 
            // chkParentesesRight
            // 
            this.chkParentesesRight.AutoSize = true;
            this.chkParentesesRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkParentesesRight.Location = new System.Drawing.Point(85, 15);
            this.chkParentesesRight.Name = "chkParentesesRight";
            this.chkParentesesRight.Size = new System.Drawing.Size(31, 20);
            this.chkParentesesRight.TabIndex = 10;
            this.chkParentesesRight.Text = ")";
            this.chkParentesesRight.UseVisualStyleBackColor = true;
            // 
            // chkParentesesLeft
            // 
            this.chkParentesesLeft.AutoSize = true;
            this.chkParentesesLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkParentesesLeft.Location = new System.Drawing.Point(6, 16);
            this.chkParentesesLeft.Name = "chkParentesesLeft";
            this.chkParentesesLeft.Size = new System.Drawing.Size(31, 20);
            this.chkParentesesLeft.TabIndex = 9;
            this.chkParentesesLeft.Text = "(";
            this.chkParentesesLeft.UseVisualStyleBackColor = true;
            // 
            // chkVirgula
            // 
            this.chkVirgula.AutoSize = true;
            this.chkVirgula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkVirgula.Location = new System.Drawing.Point(45, 14);
            this.chkVirgula.Name = "chkVirgula";
            this.chkVirgula.Size = new System.Drawing.Size(32, 24);
            this.chkVirgula.TabIndex = 8;
            this.chkVirgula.Text = ",";
            this.chkVirgula.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 18);
            this.label6.TabIndex = 7;
            this.label6.Text = "Quantidade:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(90, 20);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(46, 26);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chkTxtPreferencia);
            this.groupBox7.Controls.Add(this.chkPreferencia);
            this.groupBox7.Controls.Add(this.chkYahoo);
            this.groupBox7.Controls.Add(this.chkOutlook);
            this.groupBox7.Controls.Add(this.chkGmail);
            this.groupBox7.Controls.Add(this.btnGerarEmail);
            this.groupBox7.Location = new System.Drawing.Point(140, 282);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(123, 133);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            // 
            // chkTxtPreferencia
            // 
            this.chkTxtPreferencia.Location = new System.Drawing.Point(26, 68);
            this.chkTxtPreferencia.Multiline = true;
            this.chkTxtPreferencia.Name = "chkTxtPreferencia";
            this.chkTxtPreferencia.Size = new System.Drawing.Size(89, 37);
            this.chkTxtPreferencia.TabIndex = 8;
            this.chkTxtPreferencia.Text = "@domain1.com;@domain2.com";
            // 
            // chkPreferencia
            // 
            this.chkPreferencia.AutoSize = true;
            this.chkPreferencia.Location = new System.Drawing.Point(9, 71);
            this.chkPreferencia.Name = "chkPreferencia";
            this.chkPreferencia.Size = new System.Drawing.Size(15, 14);
            this.chkPreferencia.TabIndex = 7;
            this.chkPreferencia.UseVisualStyleBackColor = true;
            // 
            // chkYahoo
            // 
            this.chkYahoo.AutoSize = true;
            this.chkYahoo.Checked = true;
            this.chkYahoo.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkYahoo.Location = new System.Drawing.Point(8, 48);
            this.chkYahoo.Name = "chkYahoo";
            this.chkYahoo.Size = new System.Drawing.Size(89, 17);
            this.chkYahoo.TabIndex = 6;
            this.chkYahoo.Text = "@yahoo.com";
            this.chkYahoo.UseVisualStyleBackColor = true;
            // 
            // chkOutlook
            // 
            this.chkOutlook.AutoSize = true;
            this.chkOutlook.Checked = true;
            this.chkOutlook.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOutlook.Location = new System.Drawing.Point(8, 30);
            this.chkOutlook.Name = "chkOutlook";
            this.chkOutlook.Size = new System.Drawing.Size(95, 17);
            this.chkOutlook.TabIndex = 5;
            this.chkOutlook.Text = "@outlook.com";
            this.chkOutlook.UseVisualStyleBackColor = true;
            // 
            // chkGmail
            // 
            this.chkGmail.AutoSize = true;
            this.chkGmail.Checked = true;
            this.chkGmail.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkGmail.Location = new System.Drawing.Point(8, 11);
            this.chkGmail.Name = "chkGmail";
            this.chkGmail.Size = new System.Drawing.Size(84, 17);
            this.chkGmail.TabIndex = 4;
            this.chkGmail.Text = "@gmail.com";
            this.chkGmail.UseVisualStyleBackColor = true;
            // 
            // btnGerarEmail
            // 
            this.btnGerarEmail.Location = new System.Drawing.Point(23, 104);
            this.btnGerarEmail.Name = "btnGerarEmail";
            this.btnGerarEmail.Size = new System.Drawing.Size(65, 23);
            this.btnGerarEmail.TabIndex = 3;
            this.btnGerarEmail.Text = "Email\'s";
            this.btnGerarEmail.UseVisualStyleBackColor = true;
            this.btnGerarEmail.Click += new System.EventHandler(this.btnGerarEmail_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.chkIncluirMaskTelCel);
            this.groupBox6.Controls.Add(this.btnGerarCel);
            this.groupBox6.Controls.Add(this.btnGerarTel);
            this.groupBox6.Controls.Add(this.rdoDDDtxt);
            this.groupBox6.Controls.Add(this.rdoDDDaleatorio);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtDDDs);
            this.groupBox6.Location = new System.Drawing.Point(144, 164);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(119, 110);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            // 
            // chkIncluirMaskTelCel
            // 
            this.chkIncluirMaskTelCel.AutoSize = true;
            this.chkIncluirMaskTelCel.Location = new System.Drawing.Point(7, 64);
            this.chkIncluirMaskTelCel.Name = "chkIncluirMaskTelCel";
            this.chkIncluirMaskTelCel.Size = new System.Drawing.Size(72, 17);
            this.chkIncluirMaskTelCel.TabIndex = 6;
            this.chkIncluirMaskTelCel.Text = "Incluir ( ) -";
            this.chkIncluirMaskTelCel.UseVisualStyleBackColor = true;
            // 
            // btnGerarCel
            // 
            this.btnGerarCel.Location = new System.Drawing.Point(62, 84);
            this.btnGerarCel.Name = "btnGerarCel";
            this.btnGerarCel.Size = new System.Drawing.Size(49, 23);
            this.btnGerarCel.TabIndex = 5;
            this.btnGerarCel.Text = "Cel\'s";
            this.btnGerarCel.UseVisualStyleBackColor = true;
            this.btnGerarCel.Click += new System.EventHandler(this.btnGerarCel_Click);
            // 
            // btnGerarTel
            // 
            this.btnGerarTel.Location = new System.Drawing.Point(3, 84);
            this.btnGerarTel.Name = "btnGerarTel";
            this.btnGerarTel.Size = new System.Drawing.Size(45, 23);
            this.btnGerarTel.TabIndex = 2;
            this.btnGerarTel.Text = "Tel\'s";
            this.btnGerarTel.UseVisualStyleBackColor = true;
            this.btnGerarTel.Click += new System.EventHandler(this.btnGerarTel_Click);
            // 
            // rdoDDDtxt
            // 
            this.rdoDDDtxt.AutoSize = true;
            this.rdoDDDtxt.Location = new System.Drawing.Point(7, 44);
            this.rdoDDDtxt.Name = "rdoDDDtxt";
            this.rdoDDDtxt.Size = new System.Drawing.Size(14, 13);
            this.rdoDDDtxt.TabIndex = 3;
            this.rdoDDDtxt.TabStop = true;
            this.rdoDDDtxt.UseVisualStyleBackColor = true;
            // 
            // rdoDDDaleatorio
            // 
            this.rdoDDDaleatorio.AutoSize = true;
            this.rdoDDDaleatorio.Checked = true;
            this.rdoDDDaleatorio.Location = new System.Drawing.Point(6, 19);
            this.rdoDDDaleatorio.Name = "rdoDDDaleatorio";
            this.rdoDDDaleatorio.Size = new System.Drawing.Size(105, 17);
            this.rdoDDDaleatorio.TabIndex = 2;
            this.rdoDDDaleatorio.TabStop = true;
            this.rdoDDDaleatorio.Text = "DDD\'s Aleatórios";
            this.rdoDDDaleatorio.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "DDD";
            // 
            // txtDDDs
            // 
            this.txtDDDs.Location = new System.Drawing.Point(52, 40);
            this.txtDDDs.Name = "txtDDDs";
            this.txtDDDs.Size = new System.Drawing.Size(65, 20);
            this.txtDDDs.TabIndex = 0;
            this.txtDDDs.Text = "11,12,21,22";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdoOnlyHrMin);
            this.groupBox5.Controls.Add(this.rdoHrMinSeg);
            this.groupBox5.Controls.Add(this.btnGerarHora);
            this.groupBox5.Location = new System.Drawing.Point(144, 56);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(111, 102);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            // 
            // rdoOnlyHrMin
            // 
            this.rdoOnlyHrMin.AutoSize = true;
            this.rdoOnlyHrMin.Checked = true;
            this.rdoOnlyHrMin.Location = new System.Drawing.Point(14, 19);
            this.rdoOnlyHrMin.Name = "rdoOnlyHrMin";
            this.rdoOnlyHrMin.Size = new System.Drawing.Size(65, 17);
            this.rdoOnlyHrMin.TabIndex = 10;
            this.rdoOnlyHrMin.TabStop = true;
            this.rdoOnlyHrMin.Text = "hora:min";
            this.rdoOnlyHrMin.UseVisualStyleBackColor = true;
            // 
            // rdoHrMinSeg
            // 
            this.rdoHrMinSeg.AutoSize = true;
            this.rdoHrMinSeg.Location = new System.Drawing.Point(14, 37);
            this.rdoHrMinSeg.Name = "rdoHrMinSeg";
            this.rdoHrMinSeg.Size = new System.Drawing.Size(85, 17);
            this.rdoHrMinSeg.TabIndex = 9;
            this.rdoHrMinSeg.TabStop = true;
            this.rdoHrMinSeg.Text = "hora:min:seg";
            this.rdoHrMinSeg.UseVisualStyleBackColor = true;
            // 
            // btnGerarHora
            // 
            this.btnGerarHora.Location = new System.Drawing.Point(22, 66);
            this.btnGerarHora.Name = "btnGerarHora";
            this.btnGerarHora.Size = new System.Drawing.Size(62, 23);
            this.btnGerarHora.TabIndex = 4;
            this.btnGerarHora.Text = "Horas";
            this.btnGerarHora.UseVisualStyleBackColor = true;
            this.btnGerarHora.Click += new System.EventHandler(this.btnGerarHora_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.chkComHoras);
            this.groupBox4.Controls.Add(this.dtpAte);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnGerarDatas);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.dtpDe);
            this.groupBox4.Location = new System.Drawing.Point(10, 282);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(121, 138);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            // 
            // chkComHoras
            // 
            this.chkComHoras.AutoSize = true;
            this.chkComHoras.Location = new System.Drawing.Point(10, 88);
            this.chkComHoras.Name = "chkComHoras";
            this.chkComHoras.Size = new System.Drawing.Size(68, 17);
            this.chkComHoras.TabIndex = 7;
            this.chkComHoras.Text = "c/ Horas";
            this.chkComHoras.UseVisualStyleBackColor = true;
            // 
            // dtpAte
            // 
            this.dtpAte.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpAte.Location = new System.Drawing.Point(9, 65);
            this.dtpAte.Name = "dtpAte";
            this.dtpAte.Size = new System.Drawing.Size(98, 20);
            this.dtpAte.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Até:";
            // 
            // btnGerarDatas
            // 
            this.btnGerarDatas.Location = new System.Drawing.Point(25, 108);
            this.btnGerarDatas.Name = "btnGerarDatas";
            this.btnGerarDatas.Size = new System.Drawing.Size(65, 23);
            this.btnGerarDatas.TabIndex = 2;
            this.btnGerarDatas.Text = "Datas";
            this.btnGerarDatas.UseVisualStyleBackColor = true;
            this.btnGerarDatas.Click += new System.EventHandler(this.btnGerarDatas_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "De:";
            // 
            // dtpDe
            // 
            this.dtpDe.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDe.Location = new System.Drawing.Point(6, 29);
            this.dtpDe.Name = "dtpDe";
            this.dtpDe.Size = new System.Drawing.Size(98, 20);
            this.dtpDe.TabIndex = 4;
            this.dtpDe.Value = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCnjp);
            this.groupBox3.Controls.Add(this.rdoIncluirMascaraCpf);
            this.groupBox3.Controls.Add(this.rdoApenasNumeros);
            this.groupBox3.Controls.Add(this.btnCpf);
            this.groupBox3.Location = new System.Drawing.Point(10, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(121, 110);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // btnCnjp
            // 
            this.btnCnjp.Location = new System.Drawing.Point(61, 85);
            this.btnCnjp.Name = "btnCnjp";
            this.btnCnjp.Size = new System.Drawing.Size(51, 20);
            this.btnCnjp.TabIndex = 6;
            this.btnCnjp.Text = "CNPJ\'s";
            this.btnCnjp.UseVisualStyleBackColor = true;
            this.btnCnjp.Click += new System.EventHandler(this.btnCnjp_Click);
            // 
            // rdoIncluirMascaraCpf
            // 
            this.rdoIncluirMascaraCpf.AutoSize = true;
            this.rdoIncluirMascaraCpf.Checked = true;
            this.rdoIncluirMascaraCpf.Location = new System.Drawing.Point(7, 44);
            this.rdoIncluirMascaraCpf.Name = "rdoIncluirMascaraCpf";
            this.rdoIncluirMascaraCpf.Size = new System.Drawing.Size(77, 17);
            this.rdoIncluirMascaraCpf.TabIndex = 3;
            this.rdoIncluirMascaraCpf.TabStop = true;
            this.rdoIncluirMascaraCpf.Text = "Incluir . . . -";
            this.rdoIncluirMascaraCpf.UseVisualStyleBackColor = true;
            // 
            // rdoApenasNumeros
            // 
            this.rdoApenasNumeros.AutoSize = true;
            this.rdoApenasNumeros.Location = new System.Drawing.Point(5, 20);
            this.rdoApenasNumeros.Name = "rdoApenasNumeros";
            this.rdoApenasNumeros.Size = new System.Drawing.Size(106, 17);
            this.rdoApenasNumeros.TabIndex = 2;
            this.rdoApenasNumeros.TabStop = true;
            this.rdoApenasNumeros.Text = "Apenas Numeros";
            this.rdoApenasNumeros.UseVisualStyleBackColor = true;
            // 
            // btnCpf
            // 
            this.btnCpf.Location = new System.Drawing.Point(5, 85);
            this.btnCpf.Name = "btnCpf";
            this.btnCpf.Size = new System.Drawing.Size(50, 20);
            this.btnCpf.TabIndex = 1;
            this.btnCpf.Text = "CPF\'s";
            this.btnCpf.UseVisualStyleBackColor = true;
            this.btnCpf.Click += new System.EventHandler(this.btnCpf_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkNomeDoMeio);
            this.groupBox2.Controls.Add(this.chkComNomeDoFim);
            this.groupBox2.Controls.Add(this.btnGerarNomes);
            this.groupBox2.Location = new System.Drawing.Point(10, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(121, 115);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // chkNomeDoMeio
            // 
            this.chkNomeDoMeio.AutoSize = true;
            this.chkNomeDoMeio.Location = new System.Drawing.Point(10, 20);
            this.chkNomeDoMeio.Name = "chkNomeDoMeio";
            this.chkNomeDoMeio.Size = new System.Drawing.Size(109, 17);
            this.chkNomeDoMeio.TabIndex = 2;
            this.chkNomeDoMeio.Text = "c/ Nome do Meio";
            this.chkNomeDoMeio.UseVisualStyleBackColor = true;
            this.chkNomeDoMeio.CheckedChanged += new System.EventHandler(this.chkNomeDoMeio_CheckedChanged);
            // 
            // chkComNomeDoFim
            // 
            this.chkComNomeDoFim.AutoSize = true;
            this.chkComNomeDoFim.Enabled = false;
            this.chkComNomeDoFim.Location = new System.Drawing.Point(9, 43);
            this.chkComNomeDoFim.Name = "chkComNomeDoFim";
            this.chkComNomeDoFim.Size = new System.Drawing.Size(100, 17);
            this.chkComNomeDoFim.TabIndex = 1;
            this.chkComNomeDoFim.Text = "c/ Ultimo Nome";
            this.chkComNomeDoFim.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            this.txtResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtResultado.BackColor = System.Drawing.Color.LightBlue;
            this.txtResultado.Location = new System.Drawing.Point(419, 12);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultado.Size = new System.Drawing.Size(219, 456);
            this.txtResultado.TabIndex = 2;
            this.txtResultado.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtResultado_KeyDown);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(650, 491);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Gerador SQL Insert";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox11.ResumeLayout(false);
            this.groupBox11.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGerarNomes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox chkIncluirMaskTelCel;
        private System.Windows.Forms.Button btnGerarCel;
        private System.Windows.Forms.Button btnGerarTel;
        private System.Windows.Forms.RadioButton rdoDDDtxt;
        private System.Windows.Forms.RadioButton rdoDDDaleatorio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDDDs;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton rdoOnlyHrMin;
        private System.Windows.Forms.RadioButton rdoHrMinSeg;
        private System.Windows.Forms.Button btnGerarHora;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox chkComHoras;
        private System.Windows.Forms.DateTimePicker dtpAte;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGerarDatas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdoIncluirMascaraCpf;
        private System.Windows.Forms.RadioButton rdoApenasNumeros;
        private System.Windows.Forms.Button btnCpf;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkComNomeDoFim;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox chkTxtPreferencia;
        private System.Windows.Forms.CheckBox chkPreferencia;
        private System.Windows.Forms.CheckBox chkYahoo;
        private System.Windows.Forms.CheckBox chkOutlook;
        private System.Windows.Forms.CheckBox chkGmail;
        private System.Windows.Forms.Button btnGerarEmail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnCnjp;
        private System.Windows.Forms.DateTimePicker dtpDe;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox chkParentesesRight;
        private System.Windows.Forms.CheckBox chkParentesesLeft;
        private System.Windows.Forms.CheckBox chkVirgula;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox chkNomeDoMeio;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button btnGerarPalavras;
        private System.Windows.Forms.GroupBox groupBox11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNumerosAte;
        private System.Windows.Forms.TextBox txtNumerosDe;
        private System.Windows.Forms.Button btnGerarNumeros;
        private System.Windows.Forms.TextBox txtMultiplos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox chkAspasSimples;
        private System.Windows.Forms.TextBox txtPalavras;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSeparador;
    }
}

