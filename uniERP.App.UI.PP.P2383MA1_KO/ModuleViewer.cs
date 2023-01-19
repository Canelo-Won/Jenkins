#region ● Namespace declaration

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Web.Services.Protocols;

using Microsoft.Practices.CompositeUI.SmartParts;

using Infragistics.Shared;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;

using uniERP.AppFramework.UI.Common;
using uniERP.AppFramework.UI.Controls;
using uniERP.AppFramework.UI.Module;
using uniERP.AppFramework.UI.Variables;
using uniERP.AppFramework.UI.Common.Exceptions;
using uniERP.AppFramework.DataBridge;

#endregion

namespace uniERP.App.UI.PP.P2383MA1_KO611
{
	[SmartPart]
	public partial class ModuleViewer : ViewBase
	{

		#region ▶ 1. Declaration part

		#region ■ 1.1 Program information
		/// <TemplateVersion>0.0.1.0</TemplateVersion>
		/// <NameSpace>①namespace</NameSpace>
		/// <Module>②module name</Module>
		/// <Class>③class name</Class>
		/// <Desc>④
		///   This part describe the summary information about class 
		/// </Desc>
		/// <History>⑤
		///   <FirstCreated>
		///     <history name="creator" Date="created date">Make …</history>
		///   </FirstCreated>
		///   <Lastmodified>
		///     <history name="modifier"  Date="modified date"> contents </history>
		///     <history name="modifier"  Date="modified date"> contents </history>
		///     <history name="modifier"  Date="modified date"> contents </history>
		///   </Lastmodified>
		/// </History>
		/// <Remarks>⑥
		///   <remark name="modifier"  Date="modified date">… </remark>
		///   <remark name="modifier"  Date="modified date">… </remark>
		/// </Remarks>

		#endregion

		#region ■ 1.2. Class global constants (common)

		#endregion

		#region ■ 1.3. Class global variables (common)

		// change your code
		private tdsP2383MA1_KO611 cqtdsP2383MA1_KO611 = new tdsP2383MA1_KO611();
        //private bool blQueryFlg = false;
        private string hBomHistoryFlg = string.Empty;
		#endregion

		#region ■ 1.4 Class global constants (grid)

		#endregion

		#region ■ 1.5 Class global variables (grid)

		#endregion

		#endregion

		#region ▶ 2. Initialization part

		#region ■ 2.1 Constructor(common)

		public ModuleViewer()
		{
			InitializeComponent();
		}

		#endregion

		#region ■ 2.2 Form_Load(common)

		protected override void Form_Load()
		{
			uniBase.UData.SetWorkingDataSet(this.cqtdsP2383MA1_KO611);
			uniBase.UCommon.SetViewType(enumDef.ViewType.T03_SingleMulti);

			uniBase.UCommon.LoadInfTB19029(enumDef.FormType.Query, enumDef.ModuleInformation.Common);
			this.LoadCustomInfTB19029();
                                      
		}

		protected override void Form_Load_Completed()
		{
            uniBase.UCommon.SetToolBarMultiAll(false);
            uniBase.UCommon.SetToolBarSingleAll(false);
            //uniBase.UCommon.SetToolBarSingle(enumDef.ToolBitSingle.New, true);
            //uniBase.UCommon.SetToolBarCommon(enumDef.ToolBitCommon.Save, true);
            //uniBase.UCommon.SetToolBarMulti(enumDef.ToolBitMulti.Cancel, true);
            //uniBase.UCommon.SetToolBarMulti(enumDef.ToolBitMulti.DeleteRow, true);
            //uniBase.UCommon.SetToolBarMulti(enumDef.ToolBitMulti.InsertRow, true);

            popPlantCd.CodeValue = CommonVariable.gPlant;
            popPlantCd.CodeName = CommonVariable.gPlantNm;

		}

		#endregion

		#region ■ 2.3 Initializatize local global variables

		protected override void InitLocalVariables()
		{
			// init OperationMode is Create Mode
		}

		#endregion

		#region ■ 2.4 Set local global default variables

		protected override void SetLocalDefaultValue()
		{
			// init Dataset 1 Row  : change your code
			//dsAnyName.TableName.Rows.Add(dsAnyName.TableName.NewTableNameRow());

			// TO-DO: Assign default value to controls
            popPlantCd.CodeValue = CommonVariable.gPlant;
            popPlantCd.CodeName = CommonVariable.gPlantNm;
			return;
		}

		#endregion

		#region ■ 2.5 Gathering combo data(GatheringComboData)

		protected override void GatheringComboData()
		{
			// Example: Set ComboBox List (Column Name, Select, From, Where)
			//uniBase.UData.ComboMajorAdd("Charge", "M2201");
            //uniBase.UData.ComboMajorAdd("EXC_SPEC", "XP013"); //펌웨어스펙
            //uniBase.UData.ComboMajorAdd("Font_Type", "XP017"); //펌웨어스펙

		}
		#endregion

		#region ■ 2.6 Define user defined numeric info

		public void LoadCustomInfTB19029()
		{
			#region User Define Numeric Format Data Setting  ☆
			base.viewTB19029.ggUserDefined6.DecPoint = 0;
			base.viewTB19029.ggUserDefined6.Integeral = 3;
			base.viewTB19029.ggUserDefined7.DecPoint = 2;
			base.viewTB19029.ggUserDefined7.Integeral = 2;
			base.viewTB19029.ggUserDefined8.DecPoint = 6;
			base.viewTB19029.ggUserDefined8.Integeral = 11;
			#endregion
		}

		#endregion

		#endregion

		#region ▶ 3. Grid method part

		#region ■ 3.1 Initialize Grid (InitSpreadSheet)

