namespace Gaya.Windows.Views.Configuracoes_Gerais
{
    partial class FrmWizard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmWizard));
            this.Wizard = new AdvancedWizardControl.Wizard.AdvancedWizard();
            this.WizardEmpresa = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.WizardUsuario = new AdvancedWizardControl.WizardPages.AdvancedWizardPage();
            this.Wizard.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wizard
            // 
            this.Wizard.BackButtonEnabled = false;
            this.Wizard.BackButtonText = "< Back";
            this.Wizard.ButtonLayout = AdvancedWizardControl.Enums.ButtonLayoutKind.Office97;
            this.Wizard.ButtonsVisible = true;
            this.Wizard.CancelButtonText = "&Cancel";
            this.Wizard.Controls.Add(this.WizardEmpresa);
            this.Wizard.Controls.Add(this.WizardUsuario);
            this.Wizard.CurrentPageIsFinishPage = false;
            this.Wizard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Wizard.FinishButton = true;
            this.Wizard.FinishButtonEnabled = true;
            this.Wizard.FinishButtonText = "&Finish";
            this.Wizard.FlatStyle = System.Windows.Forms.FlatStyle.Standard;
            this.Wizard.HelpButton = true;
            this.Wizard.HelpButtonText = "&Help";
            this.Wizard.Location = new System.Drawing.Point(0, 0);
            this.Wizard.Name = "Wizard";
            this.Wizard.NextButtonEnabled = true;
            this.Wizard.NextButtonText = "Next >";
            this.Wizard.ProcessKeys = false;
            this.Wizard.Size = new System.Drawing.Size(690, 475);
            this.Wizard.TabIndex = 0;
            this.Wizard.TouchScreen = false;
            this.Wizard.WizardPages.Add(this.WizardEmpresa);
            this.Wizard.WizardPages.Add(this.WizardUsuario);
            // 
            // WizardEmpresa
            // 
            this.WizardEmpresa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.WizardEmpresa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WizardEmpresa.Header = true;
            this.WizardEmpresa.HeaderBackgroundColor = System.Drawing.Color.White;
            this.WizardEmpresa.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.WizardEmpresa.HeaderImage = ((System.Drawing.Image)(resources.GetObject("WizardEmpresa.HeaderImage")));
            this.WizardEmpresa.HeaderImageVisible = true;
            this.WizardEmpresa.HeaderTitle = "Assistente de inicialização do Gaya Software";
            this.WizardEmpresa.Location = new System.Drawing.Point(0, 0);
            this.WizardEmpresa.Name = "WizardEmpresa";
            this.WizardEmpresa.PreviousPage = 0;
            this.WizardEmpresa.Size = new System.Drawing.Size(690, 435);
            this.WizardEmpresa.SubTitle = "Vamos iniciar configurando a empresa";
            this.WizardEmpresa.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.WizardEmpresa.TabIndex = 1;
            // 
            // WizardUsuario
            // 
            this.WizardUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WizardUsuario.Header = true;
            this.WizardUsuario.HeaderBackgroundColor = System.Drawing.Color.White;
            this.WizardUsuario.HeaderFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.WizardUsuario.HeaderImage = ((System.Drawing.Image)(resources.GetObject("WizardUsuario.HeaderImage")));
            this.WizardUsuario.HeaderImageVisible = true;
            this.WizardUsuario.HeaderTitle = "Assistente de inicialização do Gaya Software";
            this.WizardUsuario.Location = new System.Drawing.Point(0, 0);
            this.WizardUsuario.Name = "WizardUsuario";
            this.WizardUsuario.PreviousPage = 0;
            this.WizardUsuario.Size = new System.Drawing.Size(690, 435);
            this.WizardUsuario.SubTitle = "Informe a senha do usuário de administração";
            this.WizardUsuario.SubTitleFont = new System.Drawing.Font("Tahoma", 8F);
            this.WizardUsuario.TabIndex = 2;
            // 
            // FrmWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 475);
            this.ControlBox = false;
            this.Controls.Add(this.Wizard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmWizard";
            this.Wizard.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AdvancedWizardControl.Wizard.AdvancedWizard Wizard;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage WizardEmpresa;
        private AdvancedWizardControl.WizardPages.AdvancedWizardPage WizardUsuario;
    }
}