namespace SUTH.HealthCheckup.WinFormsUI;

partial class Home
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
        components = new System.ComponentModel.Container();
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
        ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
        ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
        ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
        ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
        ribbonImageCollection = new DevExpress.Utils.ImageCollection(components);
        ribbonImageCollectionLarge = new DevExpress.Utils.ImageCollection(components);
        ((System.ComponentModel.ISupportInitialize)ribbonControl).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ribbonImageCollection).BeginInit();
        ((System.ComponentModel.ISupportInitialize)ribbonImageCollectionLarge).BeginInit();
        SuspendLayout();
        // 
        // ribbonControl
        // 
        ribbonControl.ApplicationButtonImageOptions.Image = Properties.Resources.suthb;
        ribbonControl.ExpandCollapseItem.Id = 0;
        ribbonControl.Images = ribbonImageCollection;
        ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] { ribbonControl.ExpandCollapseItem });
        ribbonControl.LargeImages = ribbonImageCollectionLarge;
        ribbonControl.Location = new Point(0, 0);
        ribbonControl.MaxItemId = 1;
        ribbonControl.Name = "ribbonControl";
        ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] { ribbonPage1 });
        ribbonControl.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonControlStyle.Office2007;
        ribbonControl.Size = new Size(1054, 158);
        ribbonControl.StatusBar = ribbonStatusBar;
        // 
        // ribbonPage1
        // 
        ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] { ribbonPageGroup1 });
        ribbonPage1.Name = "ribbonPage1";
        ribbonPage1.Text = "ribbonPage1";
        // 
        // ribbonPageGroup1
        // 
        ribbonPageGroup1.Name = "ribbonPageGroup1";
        ribbonPageGroup1.Text = "ribbonPageGroup1";
        // 
        // ribbonStatusBar
        // 
        ribbonStatusBar.Location = new Point(0, 637);
        ribbonStatusBar.Name = "ribbonStatusBar";
        ribbonStatusBar.Ribbon = ribbonControl;
        ribbonStatusBar.Size = new Size(1054, 24);
        // 
        // ribbonImageCollection
        // 
        ribbonImageCollection.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("ribbonImageCollection.ImageStream");
        // 
        // ribbonImageCollectionLarge
        // 
        ribbonImageCollectionLarge.ImageStream = (DevExpress.Utils.ImageCollectionStreamer)resources.GetObject("ribbonImageCollectionLarge.ImageStream");
        // 
        // frmHome
        // 
        AutoScaleDimensions = new SizeF(6F, 13F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(1054, 661);
        Controls.Add(ribbonStatusBar);
        Controls.Add(ribbonControl);
        Name = "frmHome";
        Ribbon = ribbonControl;
        StatusBar = ribbonStatusBar;
        Text = "frmHome";
        Load += frmHome_Load;
        ((System.ComponentModel.ISupportInitialize)ribbonControl).EndInit();
        ((System.ComponentModel.ISupportInitialize)ribbonImageCollection).EndInit();
        ((System.ComponentModel.ISupportInitialize)ribbonImageCollectionLarge).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
    private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
    private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
    private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
    private DevExpress.Utils.ImageCollection ribbonImageCollection;
    private DevExpress.Utils.ImageCollection ribbonImageCollectionLarge;
}