		private void InitSpreadSheet()
		{
			#region ■■ 3.1.1 Pre-setting grid information
			tdsP2383MA1_KO611.OPTION_LISTDataTable uniGridTB1 = this.cqtdsP2383MA1_KO611.OPTION_LIST;

            //CheckEditorDataFilter datafilter = new CheckEditorDataFilter("1", "0");

            this.uniGrid1.SSSetEdit(uniGridTB1.plant_cdColumn.ColumnName, "공장", 120, enumDef.FieldType.Primary, enumDef.CharCase.Default, false, enumDef.HAlign.Left, int.MaxValue);
            this.uniGrid1.SSSetEdit(uniGridTB1.item_grp1Column.ColumnName, "대분류", 120, enumDef.FieldType.Default, enumDef.CharCase.Default, false, enumDef.HAlign.Left, int.MaxValue);
            this.uniGrid1.SSSetEdit(uniGridTB1.item_grp1_nmColumn.ColumnName, "대분류명", 200, enumDef.FieldType.Default, enumDef.CharCase.Default, false, enumDef.HAlign.Left, int.MaxValue);
            this.uniGrid1.SSSetEdit(uniGridTB1.item_grp2Column.ColumnName, "중분류", 120, enumDef.FieldType.Default, enumDef.CharCase.Default, false, enumDef.HAlign.Left, int.MaxValue);
            this.uniGrid1.SSSetEdit(uniGridTB1.item_grp2_nmColumn.ColumnName, "중분류명", 200, enumDef.FieldType.Default, enumDef.CharCase.Default, false, enumDef.HAlign.Left, int.MaxValue);
            this.uniGrid1.SSSetEdit(uniGridTB1.item_grp3Column.ColumnName, "소분류", 120, enumDef.FieldType.Default, enumDef.CharCase.Default, false, enumDef.HAlign.Left, int.MaxValue);
            this.uniGrid1.SSSetEdit(uniGridTB1.item_grp3_nmColumn.ColumnName, "소분류명", 200, enumDef.FieldType.Default, enumDef.CharCase.Default, false, enumDef.HAlign.Left, int.MaxValue);
            this.uniGrid1.SSSetEdit(uniGridTB1.prnt_item_cdColumn.ColumnName, "모품목", 120, enumDef.FieldType.Default, enumDef.CharCase.Default, false, enumDef.HAlign.Left, int.MaxValue);
            this.uniGrid1.SSSetEdit(uniGridTB1.prnt_item_nmColumn.ColumnName, "모품목명", 200, enumDef.FieldType.Default, enumDef.CharCase.Default, false, enumDef.HAlign.Left, int.MaxValue);
            this.uniGrid1.SSSetEdit(uniGridTB1.user_spec_cdColumn.ColumnName, "USER코드", 120, enumDef.FieldType.Default, enumDef.CharCase.Default, false, enumDef.HAlign.Left, int.MaxValue);
            this.uniGrid1.SSSetEdit(uniGridTB1.child_item_cdColumn.ColumnName, "자품목", 120, enumDef.FieldType.Default, enumDef.CharCase.Default, false, enumDef.HAlign.Left, int.MaxValue);
            this.uniGrid1.SSSetEdit(uniGridTB1.child_item_nmColumn.ColumnName, "자품목명", 200, enumDef.FieldType.Default, enumDef.CharCase.Default, false, enumDef.HAlign.Left, int.MaxValue);
            this.uniGrid1.SSSetEdit(uniGridTB1.sl_cdColumn.ColumnName, "창고", 120, enumDef.FieldType.Default, enumDef.CharCase.Default, false, enumDef.HAlign.Left, int.MaxValue);
            this.uniGrid1.SSSetFloat(uniGridTB1.prev_good_qtyColumn.ColumnName, "전월재고수량", viewTB19029.ggQty, enumDef.FieldType.Default, enumDef.PosZero.Default); ;
            this.uniGrid1.SSSetFloat(uniGridTB1.good_on_hand_qtyColumn.ColumnName, "당월재고수량", viewTB19029.ggQty, enumDef.FieldType.Default, enumDef.PosZero.Default); ;
      

     
            
			
			
			#endregion

			#region ■■ 3.1.2 Formatting grid information
			uniGrid1.flagInformation("cud_char", "row_num");

			this.uniGrid1.InitializeGrid(enumDef.IsOutlookGroupBy.No, enumDef.IsSearch.No);
			#endregion

			#region ■■ 3.1.3 Setting etc grid

			// Hidden Column Setting
			#endregion
		}
		#endregion

		#region ■ 3.2 InitData

		private void InitData()
		{
			// TO-DO: 컨트롤을 초기화(또는 초기값)할때 할일 
			// SetDefaultVal과의 차이점은 전자는 Form_Load 시점에 콘트롤에 초기값을 세팅하는것이고
			// 후자는 특정 시점(조회후 또는 행추가후 등 특정이벤트)에서 초기값을 셋팅한다.
            popPlantCd.CodeValue = CommonVariable.gPlant;
            popPlantCd.CodeName = CommonVariable.gPlantNm;
		}

		#endregion

		#region ■ 3.3 SetSpreadColor

		private void SetSpreadColor(int pvStartRow, int pvEndRow)
		{
			// TO-DO: InsertRow후 그리드 컬러 변경
			//uniGrid1.SSSetProtected(gridCol.LastNum, pvStartRow, pvEndRow);
		}
		#endregion

		#region ■ 3.4 InitControlBinding
		protected override void InitControlBinding()
		{


			InitSpreadSheet();
			uniGrid1.uniGridSetDataBinding(cqtdsP2383MA1_KO611.OPTION_LIST);

            //tdsP2383MA1_KO611.OPTION_LISTDataTable uniTB1 = this.cqtdsP2383MA1_KO611.OPTION_LIST;
            //this.uniGrid1.SSSetSplit(uniTB1.checkedColumn.ColumnName);
            //this.uniGrid1.SSSetSplit(uniTB1.prnt_item_cdColumn.ColumnName);
            //uniBase.UData.addDataBinding(this.dtValidFromDt, uniTB1.valid_from_dtColumn);
		}
		#endregion

		#endregion

		#region ▶ 4. Toolbar method part

		#region ■ 4.1 Common Fnction group

		#region ■■ 4.1.1 OnFncQuery(old:FncQuery)

		protected override bool OnFncQuery()
		{
			return DBQuery();
		}

		#endregion

		#region ■■ 4.1.2 OnFncSave(old:FncSave)
		protected override bool OnFncSave()
		{
			//TO-DO : code business oriented logic
			return DBSave();
		}
		#endregion

		#endregion

		#region ■ 4.2 Single Fnction group

		#region ■■ 4.2.1 OnFncNew(old:FncNew)

		protected override bool OnFncNew()
		{
			//TO-DO : code business oriented logic
            cqtdsP2383MA1_KO611.OPTION_LIST.plant_cdColumn.DefaultValue = popPlantCd.CodeValue.Trim();
            SetLocalDefaultValue();
			return true;
		}

		#endregion

		#region ■■ 4.2.2 OnFncDelete(old:FncDelete)

		protected override bool OnFncDelete()
		{
			//TO-DO : code business oriented logic
			return true;
		}

		#endregion

		#region ■■ 4.2.3 OnFncCopy(old:FncCopy)

		protected override bool OnFncCopy()
		{
			//TO-DO : code business oriented logic
			return true;
		}

		#endregion

		#region ■■ 4.2.4 OnFncFirst(No implementation)

		#endregion

		#region ■■ 4.2.5 OnFncPrev(old:FncPrev)

		protected override bool OnFncPrev()
		{
			//TO-DO : code business oriented logic
			return true;
		}

		#endregion

		#region ■■ 4.2.6 OnFncNext(old:FncNext)

		protected override bool OnFncNext()
		{
			//TO-DO : code business oriented logic
			return true;
		}

		#endregion

		#region ■■ 4.2.7 OnFncLast(No implementation)

		#endregion

		#endregion

		#region ■ 4.3 Grid Fnction group

		#region ■■ 4.3.1 OnFncInsertRow(old:FncInsertRow)
		protected override bool OnFncInsertRow()
		{
			//TO-DO : code business oriented logic
			return true;
		}
		#endregion

		#region ■■ 4.3.2 OnFncDeleteRow(old:FncDeleteRow)
		protected override bool OnFncDeleteRow()
		{
			//TO-DO : code business oriented logic
			return true;
		}
		#endregion

		#region ■■ 4.3.3 OnFncCancel(old:FncCancel)
		protected override bool OnFncCancel()
		{
			//TO-DO : code business oriented logic
			return true;
		}
		#endregion

		#region ■■ 4.3.4 OnFncCopyRow(old:FncCopy)
		protected override bool OnFncCopyRow()
		{
			//TO-DO : code business oriented logic
			return true;
		}
		#endregion

		#endregion

		#region ■ 4.4 Db function group

		#region ■■ 4.4.1 DBQuery(Common)

