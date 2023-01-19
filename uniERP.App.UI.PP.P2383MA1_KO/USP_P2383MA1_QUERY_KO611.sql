USE [bixolon]
GO
/****** Object:  StoredProcedure [dbo].[USP_P2383MA1_QUERY_KO611]    Script Date: 2022-01-17 ���� 1:39:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- exec [USP_P2383MA1_KO611] 'P110', 'B10','','','',''    
ALTER proc [dbo].[USP_P2383MA1_QUERY_KO611](    
    @plant_cd NVARCHAR(04)    
  , @item_grp1 NVARCHAR(50)    
  , @item_grp2 NVARCHAR(50)    
  , @item_grp3 NVARCHAR(50)    
  , @item_cd NVARCHAR(50)    
  , @tracking_no NVARCHAR(25)    
  , @child_item_cd NVARCHAR(50)    
    
    
)    
    
 as          
 begin    
/*--------------------------------------------------------------------------------------------
--���� : �������� ��ȸ�ϴ� ����
--SP�� : USP_P2383MA1_QUERY_KO611
--����SP : USP_P2383MA1_KO611 (BOM �������� ������ �ϰ� USER �������� ������ �Ͽ� p_temp_lim_2�� ���� (���� ���� ������ Ȱ��)
--ȣ�����α׷�ID : P_P2383MA1_KO611
--ȣ�����α׷��� : ����������Ȳ��ȸ(S)
--�޴���ġ: [�������/MRP]
--�����̷� : 2022-01-14 ������ �ݿ�
--	
-------------------------------------------------------------------------------------------------*/
 IF isnull(@item_grp2, '') = ''    
  SELECT @item_grp2 = '%'    
 IF isnull(@item_grp3, '') = ''    
  SELECT @item_grp3 = '%'    
 IF isnull(@item_cd, '') = ''    
  SELECT @item_cd = '%'    
 IF isnull(@tracking_no, '') = ''    
  SELECT @tracking_no = '%'    
 IF isnull(@child_item_cd, '') = ''    
  SELECT @child_item_cd = '%'    
    
 IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 = '%' AND @ITEM_CD = '%' AND @TRACKING_NO = '%') -- ��з�    
 
  BEGIN      
		   SELECT DISTINCT     
		   osd.plant_cd  
		   ,X.��׷�_�ڵ�  AS ITEM_GRP1      
		   ,X.��׷�_��Ī AS ITEM_GRP1_NM      
		   ,X.�߱׷�_�ڵ� AS ITEM_GRP2       
		   ,X.�߱׷�_��Ī AS ITEM_GRP2_NM
			,X.�ұ׷�_�ڵ� AS ITEM_GRP3       
		   ,X.�ұ׷�_��Ī AS ITEM_GRP3_NM     
		   ,X.��ǰ��_�ڵ� AS PRNT_ITEM_CD    
		   ,BI.ITEM_NM   AS PRNT_ITEM_NM     
		   ,X.��ǰ��_���� AS USER_SPEC_CD    
		   ,X.��ǰ��_�ڵ� AS CHILD_ITEM_CD    
		   ,X.��ǰ��_ǰ�� AS CHILD_ITEM_NM    
		   ,OSD.SL_CD    
		   ,OSD.PREV_GOOD_QTY    
		   ,OSD.GOOD_ON_HAND_QTY    
		  --,CASE WHEN X.GB IS NULL THEN '��������' ELSE X.GB END AS GB    
		  FROM (    
		   SELECT DISTINCT  ��׷�_�ڵ�, ��׷�_��Ī, �߱׷�_�ڵ�, �߱׷�_��Ī, �ұ׷�_�ڵ�, �ұ׷�_��Ī, ��ǰ��_�ڵ�, ��ǰ��_����, ��ǰ��_�ڵ�, ��ǰ��_ǰ��    
		    ,(SELECT DISTINCT '��������'    
		    FROM  P_TEMP_LIM_2 B (NOLOCK)    
		    WHERE B.��ǰ��_���� <> 0    
		    --AND ��ǰ��_�ڵ� <> @ITEM_CD    
		    --AND ��ǰ��_���� <> @TRACKING_NO    
		    --AND �߱׷�_�ڵ� <> @ITEM_GRP2    
		    AND ��׷�_�ڵ� <> @ITEM_GRP1    
		    AND ��ǰ��_�ڵ� =  A.��ǰ��_�ڵ�    
		     ) AS GB    
		    FROM P_TEMP_LIM_2 A (NOLOCK)     
		    WHERE ��ǰ��_���� <> 0    
		    --AND ��ǰ��_�ڵ� = @ITEM_CD    
		    --AND ��ǰ��_���� = @TRACKING_NO    
		    --AND �߱׷�_�ڵ� = @ITEM_GRP2    
		    AND ��׷�_�ڵ� = @ITEM_GRP1    
		    AND ��ǰ��_���� = '30'    
		   ) X LEFT JOIN I_ONHAND_STOCK_DETAIL OSD(NOLOCK) ON X.��ǰ��_�ڵ� = OSD.ITEM_CD    
		   INNER JOIN B_ITEM BI(NOLOCK) ON X.��ǰ��_�ڵ� = BI.ITEM_CD    
		  WHERE X.GB IS NULL    
		  AND OSD.SL_CD <> ''
		  AND X.��ǰ��_�ڵ� LIKE @CHILD_ITEM_CD    
    
  END    
     
 IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 <> '%' AND @ITEM_CD = '%' AND @TRACKING_NO = '%') --�ߺз�    
 --IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 <> '%') --�ߺз�    
  BEGIN      
		  SELECT DISTINCT 
		   osd.plant_cd  
		   ,X.��׷�_�ڵ�  AS ITEM_GRP1      
		   ,X.��׷�_��Ī AS ITEM_GRP1_NM      
		   ,X.�߱׷�_�ڵ� AS ITEM_GRP2       
		   ,X.�߱׷�_��Ī AS ITEM_GRP2_NM
			,X.�ұ׷�_�ڵ� AS ITEM_GRP3       
		   ,X.�ұ׷�_��Ī AS ITEM_GRP3_NM
		   ,X.��ǰ��_�ڵ� AS PRNT_ITEM_CD     
		   ,BI.ITEM_NM   AS PRNT_ITEM_NM     
		   ,X.��ǰ��_���� AS USER_SPEC_CD    
		   ,X.��ǰ��_�ڵ� AS CHILD_ITEM_CD    
		   ,X.��ǰ��_ǰ�� AS CHILD_ITEM_NM    
		   ,OSD.SL_CD    
		   ,OSD.PREV_GOOD_QTY    
		   ,OSD.GOOD_ON_HAND_QTY    
		  --,CASE WHEN X.GB IS NULL THEN '��������' ELSE X.GB END AS GB    
		  FROM (    
		   SELECT DISTINCT  ��׷�_�ڵ�, ��׷�_��Ī, �߱׷�_�ڵ�, �߱׷�_��Ī, �ұ׷�_�ڵ�, �ұ׷�_��Ī, ��ǰ��_�ڵ�, ��ǰ��_����, ��ǰ��_�ڵ�, ��ǰ��_ǰ��    
		    ,(SELECT DISTINCT '��������'    
		    FROM  P_TEMP_LIM_2 B (NOLOCK)    
		    WHERE B.��ǰ��_���� <> 0    
		    --AND ��ǰ��_�ڵ� <> @ITEM_CD    
		    --AND ��ǰ��_���� <> @TRACKING_NO    
		      AND �߱׷�_�ڵ� <> @ITEM_GRP2    
		    --AND ��׷�_�ڵ� <> @ITEM_GRP1    
		    AND ��ǰ��_�ڵ� =  A.��ǰ��_�ڵ�    
		     ) AS GB    
		    FROM P_TEMP_LIM_2 A (NOLOCK)     
		    WHERE ��ǰ��_���� <> 0    
		    --AND ��ǰ��_�ڵ� = @ITEM_CD    
		    --AND ��ǰ��_���� = @TRACKING_NO    
		    AND �߱׷�_�ڵ� = @ITEM_GRP2    
		    --AND ��׷�_�ڵ� = @ITEM_GRP1    
		    AND ��ǰ��_���� = '30'    
		        
		  ) X  LEFT JOIN I_ONHAND_STOCK_DETAIL OSD(NOLOCK) ON X.��ǰ��_�ڵ� = OSD.ITEM_CD    
		  INNER JOIN B_ITEM BI(NOLOCK) ON X.��ǰ��_�ڵ� = BI.ITEM_CD    
		  WHERE X.GB IS NULL    
		  AND OSD.SL_CD <> ''
		  AND X.��ǰ��_�ڵ� LIKE @CHILD_ITEM_CD    
  END     
 
 IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 <> '%' AND @ITEM_GRP3 <> '%' AND @ITEM_CD = '%' AND @TRACKING_NO = '%') --�Һз�      
 --IF (@ITEM_GRP3 <> '%') --�Һз�    
  BEGIN      
		  SELECT DISTINCT 
		   osd.plant_cd  
		   ,X.��׷�_�ڵ�  AS ITEM_GRP1      
		   ,X.��׷�_��Ī AS ITEM_GRP1_NM      
		   ,X.�߱׷�_�ڵ� AS ITEM_GRP2       
		   ,X.�߱׷�_��Ī AS ITEM_GRP2_NM
			,X.�ұ׷�_�ڵ� AS ITEM_GRP3       
		   ,X.�ұ׷�_��Ī AS ITEM_GRP3_NM
		   ,X.��ǰ��_�ڵ� AS PRNT_ITEM_CD     
		   ,BI.ITEM_NM   AS PRNT_ITEM_NM     
		   ,X.��ǰ��_���� AS USER_SPEC_CD    
		   ,X.��ǰ��_�ڵ� AS CHILD_ITEM_CD    
		   ,X.��ǰ��_ǰ�� AS CHILD_ITEM_NM    
		   ,OSD.SL_CD    
		   ,OSD.PREV_GOOD_QTY    
		   ,OSD.GOOD_ON_HAND_QTY    
		  --,CASE WHEN X.GB IS NULL THEN '��������' ELSE X.GB END AS GB    
		  FROM (    
		   SELECT DISTINCT  ��׷�_�ڵ�, ��׷�_��Ī, �߱׷�_�ڵ�, �߱׷�_��Ī, �ұ׷�_�ڵ�, �ұ׷�_��Ī, ��ǰ��_�ڵ�, ��ǰ��_����, ��ǰ��_�ڵ�, ��ǰ��_ǰ��    
		    ,(SELECT DISTINCT '��������'    
		    FROM  P_TEMP_LIM_2 B (NOLOCK)    
		    WHERE B.��ǰ��_���� <> 0    
		    --AND ��ǰ��_�ڵ� <> @ITEM_CD    
		    --AND ��ǰ��_���� <> @TRACKING_NO
			   AND �ұ׷�_�ڵ� <> @ITEM_GRP3    	 
		    --AND �߱׷�_�ڵ� <> @ITEM_GRP2    
		    --AND ��׷�_�ڵ� <> @ITEM_GRP1    
		    AND ��ǰ��_�ڵ� =  A.��ǰ��_�ڵ�    
		     ) AS GB    
		    FROM P_TEMP_LIM_2 A (NOLOCK)     
		    WHERE ��ǰ��_���� <> 0    
		    --AND ��ǰ��_�ڵ� = @ITEM_CD    
		    --AND ��ǰ��_���� = @TRACKING_NO
			   AND �ұ׷�_�ڵ� = @ITEM_GRP3 
		    --AND �߱׷�_�ڵ� = @ITEM_GRP2    
		    --AND ��׷�_�ڵ� = @ITEM_GRP1    
		    AND ��ǰ��_���� = '30'    
		        
		  ) X  LEFT JOIN I_ONHAND_STOCK_DETAIL OSD(NOLOCK) ON X.��ǰ��_�ڵ� = OSD.ITEM_CD    
		  INNER JOIN B_ITEM BI(NOLOCK) ON X.��ǰ��_�ڵ� = BI.ITEM_CD    
		  WHERE X.GB IS NULL    
		  AND OSD.SL_CD <> ''
		  AND X.��ǰ��_�ڵ� LIKE @CHILD_ITEM_CD    
  END     
 
 IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 <> '%' AND @ITEM_GRP3 <> '%' AND @ITEM_CD <> '%' AND @TRACKING_NO = '%') -- ��ǰ�з�    
 --IF (@ITEM_CD <> '%' AND @TRACKING_NO = '%') -- ��ǰ�з�    
  BEGIN      
		  SELECT DISTINCT 
		   osd.plant_cd  
		   ,X.��׷�_�ڵ�  AS ITEM_GRP1      
		   ,X.��׷�_��Ī AS ITEM_GRP1_NM      
		   ,X.�߱׷�_�ڵ� AS ITEM_GRP2       
		   ,X.�߱׷�_��Ī AS ITEM_GRP2_NM
			,X.�ұ׷�_�ڵ� AS ITEM_GRP3       
		   ,X.�ұ׷�_��Ī AS ITEM_GRP3_NM
		   ,X.��ǰ��_�ڵ� AS PRNT_ITEM_CD     
		   ,BI.ITEM_NM   AS PRNT_ITEM_NM     
		   ,X.��ǰ��_���� AS USER_SPEC_CD    
		   ,X.��ǰ��_�ڵ� AS CHILD_ITEM_CD    
		   ,X.��ǰ��_ǰ�� AS CHILD_ITEM_NM    
		   ,OSD.SL_CD    
		   ,OSD.PREV_GOOD_QTY    
		   ,OSD.GOOD_ON_HAND_QTY    
		  --,CASE WHEN X.GB IS NULL THEN '��������' ELSE X.GB END AS GB    
		  FROM (    
		   SELECT DISTINCT  ��׷�_�ڵ�, ��׷�_��Ī, �߱׷�_�ڵ�, �߱׷�_��Ī, �ұ׷�_�ڵ�, �ұ׷�_��Ī, ��ǰ��_�ڵ�, ��ǰ��_����, ��ǰ��_�ڵ�, ��ǰ��_ǰ��    
		    ,(SELECT DISTINCT '��������'    
		    FROM  P_TEMP_LIM_2 B (NOLOCK)    
		    WHERE B.��ǰ��_���� <> 0    
		    AND ��ǰ��_�ڵ� <> @ITEM_CD    
		    --AND ��ǰ��_���� <> @TRACKING_NO    
		    --AND �߱׷�_�ڵ� <> @ITEM_GRP2    
		    --AND ��׷�_�ڵ� <> @ITEM_GRP1    
		    AND ��ǰ��_�ڵ� =  A.��ǰ��_�ڵ�    
		     ) AS GB    
		    FROM P_TEMP_LIM_2 A (NOLOCK)     
		    WHERE ��ǰ��_���� <> 0    
		    AND ��ǰ��_�ڵ� = @ITEM_CD    
		    --AND ��ǰ��_���� = @TRACKING_NO    
		    --AND �߱׷�_�ڵ� = @ITEM_GRP2    
		    --AND ��׷�_�ڵ� = @ITEM_GRP1    
		    AND ��ǰ��_���� = '30'    
		        
		  ) X  LEFT JOIN I_ONHAND_STOCK_DETAIL OSD(NOLOCK) ON X.��ǰ��_�ڵ� = OSD.ITEM_CD    
		  INNER JOIN B_ITEM BI(NOLOCK) ON X.��ǰ��_�ڵ� = BI.ITEM_CD    
		  WHERE X.GB IS NULL    
		  AND OSD.SL_CD <> ''
		  AND X.��ǰ��_�ڵ� LIKE @CHILD_ITEM_CD    
  END     
    
    
      
 IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 <> '%' AND @ITEM_GRP3 <> '%' AND @ITEM_CD <> '%' AND @TRACKING_NO <> '%') --�����з�    
 --IF (@ITEM_CD <> '%' AND @TRACKING_NO <> '%') --�����з�    
    
  BEGIN      
		   SELECT DISTINCT 
		    osd.plant_cd   
		    ,X.��׷�_�ڵ�  AS ITEM_GRP1      
		    ,X.��׷�_��Ī AS ITEM_GRP1_NM      
		    ,X.�߱׷�_�ڵ� AS ITEM_GRP2       
		    ,X.�߱׷�_��Ī AS ITEM_GRP2_NM
			,X.�ұ׷�_�ڵ� AS ITEM_GRP3       
		    ,X.�ұ׷�_��Ī AS ITEM_GRP3_NM
		    ,X.��ǰ��_�ڵ� AS PRNT_ITEM_CD     
		    ,BI.ITEM_NM   AS PRNT_ITEM_NM     
		    ,X.��ǰ��_���� AS USER_SPEC_CD    
		    ,X.��ǰ��_�ڵ� AS CHILD_ITEM_CD    
		    ,X.��ǰ��_ǰ�� AS CHILD_ITEM_NM    
		    ,OSD.SL_CD    
		    ,OSD.PREV_GOOD_QTY    
		    ,OSD.GOOD_ON_HAND_QTY    
		   --,CASE WHEN X.GB IS NULL THEN '��������' ELSE X.GB END AS GB    
		   FROM (    
		    SELECT DISTINCT  ��׷�_�ڵ�, ��׷�_��Ī, �߱׷�_�ڵ�, �߱׷�_��Ī, �ұ׷�_�ڵ�, �ұ׷�_��Ī, ��ǰ��_�ڵ�, ��ǰ��_����, ��ǰ��_�ڵ�, ��ǰ��_ǰ��    
		     ,(SELECT DISTINCT '��������'    
		     FROM  P_TEMP_LIM_2 B (NOLOCK)    
		     WHERE B.��ǰ��_���� <> 0    
		     --AND ��ǰ��_�ڵ� <> @ITEM_CD    
		     --AND ��ǰ��_���� <> @TRACKING_NO    
		     AND (��ǰ��_�ڵ� <> @ITEM_CD AND ��ǰ��_���� <> @TRACKING_NO)    
		     --AND �߱׷�_�ڵ� <> @ITEM_GRP2    
		     --AND ��׷�_�ڵ� <> @ITEM_GRP1    
		     AND ��ǰ��_�ڵ� =  A.��ǰ��_�ڵ�    
		      ) AS GB    
		     FROM P_TEMP_LIM_2 A (NOLOCK)     
		     WHERE ��ǰ��_���� <> 0    
		     AND (��ǰ��_�ڵ� = @ITEM_CD   AND ��ǰ��_���� = @TRACKING_NO)    
		     --AND �߱׷�_�ڵ� = @ITEM_GRP2    
		     --AND ��׷�_�ڵ� = @ITEM_GRP1    
		     AND ��ǰ��_���� = '30'    
		         
		   ) X LEFT JOIN I_ONHAND_STOCK_DETAIL OSD(NOLOCK) ON X.��ǰ��_�ڵ� = OSD.ITEM_CD    
		   INNER JOIN B_ITEM BI(NOLOCK) ON X.��ǰ��_�ڵ� = BI.ITEM_CD    
		   WHERE X.GB IS NULL   
		   AND OSD.SL_CD <> '' 
		   AND X.��ǰ��_�ڵ� LIKE @CHILD_ITEM_CD    
  END     
end 