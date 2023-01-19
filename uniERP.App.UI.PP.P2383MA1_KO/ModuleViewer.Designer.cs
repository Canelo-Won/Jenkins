using uniERP.AppFramework.UI.Module;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.ObjectBuilder;

namespace uniERP.App.UI.PP.P2383MA1_KO611
{

	public class ModuleInitializer : uniERP.AppFramework.UI.Module.Module
	{
		[InjectionConstructor]
		public ModuleInitializer([ServiceDependency] WorkItem rootWorkItem)
			: base(rootWorkItem) { }

		protected override void RegisterModureViewer()
		{
			base.AddModule<ModuleViewer>();
		}
	}

	partial class ModuleViewer
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            Infragistics.Win.Appearance appearance86 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance93 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance92 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance87 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance94 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance95 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance96 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance97 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance98 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance99 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance89 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance90 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance91 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance100 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance101 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance102 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance103 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance104 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance105 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance106 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance107 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance108 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance109 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance110 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance111 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance85 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance112 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance88 = new Infragistics.Win.Appearance();
            this.uniTBL_OuterMost = new uniERP.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_MainCondition = new uniERP.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.lblPlantCd = new uniERP.AppFramework.UI.Controls.uniLabel(this.components);
            this.popPlantCd = new uniERP.AppFramework.UI.Controls.uniOpenPopup();
            this.popItemGrp1 = new uniERP.AppFramework.UI.Controls.uniOpenPopup();
            this.lbItemCd = new uniERP.AppFramework.UI.Controls.uniLabel(this.components);
            this.uniLabel2 = new uniERP.AppFramework.UI.Controls.uniLabel(this.components);
            this.uniLabel3 = new uniERP.AppFramework.UI.Controls.uniLabel(this.components);
            this.popChildItemCd = new uniERP.AppFramework.UI.Controls.uniOpenPopup();
            this.uniTextBox_Name = new uniERP.AppFramework.UI.Controls.uniTextBox(this.components);
            this.uniTextBox_Code = new uniERP.AppFramework.UI.Controls.uniTextBox(this.components);
            this.uniTextBox9 = new uniERP.AppFramework.UI.Controls.uniTextBox(this.components);
            this.uniTextBox10 = new uniERP.AppFramework.UI.Controls.uniTextBox(this.components);
            this.uniTextBox11 = new uniERP.AppFramework.UI.Controls.uniTextBox(this.components);
            this.uniTextBox12 = new uniERP.AppFramework.UI.Controls.uniTextBox(this.components);
            this.uniLabel4 = new uniERP.AppFramework.UI.Controls.uniLabel(this.components);
            this.popTrackingNo = new uniERP.AppFramework.UI.Controls.uniOpenPopup();
            this.uniTextBox1 = new uniERP.AppFramework.UI.Controls.uniTextBox(this.components);
            this.uniTextBox2 = new uniERP.AppFramework.UI.Controls.uniTextBox(this.components);
            this.uniTBL_MainReference = new uniERP.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.lblBChange = new uniERP.AppFramework.UI.Controls.uniLabel(this.components);
            this.uniTBL_MainBatch = new uniERP.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.btnBomExec = new uniERP.AppFramework.UI.Controls.uniButton(this.components);
            this.uniTBL_MainData = new uniERP.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniGrid1 = new uniERP.AppFramework.UI.Controls.uniGrid(this.components);
            this.uniTableLayoutPanel2 = new uniERP.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniLabel5 = new uniERP.AppFramework.UI.Controls.uniLabel(this.components);
            this.popItemGrp2 = new uniERP.AppFramework.UI.Controls.uniOpenPopup();
            this.uniTextBox3 = new uniERP.AppFramework.UI.Controls.uniTextBox(this.components);
            this.uniLabel1 = new uniERP.AppFramework.UI.Controls.uniLabel(this.components);
            this.popItemGrp3 = new uniERP.AppFramework.UI.Controls.uniOpenPopup();
            this.popItemCd = new uniERP.AppFramework.UI.Controls.uniOpenPopup();
            this.uniTBL_OuterMost.SuspendLayout();
            this.uniTBL_MainCondition.SuspendLayout();
            this.popChildItemCd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox_Code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox12)).BeginInit();
            this.popTrackingNo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox2)).BeginInit();
            this.uniTBL_MainReference.SuspendLayout();
            this.uniTBL_MainBatch.SuspendLayout();
            this.uniTBL_MainData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniGrid1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // uniLabel_Path
            // 
            this.uniLabel_Path.Size = new System.Drawing.Size(500, 14);
            this.uniLabel_Path.TabIndex = 1;
            // 
            // uniTBL_OuterMost
            // 
            this.uniTBL_OuterMost.AutoFit = false;
            this.uniTBL_OuterMost.AutoFitColumnCount = 4;
            this.uniTBL_OuterMost.AutoFitRowCount = 4;
            this.uniTBL_OuterMost.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_OuterMost.ColumnCount = 1;
            this.uniTBL_OuterMost.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_OuterMost.ConditionRowCount = 2;
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainCondition, 0, 2);
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainReference, 0, 0);
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainBatch, 0, 6);
            this.uniTBL_OuterMost.Controls.Add(this.uniTBL_MainData, 0, 4);
            this.uniTBL_OuterMost.DefaultRowSize = 25;
            this.uniTBL_OuterMost.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_OuterMost.EasyBaseBatchType = uniERP.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_OuterMost.HEIGHT_TYPE_00_REFERENCE = 25F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_01 = 3F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_01_CONDITION = 30F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_02 = 9F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_03_BOTTOM = 31F;
            this.uniTBL_OuterMost.HEIGHT_TYPE_04 = 3F;
            this.uniTBL_OuterMost.Location = new System.Drawing.Point(1, 10);
            this.uniTBL_OuterMost.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_OuterMost.Name = "uniTBL_OuterMost";
            this.uniTBL_OuterMost.PanelType = uniERP.AppFramework.UI.Variables.enumDef.PanelType.Default;
            this.uniTBL_OuterMost.RowCount = 8;
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 6F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 121F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 11F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 3F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 1F));
            this.uniTBL_OuterMost.Size = new System.Drawing.Size(979, 740);
            this.uniTBL_OuterMost.SizeTD5 = 14F;
            this.uniTBL_OuterMost.SizeTD6 = 36F;
            this.uniTBL_OuterMost.TabIndex = 0;
            this.uniTBL_OuterMost.uniERPTableLayout = uniERP.AppFramework.UI.Controls.uniERPTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_OuterMost.uniLR_SPACE_TYPE = uniERP.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            this.uniTBL_OuterMost.Paint += new System.Windows.Forms.PaintEventHandler(this.uniTBL_OuterMost_Paint);
            // 
            // uniTBL_MainCondition
            // 
            this.uniTBL_MainCondition.AutoFit = false;
            this.uniTBL_MainCondition.AutoFitColumnCount = 4;
            this.uniTBL_MainCondition.AutoFitRowCount = 4;
            this.uniTBL_MainCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(245)))), ((int)(((byte)(247)))));
            this.uniTBL_MainCondition.ColumnCount = 4;
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.uniTBL_MainCondition.Controls.Add(this.uniLabel5, 0, 3);
            this.uniTBL_MainCondition.Controls.Add(this.lblPlantCd, 0, 0);
            this.uniTBL_MainCondition.Controls.Add(this.popPlantCd, 1, 0);
            this.uniTBL_MainCondition.Controls.Add(this.uniLabel3, 2, 1);
            this.uniTBL_MainCondition.Controls.Add(this.uniLabel1, 2, 3);
            this.uniTBL_MainCondition.Controls.Add(this.popChildItemCd, 3, 3);
            this.uniTBL_MainCondition.Controls.Add(this.uniLabel4, 2, 2);
            this.uniTBL_MainCondition.Controls.Add(this.popTrackingNo, 3, 2);
            this.uniTBL_MainCondition.Controls.Add(this.uniLabel2, 0, 2);
            this.uniTBL_MainCondition.Controls.Add(this.popItemGrp2, 1, 2);
            this.uniTBL_MainCondition.Controls.Add(this.lbItemCd, 0, 1);
            this.uniTBL_MainCondition.Controls.Add(this.popItemGrp1, 1, 1);
            this.uniTBL_MainCondition.Controls.Add(this.popItemGrp3, 1, 3);
            this.uniTBL_MainCondition.Controls.Add(this.popItemCd, 3, 1);
            this.uniTBL_MainCondition.DefaultRowSize = 23;
            this.uniTBL_MainCondition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainCondition.EasyBaseBatchType = uniERP.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainCondition.HEIGHT_TYPE_00_REFERENCE = 32F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_01 = 3F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_01_CONDITION = 29F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_02 = 5F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_03_BOTTOM = 32F;
            this.uniTBL_MainCondition.HEIGHT_TYPE_04 = 3F;
            this.uniTBL_MainCondition.Location = new System.Drawing.Point(0, 27);
            this.uniTBL_MainCondition.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainCondition.Name = "uniTBL_MainCondition";
            this.uniTBL_MainCondition.Padding = new System.Windows.Forms.Padding(0, 5, 0, 10);
            this.uniTBL_MainCondition.PanelType = uniERP.AppFramework.UI.Variables.enumDef.PanelType.Condition;
            this.uniTBL_MainCondition.RowCount = 4;
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uniTBL_MainCondition.Size = new System.Drawing.Size(979, 121);
            this.uniTBL_MainCondition.SizeTD5 = 16F;
            this.uniTBL_MainCondition.SizeTD6 = 34F;
            this.uniTBL_MainCondition.TabIndex = 0;
            this.uniTBL_MainCondition.uniERPTableLayout = uniERP.AppFramework.UI.Controls.uniERPTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainCondition.uniLR_SPACE_TYPE = uniERP.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            this.uniTBL_MainCondition.Paint += new System.Windows.Forms.PaintEventHandler(this.uniTBL_MainCondition_Paint);
            // 
            // lblPlantCd
            // 
            appearance86.TextHAlignAsString = "Left";
            appearance86.TextVAlignAsString = "Middle";
            this.lblPlantCd.Appearance = appearance86;
            this.lblPlantCd.AutoPopupID = null;
            this.lblPlantCd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlantCd.LabelType = uniERP.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.lblPlantCd.Location = new System.Drawing.Point(15, 6);
            this.lblPlantCd.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.lblPlantCd.Name = "lblPlantCd";
            this.lblPlantCd.Size = new System.Drawing.Size(122, 22);
            this.lblPlantCd.StyleSetName = "Default";
            this.lblPlantCd.TabIndex = 0;
            this.lblPlantCd.Text = "공장";
            this.lblPlantCd.UseMnemonic = false;
            // 
            // popPlantCd
            // 
            this.popPlantCd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.popPlantCd.AutoPopupCodeParameter = null;
            this.popPlantCd.AutoPopupID = null;
            this.popPlantCd.AutoPopupNameParameter = null;
            this.popPlantCd.CodeMaxLength = 6;
            this.popPlantCd.CodeName = "";
            this.popPlantCd.CodeSize = 100;
            this.popPlantCd.CodeStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popPlantCd.CodeTextBoxName = null;
            this.popPlantCd.CodeValue = "";
            this.popPlantCd.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.NotNull;
            this.popPlantCd.Location = new System.Drawing.Point(137, 7);
            this.popPlantCd.LockedField = false;
            this.popPlantCd.Margin = new System.Windows.Forms.Padding(0);
            this.popPlantCd.Name = "popPlantCd";
            this.popPlantCd.NameDisplay = true;
            this.popPlantCd.NameId = null;
            this.popPlantCd.NameMaxLength = 50;
            this.popPlantCd.NamePopup = false;
            this.popPlantCd.NameSize = 150;
            this.popPlantCd.NameStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.CodeName;
            this.popPlantCd.Parameter = null;
            this.popPlantCd.PopupButtonEnable = uniERP.AppFramework.UI.Variables.enumDef.uniOpenPopupButton.Enable;
            this.popPlantCd.PopupId = null;
            this.popPlantCd.PopupType = uniERP.AppFramework.UI.Variables.enumDef.PopupType.CommonPopup;
            this.popPlantCd.QueryIfEnterKeyPressed = true;
            this.popPlantCd.RequiredField = false;
            this.popPlantCd.Size = new System.Drawing.Size(271, 21);
            this.popPlantCd.TabIndex = 0;
            this.popPlantCd.uniALT = "Plant";
            this.popPlantCd.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.popPlantCd.UseDynamicFormat = false;
            this.popPlantCd.ValueTextBoxName = null;
            this.popPlantCd.BeforePopupOpen += new uniERP.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.popPlantCd_BeforePopupOpen);
            this.popPlantCd.AfterPopupClosed += new uniERP.AppFramework.UI.Controls.Popup.AfterPopupCloseEventHandler(this.popPlantCd_AfterPopupClosed);
            // 
            // popItemGrp1
            // 
            this.popItemGrp1.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.popItemGrp1.AutoPopupCodeParameter = null;
            this.popItemGrp1.AutoPopupID = null;
            this.popItemGrp1.AutoPopupNameParameter = null;
            this.popItemGrp1.CodeMaxLength = 18;
            this.popItemGrp1.CodeName = "";
            this.popItemGrp1.CodeSize = 150;
            this.popItemGrp1.CodeStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popItemGrp1.CodeTextBoxName = null;
            this.popItemGrp1.CodeValue = "";
            this.popItemGrp1.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.NotNull;
            this.popItemGrp1.Location = new System.Drawing.Point(137, 28);
            this.popItemGrp1.LockedField = false;
            this.popItemGrp1.Margin = new System.Windows.Forms.Padding(0);
            this.popItemGrp1.Name = "popItemGrp1";
            this.popItemGrp1.NameDisplay = true;
            this.popItemGrp1.NameId = null;
            this.popItemGrp1.NameMaxLength = 50;
            this.popItemGrp1.NamePopup = false;
            this.popItemGrp1.NameSize = 150;
            this.popItemGrp1.NameStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popItemGrp1.Parameter = null;
            this.popItemGrp1.PopupButtonEnable = uniERP.AppFramework.UI.Variables.enumDef.uniOpenPopupButton.Enable;
            this.popItemGrp1.PopupId = null;
            this.popItemGrp1.PopupType = uniERP.AppFramework.UI.Variables.enumDef.PopupType.CommonPopup;
            this.popItemGrp1.QueryIfEnterKeyPressed = true;
            this.popItemGrp1.RequiredField = false;
            this.popItemGrp1.Size = new System.Drawing.Size(321, 30);
            this.popItemGrp1.TabIndex = 1;
            this.popItemGrp1.uniALT = "Component Item";
            this.popItemGrp1.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.popItemGrp1.UseDynamicFormat = false;
            this.popItemGrp1.ValueTextBoxName = null;
            this.popItemGrp1.BeforePopupOpen += new uniERP.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.popItemGroup1_BeforePopupOpen);
            this.popItemGrp1.AfterPopupClosed += new uniERP.AppFramework.UI.Controls.Popup.AfterPopupCloseEventHandler(this.popItemGroup1_AfterPopupClosed);
            // 
            // lbItemCd
            // 
            appearance93.TextHAlignAsString = "Left";
            appearance93.TextVAlignAsString = "Middle";
            this.lbItemCd.Appearance = appearance93;
            this.lbItemCd.AutoPopupID = null;
            this.lbItemCd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbItemCd.LabelType = uniERP.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.lbItemCd.Location = new System.Drawing.Point(15, 29);
            this.lbItemCd.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.lbItemCd.Name = "lbItemCd";
            this.lbItemCd.Size = new System.Drawing.Size(122, 29);
            this.lbItemCd.StyleSetName = "Default";
            this.lbItemCd.TabIndex = 1;
            this.lbItemCd.Text = "대분류";
            this.lbItemCd.UseFlatMode = Infragistics.Win.DefaultableBoolean.False;
            this.lbItemCd.UseMnemonic = false;
            // 
            // uniLabel2
            // 
            appearance92.TextHAlignAsString = "Left";
            appearance92.TextVAlignAsString = "Middle";
            this.uniLabel2.Appearance = appearance92;
            this.uniLabel2.AutoPopupID = null;
            this.uniLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniLabel2.LabelType = uniERP.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.uniLabel2.Location = new System.Drawing.Point(15, 59);
            this.uniLabel2.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.uniLabel2.Name = "uniLabel2";
            this.uniLabel2.Size = new System.Drawing.Size(122, 28);
            this.uniLabel2.StyleSetName = "Default";
            this.uniLabel2.TabIndex = 7;
            this.uniLabel2.Text = "중분류";
            this.uniLabel2.UseFlatMode = Infragistics.Win.DefaultableBoolean.False;
            this.uniLabel2.UseMnemonic = false;
            this.uniLabel2.BeforePopupOpen += new uniERP.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.uniLabel2_BeforePopupOpen);
            // 
            // uniLabel3
            // 
            appearance87.TextHAlignAsString = "Left";
            appearance87.TextVAlignAsString = "Middle";
            this.uniLabel3.Appearance = appearance87;
            this.uniLabel3.AutoPopupID = null;
            this.uniLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniLabel3.LabelType = uniERP.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.uniLabel3.Location = new System.Drawing.Point(504, 29);
            this.uniLabel3.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.uniLabel3.Name = "uniLabel3";
            this.uniLabel3.Size = new System.Drawing.Size(122, 29);
            this.uniLabel3.StyleSetName = "Default";
            this.uniLabel3.TabIndex = 8;
            this.uniLabel3.Text = "모품목";
            this.uniLabel3.UseFlatMode = Infragistics.Win.DefaultableBoolean.False;
            this.uniLabel3.UseMnemonic = false;
            // 
            // popChildItemCd
            // 
            this.popChildItemCd.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.popChildItemCd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.popChildItemCd.AutoPopupCodeParameter = null;
            this.popChildItemCd.AutoPopupID = null;
            this.popChildItemCd.AutoPopupNameParameter = null;
            this.popChildItemCd.CodeMaxLength = 18;
            this.popChildItemCd.CodeName = "";
            this.popChildItemCd.CodeSize = 150;
            this.popChildItemCd.CodeStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popChildItemCd.CodeTextBoxName = null;
            this.popChildItemCd.CodeValue = "";
            this.popChildItemCd.Controls.Add(this.uniTextBox_Name);
            this.popChildItemCd.Controls.Add(this.uniTextBox_Code);
            this.popChildItemCd.Controls.Add(this.uniTextBox9);
            this.popChildItemCd.Controls.Add(this.uniTextBox10);
            this.popChildItemCd.Controls.Add(this.uniTextBox11);
            this.popChildItemCd.Controls.Add(this.uniTextBox12);
            this.popChildItemCd.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.Nullable;
            this.popChildItemCd.Location = new System.Drawing.Point(626, 90);
            this.popChildItemCd.LockedField = false;
            this.popChildItemCd.Margin = new System.Windows.Forms.Padding(0);
            this.popChildItemCd.Name = "popChildItemCd";
            this.popChildItemCd.NameDisplay = true;
            this.popChildItemCd.NameId = null;
            this.popChildItemCd.NameMaxLength = 50;
            this.popChildItemCd.NamePopup = false;
            this.popChildItemCd.NameSize = 150;
            this.popChildItemCd.NameStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popChildItemCd.Parameter = null;
            this.popChildItemCd.PopupButtonEnable = uniERP.AppFramework.UI.Variables.enumDef.uniOpenPopupButton.Enable;
            this.popChildItemCd.PopupId = null;
            this.popChildItemCd.PopupType = uniERP.AppFramework.UI.Variables.enumDef.PopupType.CommonPopup;
            this.popChildItemCd.QueryIfEnterKeyPressed = true;
            this.popChildItemCd.RequiredField = false;
            this.popChildItemCd.Size = new System.Drawing.Size(321, 21);
            this.popChildItemCd.TabIndex = 14;
            this.popChildItemCd.uniALT = "Component Item";
            this.popChildItemCd.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.popChildItemCd.UseDynamicFormat = false;
            this.popChildItemCd.ValueTextBoxName = null;
            this.popChildItemCd.BeforePopupOpen += new uniERP.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.popItemCd_BeforePopupOpen);
            this.popChildItemCd.AfterPopupClosed += new uniERP.AppFramework.UI.Controls.Popup.AfterPopupCloseEventHandler(this.popItemCd_AfterPopupClosed);
            // 
            // uniTextBox_Name
            // 
            this.uniTextBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            appearance94.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox_Name.Appearance = appearance94;
            this.uniTextBox_Name.AutoSize = false;
            this.uniTextBox_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox_Name.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.uniTextBox_Name.Location = new System.Drawing.Point(171, 0);
            this.uniTextBox_Name.LockedField = false;
            this.uniTextBox_Name.Margin = new System.Windows.Forms.Padding(0);
            this.uniTextBox_Name.MaxLength = 50;
            this.uniTextBox_Name.Name = "uniTextBox_Name";
            this.uniTextBox_Name.QueryIfEnterKeyPressed = true;
            this.uniTextBox_Name.ReadOnly = true;
            this.uniTextBox_Name.RequiredField = false;
            this.uniTextBox_Name.Size = new System.Drawing.Size(150, 21);
            this.uniTextBox_Name.Style = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.uniTextBox_Name.StyleSetName = "Lock";
            this.uniTextBox_Name.TabIndex = 0;
            this.uniTextBox_Name.TabStop = false;
            this.uniTextBox_Name.uniALT = null;
            this.uniTextBox_Name.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.uniTextBox_Name.UseDynamicFormat = false;
            this.uniTextBox_Name.WordWrap = false;
            // 
            // uniTextBox_Code
            // 
            this.uniTextBox_Code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            appearance95.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox_Code.Appearance = appearance95;
            this.uniTextBox_Code.AutoSize = false;
            this.uniTextBox_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox_Code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.uniTextBox_Code.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.uniTextBox_Code.Location = new System.Drawing.Point(0, 0);
            this.uniTextBox_Code.LockedField = false;
            this.uniTextBox_Code.Margin = new System.Windows.Forms.Padding(0);
            this.uniTextBox_Code.MaxLength = 18;
            this.uniTextBox_Code.Name = "uniTextBox_Code";
            this.uniTextBox_Code.QueryIfEnterKeyPressed = true;
            this.uniTextBox_Code.RequiredField = false;
            this.uniTextBox_Code.Size = new System.Drawing.Size(150, 21);
            this.uniTextBox_Code.Style = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.uniTextBox_Code.StyleSetName = "Default";
            this.uniTextBox_Code.TabIndex = 0;
            this.uniTextBox_Code.uniALT = null;
            this.uniTextBox_Code.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.uniTextBox_Code.UseDynamicFormat = false;
            this.uniTextBox_Code.WordWrap = false;
            // 
            // uniTextBox9
            // 
            this.uniTextBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            appearance96.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox9.Appearance = appearance96;
            this.uniTextBox9.AutoSize = false;
            this.uniTextBox9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox9.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.uniTextBox9.Location = new System.Drawing.Point(171, 0);
            this.uniTextBox9.LockedField = false;
            this.uniTextBox9.Margin = new System.Windows.Forms.Padding(0);
            this.uniTextBox9.MaxLength = 50;
            this.uniTextBox9.Name = "uniTextBox9";
            this.uniTextBox9.QueryIfEnterKeyPressed = true;
            this.uniTextBox9.ReadOnly = true;
            this.uniTextBox9.RequiredField = false;
            this.uniTextBox9.Size = new System.Drawing.Size(148, 21);
            this.uniTextBox9.Style = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.uniTextBox9.StyleSetName = "Lock";
            this.uniTextBox9.TabIndex = 0;
            this.uniTextBox9.TabStop = false;
            this.uniTextBox9.uniALT = null;
            this.uniTextBox9.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.uniTextBox9.UseDynamicFormat = false;
            this.uniTextBox9.WordWrap = false;
            // 
            // uniTextBox10
            // 
            this.uniTextBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            appearance97.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox10.Appearance = appearance97;
            this.uniTextBox10.AutoSize = false;
            this.uniTextBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox10.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.uniTextBox10.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.uniTextBox10.Location = new System.Drawing.Point(0, 0);
            this.uniTextBox10.LockedField = false;
            this.uniTextBox10.Margin = new System.Windows.Forms.Padding(0);
            this.uniTextBox10.MaxLength = 18;
            this.uniTextBox10.Name = "uniTextBox10";
            this.uniTextBox10.QueryIfEnterKeyPressed = true;
            this.uniTextBox10.RequiredField = false;
            this.uniTextBox10.Size = new System.Drawing.Size(150, 21);
            this.uniTextBox10.Style = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.uniTextBox10.StyleSetName = "Default";
            this.uniTextBox10.TabIndex = 0;
            this.uniTextBox10.uniALT = null;
            this.uniTextBox10.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.uniTextBox10.UseDynamicFormat = false;
            this.uniTextBox10.WordWrap = false;
            // 
            // uniTextBox11
            // 
            this.uniTextBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            appearance98.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox11.Appearance = appearance98;
            this.uniTextBox11.AutoSize = false;
            this.uniTextBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox11.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.uniTextBox11.Location = new System.Drawing.Point(171, 0);
            this.uniTextBox11.LockedField = false;
            this.uniTextBox11.Margin = new System.Windows.Forms.Padding(0);
            this.uniTextBox11.MaxLength = 50;
            this.uniTextBox11.Name = "uniTextBox11";
            this.uniTextBox11.QueryIfEnterKeyPressed = true;
            this.uniTextBox11.ReadOnly = true;
            this.uniTextBox11.RequiredField = false;
            this.uniTextBox11.Size = new System.Drawing.Size(150, 21);
            this.uniTextBox11.Style = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.uniTextBox11.StyleSetName = "Lock";
            this.uniTextBox11.TabIndex = 0;
            this.uniTextBox11.TabStop = false;
            this.uniTextBox11.uniALT = null;
            this.uniTextBox11.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.uniTextBox11.UseDynamicFormat = false;
            this.uniTextBox11.WordWrap = false;
            // 
            // uniTextBox12
            // 
            this.uniTextBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            appearance99.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox12.Appearance = appearance99;
            this.uniTextBox12.AutoSize = false;
            this.uniTextBox12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox12.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.uniTextBox12.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.uniTextBox12.Location = new System.Drawing.Point(0, 0);
            this.uniTextBox12.LockedField = false;
            this.uniTextBox12.Margin = new System.Windows.Forms.Padding(0);
            this.uniTextBox12.MaxLength = 18;
            this.uniTextBox12.Name = "uniTextBox12";
            this.uniTextBox12.QueryIfEnterKeyPressed = true;
            this.uniTextBox12.RequiredField = false;
            this.uniTextBox12.Size = new System.Drawing.Size(150, 21);
            this.uniTextBox12.Style = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.uniTextBox12.StyleSetName = "Default";
            this.uniTextBox12.TabIndex = 0;
            this.uniTextBox12.uniALT = null;
            this.uniTextBox12.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.uniTextBox12.UseDynamicFormat = false;
            this.uniTextBox12.WordWrap = false;
            // 
            // uniLabel4
            // 
            appearance89.TextHAlignAsString = "Left";
            appearance89.TextVAlignAsString = "Middle";
            this.uniLabel4.Appearance = appearance89;
            this.uniLabel4.AutoPopupID = null;
            this.uniLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniLabel4.LabelType = uniERP.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.uniLabel4.Location = new System.Drawing.Point(504, 59);
            this.uniLabel4.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.uniLabel4.Name = "uniLabel4";
            this.uniLabel4.Size = new System.Drawing.Size(122, 28);
            this.uniLabel4.StyleSetName = "Default";
            this.uniLabel4.TabIndex = 9;
            this.uniLabel4.Text = "유저";
            this.uniLabel4.UseFlatMode = Infragistics.Win.DefaultableBoolean.False;
            this.uniLabel4.UseMnemonic = false;
            // 
            // popTrackingNo
            // 
            this.popTrackingNo.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.popTrackingNo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.popTrackingNo.AutoPopupCodeParameter = null;
            this.popTrackingNo.AutoPopupID = null;
            this.popTrackingNo.AutoPopupNameParameter = null;
            this.popTrackingNo.CodeMaxLength = 18;
            this.popTrackingNo.CodeName = "";
            this.popTrackingNo.CodeSize = 150;
            this.popTrackingNo.CodeStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popTrackingNo.CodeTextBoxName = null;
            this.popTrackingNo.CodeValue = "";
            this.popTrackingNo.Controls.Add(this.uniTextBox1);
            this.popTrackingNo.Controls.Add(this.uniTextBox2);
            this.popTrackingNo.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.Nullable;
            this.popTrackingNo.Location = new System.Drawing.Point(626, 66);
            this.popTrackingNo.LockedField = false;
            this.popTrackingNo.Margin = new System.Windows.Forms.Padding(0);
            this.popTrackingNo.Name = "popTrackingNo";
            this.popTrackingNo.NameDisplay = true;
            this.popTrackingNo.NameId = null;
            this.popTrackingNo.NameMaxLength = 50;
            this.popTrackingNo.NamePopup = false;
            this.popTrackingNo.NameSize = 150;
            this.popTrackingNo.NameStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popTrackingNo.Parameter = null;
            this.popTrackingNo.PopupButtonEnable = uniERP.AppFramework.UI.Variables.enumDef.uniOpenPopupButton.Enable;
            this.popTrackingNo.PopupId = null;
            this.popTrackingNo.PopupType = uniERP.AppFramework.UI.Variables.enumDef.PopupType.CommonPopup;
            this.popTrackingNo.QueryIfEnterKeyPressed = true;
            this.popTrackingNo.RequiredField = false;
            this.popTrackingNo.Size = new System.Drawing.Size(321, 21);
            this.popTrackingNo.TabIndex = 11;
            this.popTrackingNo.uniALT = "Component Item";
            this.popTrackingNo.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.popTrackingNo.UseDynamicFormat = false;
            this.popTrackingNo.ValueTextBoxName = null;
            // 
            // uniTextBox1
            // 
            this.uniTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            appearance90.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox1.Appearance = appearance90;
            this.uniTextBox1.AutoSize = false;
            this.uniTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox1.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.uniTextBox1.Location = new System.Drawing.Point(171, 0);
            this.uniTextBox1.LockedField = false;
            this.uniTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.uniTextBox1.MaxLength = 50;
            this.uniTextBox1.Name = "uniTextBox1";
            this.uniTextBox1.QueryIfEnterKeyPressed = true;
            this.uniTextBox1.ReadOnly = true;
            this.uniTextBox1.RequiredField = false;
            this.uniTextBox1.Size = new System.Drawing.Size(150, 21);
            this.uniTextBox1.Style = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.uniTextBox1.StyleSetName = "Lock";
            this.uniTextBox1.TabIndex = 0;
            this.uniTextBox1.TabStop = false;
            this.uniTextBox1.uniALT = null;
            this.uniTextBox1.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.uniTextBox1.UseDynamicFormat = false;
            this.uniTextBox1.WordWrap = false;
            // 
            // uniTextBox2
            // 
            this.uniTextBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            appearance91.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox2.Appearance = appearance91;
            this.uniTextBox2.AutoSize = false;
            this.uniTextBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.uniTextBox2.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.uniTextBox2.Location = new System.Drawing.Point(0, 0);
            this.uniTextBox2.LockedField = false;
            this.uniTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.uniTextBox2.MaxLength = 18;
            this.uniTextBox2.Name = "uniTextBox2";
            this.uniTextBox2.QueryIfEnterKeyPressed = true;
            this.uniTextBox2.RequiredField = false;
            this.uniTextBox2.Size = new System.Drawing.Size(150, 21);
            this.uniTextBox2.Style = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.uniTextBox2.StyleSetName = "Default";
            this.uniTextBox2.TabIndex = 0;
            this.uniTextBox2.uniALT = null;
            this.uniTextBox2.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.uniTextBox2.UseDynamicFormat = false;
            this.uniTextBox2.WordWrap = false;
            // 
            // uniTBL_MainReference
            // 
            this.uniTBL_MainReference.AutoFit = false;
            this.uniTBL_MainReference.AutoFitColumnCount = 4;
            this.uniTBL_MainReference.AutoFitRowCount = 4;
            this.uniTBL_MainReference.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_MainReference.ColumnCount = 3;
            this.uniTBL_MainReference.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainReference.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainReference.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainReference.Controls.Add(this.lblBChange, 2, 0);
            this.uniTBL_MainReference.DefaultRowSize = 25;
            this.uniTBL_MainReference.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainReference.EasyBaseBatchType = uniERP.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainReference.HEIGHT_TYPE_00_REFERENCE = 32F;
            this.uniTBL_MainReference.HEIGHT_TYPE_01 = 3F;
            this.uniTBL_MainReference.HEIGHT_TYPE_01_CONDITION = 29F;
            this.uniTBL_MainReference.HEIGHT_TYPE_02 = 5F;
            this.uniTBL_MainReference.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_MainReference.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_MainReference.HEIGHT_TYPE_03_BOTTOM = 32F;
            this.uniTBL_MainReference.HEIGHT_TYPE_04 = 3F;
            this.uniTBL_MainReference.Location = new System.Drawing.Point(0, 0);
            this.uniTBL_MainReference.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainReference.Name = "uniTBL_MainReference";
            this.uniTBL_MainReference.PanelType = uniERP.AppFramework.UI.Variables.enumDef.PanelType.Default;
            this.uniTBL_MainReference.RowCount = 1;
            this.uniTBL_MainReference.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainReference.Size = new System.Drawing.Size(979, 21);
            this.uniTBL_MainReference.SizeTD5 = 14F;
            this.uniTBL_MainReference.SizeTD6 = 36F;
            this.uniTBL_MainReference.TabIndex = 2;
            this.uniTBL_MainReference.uniERPTableLayout = uniERP.AppFramework.UI.Controls.uniERPTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainReference.uniLR_SPACE_TYPE = uniERP.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // lblBChange
            // 
            appearance100.TextHAlignAsString = "Left";
            appearance100.TextVAlignAsString = "Middle";
            this.lblBChange.Appearance = appearance100;
            this.lblBChange.AutoPopupID = null;
            this.lblBChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblBChange.LabelType = uniERP.AppFramework.UI.Variables.enumDef.LabelType.Reference;
            this.lblBChange.Location = new System.Drawing.Point(879, 3);
            this.lblBChange.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lblBChange.Name = "lblBChange";
            this.lblBChange.Size = new System.Drawing.Size(100, 15);
            this.lblBChange.StyleSetName = "uniLabel_Reference";
            this.lblBChange.TabIndex = 0;
            this.lblBChange.Text = "Batch Change";
            this.lblBChange.UseMnemonic = false;
            this.lblBChange.Visible = false;
            // 
            // uniTBL_MainBatch
            // 
            this.uniTBL_MainBatch.AutoFit = false;
            this.uniTBL_MainBatch.AutoFitColumnCount = 4;
            this.uniTBL_MainBatch.AutoFitRowCount = 4;
            this.uniTBL_MainBatch.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_MainBatch.ColumnCount = 5;
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainBatch.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.uniTBL_MainBatch.Controls.Add(this.btnBomExec, 0, 0);
            this.uniTBL_MainBatch.DefaultRowSize = 25;
            this.uniTBL_MainBatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainBatch.EasyBaseBatchType = uniERP.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainBatch.HEIGHT_TYPE_00_REFERENCE = 32F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_01 = 3F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_01_CONDITION = 29F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_02 = 5F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_03 = 3F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_03_BOTTOM = 32F;
            this.uniTBL_MainBatch.HEIGHT_TYPE_04 = 3F;
            this.uniTBL_MainBatch.Location = new System.Drawing.Point(0, 711);
            this.uniTBL_MainBatch.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainBatch.Name = "uniTBL_MainBatch";
            this.uniTBL_MainBatch.PanelType = uniERP.AppFramework.UI.Variables.enumDef.PanelType.Default;
            this.uniTBL_MainBatch.RowCount = 1;
            this.uniTBL_MainBatch.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainBatch.Size = new System.Drawing.Size(979, 28);
            this.uniTBL_MainBatch.SizeTD5 = 14F;
            this.uniTBL_MainBatch.SizeTD6 = 36F;
            this.uniTBL_MainBatch.TabIndex = 3;
            this.uniTBL_MainBatch.uniERPTableLayout = uniERP.AppFramework.UI.Controls.uniERPTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainBatch.uniLR_SPACE_TYPE = uniERP.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // btnBomExec
            // 
            this.btnBomExec.AutoPopupID = null;
            this.btnBomExec.ButtonText = uniERP.AppFramework.UI.Variables.enumDef.ButtonText.UserDefined;
            this.btnBomExec.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBomExec.Location = new System.Drawing.Point(0, 1);
            this.btnBomExec.Margin = new System.Windows.Forms.Padding(0, 1, 3, 3);
            this.btnBomExec.Name = "btnBomExec";
            this.btnBomExec.PopupID = null;
            this.btnBomExec.Size = new System.Drawing.Size(97, 24);
            this.btnBomExec.Style = uniERP.AppFramework.UI.Controls.Button_Style.Default;
            this.btnBomExec.TabIndex = 7;
            this.btnBomExec.Text = "전개";
            this.btnBomExec.UserDefinedText = null;
            this.btnBomExec.Click += new System.EventHandler(this.btnBomExec_Click);
            // 
            // uniTBL_MainData
            // 
            this.uniTBL_MainData.AutoFit = false;
            this.uniTBL_MainData.AutoFitColumnCount = 4;
            this.uniTBL_MainData.AutoFitRowCount = 4;
            this.uniTBL_MainData.BackColor = System.Drawing.Color.Transparent;
            this.uniTBL_MainData.ColumnCount = 1;
            this.uniTBL_MainData.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainData.Controls.Add(this.uniGrid1, 0, 0);
            this.uniTBL_MainData.DefaultRowSize = 25;
            this.uniTBL_MainData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniTBL_MainData.EasyBaseBatchType = uniERP.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTBL_MainData.HEIGHT_TYPE_00_REFERENCE = 25F;
            this.uniTBL_MainData.HEIGHT_TYPE_01 = 9F;
            this.uniTBL_MainData.HEIGHT_TYPE_01_CONDITION = 40F;
            this.uniTBL_MainData.HEIGHT_TYPE_02 = 9F;
            this.uniTBL_MainData.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTBL_MainData.HEIGHT_TYPE_03 = 9F;
            this.uniTBL_MainData.HEIGHT_TYPE_03_BOTTOM = 25F;
            this.uniTBL_MainData.HEIGHT_TYPE_04 = 3F;
            this.uniTBL_MainData.Location = new System.Drawing.Point(0, 159);
            this.uniTBL_MainData.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainData.Name = "uniTBL_MainData";
            this.uniTBL_MainData.PanelType = uniERP.AppFramework.UI.Variables.enumDef.PanelType.Data;
            this.uniTBL_MainData.RowCount = 1;
            this.uniTBL_MainData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uniTBL_MainData.Size = new System.Drawing.Size(979, 549);
            this.uniTBL_MainData.SizeTD5 = 14F;
            this.uniTBL_MainData.SizeTD6 = 36F;
            this.uniTBL_MainData.TabIndex = 1;
            this.uniTBL_MainData.uniERPTableLayout = uniERP.AppFramework.UI.Controls.uniERPTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainData.uniLR_SPACE_TYPE = uniERP.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // uniGrid1
            // 
            this.uniGrid1.AddEmptyRow = false;
            this.uniGrid1.DirectPaste = false;
            appearance101.BackColor = System.Drawing.SystemColors.Window;
            appearance101.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.uniGrid1.DisplayLayout.Appearance = appearance101;
            this.uniGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.uniGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance102.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance102.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance102.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance102.BorderColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.GroupByBox.Appearance = appearance102;
            appearance103.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uniGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance103;
            this.uniGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance104.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance104.BackColor2 = System.Drawing.SystemColors.Control;
            appearance104.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance104.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uniGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance104;
            this.uniGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.uniGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance105.BackColor = System.Drawing.SystemColors.Window;
            appearance105.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uniGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance105;
            this.uniGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.uniGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.uniGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance106.BackColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.Override.CardAreaAppearance = appearance106;
            appearance107.BorderColor = System.Drawing.Color.Silver;
            appearance107.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.uniGrid1.DisplayLayout.Override.CellAppearance = appearance107;
            this.uniGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect;
            this.uniGrid1.DisplayLayout.Override.CellPadding = 0;
            appearance108.BackColor = System.Drawing.SystemColors.Control;
            appearance108.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance108.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance108.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance108.BorderColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance108;
            appearance109.TextHAlignAsString = "Left";
            this.uniGrid1.DisplayLayout.Override.HeaderAppearance = appearance109;
            this.uniGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.uniGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance110.BackColor = System.Drawing.SystemColors.Window;
            appearance110.BorderColor = System.Drawing.Color.Silver;
            this.uniGrid1.DisplayLayout.Override.RowAppearance = appearance110;
            this.uniGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance111.BackColor = System.Drawing.SystemColors.ControlLight;
            this.uniGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance111;
            this.uniGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uniGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.uniGrid1.EnableContextMenu = true;
            this.uniGrid1.EnableGridInfoContextMenu = true;
            this.uniGrid1.ExceptInExcel = false;
            this.uniGrid1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uniGrid1.gComNumDec = uniERP.AppFramework.UI.Variables.enumDef.ComDec.Decimal;
            this.uniGrid1.GridStyle = uniERP.AppFramework.UI.Variables.enumDef.GridStyle.Master;
            this.uniGrid1.Location = new System.Drawing.Point(0, 0);
            this.uniGrid1.Margin = new System.Windows.Forms.Padding(0);
            this.uniGrid1.Name = "uniGrid1";
            this.uniGrid1.OutlookGroupBy = uniERP.AppFramework.UI.Variables.enumDef.IsOutlookGroupBy.No;
            this.uniGrid1.PopupDeleteMenuVisible = true;
            this.uniGrid1.PopupInsertMenuVisible = true;
            this.uniGrid1.PopupUndoMenuVisible = true;
            this.uniGrid1.Search = uniERP.AppFramework.UI.Variables.enumDef.IsSearch.Yes;
            this.uniGrid1.ShowHeaderCheck = true;
            this.uniGrid1.Size = new System.Drawing.Size(979, 497);
            this.uniGrid1.StyleSetName = "Default";
            this.uniGrid1.TabIndex = 1;
            this.uniGrid1.Text = "uniGrid1";
            this.uniGrid1.UseDynamicFormat = false;
            this.uniGrid1.BeforePopupOpen += new uniERP.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.uniGrid1_BeforePopupOpen);
            this.uniGrid1.AfterPopupClosed += new uniERP.AppFramework.UI.Controls.Popup.AfterPopupCloseEventHandler(this.uniGrid1_AfterPopupClosed);
            this.uniGrid1.HeaderCheckBoxClick += new System.EventHandler(this.uniGrid1_HeaderCheckBoxClick);
            this.uniGrid1.CellChange += new Infragistics.Win.UltraWinGrid.CellEventHandler(this.uniGrid1_CellChange);
            // 
            // uniTableLayoutPanel2
            // 
            this.uniTableLayoutPanel2.AutoFit = false;
            this.uniTableLayoutPanel2.AutoFitColumnCount = 4;
            this.uniTableLayoutPanel2.AutoFitRowCount = 4;
            this.uniTableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.uniTableLayoutPanel2.ColumnCount = 3;
            this.uniTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.27273F));
            this.uniTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.72727F));
            this.uniTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 174F));
            this.uniTableLayoutPanel2.DefaultRowSize = 23;
            this.uniTableLayoutPanel2.EasyBaseBatchType = uniERP.AppFramework.UI.Controls.EasyBaseTBType.NONE;
            this.uniTableLayoutPanel2.HEIGHT_TYPE_00_REFERENCE = 21F;
            this.uniTableLayoutPanel2.HEIGHT_TYPE_01 = 6F;
            this.uniTableLayoutPanel2.HEIGHT_TYPE_01_CONDITION = 38F;
            this.uniTableLayoutPanel2.HEIGHT_TYPE_02 = 9F;
            this.uniTableLayoutPanel2.HEIGHT_TYPE_02_DATA = 0F;
            this.uniTableLayoutPanel2.HEIGHT_TYPE_03 = 3F;
            this.uniTableLayoutPanel2.HEIGHT_TYPE_03_BOTTOM = 28F;
            this.uniTableLayoutPanel2.HEIGHT_TYPE_04 = 1F;
            this.uniTableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.uniTableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.uniTableLayoutPanel2.Name = "uniTableLayoutPanel2";
            this.uniTableLayoutPanel2.PanelType = uniERP.AppFramework.UI.Variables.enumDef.PanelType.Default;
            this.uniTableLayoutPanel2.RowCount = 1;
            this.uniTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTableLayoutPanel2.Size = new System.Drawing.Size(200, 100);
            this.uniTableLayoutPanel2.SizeTD5 = 14F;
            this.uniTableLayoutPanel2.SizeTD6 = 36F;
            this.uniTableLayoutPanel2.TabIndex = 0;
            this.uniTableLayoutPanel2.uniERPTableLayout = uniERP.AppFramework.UI.Controls.uniERPTableLayOutStyle.DefaultTableLayout;
            this.uniTableLayoutPanel2.uniLR_SPACE_TYPE = uniERP.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // uniLabel5
            // 
            appearance85.TextHAlignAsString = "Left";
            appearance85.TextVAlignAsString = "Middle";
            this.uniLabel5.Appearance = appearance85;
            this.uniLabel5.AutoPopupID = null;
            this.uniLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniLabel5.LabelType = uniERP.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.uniLabel5.Location = new System.Drawing.Point(15, 88);
            this.uniLabel5.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.uniLabel5.Name = "uniLabel5";
            this.uniLabel5.Size = new System.Drawing.Size(122, 23);
            this.uniLabel5.StyleSetName = "Default";
            this.uniLabel5.TabIndex = 15;
            this.uniLabel5.Text = "소분류";
            this.uniLabel5.UseFlatMode = Infragistics.Win.DefaultableBoolean.False;
            this.uniLabel5.UseMnemonic = false;
            // 
            // popItemGrp2
            // 
            this.popItemGrp2.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.popItemGrp2.AutoPopupCodeParameter = null;
            this.popItemGrp2.AutoPopupID = null;
            this.popItemGrp2.AutoPopupNameParameter = null;
            this.popItemGrp2.CodeMaxLength = 18;
            this.popItemGrp2.CodeName = "";
            this.popItemGrp2.CodeSize = 150;
            this.popItemGrp2.CodeStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popItemGrp2.CodeTextBoxName = null;
            this.popItemGrp2.CodeValue = "";
            this.popItemGrp2.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.Nullable;
            this.popItemGrp2.Location = new System.Drawing.Point(137, 58);
            this.popItemGrp2.LockedField = false;
            this.popItemGrp2.Margin = new System.Windows.Forms.Padding(0);
            this.popItemGrp2.Name = "popItemGrp2";
            this.popItemGrp2.NameDisplay = true;
            this.popItemGrp2.NameId = null;
            this.popItemGrp2.NameMaxLength = 50;
            this.popItemGrp2.NamePopup = false;
            this.popItemGrp2.NameSize = 150;
            this.popItemGrp2.NameStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popItemGrp2.Parameter = null;
            this.popItemGrp2.PopupButtonEnable = uniERP.AppFramework.UI.Variables.enumDef.uniOpenPopupButton.Enable;
            this.popItemGrp2.PopupId = null;
            this.popItemGrp2.PopupType = uniERP.AppFramework.UI.Variables.enumDef.PopupType.CommonPopup;
            this.popItemGrp2.QueryIfEnterKeyPressed = true;
            this.popItemGrp2.RequiredField = false;
            this.popItemGrp2.Size = new System.Drawing.Size(321, 29);
            this.popItemGrp2.TabIndex = 12;
            this.popItemGrp2.uniALT = "Component Item";
            this.popItemGrp2.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.popItemGrp2.UseDynamicFormat = false;
            this.popItemGrp2.ValueTextBoxName = null;
            this.popItemGrp2.BeforePopupOpen += new uniERP.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.popItemGroup2_BeforePopupOpen);
            this.popItemGrp2.AfterPopupClosed += new uniERP.AppFramework.UI.Controls.Popup.AfterPopupCloseEventHandler(this.popItemGroup2_AfterPopupClosed);
            // 
            // uniTextBox3
            // 
            this.uniTextBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            appearance112.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox3.Appearance = appearance112;
            this.uniTextBox3.AutoSize = false;
            this.uniTextBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox3.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.uniTextBox3.Location = new System.Drawing.Point(171, 0);
            this.uniTextBox3.LockedField = false;
            this.uniTextBox3.Margin = new System.Windows.Forms.Padding(0);
            this.uniTextBox3.MaxLength = 50;
            this.uniTextBox3.Name = "uniTextBox3";
            this.uniTextBox3.QueryIfEnterKeyPressed = true;
            this.uniTextBox3.ReadOnly = true;
            this.uniTextBox3.RequiredField = false;
            this.uniTextBox3.Size = new System.Drawing.Size(150, 21);
            this.uniTextBox3.Style = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.uniTextBox3.StyleSetName = "Lock";
            this.uniTextBox3.TabIndex = 0;
            this.uniTextBox3.TabStop = false;
            this.uniTextBox3.uniALT = null;
            this.uniTextBox3.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.uniTextBox3.UseDynamicFormat = false;
            this.uniTextBox3.WordWrap = false;
            // 
            // uniLabel1
            // 
            appearance88.TextHAlignAsString = "Left";
            appearance88.TextVAlignAsString = "Middle";
            this.uniLabel1.Appearance = appearance88;
            this.uniLabel1.AutoPopupID = null;
            this.uniLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniLabel1.LabelType = uniERP.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.uniLabel1.Location = new System.Drawing.Point(504, 88);
            this.uniLabel1.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.uniLabel1.Name = "uniLabel1";
            this.uniLabel1.Size = new System.Drawing.Size(122, 23);
            this.uniLabel1.StyleSetName = "Default";
            this.uniLabel1.TabIndex = 17;
            this.uniLabel1.Text = "자품목";
            this.uniLabel1.UseMnemonic = false;
            // 
            // popItemGrp3
            // 
            this.popItemGrp3.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.popItemGrp3.AutoPopupCodeParameter = null;
            this.popItemGrp3.AutoPopupID = null;
            this.popItemGrp3.AutoPopupNameParameter = null;
            this.popItemGrp3.CodeMaxLength = 18;
            this.popItemGrp3.CodeName = "";
            this.popItemGrp3.CodeSize = 150;
            this.popItemGrp3.CodeStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popItemGrp3.CodeTextBoxName = null;
            this.popItemGrp3.CodeValue = "";
            this.popItemGrp3.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.Nullable;
            this.popItemGrp3.Location = new System.Drawing.Point(137, 87);
            this.popItemGrp3.LockedField = false;
            this.popItemGrp3.Margin = new System.Windows.Forms.Padding(0);
            this.popItemGrp3.Name = "popItemGrp3";
            this.popItemGrp3.NameDisplay = true;
            this.popItemGrp3.NameId = null;
            this.popItemGrp3.NameMaxLength = 50;
            this.popItemGrp3.NamePopup = false;
            this.popItemGrp3.NameSize = 150;
            this.popItemGrp3.NameStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popItemGrp3.Parameter = null;
            this.popItemGrp3.PopupButtonEnable = uniERP.AppFramework.UI.Variables.enumDef.uniOpenPopupButton.Enable;
            this.popItemGrp3.PopupId = null;
            this.popItemGrp3.PopupType = uniERP.AppFramework.UI.Variables.enumDef.PopupType.CommonPopup;
            this.popItemGrp3.QueryIfEnterKeyPressed = true;
            this.popItemGrp3.RequiredField = false;
            this.popItemGrp3.Size = new System.Drawing.Size(321, 24);
            this.popItemGrp3.TabIndex = 18;
            this.popItemGrp3.uniALT = "Component Item";
            this.popItemGrp3.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.popItemGrp3.UseDynamicFormat = false;
            this.popItemGrp3.ValueTextBoxName = null;
            this.popItemGrp3.BeforePopupOpen += new uniERP.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.popItemGroup3_BeforePopupOpen);
            this.popItemGrp3.AfterPopupClosed += new uniERP.AppFramework.UI.Controls.Popup.AfterPopupCloseEventHandler(this.popItemGroup3_AfterPopupClosed);
            // 
            // popItemCd
            // 
            this.popItemCd.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.popItemCd.AutoPopupCodeParameter = null;
            this.popItemCd.AutoPopupID = null;
            this.popItemCd.AutoPopupNameParameter = null;
            this.popItemCd.CodeMaxLength = 18;
            this.popItemCd.CodeName = "";
            this.popItemCd.CodeSize = 150;
            this.popItemCd.CodeStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popItemCd.CodeTextBoxName = null;
            this.popItemCd.CodeValue = "";
            this.popItemCd.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.Nullable;
            this.popItemCd.Location = new System.Drawing.Point(626, 28);
            this.popItemCd.LockedField = false;
            this.popItemCd.Margin = new System.Windows.Forms.Padding(0);
            this.popItemCd.Name = "popItemCd";
            this.popItemCd.NameDisplay = true;
            this.popItemCd.NameId = null;
            this.popItemCd.NameMaxLength = 50;
            this.popItemCd.NamePopup = false;
            this.popItemCd.NameSize = 150;
            this.popItemCd.NameStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popItemCd.Parameter = null;
            this.popItemCd.PopupButtonEnable = uniERP.AppFramework.UI.Variables.enumDef.uniOpenPopupButton.Enable;
            this.popItemCd.PopupId = null;
            this.popItemCd.PopupType = uniERP.AppFramework.UI.Variables.enumDef.PopupType.CommonPopup;
            this.popItemCd.QueryIfEnterKeyPressed = true;
            this.popItemCd.RequiredField = false;
            this.popItemCd.Size = new System.Drawing.Size(321, 23);
            this.popItemCd.TabIndex = 13;
            this.popItemCd.uniALT = "Component Item";
            this.popItemCd.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.popItemCd.UseDynamicFormat = false;
            this.popItemCd.ValueTextBoxName = null;
            this.popItemCd.BeforePopupOpen += new uniERP.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.popItemCd_BeforePopupOpen);
            this.popItemCd.AfterPopupClosed += new uniERP.AppFramework.UI.Controls.Popup.AfterPopupCloseEventHandler(this.popItemCd_AfterPopupClosed);
            // 
            // ModuleViewer
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.uniTBL_OuterMost);
            this.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumSize = new System.Drawing.Size(0, 0);
            this.Name = "ModuleViewer";
            this.Size = new System.Drawing.Size(990, 760);
            this.Controls.SetChildIndex(this.uniTBL_OuterMost, 0);
            this.Controls.SetChildIndex(this.uniLabel_Path, 0);
            this.uniTBL_OuterMost.ResumeLayout(false);
            this.uniTBL_MainCondition.ResumeLayout(false);
            this.popChildItemCd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox_Code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox12)).EndInit();
            this.popTrackingNo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox2)).EndInit();
            this.uniTBL_MainReference.ResumeLayout(false);
            this.uniTBL_MainBatch.ResumeLayout(false);
            this.uniTBL_MainData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uniGrid1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox3)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private uniERP.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_OuterMost;
		private uniERP.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainCondition;
		private uniERP.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainReference;
		private uniERP.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainBatch;
        private uniERP.AppFramework.UI.Controls.uniTableLayoutPanel uniTBL_MainData;
		private uniERP.AppFramework.UI.Controls.uniGrid uniGrid1;
		private uniERP.AppFramework.UI.Controls.uniLabel lblPlantCd;
        private uniERP.AppFramework.UI.Controls.uniLabel lbItemCd;
		private uniERP.AppFramework.UI.Controls.uniOpenPopup popPlantCd;
        private uniERP.AppFramework.UI.Controls.uniOpenPopup popItemGrp1;
        private uniERP.AppFramework.UI.Controls.uniTableLayoutPanel uniTableLayoutPanel2;
        private uniERP.AppFramework.UI.Controls.uniLabel lblBChange;
        private AppFramework.UI.Controls.uniLabel uniLabel4;
        private AppFramework.UI.Controls.uniLabel uniLabel2;
        private AppFramework.UI.Controls.uniLabel uniLabel3;
        private AppFramework.UI.Controls.uniOpenPopup popTrackingNo;
        private AppFramework.UI.Controls.uniTextBox uniTextBox1;
        private AppFramework.UI.Controls.uniTextBox uniTextBox2;
        private AppFramework.UI.Controls.uniOpenPopup popChildItemCd;
        private AppFramework.UI.Controls.uniTextBox uniTextBox_Name;
        private AppFramework.UI.Controls.uniTextBox uniTextBox_Code;
        private AppFramework.UI.Controls.uniTextBox uniTextBox9;
        private AppFramework.UI.Controls.uniTextBox uniTextBox10;
        private AppFramework.UI.Controls.uniTextBox uniTextBox11;
        private AppFramework.UI.Controls.uniTextBox uniTextBox12;
        private AppFramework.UI.Controls.uniButton btnBomExec;
        private AppFramework.UI.Controls.uniLabel uniLabel5;
        private AppFramework.UI.Controls.uniOpenPopup popItemGrp2;
        private AppFramework.UI.Controls.uniTextBox uniTextBox3;
        private AppFramework.UI.Controls.uniLabel uniLabel1;
        private AppFramework.UI.Controls.uniOpenPopup popItemGrp3;
        private AppFramework.UI.Controls.uniOpenPopup popItemCd;

	}
}