		private bool DBQuery()
		{
            
            cqtdsP2383MA1_KO611.OPTION_LIST.Clear();
            string strPlantCd = string.Empty;
            string strItemGrp1 = string.Empty;
            string strItemGrp2 = string.Empty;
            string strItemGrp3 = string.Empty;
            string strItemCd = string.Empty;
            string strTrackingNo = string.Empty;
            string strChildItemCd = string.Empty;

            if (!uniBase.UCommon.CheckRequiredFields(enumDef.PanelType.Condition))
            {
                return false;
            }

            strPlantCd = popPlantCd.CodeValue;
            strItemGrp1 = popItemGrp1.CodeValue;
            strItemGrp2 = popItemGrp2.CodeValue;
            strItemGrp3 = popItemGrp3.CodeValue;
            strItemCd = popItemCd.CodeValue;
            strTrackingNo = popTrackingNo.CodeValue;
            strChildItemCd = popChildItemCd.CodeValue;

            cqtdsP2383MA1_KO611.OPTION_LIST.Clear();

            try
            {
                // (저장PGM)간단한 sql은 여기서 바로 sql문으로 호출하도록 한다.(복잡할 경우 sp사용하여도 무방하며 개발자가 판단하도록 한다.)
                // (조회PGM)sp를 이용한 조회.
                //cqtdsQCUD.IE_DATA.Clear();
                //cqtdsQCUD.IE_DATA_DTL.Clear();

                string strQuery = string.Format(@"
                        exec dbo.USP_P2383MA1_QUERY_KO611 {0}, {1}, {2}, {3}, {4}, {5}, {6}"
                        , uniBase.UCommon.FilterVariable(strPlantCd, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true)
                        , uniBase.UCommon.FilterVariable(strItemGrp1, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true)
                        , uniBase.UCommon.FilterVariable(strItemGrp2, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true)
                        , uniBase.UCommon.FilterVariable(strItemGrp3, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true)
                        , uniBase.UCommon.FilterVariable(strItemCd, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true)
                        , uniBase.UCommon.FilterVariable(strTrackingNo, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true)
                        , uniBase.UCommon.FilterVariable(strChildItemCd, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true)
                        );
                DataSet dsQuery = uniBase.UDataAccess.CommonQuerySQL(strQuery);

                if (dsQuery == null || dsQuery.Tables.Count == 0 || dsQuery.Tables[0].Rows.Count == 0)
                {
                    cqtdsP2383MA1_KO611.OPTION_LIST.Clear();
                    return true;
                }

                cqtdsP2383MA1_KO611.OPTION_LIST.Merge(dsQuery.Tables[0], false, MissingSchemaAction.Ignore);
                for (int i = 0; i < uniGrid1.Rows.Count; i++)
                {
                    //if (uniGrid1.Rows[i].Cells["loc"].Value.ToString() != "")
                    //    uniGrid1.SpreadLock("checked", i, i);
                }
                uniBase.UCommon.SetToolBarCommon(enumDef.ToolBitCommon.Save, true);
                return true;
            }
            catch (Exception ex)
            {
                bool reThrow = uniBase.UExceptionController.AutoProcessException(ex);
                if (reThrow)
                    throw;
                return false;
            }

			//return true;
		}
		#endregion

		#region ■■ 4.4.2 DBDelete(Single)

		private bool DBDelete()
		{
			try
			{
				//wsMyBizFL.Service wsDelete = new wsMyBizFL.Service();
				//wsDelete.DeleteWebMethod(CommonVariable.gStrGlobalCollection, dsAnyName);
			}
			catch (Exception ex)
			{
				bool reThrow = ExceptionControler.AutoProcessException(ex);
				if (reThrow)
					throw;
				return false;
			}

			return true;
		}

		#endregion

		#region ■■ 4.4.3 DBSave(Common)

        private bool DBSave()
        {

         


            return true;

        }

		#endregion

		#endregion

		#endregion

		#region ▶ 5. Event method part

		#region ■ 5.1 Single control event implementation group

		#endregion

		#region ■ 5.2 Grid   control event implementation group

		#region ▶ Click >>> AfterCellActivate | AfterRowActivate | AfterSelectChange
		/// <summary>
		/// 기존의 Context메뉴를 보여주기 위해 fpSpread의 MouseDown이벤트와 Click이벤트에서 처리하던 일련의 코드들은
		/// UltraGrid에서는 MouseDown이벤트에서 처리합니다.
		/// fpSpread의 Click이벤트는 UltraGrid의 
		/// AfterCellActivate | AfterRowActivate | AfterSelectChange 이벤트로 변경 하실 수 있습니다.
		/// AfterCellActivate   : isSearch=No (에디터모드)에서 CellSelect모드에서 한 Cell을 클릭했을때 발생하는 이벤트입니다.
		/// AfterRowActivate    : isSearch=Yes (조회전용모드)에서 RowSelect모드에서 한 Row를 클릭했을때 발생하는 이벤트입니다.
		/// AfterSelectChange   : 셀또는 Row를 하나 이상 선택시 발생하는 이벤트입니다.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void uniGrid1_AfterSelectChange(object sender, AfterSelectChangeEventArgs e)
		{
			Debug.WriteLine("AfterSelectChange Event Fired");

			// Check the type to find out whether rows, columns or cells were selected.
			// 그리드가 읽기 전용 일경우는 e.Type은 UltraGridRow이며
			// 그렇지 않을 경우는 e.Type은 UltraGridCell을 반환합니다.
			if (typeof(UltraGridGroupByRow) == e.Type)
			{
				// The activeRow can be a group-by row 
				// Item type is a group-by-row so use Rows property off the Selected to access those items. 
				if (this.uniGrid1.Selected.Rows.Count == 0)
					Debug.WriteLine("No group-by rows selected.");
				else
				{
					Debug.WriteLine(this.uniGrid1.Selected.Rows.Count + " group-by rows selected.");
					Debug.WriteLine("Group by row activated. Description : " + uniGrid1.ActiveRow.Description);
				}
			}
			else if (typeof(UltraGridRow) == e.Type)
			{
				// Item type is a row so use Rows property off the Selected to access those items. 
				if (this.uniGrid1.Selected.Rows.Count == 0)
					Debug.WriteLine("No rows selected.");
				else
				{
					Debug.WriteLine(this.uniGrid1.Selected.Rows.Count + " rows selected.");
					Debug.WriteLine(uniGrid1.ActiveRow.Index.ToString());
					Debug.WriteLine(uniGrid1.ActiveRow.ListIndex.ToString());
					// 참고 : 특정컬럼을 기준으로 그룹화 되었을 경우
					// ActiveRow.Index와 ActiveRow.ListIndex는 서로 다른 값을 반환합니다.
					// uniGrid1.ActiveRow = uniGrid1.Rows.GetRowWithListIndex(5);
				}
			}
			else if (typeof(UltraGridColumn) == e.Type)
			{
				// Item type is a column so use Columns property off the Selected to access those items. 
				if (this.uniGrid1.Selected.Columns.Count == 0)
					Debug.WriteLine("Columns are being unselected.");
				else
					Debug.WriteLine(this.uniGrid1.Selected.Columns.Count + " columns are being selected.");
			}
			else if (typeof(UltraGridCell) == e.Type)
			{
				// Item type is a cell so use Cells property off the Selected to access those items. 
				if (this.uniGrid1.Selected.Cells.Count == 0)
					Debug.WriteLine("Columns are being unselected.");
				else
				{
					Debug.WriteLine(this.uniGrid1.Selected.Cells.Count + " cells are being selected.");
					Debug.WriteLine("Index of the new active row is  " + this.uniGrid1.ActiveCell.Row.Index.ToString());
					Debug.WriteLine("Key of the new active col is  " + this.uniGrid1.ActiveCell.Column.Key.ToString());
				}
			}
		}

