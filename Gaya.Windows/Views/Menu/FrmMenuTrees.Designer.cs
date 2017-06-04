using System.Drawing;

namespace Gaya.Windows.Views.Menu
{
    partial class FrmMenuTrees
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Alterar Empresa", 1, 1);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Usuários");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Cadastros", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Permissões de Usuários", 2, 2);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Configurações Gerais", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Inicialização", new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Empresa", 2, 2);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Filiais", 2, 2);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Cadastros", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8});
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Administração", 0, 0, new System.Windows.Forms.TreeNode[] {
            treeNode9});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuTrees));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.treeViewMenu = new System.Windows.Forms.TreeView();
            this.imageListMenu = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(293, 33);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 1;
            // 
            // treeViewMenu
            // 
            this.treeViewMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeViewMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewMenu.ImageIndex = 0;
            this.treeViewMenu.ImageList = this.imageListMenu;
            this.treeViewMenu.Location = new System.Drawing.Point(0, 0);
            this.treeViewMenu.Name = "treeViewMenu";
            treeNode1.ImageIndex = 1;
            treeNode1.Name = "MnuLogOff";
            treeNode1.SelectedImageIndex = 1;
            treeNode1.Text = "Alterar Empresa";
            treeNode2.ImageIndex = 2;
            treeNode2.Name = "MnuUsuarios";
            treeNode2.SelectedImageKey = "MenuIcon.ico";
            treeNode2.Text = "Usuários";
            treeNode3.Name = "NodeInicialCadastros";
            treeNode3.Text = "Cadastros";
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "MnuPermUsuarios";
            treeNode4.SelectedImageIndex = 2;
            treeNode4.Text = "Permissões de Usuários";
            treeNode5.Name = "NodeGeral";
            treeNode5.Text = "Configurações Gerais";
            treeNode6.Name = "NodeInicial";
            treeNode6.Text = "Inicialização";
            treeNode7.ImageIndex = 2;
            treeNode7.Name = "MnuEmpresa";
            treeNode7.SelectedImageIndex = 2;
            treeNode7.Text = "Empresa";
            treeNode8.ImageIndex = 2;
            treeNode8.Name = "MnuFiliais";
            treeNode8.SelectedImageIndex = 2;
            treeNode8.Text = "Filiais";
            treeNode9.ImageIndex = 0;
            treeNode9.Name = "NodeAdm_Cadastros";
            treeNode9.SelectedImageIndex = 0;
            treeNode9.Text = "Cadastros";
            treeNode10.ImageIndex = 0;
            treeNode10.Name = "NodeAdm";
            treeNode10.SelectedImageIndex = 0;
            treeNode10.Text = "Administração";
            this.treeViewMenu.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode6,
            treeNode10});
            this.treeViewMenu.SelectedImageIndex = 0;
            this.treeViewMenu.Size = new System.Drawing.Size(288, 484);
            this.treeViewMenu.TabIndex = 2;
            this.treeViewMenu.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeViewMenu_NodeMouseDoubleClick);
            // 
            // imageListMenu
            // 
            this.imageListMenu.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListMenu.ImageStream")));
            this.imageListMenu.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListMenu.Images.SetKeyName(0, "FolderMenuIcon.ico");
            this.imageListMenu.Images.SetKeyName(1, "Logoff.ico");
            this.imageListMenu.Images.SetKeyName(2, "MenuIcon.ico");
            // 
            // UIMenuTrees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 484);
            this.ControlBox = false;
            this.Controls.Add(this.treeViewMenu);
            this.Controls.Add(this.treeView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UIMenuTrees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menus";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TreeView treeViewMenu;
        private System.Windows.Forms.ImageList imageListMenu;
    }
}