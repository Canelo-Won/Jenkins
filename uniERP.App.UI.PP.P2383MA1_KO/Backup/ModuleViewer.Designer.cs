using uniERP.AppFramework.UI.Module;
using Microsoft.Practices.CompositeUI;
using Microsoft.Practices.ObjectBuilder;

namespace uniERP.App.UI.MDM.B1B11MA6_KO611
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
            Infragistics.Win.Appearance appearance1 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance2 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance3 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance4 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance5 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance6 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance7 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance8 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance9 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance10 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance11 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance12 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance13 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance14 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance15 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance16 = new Infragistics.Win.Appearance();
            Infragistics.Win.Appearance appearance17 = new Infragistics.Win.Appearance();
            this.uniTBL_OuterMost = new uniERP.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_MainCondition = new uniERP.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.lblPlantCd = new uniERP.AppFramework.UI.Controls.uniLabel(this.components);
            this.lbItemCd = new uniERP.AppFramework.UI.Controls.uniLabel(this.components);
            this.popPlantCd = new uniERP.AppFramework.UI.Controls.uniOpenPopup();
            this.popItemCd = new uniERP.AppFramework.UI.Controls.uniOpenPopup();
            this.uniLabel22 = new uniERP.AppFramework.UI.Controls.uniLabel(this.components);
            this.popTracking = new uniERP.AppFramework.UI.Controls.uniOpenPopup();
            this.uniTextBox_Name = new uniERP.AppFramework.UI.Controls.uniTextBox(this.components);
            this.uniTextBox_Code = new uniERP.AppFramework.UI.Controls.uniTextBox(this.components);
            this.uniTBL_MainReference = new uniERP.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.lblBChange = new uniERP.AppFramework.UI.Controls.uniLabel(this.components);
            this.uniTBL_MainBatch = new uniERP.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_MainData = new uniERP.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniGrid1 = new uniERP.AppFramework.UI.Controls.uniGrid(this.components);
            this.uniTableLayoutPanel2 = new uniERP.AppFramework.UI.Controls.uniTableLayoutPanel(this.components);
            this.uniTBL_OuterMost.SuspendLayout();
            this.uniTBL_MainCondition.SuspendLayout();
            this.popTracking.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox_Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox_Code)).BeginInit();
            this.uniTBL_MainReference.SuspendLayout();
            this.uniTBL_MainData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.uniGrid1)).BeginInit();
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
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.uniTBL_OuterMost.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
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
            // 
            // uniTBL_MainCondition
            // 
            this.uniTBL_MainCondition.AutoFit = false;
            this.uniTBL_MainCondition.AutoFitColumnCount = 4;
            this.uniTBL_MainCondition.AutoFitRowCount = 4;
            this.uniTBL_MainCondition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(236)))), ((int)(((byte)(248)))));
            this.uniTBL_MainCondition.ColumnCount = 4;
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14F));
            this.uniTBL_MainCondition.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36F));
            this.uniTBL_MainCondition.Controls.Add(this.lblPlantCd, 0, 0);
            this.uniTBL_MainCondition.Controls.Add(this.lbItemCd, 0, 1);
            this.uniTBL_MainCondition.Controls.Add(this.popPlantCd, 1, 0);
            this.uniTBL_MainCondition.Controls.Add(this.popItemCd, 1, 1);
            this.uniTBL_MainCondition.Controls.Add(this.uniLabel22, 2, 1);
            this.uniTBL_MainCondition.Controls.Add(this.popTracking, 3, 1);
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
            this.uniTBL_MainCondition.RowCount = 2;
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.uniTBL_MainCondition.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainCondition.Size = new System.Drawing.Size(979, 61);
            this.uniTBL_MainCondition.SizeTD5 = 16F;
            this.uniTBL_MainCondition.SizeTD6 = 34F;
            this.uniTBL_MainCondition.TabIndex = 0;
            this.uniTBL_MainCondition.uniERPTableLayout = uniERP.AppFramework.UI.Controls.uniERPTableLayOutStyle.DefaultTableLayout;
            this.uniTBL_MainCondition.uniLR_SPACE_TYPE = uniERP.AppFramework.UI.Controls.LR_SPACE_TYPE.LR_SPACE_TYPE_00;
            // 
            // lblPlantCd
            // 
            appearance1.TextHAlignAsString = "Left";
            appearance1.TextVAlignAsString = "Middle";
            this.lblPlantCd.Appearance = appearance1;
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
            // lbItemCd
            // 
            appearance2.TextHAlignAsString = "Left";
            appearance2.TextVAlignAsString = "Middle";
            this.lbItemCd.Appearance = appearance2;
            this.lbItemCd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbItemCd.LabelType = uniERP.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.lbItemCd.Location = new System.Drawing.Point(15, 29);
            this.lbItemCd.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.lbItemCd.Name = "lbItemCd";
            this.lbItemCd.Size = new System.Drawing.Size(122, 22);
            this.lbItemCd.StyleSetName = "Default";
            this.lbItemCd.TabIndex = 1;
            this.lbItemCd.Text = "자품목";
            this.lbItemCd.UseMnemonic = false;
            // 
            // popPlantCd
            // 
            this.popPlantCd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.popPlantCd.NameStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
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
            // popItemCd
            // 
            this.popItemCd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.popItemCd.CodeMaxLength = 18;
            this.popItemCd.CodeName = "";
            this.popItemCd.CodeSize = 150;
            this.popItemCd.CodeStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popItemCd.CodeTextBoxName = null;
            this.popItemCd.CodeValue = "";
            this.popItemCd.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.NotNull;
            this.popItemCd.Location = new System.Drawing.Point(137, 30);
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
            this.popItemCd.Size = new System.Drawing.Size(321, 21);
            this.popItemCd.TabIndex = 1;
            this.popItemCd.uniALT = "Component Item";
            this.popItemCd.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.popItemCd.UseDynamicFormat = false;
            this.popItemCd.ValueTextBoxName = null;
            this.popItemCd.BeforePopupOpen += new uniERP.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.popItemCd_BeforePopupOpen);
            this.popItemCd.AfterPopupClosed += new uniERP.AppFramework.UI.Controls.Popup.AfterPopupCloseEventHandler(this.popItemCd_AfterPopupClosed);
            // 
            // uniLabel22
            // 
            appearance3.TextHAlignAsString = "Left";
            appearance3.TextVAlignAsString = "Middle";
            this.uniLabel22.Appearance = appearance3;
            this.uniLabel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniLabel22.LabelType = uniERP.AppFramework.UI.Variables.enumDef.LabelType.Title;
            this.uniLabel22.Location = new System.Drawing.Point(504, 29);
            this.uniLabel22.Margin = new System.Windows.Forms.Padding(15, 1, 0, 0);
            this.uniLabel22.Name = "uniLabel22";
            this.uniLabel22.Size = new System.Drawing.Size(122, 22);
            this.uniLabel22.StyleSetName = "Default";
            this.uniLabel22.TabIndex = 4;
            this.uniLabel22.Text = "USER코드";
            this.uniLabel22.UseMnemonic = false;
            // 
            // popTracking
            // 
            this.popTracking.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.popTracking.CodeMaxLength = 10;
            this.popTracking.CodeName = "";
            this.popTracking.CodeSize = 100;
            this.popTracking.CodeStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popTracking.CodeTextBoxName = null;
            this.popTracking.CodeValue = "";
            this.popTracking.Controls.Add(this.uniTextBox_Name);
            this.popTracking.Controls.Add(this.uniTextBox_Code);
            this.popTracking.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.popTracking.Location = new System.Drawing.Point(626, 30);
            this.popTracking.LockedField = false;
            this.popTracking.Margin = new System.Windows.Forms.Padding(0);
            this.popTracking.Name = "popTracking";
            this.popTracking.NameDisplay = false;
            this.popTracking.NameId = null;
            this.popTracking.NameMaxLength = 50;
            this.popTracking.NamePopup = false;
            this.popTracking.NameSize = 100;
            this.popTracking.NameStyle = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.popTracking.Parameter = null;
            this.popTracking.PopupButtonEnable = uniERP.AppFramework.UI.Variables.enumDef.uniOpenPopupButton.Enable;
            this.popTracking.PopupId = null;
            this.popTracking.PopupType = uniERP.AppFramework.UI.Variables.enumDef.PopupType.CommonPopup;
            this.popTracking.QueryIfEnterKeyPressed = true;
            this.popTracking.RequiredField = false;
            this.popTracking.Size = new System.Drawing.Size(121, 21);
            this.popTracking.TabIndex = 5;
            this.popTracking.uniALT = null;
            this.popTracking.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.popTracking.UseDynamicFormat = false;
            this.popTracking.ValueTextBoxName = null;
            this.popTracking.BeforePopupOpen += new uniERP.AppFramework.UI.Controls.Popup.BeforePopupOpenEventHandler(this.popTracking_BeforePopupOpen);
            this.popTracking.AfterPopupClosed += new uniERP.AppFramework.UI.Controls.Popup.AfterPopupCloseEventHandler(this.popTracking_AfterPopupClosed);
            // 
            // uniTextBox_Name
            // 
            this.uniTextBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            appearance4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox_Name.Appearance = appearance4;
            this.uniTextBox_Name.AutoSize = false;
            this.uniTextBox_Name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox_Name.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.uniTextBox_Name.Location = new System.Drawing.Point(121, 0);
            this.uniTextBox_Name.LockedField = false;
            this.uniTextBox_Name.Margin = new System.Windows.Forms.Padding(0);
            this.uniTextBox_Name.MaxLength = 50;
            this.uniTextBox_Name.Name = "uniTextBox_Name";
            this.uniTextBox_Name.QueryIfEnterKeyPressed = true;
            this.uniTextBox_Name.ReadOnly = true;
            this.uniTextBox_Name.RequiredField = false;
            this.uniTextBox_Name.Size = new System.Drawing.Size(0, 21);
            this.uniTextBox_Name.Style = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.uniTextBox_Name.StyleSetName = "Lock";
            this.uniTextBox_Name.TabIndex = 0;
            this.uniTextBox_Name.TabStop = false;
            this.uniTextBox_Name.uniALT = null;
            this.uniTextBox_Name.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.uniTextBox_Name.UseDynamicFormat = false;
            this.uniTextBox_Name.Visible = false;
            this.uniTextBox_Name.WordWrap = false;
            // 
            // uniTextBox_Code
            // 
            this.uniTextBox_Code.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            appearance5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox_Code.Appearance = appearance5;
            this.uniTextBox_Code.AutoSize = false;
            this.uniTextBox_Code.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.uniTextBox_Code.FieldType = uniERP.AppFramework.UI.Variables.enumDef.FieldType.Default;
            this.uniTextBox_Code.Location = new System.Drawing.Point(0, 0);
            this.uniTextBox_Code.LockedField = false;
            this.uniTextBox_Code.Margin = new System.Windows.Forms.Padding(0);
            this.uniTextBox_Code.MaxLength = 10;
            this.uniTextBox_Code.Name = "uniTextBox_Code";
            this.uniTextBox_Code.QueryIfEnterKeyPressed = true;
            this.uniTextBox_Code.RequiredField = false;
            this.uniTextBox_Code.Size = new System.Drawing.Size(100, 21);
            this.uniTextBox_Code.Style = uniERP.AppFramework.UI.Controls.TextBox_Style.Default;
            this.uniTextBox_Code.StyleSetName = "Default";
            this.uniTextBox_Code.TabIndex = 0;
            this.uniTextBox_Code.uniALT = null;
            this.uniTextBox_Code.uniCharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.uniTextBox_Code.UseDynamicFormat = false;
            this.uniTextBox_Code.WordWrap = false;
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
            appearance6.TextHAlignAsString = "Left";
            appearance6.TextVAlignAsString = "Middle";
            this.lblBChange.Appearance = appearance6;
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
            // uniTBL_MainData
            // 
            this.uniTBL_MainData.AutoFit = false;
            this.uniTBL_MainData.AutoFitColumnCount = 4;
            this.uniTBL_MainData.AutoFitRowCount = 4;
            this.uniTBL_MainData.BackColor = System.Drawing.Color.White;
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
            this.uniTBL_MainData.Location = new System.Drawing.Point(0, 97);
            this.uniTBL_MainData.Margin = new System.Windows.Forms.Padding(0);
            this.uniTBL_MainData.Name = "uniTBL_MainData";
            this.uniTBL_MainData.PanelType = uniERP.AppFramework.UI.Variables.enumDef.PanelType.Data;
            this.uniTBL_MainData.RowCount = 1;
            this.uniTBL_MainData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uniTBL_MainData.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uniTBL_MainData.Size = new System.Drawing.Size(979, 611);
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
            appearance7.BackColor = System.Drawing.SystemColors.Window;
            appearance7.BorderColor = System.Drawing.SystemColors.InactiveCaption;
            this.uniGrid1.DisplayLayout.Appearance = appearance7;
            this.uniGrid1.DisplayLayout.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            this.uniGrid1.DisplayLayout.CaptionVisible = Infragistics.Win.DefaultableBoolean.False;
            appearance8.BackColor = System.Drawing.SystemColors.ActiveBorder;
            appearance8.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance8.BackGradientStyle = Infragistics.Win.GradientStyle.Vertical;
            appearance8.BorderColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.GroupByBox.Appearance = appearance8;
            appearance9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uniGrid1.DisplayLayout.GroupByBox.BandLabelAppearance = appearance9;
            this.uniGrid1.DisplayLayout.GroupByBox.BorderStyle = Infragistics.Win.UIElementBorderStyle.Solid;
            appearance10.BackColor = System.Drawing.SystemColors.ControlLightLight;
            appearance10.BackColor2 = System.Drawing.SystemColors.Control;
            appearance10.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance10.ForeColor = System.Drawing.SystemColors.GrayText;
            this.uniGrid1.DisplayLayout.GroupByBox.PromptAppearance = appearance10;
            this.uniGrid1.DisplayLayout.MaxColScrollRegions = 1;
            this.uniGrid1.DisplayLayout.MaxRowScrollRegions = 1;
            appearance11.BackColor = System.Drawing.SystemColors.Window;
            appearance11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.uniGrid1.DisplayLayout.Override.ActiveCellAppearance = appearance11;
            this.uniGrid1.DisplayLayout.Override.AllowAddNew = Infragistics.Win.UltraWinGrid.AllowAddNew.No;
            this.uniGrid1.DisplayLayout.Override.BorderStyleCell = Infragistics.Win.UIElementBorderStyle.Dotted;
            this.uniGrid1.DisplayLayout.Override.BorderStyleRow = Infragistics.Win.UIElementBorderStyle.Dotted;
            appearance12.BackColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.Override.CardAreaAppearance = appearance12;
            appearance13.BorderColor = System.Drawing.Color.Silver;
            appearance13.TextTrimming = Infragistics.Win.TextTrimming.EllipsisCharacter;
            this.uniGrid1.DisplayLayout.Override.CellAppearance = appearance13;
            this.uniGrid1.DisplayLayout.Override.CellClickAction = Infragistics.Win.UltraWinGrid.CellClickAction.CellSelect;
            this.uniGrid1.DisplayLayout.Override.CellPadding = 0;
            appearance14.BackColor = System.Drawing.SystemColors.Control;
            appearance14.BackColor2 = System.Drawing.SystemColors.ControlDark;
            appearance14.BackGradientAlignment = Infragistics.Win.GradientAlignment.Element;
            appearance14.BackGradientStyle = Infragistics.Win.GradientStyle.Horizontal;
            appearance14.BorderColor = System.Drawing.SystemColors.Window;
            this.uniGrid1.DisplayLayout.Override.GroupByRowAppearance = appearance14;
            appearance15.TextHAlignAsString = "Left";
            this.uniGrid1.DisplayLayout.Override.HeaderAppearance = appearance15;
            this.uniGrid1.DisplayLayout.Override.HeaderClickAction = Infragistics.Win.UltraWinGrid.HeaderClickAction.SortMulti;
            this.uniGrid1.DisplayLayout.Override.HeaderStyle = Infragistics.Win.HeaderStyle.WindowsXPCommand;
            appearance16.BackColor = System.Drawing.SystemColors.Window;
            appearance16.BorderColor = System.Drawing.Color.Silver;
            this.uniGrid1.DisplayLayout.Override.RowAppearance = appearance16;
            this.uniGrid1.DisplayLayout.Override.RowSelectors = Infragistics.Win.DefaultableBoolean.False;
            appearance17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.uniGrid1.DisplayLayout.Override.TemplateAddRowAppearance = appearance17;
            this.uniGrid1.DisplayLayout.ScrollBounds = Infragistics.Win.UltraWinGrid.ScrollBounds.ScrollToFill;
            this.uniGrid1.DisplayLayout.ScrollStyle = Infragistics.Win.UltraWinGrid.ScrollStyle.Immediate;
            this.uniGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uniGrid1.EnableContextMenu = true;
            this.uniGrid1.EnableGridInfoContextMenu = true;
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
            this.uniGrid1.Size = new System.Drawing.Size(979, 611);
            this.uniGrid1.StyleSetName = "Default";
            this.uniGrid1.TabIndex = 1;
            this.uniGrid1.Text = "uniGrid1";
            this.uniGrid1.UseDynamicFormat = false;
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
            this.popTracking.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox_Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uniTextBox_Code)).EndInit();
            this.uniTBL_MainReference.ResumeLayout(false);
            this.uniTBL_MainData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.uniGrid1)).EndInit();
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
        private uniERP.AppFramework.UI.Controls.uniOpenPopup popItemCd;
        private uniERP.AppFramework.UI.Controls.uniTableLayoutPanel uniTableLayoutPanel2;
		private uniERP.AppFramework.UI.Controls.uniLabel lblBChange;
        private uniERP.AppFramework.UI.Controls.uniLabel uniLabel22;
        private uniERP.AppFramework.UI.Controls.uniOpenPopup popTracking;
        private uniERP.AppFramework.UI.Controls.uniTextBox uniTextBox_Name;
        private uniERP.AppFramework.UI.Controls.uniTextBox uniTextBox_Code;

	}
}