		private void uniGrid1_AfterCellActivate(object sender, EventArgs e)
		{
			Debug.WriteLine("AfterCellActivate Event Fired");
			Debug.WriteLine("Index of the new active row is  " + uniGrid1.ActiveCell.Row.Index.ToString());
			Debug.WriteLine("Key of the new active col is  " + uniGrid1.ActiveCell.Column.Key.ToString());
		}

		private void uniGrid1_AfterRowActivate(object sender, EventArgs e)
		{
			Debug.WriteLine("AfterRowActivate Event Fired");
			Debug.WriteLine("Index of the new active row is  " + uniGrid1.ActiveRow.Index.ToString());
		}
		#endregion ▶ Click >>> AfterSelectChange

		#region ▶ DblClick >>> DoubleClickCell
		/// <summary>
		/// fpSpread의 DblClick이벤트는 UltraGrid의 DoubleClickCell이벤트로 변경 하실 수 있습니다.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void uniGrid1_DoubleClickCell(object sender, DoubleClickCellEventArgs e)
		{
			Debug.WriteLine("DoubleClickCell Event Fired");
			Debug.WriteLine("Index of the new active row is  " + e.Cell.Row.Index.ToString());
			Debug.WriteLine("Key of the new active col is  " + e.Cell.Column.Key);
		}
		#endregion ▶ DblClick >>> DoubleClickCell

		#region ▶ MouseDown >>> MouseDown
		/// <summary>
		/// 마우스 우측 버튼 클릭시 Context메뉴를 보여주는 일련의 작업들을 이 이벤트에서 수행합니다.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void uniGrid1_MouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Right)
				return;

			UltraGrid grid = (UltraGrid)sender;
			UIElement element = grid.DisplayLayout.UIElement.ElementFromPoint(new Point(e.X, e.Y));
			UltraGridCell cell = element.GetContext(typeof(UltraGridCell)) as UltraGridCell;

			if (cell != null)
			{
				Debug.WriteLine("MouseDown Event Fired");
				Debug.WriteLine("Index of the right mouse click row is  " + cell.Row.Index.ToString());
				Debug.WriteLine("Key of the right mouse click col is  " + cell.Column.Key);

				// 컨텍스트 메뉴를 보여주기 위한 코드 작성 시작
				//SetPopUpMenuItemInf("1101111111")
				// 컨텍스트 메뉴를 보여주기 위한 코드 작성 끝
			}
		}
		#endregion ▶ MouseDown >>> MouseDown

		#region ▶ ScriptLeaveCell >>> BeforeCellDeactivate
		/// <summary>
		/// fpSpread의 ScripLeaveCell 이벤트는 UltraGrid의 
		/// BeforeCellDeactivate 이벤트와 AfterCellActivate 이벤트를 겸해서 사용합니다.
		/// BeforeCellDeactivate    : 기존Cell에서 새로운 Cell로 이동하기 전에 기존Cell위치에서 처리 할 일련의 작업들을 기술합니다.
		/// AfterCellActivate       : 새로운 Cell로 이동해서 처리할 일련의 작업들을 기술합니다.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void uniGrid1_BeforeCellDeactivate(object sender, CancelEventArgs e)
		{
			Debug.WriteLine("Before Cell Row is  " + uniGrid1.ActiveCell.Row.Index.ToString());
			Debug.WriteLine("Before Cell Col is  " + uniGrid1.ActiveCell.Column.Key.ToString());

			// 새로운 Cell로 이동하기전에 기존 Cell에서 처리할 작업들 수행 코드 시작

			// Validation 체크해서 새로운 Cell로 이동하는 것을 취소
			// e.Cancel = true;

			// 새로운 Cell로 이동하기전에 기존 Cell에서 처리할 작업들 수행 코드 종료



			// 새로운 Cell에 대한 작업은 AfterCellActivate 이벤트에서 처리합니다.
		}
		#endregion ▶ ScriptLeaveCell >>> BeforeCellDeactivate

		#region ▶ ButtonClicked >>> ClickCellButton
		/// <summary>
		/// Cell 내의 버튼을 클릭했을때의 일련작업들을 수행합니다.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void uniGrid1_ClickCellButton(object sender, CellEventArgs e)
		{
			Debug.WriteLine("ClickCellButton Event Fired");
			Debug.WriteLine("Index of the new active row is  " + e.Cell.Row.Index.ToString());
			Debug.WriteLine("Key of the new active col is  " + e.Cell.Column.Key);

			// 버튼클릭 시 수행 할 코드 작성 시작
			//switch (e.Cell.Column.Key)
			//{
			//    case "C_AcctPopUp":
			//        OpenPopUp(e.Cell.Row.Cells["AAA"].Value);
			//        break;
			//    case "C_deptPopup":
			//        OpenPopUp(e.Cell.Row.Cells["BBB"].Value);
			//        break;
			//    case "C_DocCurPopup":
			//        OpenPopUp(e.Cell.Row.Cells["CCC"].Value);
			//        break;
			//    default:
			//}
			// 버튼클릭 시 수행 할 코드 작성 끝
		}
		#endregion ▶ ButtonClicked >>> ClickCellButton

		#region ▶ ComboSelChange >>> CellListSelect
		/// <summary>
		/// Cell 내의 콤보박스의 Item을 선택 변경했을때 이벤트가 발생합니다.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void uniGrid1_CellListSelect(object sender, CellEventArgs e)
		{
			if (null != e.Cell.Column.ValueList)
			{
				int itemIndex = e.Cell.Column.ValueList.SelectedItemIndex;
				Debug.WriteLine("Selected Item Index = " + itemIndex);
				Debug.WriteLine("Selected Item Value = " + e.Cell.Column.ValueList.GetValue(itemIndex).ToString());
				Debug.WriteLine("Selected Item Text = " + e.Cell.Column.ValueList.GetText(itemIndex).ToString());
				Debug.WriteLine("Index of the new active row is  " + e.Cell.Row.Index.ToString());
				Debug.WriteLine("Key of the new active col is  " + e.Cell.Column.Key);

				//switch (e.Cell.Column.Key)
				//{
				//    case "AAA":
				//        break;
				//    case "BBB":
				//        break;
				//    case "CCC":
				//        break;
				//    default:
				//        break;
				//}
			}
		}
		#endregion ▶ ComboSelChange >>> CellListSelect

		#region ▶ Change >>> CellChange
		/// <summary>
		/// fpSpread의 Change 이벤트는 UltraGrid의 BeforeExitEditMode 또는 AfterExitEditMode 이벤트로 대체됩니다.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void uniGrid1_BeforeExitEditMode(object sender, Infragistics.Win.UltraWinGrid.BeforeExitEditModeEventArgs e)
		{
			// If the user is canceling the modifications (for example by hitting Escape  
			// key, then just return because the cell will revert to its original value 
			// in this case and not commit the user‘s input. 
			if (e.CancellingEditOperation)
				return;

			switch (uniGrid1.ActiveCell.Column.Key)
			{
				case "AAA":
					break;
				case "BBB":
					break;
				case "CCC":
					break;
				default:
					break;
			}
		}

		private void uniGrid1_AfterExitEditMode(object sender, EventArgs e)
		{

		}
		#endregion ▶ Change >>> CellChange

