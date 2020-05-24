namespace OrderAutomation
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainMenu = new System.Windows.Forms.ToolStrip();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.lbHome = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdmin = new System.Windows.Forms.ToolStripButton();
            this.lbAdmin = new System.Windows.Forms.ToolStripLabel();
            this.btnLogin = new System.Windows.Forms.ToolStripButton();
            this.lbLogin = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnRegister = new System.Windows.Forms.ToolStripButton();
            this.lbRegister = new System.Windows.Forms.ToolStripLabel();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnDown = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.lbAccountName = new System.Windows.Forms.ToolStripLabel();
            this.btnAccount = new System.Windows.Forms.ToolStripDropDownButton();
            this.btnAccountProperty = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOrderHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAccountRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSignOut = new System.Windows.Forms.ToolStripMenuItem();
            this.subMenu = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnShop = new System.Windows.Forms.ToolStripButton();
            this.lbShop = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnHistory = new System.Windows.Forms.ToolStripButton();
            this.lbHistory = new System.Windows.Forms.ToolStripLabel();
            this.subMenuAdmin = new System.Windows.Forms.ToolStrip();
            this.btnItemAdd = new System.Windows.Forms.ToolStripButton();
            this.lbItemAdd = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tbItemRemove = new System.Windows.Forms.ToolStripButton();
            this.lbItemRemove = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnItemUpdate = new System.Windows.Forms.ToolStripButton();
            this.lbItemUpdate = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCustomerFollow = new System.Windows.Forms.ToolStripButton();
            this.lbCustomerFollow = new System.Windows.Forms.ToolStripLabel();
            this.mainMenu.SuspendLayout();
            this.subMenu.SuspendLayout();
            this.subMenuAdmin.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.mainMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnHome,
            this.lbHome,
            this.toolStripSeparator2,
            this.btnAdmin,
            this.lbAdmin,
            this.btnLogin,
            this.lbLogin,
            this.toolStripSeparator1,
            this.btnRegister,
            this.lbRegister,
            this.btnExit,
            this.btnDown,
            this.toolStripSeparator3,
            this.lbAccountName,
            this.btnAccount});
            this.mainMenu.Location = new System.Drawing.Point(0, 0);
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.mainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.mainMenu.Size = new System.Drawing.Size(3102, 50);
            this.mainMenu.TabIndex = 2;
            this.mainMenu.Text = "toolStrip1";
            this.mainMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainMenu_MouseDown);
            this.mainMenu.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainMenu_MouseMove);
            this.mainMenu.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainMenu_MouseUp);
            // 
            // btnHome
            // 
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(46, 36);
            this.btnHome.Text = "Menü";
            this.btnHome.Visible = false;
            this.btnHome.Click += new System.EventHandler(this.subMenuShow);
            this.btnHome.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.btnHome.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // lbHome
            // 
            this.lbHome.Name = "lbHome";
            this.lbHome.Size = new System.Drawing.Size(78, 36);
            this.lbHome.Text = "Menü";
            this.lbHome.Visible = false;
            this.lbHome.Click += new System.EventHandler(this.subMenuShow);
            this.lbHome.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.lbHome.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            this.toolStripSeparator2.Visible = false;
            // 
            // btnAdmin
            // 
            this.btnAdmin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btnAdmin.Image")));
            this.btnAdmin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Size = new System.Drawing.Size(46, 36);
            this.btnAdmin.Text = "Yönetici İşlemleri";
            this.btnAdmin.Visible = false;
            this.btnAdmin.Click += new System.EventHandler(this.subMenuAdminShow);
            this.btnAdmin.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.btnAdmin.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // lbAdmin
            // 
            this.lbAdmin.Name = "lbAdmin";
            this.lbAdmin.Size = new System.Drawing.Size(194, 36);
            this.lbAdmin.Text = "Yönetici İşlemleri";
            this.lbAdmin.Visible = false;
            this.lbAdmin.Click += new System.EventHandler(this.subMenuAdminShow);
            this.lbAdmin.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.lbAdmin.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // btnLogin
            // 
            this.btnLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLogin.Image = ((System.Drawing.Image)(resources.GetObject("btnLogin.Image")));
            this.btnLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(46, 44);
            this.btnLogin.Text = "Giriş";
            this.btnLogin.Click += new System.EventHandler(this.Form1Open);
            this.btnLogin.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.btnLogin.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // lbLogin
            // 
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(61, 44);
            this.lbLogin.Text = "Giriş";
            this.lbLogin.Click += new System.EventHandler(this.Form1Open);
            this.lbLogin.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.lbLogin.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
            // 
            // btnRegister
            // 
            this.btnRegister.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRegister.Image = ((System.Drawing.Image)(resources.GetObject("btnRegister.Image")));
            this.btnRegister.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(46, 44);
            this.btnRegister.Text = "Kayıt Ol";
            this.btnRegister.Click += new System.EventHandler(this.RegisterFormOpen);
            this.btnRegister.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.btnRegister.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // lbRegister
            // 
            this.lbRegister.Name = "lbRegister";
            this.lbRegister.Size = new System.Drawing.Size(98, 44);
            this.lbRegister.Text = "Kayıt Ol";
            this.lbRegister.Click += new System.EventHandler(this.RegisterFormOpen);
            this.lbRegister.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.lbRegister.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // btnExit
            // 
            this.btnExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 44);
            this.btnExit.Text = "Kapat";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.btnExit.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // btnDown
            // 
            this.btnDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDown.Image")));
            this.btnDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(46, 44);
            this.btnDown.Text = "Küçült";
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            this.btnDown.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.btnDown.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
            // 
            // lbAccountName
            // 
            this.lbAccountName.Name = "lbAccountName";
            this.lbAccountName.Size = new System.Drawing.Size(85, 36);
            this.lbAccountName.Text = "Boşluk";
            this.lbAccountName.Visible = false;
            this.lbAccountName.Click += new System.EventHandler(this.lbAccountName_Click);
            this.lbAccountName.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.lbAccountName.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // btnAccount
            // 
            this.btnAccount.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAccount.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAccountProperty,
            this.btnOrderHistory,
            this.btnAccountRemove,
            this.btnSignOut});
            this.btnAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnAccount.Image")));
            this.btnAccount.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(54, 36);
            this.btnAccount.Text = "Hesabım";
            this.btnAccount.Visible = false;
            this.btnAccount.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.btnAccount.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // btnAccountProperty
            // 
            this.btnAccountProperty.Name = "btnAccountProperty";
            this.btnAccountProperty.Size = new System.Drawing.Size(313, 44);
            this.btnAccountProperty.Text = "Hesap İşlemleri";
            this.btnAccountProperty.Click += new System.EventHandler(this.btnAccountProperty_Click);
            // 
            // btnOrderHistory
            // 
            this.btnOrderHistory.Name = "btnOrderHistory";
            this.btnOrderHistory.Size = new System.Drawing.Size(313, 44);
            this.btnOrderHistory.Text = "Sipariş Geçmişi";
            this.btnOrderHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            // 
            // btnAccountRemove
            // 
            this.btnAccountRemove.Name = "btnAccountRemove";
            this.btnAccountRemove.Size = new System.Drawing.Size(313, 44);
            this.btnAccountRemove.Text = "Hesabı Sil";
            this.btnAccountRemove.Click += new System.EventHandler(this.btnAccountRemove_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(313, 44);
            this.btnSignOut.Text = "Oturumu Kapat";
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // subMenu
            // 
            this.subMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.subMenu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.subMenu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.subMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator4,
            this.btnShop,
            this.lbShop,
            this.toolStripSeparator5,
            this.btnHistory,
            this.lbHistory});
            this.subMenu.Location = new System.Drawing.Point(0, 42);
            this.subMenu.Name = "subMenu";
            this.subMenu.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.subMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.subMenu.Size = new System.Drawing.Size(66, 939);
            this.subMenu.TabIndex = 3;
            this.subMenu.Text = "toolStrip2";
            this.subMenu.Visible = false;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(41, 6);
            // 
            // btnShop
            // 
            this.btnShop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnShop.Image = ((System.Drawing.Image)(resources.GetObject("btnShop.Image")));
            this.btnShop.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnShop.Name = "btnShop";
            this.btnShop.Size = new System.Drawing.Size(41, 36);
            this.btnShop.Text = "Mağaza";
            this.btnShop.Click += new System.EventHandler(this.btnShop_Click);
            this.btnShop.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.btnShop.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // lbShop
            // 
            this.lbShop.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbShop.Name = "lbShop";
            this.lbShop.Size = new System.Drawing.Size(41, 96);
            this.lbShop.Text = "Mağaza";
            this.lbShop.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.lbShop.Click += new System.EventHandler(this.btnShop_Click);
            this.lbShop.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.lbShop.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(41, 6);
            // 
            // btnHistory
            // 
            this.btnHistory.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHistory.Image = ((System.Drawing.Image)(resources.GetObject("btnHistory.Image")));
            this.btnHistory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(41, 36);
            this.btnHistory.Text = "Sipariş Geçmişi";
            this.btnHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            this.btnHistory.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.btnHistory.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // lbHistory
            // 
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(41, 174);
            this.lbHistory.Text = "Sipariş Geçmişi";
            this.lbHistory.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.lbHistory.Click += new System.EventHandler(this.btnOrderHistory_Click);
            this.lbHistory.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.lbHistory.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // subMenuAdmin
            // 
            this.subMenuAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.subMenuAdmin.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.subMenuAdmin.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.subMenuAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnItemAdd,
            this.lbItemAdd,
            this.toolStripSeparator6,
            this.tbItemRemove,
            this.lbItemRemove,
            this.toolStripSeparator7,
            this.btnItemUpdate,
            this.lbItemUpdate,
            this.toolStripSeparator8,
            this.btnCustomerFollow,
            this.lbCustomerFollow});
            this.subMenuAdmin.Location = new System.Drawing.Point(0, 50);
            this.subMenuAdmin.Name = "subMenuAdmin";
            this.subMenuAdmin.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.subMenuAdmin.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.subMenuAdmin.Size = new System.Drawing.Size(66, 931);
            this.subMenuAdmin.TabIndex = 4;
            this.subMenuAdmin.Text = "toolStrip2";
            this.subMenuAdmin.Visible = false;
            // 
            // btnItemAdd
            // 
            this.btnItemAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItemAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnItemAdd.Image")));
            this.btnItemAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItemAdd.Name = "btnItemAdd";
            this.btnItemAdd.Size = new System.Drawing.Size(57, 36);
            this.btnItemAdd.Text = "Ürün Ekle";
            this.btnItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            this.btnItemAdd.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.btnItemAdd.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // lbItemAdd
            // 
            this.lbItemAdd.Name = "lbItemAdd";
            this.lbItemAdd.Size = new System.Drawing.Size(57, 117);
            this.lbItemAdd.Text = "Ürün Ekle";
            this.lbItemAdd.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.lbItemAdd.Click += new System.EventHandler(this.btnItemAdd_Click);
            this.lbItemAdd.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.lbItemAdd.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(57, 6);
            // 
            // tbItemRemove
            // 
            this.tbItemRemove.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbItemRemove.Image = ((System.Drawing.Image)(resources.GetObject("tbItemRemove.Image")));
            this.tbItemRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbItemRemove.Name = "tbItemRemove";
            this.tbItemRemove.Size = new System.Drawing.Size(57, 36);
            this.tbItemRemove.Text = "Ürün Sil";
            this.tbItemRemove.Click += new System.EventHandler(this.tbItemRemove_Click);
            this.tbItemRemove.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.tbItemRemove.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // lbItemRemove
            // 
            this.lbItemRemove.Name = "lbItemRemove";
            this.lbItemRemove.Size = new System.Drawing.Size(57, 99);
            this.lbItemRemove.Text = "Ürün Sil";
            this.lbItemRemove.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.lbItemRemove.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.lbItemRemove.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(57, 6);
            // 
            // btnItemUpdate
            // 
            this.btnItemUpdate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItemUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnItemUpdate.Image")));
            this.btnItemUpdate.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnItemUpdate.Name = "btnItemUpdate";
            this.btnItemUpdate.Size = new System.Drawing.Size(57, 36);
            this.btnItemUpdate.Text = "Ürün Güncelleme";
            this.btnItemUpdate.Click += new System.EventHandler(this.btnItemUpdate_Click);
            this.btnItemUpdate.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.btnItemUpdate.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // lbItemUpdate
            // 
            this.lbItemUpdate.Name = "lbItemUpdate";
            this.lbItemUpdate.Size = new System.Drawing.Size(57, 167);
            this.lbItemUpdate.Text = "Ürün Güncelle";
            this.lbItemUpdate.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.lbItemUpdate.Click += new System.EventHandler(this.btnItemUpdate_Click);
            this.lbItemUpdate.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.lbItemUpdate.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(57, 6);
            // 
            // btnCustomerFollow
            // 
            this.btnCustomerFollow.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCustomerFollow.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomerFollow.Image")));
            this.btnCustomerFollow.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomerFollow.Name = "btnCustomerFollow";
            this.btnCustomerFollow.Size = new System.Drawing.Size(57, 36);
            this.btnCustomerFollow.Text = "Müşteri Takip";
            this.btnCustomerFollow.Click += new System.EventHandler(this.btnCustomerFollow_Click);
            this.btnCustomerFollow.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.btnCustomerFollow.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // lbCustomerFollow
            // 
            this.lbCustomerFollow.Name = "lbCustomerFollow";
            this.lbCustomerFollow.Size = new System.Drawing.Size(57, 157);
            this.lbCustomerFollow.Text = "Müşteri Takip";
            this.lbCustomerFollow.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            this.lbCustomerFollow.MouseEnter += new System.EventHandler(this.CursorChangeHand);
            this.lbCustomerFollow.MouseLeave += new System.EventHandler(this.CursorChangeArrow);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3102, 981);
            this.Controls.Add(this.subMenuAdmin);
            this.Controls.Add(this.subMenu);
            this.Controls.Add(this.mainMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            this.subMenu.ResumeLayout(false);
            this.subMenu.PerformLayout();
            this.subMenuAdmin.ResumeLayout(false);
            this.subMenuAdmin.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.ToolStrip mainMenu;
        private System.Windows.Forms.ToolStripLabel lbHome;
        private System.Windows.Forms.ToolStrip subMenu;
        private System.Windows.Forms.ToolStripButton btnAdmin;
        private System.Windows.Forms.ToolStripLabel lbAdmin;
        private System.Windows.Forms.ToolStrip subMenuAdmin;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripButton btnDown;
        private System.Windows.Forms.ToolStripLabel lbLogin;
        private System.Windows.Forms.ToolStripDropDownButton btnAccount;
        private System.Windows.Forms.ToolStripMenuItem btnAccountProperty;
        private System.Windows.Forms.ToolStripMenuItem btnSignOut;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripButton btnRegister;
        private System.Windows.Forms.ToolStripLabel lbRegister;
        private System.Windows.Forms.ToolStripButton btnLogin;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btnAccountRemove;
        public System.Windows.Forms.ToolStripLabel lbAccountName;
        private System.Windows.Forms.ToolStripButton btnShop;
        private System.Windows.Forms.ToolStripLabel lbShop;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem btnOrderHistory;
        private System.Windows.Forms.ToolStripButton btnHistory;
        private System.Windows.Forms.ToolStripLabel lbHistory;
        private System.Windows.Forms.ToolStripButton btnItemAdd;
        private System.Windows.Forms.ToolStripLabel lbItemAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tbItemRemove;
        private System.Windows.Forms.ToolStripLabel lbItemRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton btnItemUpdate;
        private System.Windows.Forms.ToolStripLabel lbItemUpdate;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton btnCustomerFollow;
        private System.Windows.Forms.ToolStripLabel lbCustomerFollow;
    }
}