        private void uniGrid1_HeaderCheckBoxClick(object sender, EventArgs e)
        {

            tdsP2383MA1_KO611.OPTION_LISTDataTable uniGridTB1 = this.cqtdsP2383MA1_KO611.OPTION_LIST;
            for (int i = 0, count = cqtdsP2383MA1_KO611.OPTION_LIST.Rows.Count; i < count; i++)
            {
            //    if (uniGrid1.Rows[i].Cells[uniGridTB1.checkedColumn.ColumnName].Value.ToString() == "0")
            //    {
            //        uniGrid1.editUndo(i, i);

            //        uniGrid1.SpreadLock(uniGridTB1.child_item_cdColumn.ColumnName, i, i);
            //        uniGrid1.SpreadLock(uniGridTB1.child_item_qtyColumn.ColumnName, i, i);
                   
            //    }
            //    else
            //    {
            //        if (uniGrid1.Rows[i].Cells[uniGridTB1.checkedColumn.ColumnName].Value.ToString() == "1")
            //        {
            //            uniGrid1.SpreadUnLock(uniGridTB1.child_item_qtyColumn.ColumnName, i, i);
            //            uniGrid1.SSSetRequired(uniGridTB1.child_item_qtyColumn.ColumnName, i, i);
            //        }
            //    }
            }
        }


		#endregion

		#region ■ 5.3 TAB    control event implementation group
		#endregion

		#endregion

		#region ▶ 6. Popup method part

		#region ■ 6.1 Common popup implementation group

		private void popPlantCd_BeforePopupOpen(object sender, uniERP.AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
		{
			e.PopupPassData.PopupWinTitle = "Plant Popup";
			e.PopupPassData.ConditionCaption = "Plant";

			e.PopupPassData.SQLFromStatements = "B_PLANT (nolock) ";
			e.PopupPassData.SQLWhereStatements = "";
			e.PopupPassData.SQLWhereInputCodeValue = this.popPlantCd.CodeValue.Trim();
			e.PopupPassData.SQLWhereInputNameValue = "";
			e.PopupPassData.DistinctOrNot = false;

			e.PopupPassData.GridCellCode = new String[2];
			e.PopupPassData.GridCellCaption = new String[2];
			e.PopupPassData.GridCellType = new enumDef.GridCellType[2];

			e.PopupPassData.GridCellCode[0] = "PLANT_CD";
			e.PopupPassData.GridCellCode[1] = "PLANT_NM";


			e.PopupPassData.GridCellCaption[0] = "Plant";
			e.PopupPassData.GridCellCaption[1] = "Plant Name";


			e.PopupPassData.GridCellType[0] = enumDef.GridCellType.Edit;
			e.PopupPassData.GridCellType[1] = enumDef.GridCellType.Edit;

			//New Add
			e.PopupPassData.PopupWinHeight = 450;
			e.PopupPassData.PopupWinWidth = 420;

			e.PopupPassData.GridCellLength = new Int32[2];
			e.PopupPassData.GridCellLength[0] = 100;
			e.PopupPassData.GridCellLength[1] = 200;

		}


		private void popPlantCd_AfterPopupClosed(object sender, uniERP.AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
		{
			DataSet iDataSet = new DataSet();

			if (e.ResultData.Data == null)
				return;

			iDataSet = (DataSet)e.ResultData.Data;

			this.popPlantCd.CodeValue = iDataSet.Tables[0].Rows[0]["PLANT_CD"].ToString();
			this.popPlantCd.CodeName = iDataSet.Tables[0].Rows[0]["PLANT_NM"].ToString();
		}

		#endregion

		#region ■ 6.2 User-defined popup implementation group

		private void popItemCd_BeforePopupOpen(object sender, uniERP.AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
		{
			uniOpenPopup popItemCd = (uniOpenPopup)sender;

            if (!uniBase.UCommon.CheckRequiredField(popPlantCd, enumDef.PanelType.Condition))
			{
				e.Cancel = true;
				return;
			}

			e.PopupPassData.CalledPopupID = "uniERP.App.UI.Popup.B1B11PA4";
			e.PopupPassData.PopupWinTitle = "Component Item Popup";
			e.PopupPassData.PopupWinWidth = 760;
			e.PopupPassData.PopupWinHeight = 420;

			DataSet passDs = new DataSet("PassDs");
			passDs.Tables.Add("table1");
			passDs.Tables["table1"].Columns.Add("PlantCd", System.Type.GetType("System.String"));
			passDs.Tables["table1"].Columns.Add("ItemCd", System.Type.GetType("System.String"));
			passDs.Tables["table1"].Columns.Add("Param3", System.Type.GetType("System.String"));
			passDs.Tables["table1"].Columns.Add("Param4", System.Type.GetType("System.String"));
			passDs.Tables["table1"].Columns.Add("Param5", System.Type.GetType("System.String"));
			passDs.Tables["table1"].Columns.Add("Param6", System.Type.GetType("System.String"));

			DataRow idr = passDs.Tables["table1"].NewRow();
			idr["PlantCd"] = this.popPlantCd.CodeValue.Trim();
			idr["ItemCd"] = popItemCd.CodeValue.Trim();
			idr["Param3"] = "";
			idr["Param4"] = "";
			idr["Param5"] = "";
			idr["Param6"] = "";
			passDs.Tables["table1"].Rows.Add(idr);
			e.PopupPassData.Data = passDs;

		}

		private void popItemCd_AfterPopupClosed(object sender, uniERP.AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
		{
			uniOpenPopup popItemCd = (uniOpenPopup)sender;
			DataSet iDataSet = new DataSet();

			if (e.ResultData.Data == null)
				return;

			iDataSet = (DataSet)e.ResultData.Data;

			popItemCd.CodeValue = iDataSet.Tables[0].Rows[0]["ITEM_CD"].ToString();
			popItemCd.CodeName = iDataSet.Tables[0].Rows[0]["ITEM_NM"].ToString();
		}

		#endregion

        private void uniGrid1_BeforePopupOpen(object sender, uniERP.AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
        { //why
            //int ActiveRIndex = uniGrid1.ActiveRow.Index;
            //if (uniGrid1.ActiveCell != null)
            //{
            //    if (!uniBase.UCommon.CheckRequiredField(popPlantCd, enumDef.PanelType.Condition))
            //    {
            //        e.Cancel = true;
            //        return;
            //    }

                      int ActiveRIndex = uniGrid1.ActiveRow.Index;
            if (uniGrid1.ActiveCell != null)
            {
                DataSet iDataSet = new DataSet();
                switch (uniGrid1.ActiveCell.Column.Key.ToUpper())
                {

                    case "ITEM_CD":

                        e.PopupPassData.CalledPopupID = "uniERP.App.UI.Popup.B1B11PA4";
                        e.PopupPassData.PopupWinTitle = "Component Item Popup";
                        e.PopupPassData.PopupWinWidth = 760;
                        e.PopupPassData.PopupWinHeight = 420;

                        DataSet passDs = new DataSet("PassDs");
                        passDs.Tables.Add("table1");
                        passDs.Tables["table1"].Columns.Add("PlantCd", System.Type.GetType("System.String"));
                        passDs.Tables["table1"].Columns.Add("ItemCd", System.Type.GetType("System.String"));
                        passDs.Tables["table1"].Columns.Add("Param3", System.Type.GetType("System.String"));
                        passDs.Tables["table1"].Columns.Add("Param4", System.Type.GetType("System.String"));
                        passDs.Tables["table1"].Columns.Add("Param5", System.Type.GetType("System.String"));
                        passDs.Tables["table1"].Columns.Add("Param6", System.Type.GetType("System.String"));

                        DataRow idr = passDs.Tables["table1"].NewRow();
                        idr["PlantCd"] = this.popPlantCd.CodeValue.Trim();
                        idr["ItemCd"] = popItemGrp1.CodeValue.Trim();
                        idr["Param3"] = "";
                        idr["Param4"] = "";
                        idr["Param5"] = "";
                        idr["Param6"] = "";
                        passDs.Tables["table1"].Rows.Add(idr);
                        e.PopupPassData.Data = passDs;
                        break;

                    case "CHILD_ITEM_CD":

                        e.PopupPassData.CalledPopupID = "uniERP.App.UI.Popup.B1B11PA4";
                        e.PopupPassData.PopupWinTitle = "Component Item Popup";
                        e.PopupPassData.PopupWinWidth = 760;
                        e.PopupPassData.PopupWinHeight = 420;

                        DataSet passDs1 = new DataSet("PassDs");
                        passDs1.Tables.Add("table1");
                        passDs1.Tables["table1"].Columns.Add("PlantCd", System.Type.GetType("System.String"));
                        passDs1.Tables["table1"].Columns.Add("ItemCd", System.Type.GetType("System.String"));
                        passDs1.Tables["table1"].Columns.Add("Param3", System.Type.GetType("System.String"));
                        passDs1.Tables["table1"].Columns.Add("Param4", System.Type.GetType("System.String"));
                        passDs1.Tables["table1"].Columns.Add("Param5", System.Type.GetType("System.String"));
                        passDs1.Tables["table1"].Columns.Add("Param6", System.Type.GetType("System.String"));

                        DataRow idr1 = passDs1.Tables["table1"].NewRow();
                        idr1["PlantCd"] = this.popPlantCd.CodeValue.Trim();
                        idr1["ItemCd"] = popItemGrp1.CodeValue.Trim();
                        idr1["Param3"] = "";
                        idr1["Param4"] = "";
                        idr1["Param5"] = "";
                        idr1["Param6"] = "";
                        passDs1.Tables["table1"].Rows.Add(idr1);
                        e.PopupPassData.Data = passDs1;
                        break;


                    case "USER_SPEC_CD":

                         e.PopupPassData.PopupWinTitle = "USER사양 팝업";
                         e.PopupPassData.ConditionCaption = "USER사양 팝업";

                         e.PopupPassData.SQLFromStatements = "s_so_tracking a, b_item_by_plant b, b_item c, b_item_by_user_ko611 d";
                         e.PopupPassData.SQLWhereStatements = "a.item_cd = b.item_cd and a.sl_cd = b.plant_cd and b.item_cd = c.item_cd and a.tracking_no = d.user_spec_cd and a.item_cd = d.item_cd and a.sl_cd = d.plant_cd ";
                         if(popItemGrp1.CodeValue != "")
                            // e.PopupPassData.SQLWhereStatements += " and a.tracking_no != '*' and a.item_cd = " + uniBase.UCommon.FilterVariable(popItemCd.CodeValue, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true);
                             e.PopupPassData.SQLWhereStatements += " and a.tracking_no != '*' and a.item_cd = " + uniBase.UCommon.FilterVariable(uniGrid1.ActiveRow.Cells["ITEM_CD"].Value, "''", enumDef.FilterVarType.BraceWithSingleQuotation, true);
                         else
                             e.PopupPassData.SQLWhereStatements += " and a.tracking_no != '*' ";
                         //e.PopupPassData.SQLWhereInputCodeValue = popTracking.CodeValue;

                         e.PopupPassData.DistinctOrNot = true;
                         e.PopupPassData.GridCellCode = new String[6];
                         e.PopupPassData.GridCellCaption = new String[6];
                         e.PopupPassData.GridCellType = new enumDef.GridCellType[6];
                         e.PopupPassData.GridCellLength = new Int32[6];

                         e.PopupPassData.GridCellCode[0] = "a.tracking_no";
                         e.PopupPassData.GridCellCode[1] = "a.item_cd";
                         e.PopupPassData.GridCellCode[2] = "c.item_nm";
                         e.PopupPassData.GridCellCode[3] = "c.spec";
                         e.PopupPassData.GridCellCode[4] = "d.buyer_name";
                         e.PopupPassData.GridCellCode[5] = "d.buyer_nation";

                         e.PopupPassData.GridCellCaption[0] = "USER사양";
                         e.PopupPassData.GridCellCaption[1] = "품목";
                         e.PopupPassData.GridCellCaption[2] = "품목명";
                         e.PopupPassData.GridCellCaption[3] = "규격";
                         e.PopupPassData.GridCellCaption[4] = "Buyer";
                         e.PopupPassData.GridCellCaption[5] = "Buyer국가";

                         e.PopupPassData.GridCellType[0] = enumDef.GridCellType.Edit;
                         e.PopupPassData.GridCellType[1] = enumDef.GridCellType.Edit;
                         e.PopupPassData.GridCellType[2] = enumDef.GridCellType.Edit;
                         e.PopupPassData.GridCellType[3] = enumDef.GridCellType.Edit;
                         e.PopupPassData.GridCellType[4] = enumDef.GridCellType.Edit;
                         e.PopupPassData.GridCellType[5] = enumDef.GridCellType.Edit;
                        break;

                }
            }
        }

        private void uniGrid1_AfterPopupClosed(object sender, uniERP.AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
        { 

         
            int ActiveRIndex = uniGrid1.ActiveRow.Index;
            if (uniGrid1.ActiveCell != null)
            {
                DataSet iDataSet = new DataSet();
                switch (uniGrid1.ActiveCell.Column.Key.ToUpper())
                {

                    case "ITEM_CD":
                        //iDataSet = (DataSet)e.ResultData.Data;
                        //if (iDataSet.Tables[0].Rows[0]["PHANTOM_FLG"].ToString() == "Y")
                        //{
                        //    uniBase.UMessage.DisplayMessageBox("189214", MessageBoxButtons.OK, "");
                        //    return;
                        //}
                        //if (iDataSet.Tables[0].Rows[0]["VALID_FLG"].ToString() == "N")
                        //{
                        //    uniBase.UMessage.DisplayMessageBox("122729", MessageBoxButtons.OK, "");
                        //    return;
                        //}
                        //uniGrid1.ActiveRow.Cells[cqtdsP2383MA1_KO611.OPTION_LIST.item_cdColumn.ColumnName].Value = iDataSet.Tables[0].Rows[0]["ITEM_CD"];
                        //uniGrid1.ActiveRow.Cells[cqtdsP2383MA1_KO611.OPTION_LIST.item_nmColumn.ColumnName].Value = iDataSet.Tables[0].Rows[0]["ITEM_NM"];
                        iDataSet = (DataSet)e.ResultData.Data;
                        uniGrid1.ActiveRow.Cells["ITEM_CD"].Value = iDataSet.Tables[0].Rows[0]["ITEM_CD"].ToString();
                        //uniGrid1.ActiveRow.Cells["ITEM_NM"].Value = iDataSet.Tables[0].Rows[0]["ITEM_NM"].ToString();
                        //uniGrid1.ActiveRow.Cells["SPEC"].Value = iDataSet.Tables[0].Rows[0]["SPEC"].ToString();
                        break;

                    case "CHILD_ITEM_CD":

                        iDataSet = (DataSet)e.ResultData.Data;
                        uniGrid1.ActiveRow.Cells["CHILD_ITEM_CD"].Value = iDataSet.Tables[0].Rows[0]["ITEM_CD"].ToString();

                        break;

                    case "USER_SPEC_CD":
                        iDataSet = (DataSet)e.ResultData.Data;
                        uniGrid1.ActiveRow.Cells["USER_SPEC_CD"].Value = iDataSet.Tables[0].Rows[0]["tracking_no"].ToString();

                        break;

                }
            }
        }

		private void uniGrid1_CellChange(object sender, CellEventArgs e)
		{
            tdsP2383MA1_KO611.OPTION_LISTDataTable uniGridTB1 = this.cqtdsP2383MA1_KO611.OPTION_LIST; 
			
		}

		#endregion


		#region ▶ 7. User-defined method part

		#region ■ 7.1 User-defined function group
        private void SetColumnPropery(int iIndex)
        {
            tdsP2383MA1_KO611.OPTION_LISTDataTable uniGridTB1 = this.cqtdsP2383MA1_KO611.OPTION_LIST;
           // uniGrid1.SpreadUnLock(uniGridTB1.child_item_qtyColumn.ColumnName, iIndex, iIndex);
           // uniGrid1.SSSetRequired(uniGridTB1.child_item_qtyColumn.ColumnName, iIndex, iIndex);
           
        }
        private void SetColumnProperyLock(int iIndex)
        {
            tdsP2383MA1_KO611.OPTION_LISTDataTable uniGridTB1 = this.cqtdsP2383MA1_KO611.OPTION_LIST;
         //   uniGrid1.SpreadLock(uniGridTB1.child_item_qtyColumn.ColumnName, iIndex, iIndex);
        }

		#endregion

        private void popTracking_BeforePopupOpen(object sender, uniERP.AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
        {
            e.PopupPassData.PopupWinTitle = "USER사양 팝업";
            e.PopupPassData.ConditionCaption = "USER사양 팝업";

            e.PopupPassData.SQLFromStatements = "s_so_tracking a, b_item_by_plant b, b_item c, b_item_by_user_ko611 d";
            e.PopupPassData.SQLWhereStatements = "a.item_cd = b.item_cd and a.sl_cd = b.plant_cd and b.item_cd = c.item_cd and a.tracking_no = d.user_spec_cd and a.item_cd = d.item_cd and a.sl_cd = d.plant_cd ";
            if (popItemGrp1.CodeValue != "")
                e.PopupPassData.SQLWhereStatements += " and a.tracking_no != '*' ";
            else
                e.PopupPassData.SQLWhereStatements += " and a.tracking_no != '*' ";
            e.PopupPassData.SQLWhereInputCodeValue = popChildItemCd.CodeValue;

            e.PopupPassData.DistinctOrNot = true;
            e.PopupPassData.GridCellCode = new String[6];
            e.PopupPassData.GridCellCaption = new String[6];
            e.PopupPassData.GridCellType = new enumDef.GridCellType[6];
            e.PopupPassData.GridCellLength = new Int32[6];

            e.PopupPassData.GridCellCode[0] = "a.tracking_no";
            e.PopupPassData.GridCellCode[1] = "a.item_cd";
            e.PopupPassData.GridCellCode[2] = "c.item_nm";
            e.PopupPassData.GridCellCode[3] = "c.spec";
            e.PopupPassData.GridCellCode[4] = "d.buyer_name";
            e.PopupPassData.GridCellCode[5] = "d.buyer_nation";

            e.PopupPassData.GridCellCaption[0] = "USER사양";
            e.PopupPassData.GridCellCaption[1] = "품목";
            e.PopupPassData.GridCellCaption[2] = "품목명";
            e.PopupPassData.GridCellCaption[3] = "규격";
            e.PopupPassData.GridCellCaption[4] = "Buyer";
            e.PopupPassData.GridCellCaption[5] = "Buyer국가";

            e.PopupPassData.GridCellType[0] = enumDef.GridCellType.Edit;
            e.PopupPassData.GridCellType[1] = enumDef.GridCellType.Edit;
            e.PopupPassData.GridCellType[2] = enumDef.GridCellType.Edit;
            e.PopupPassData.GridCellType[3] = enumDef.GridCellType.Edit;
            e.PopupPassData.GridCellType[4] = enumDef.GridCellType.Edit;
            e.PopupPassData.GridCellType[5] = enumDef.GridCellType.Edit;
        }
   
       

		#endregion

        private void popTracking_AfterPopupClosed(object sender, uniERP.AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
        {
            DataSet iDataSet = new DataSet();

            if (e.ResultData.Data == null)
                return;

            iDataSet = (DataSet)e.ResultData.Data;

            popChildItemCd.CodeValue = iDataSet.Tables[0].Rows[0]["tracking_no"].ToString();
        }

        private void popItemGroup1_BeforePopupOpen(object sender, uniERP.AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
        {
            e.PopupPassData.PopupWinTitle = "Item Group Popup";
            e.PopupPassData.ConditionCaption = "Item Group";

            e.PopupPassData.SQLFromStatements = "B_ITEM_GROUP(nolock)";
            //e.PopupPassData.SQLWhereStatements = " DEL_FLG = 'N'  AND LEAF_FLG ='Y' AND VALID_TO_DT >= '" + uniBase.UDate.GetDBServerDateTime().ToString(CommonVariable.CDT_YYYY_MM_DD) + "'";
            e.PopupPassData.SQLWhereStatements = " ITEM_GROUP_LEVEL = 1 AND VALID_TO_DT >= '" + uniBase.UDate.GetDBServerDateTime().ToString(CommonVariable.CDT_YYYY_MM_DD) + "'";
            e.PopupPassData.SQLWhereInputCodeValue = popItemGrp1.CodeValue.Trim();
            e.PopupPassData.SQLWhereInputNameValue = "";
            e.PopupPassData.DistinctOrNot = true;

            e.PopupPassData.GridCellCode = new String[2];
            e.PopupPassData.GridCellCaption = new String[2];
            e.PopupPassData.GridCellType = new enumDef.GridCellType[2];

            e.PopupPassData.GridCellCode[0] = "ITEM_GROUP_CD";
            e.PopupPassData.GridCellCode[1] = "ITEM_GROUP_NM";

            e.PopupPassData.GridCellCaption[0] = "Item Group";
            e.PopupPassData.GridCellCaption[1] = "Item Group Desc.";

            e.PopupPassData.GridCellType[0] = enumDef.GridCellType.Edit;
            e.PopupPassData.GridCellType[1] = enumDef.GridCellType.Edit;
        }

        private void popItemGroup1_AfterPopupClosed(object sender, uniERP.AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
        {
            DataSet iDataSet = new DataSet();

            if (e.ResultData.Data == null)
                return;

            iDataSet = (DataSet)e.ResultData.Data;

            popItemGrp1.CodeValue = iDataSet.Tables[0].Rows[0]["ITEM_GROUP_CD"].ToString();
            popItemGrp1.CodeName = iDataSet.Tables[0].Rows[0]["ITEM_GROUP_NM"].ToString();
        }

        private void popItemGroup2_BeforePopupOpen(object sender, uniERP.AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
        {
            e.PopupPassData.PopupWinTitle = "Item Group Popup";
            e.PopupPassData.ConditionCaption = "Item Group";

            e.PopupPassData.SQLFromStatements = "B_ITEM_GROUP(nolock)";
            //e.PopupPassData.SQLWhereStatements = " DEL_FLG = 'N'  AND LEAF_FLG ='Y' AND VALID_TO_DT >= '" + uniBase.UDate.GetDBServerDateTime().ToString(CommonVariable.CDT_YYYY_MM_DD) + "'";
            e.PopupPassData.SQLWhereStatements = " ITEM_GROUP_LEVEL = 2 AND UPPER_ITEM_GROUP_CD = '" + popItemGrp1.CodeValue + "' AND VALID_TO_DT >= '" + uniBase.UDate.GetDBServerDateTime().ToString(CommonVariable.CDT_YYYY_MM_DD) + "'";
            e.PopupPassData.SQLWhereInputCodeValue = popItemGrp2.CodeValue.Trim();
            e.PopupPassData.SQLWhereInputNameValue = "";
            e.PopupPassData.DistinctOrNot = true;

            e.PopupPassData.GridCellCode = new String[2];
            e.PopupPassData.GridCellCaption = new String[2];
            e.PopupPassData.GridCellType = new enumDef.GridCellType[2];

            e.PopupPassData.GridCellCode[0] = "ITEM_GROUP_CD";
            e.PopupPassData.GridCellCode[1] = "ITEM_GROUP_NM";

            e.PopupPassData.GridCellCaption[0] = "Item Group";
            e.PopupPassData.GridCellCaption[1] = "Item Group Desc.";

            e.PopupPassData.GridCellType[0] = enumDef.GridCellType.Edit;
            e.PopupPassData.GridCellType[1] = enumDef.GridCellType.Edit;
        }

        private void popItemGroup2_AfterPopupClosed(object sender, uniERP.AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
        {
            DataSet iDataSet = new DataSet();

            if (e.ResultData.Data == null)
                return;

            iDataSet = (DataSet)e.ResultData.Data;

            popItemGrp2.CodeValue = iDataSet.Tables[0].Rows[0]["ITEM_GROUP_CD"].ToString();
            popItemGrp2.CodeName = iDataSet.Tables[0].Rows[0]["ITEM_GROUP_NM"].ToString();
        }

        private void popItemGroup3_BeforePopupOpen(object sender, uniERP.AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
        {
            e.PopupPassData.PopupWinTitle = "Item Group Popup";
            e.PopupPassData.ConditionCaption = "Item Group";

            e.PopupPassData.SQLFromStatements = "B_ITEM_GROUP(nolock)";
            e.PopupPassData.SQLWhereStatements = " DEL_FLG = 'N'  AND LEAF_FLG ='Y'AND UPPER_ITEM_GROUP_CD = '" + popItemGrp2.CodeValue + "' AND VALID_TO_DT >= '" + uniBase.UDate.GetDBServerDateTime().ToString(CommonVariable.CDT_YYYY_MM_DD) + "'";
            e.PopupPassData.SQLWhereInputCodeValue = popTrackingNo.CodeValue.Trim();
            e.PopupPassData.SQLWhereInputNameValue = "";
            e.PopupPassData.DistinctOrNot = true;

            e.PopupPassData.GridCellCode = new String[2];
            e.PopupPassData.GridCellCaption = new String[2];
            e.PopupPassData.GridCellType = new enumDef.GridCellType[2];

            e.PopupPassData.GridCellCode[0] = "ITEM_GROUP_CD";
            e.PopupPassData.GridCellCode[1] = "ITEM_GROUP_NM";

            e.PopupPassData.GridCellCaption[0] = "Item Group";
            e.PopupPassData.GridCellCaption[1] = "Item Group Desc.";

            e.PopupPassData.GridCellType[0] = enumDef.GridCellType.Edit;
            e.PopupPassData.GridCellType[1] = enumDef.GridCellType.Edit;
        }

        private void popItemGroup3_AfterPopupClosed(object sender, uniERP.AppFramework.UI.Controls.Popup.AfterPopupCloseEventArgs e)
        {
            DataSet iDataSet = new DataSet();

            if (e.ResultData.Data == null)
                return;

            iDataSet = (DataSet)e.ResultData.Data;

            popItemGrp3.CodeValue = iDataSet.Tables[0].Rows[0]["ITEM_GROUP_CD"].ToString();
            popItemGrp3.CodeName = iDataSet.Tables[0].Rows[0]["ITEM_GROUP_NM"].ToString();
        }

        private void uniLabel2_BeforePopupOpen(object sender, AppFramework.UI.Controls.Popup.BeforePopupOpenEventArgs e)
        {

        }

        private void btnBomExec_Click(object sender, EventArgs e)
        {
            string strMsgCd = string.Empty;
            string strMsgTxt = string.Empty;
            string strRetMsgTxt = string.Empty;

           
            uniBase.UProcess.DisplayProgressBar();

            //TO-DO : code business oriented logic
            this.uniGrid1.UpdateData();

            //DataTable chgData = uniBase.UData.GetDataChange(cqtdsDataSet.E_DATA, "cud_char");
            //DataTable saveData = new DataTable();

            try
            {
                //saveData.Merge(new tdsDataSet.IE_PO_DATADataTable(), false, MissingSchemaAction.Add);

                //if (chgData != null && chgData.Rows.Count > 0)
                //    saveData.Merge(chgData, false, MissingSchemaAction.Ignore);
                //else
                //{
                //    uniBase.UMessage.DisplayMessageBox("W70001", MessageBoxButtons.OK, "\n선택된 자료가 없습니다.", "X");
                //    uniBase.UProcess.HideProgressBar();
                //    return;
                //}

                using (uniCommand iuniCommand = uniBase.UDatabase.GetStoredProcCommand("USP_P2383MA1_KO611"))
                {

                    uniBase.UDatabase.AddOutParameter(iuniCommand, "@msg_cd", SqlDbType.NVarChar, 6);
                    uniBase.UDatabase.AddOutParameter(iuniCommand, "@msg_txt", SqlDbType.NVarChar, 500);
                    uniBase.UDatabase.AddReturnParameter(iuniCommand, "RETURN_VALUE", SqlDbType.Int, 4);

                    uniBase.UDatabase.ExecuteNonQuery(iuniCommand, false);

                    int iRet = (int)uniBase.UDatabase.GetParameterValue(iuniCommand, "RETURN_VALUE");

                    if (iRet < 0)
                    {
                        uniBase.UProcess.HideProgressBar();
                        uniBase.UMessage.DisplayMessageBox(uniBase.UDatabase.GetParameterValue(iuniCommand, "@msg_cd") as string
                                                         , MessageBoxButtons.OK
                                                         , uniBase.UDatabase.GetParameterValue(iuniCommand, "@msg_txt") as string);
                        return;
                    }
                    else
                    {
                        //uniBase.UMessage.DisplayMessageBox(uniBase.UDatabase.GetParameterValue(iuniCommand, "@msg_cd") as string
                        //                                 , MessageBoxButtons.OK
                        //                                 , uniBase.UDatabase.GetParameterValue(iuniCommand, "@msg_txt") as string);
                        strMsgCd = uniBase.UDatabase.GetParameterValue(iuniCommand, "@msg_cd") as string;
                        strMsgTxt = uniBase.UDatabase.GetParameterValue(iuniCommand, "@msg_txt") as string;
                    }
                }
            }

            catch (Exception ex)
            {
                uniBase.UProcess.HideProgressBar();
                bool reThrow = uniBase.UExceptionController.AutoProcessException(ex);
                if (reThrow)
                    throw;

                return;
            }
            finally
            {

            }


            ////해당spid로 발주생성하기
            //if (!Create_PoSheet(lgSpId))
            //{
            //    //uniBase.UMessage.DisplayMessageBox("W70001", MessageBoxButtons.OK, "발주정보생성시 오류가 발생하였습니다.", "X");
            //    uniBase.UProcess.HideProgressBar();
            //    return;
            //}

            uniBase.UProcess.HideProgressBar();
            return;
        }

        private void uniTBL_OuterMost_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uniTBL_MainCondition_Paint(object sender, PaintEventArgs e)
        {

        }

	}
}