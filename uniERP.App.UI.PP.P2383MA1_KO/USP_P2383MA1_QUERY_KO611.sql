USE [bixolon]
GO
/****** Object:  StoredProcedure [dbo].[USP_P2383MA1_QUERY_KO611]    Script Date: 2022-01-17 오후 1:39:21 ******/
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
--개요 : 전용자재 조회하는 로직
--SP명 : USP_P2383MA1_QUERY_KO611
--관련SP : USP_P2383MA1_KO611 (BOM 기준으로 전개를 하고 USER 기준으로 전개를 하여 p_temp_lim_2에 저장 (이전 개발 로직을 활용)
--호출프로그램ID : P_P2383MA1_KO611
--호출프로그램명 : 전용자재현황조회(S)
--메뉴위치: [생산관리/MRP]
--수정이력 : 2022-01-14 본서버 반영
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
    
 IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 = '%' AND @ITEM_CD = '%' AND @TRACKING_NO = '%') -- 대분류    
 
  BEGIN      
		   SELECT DISTINCT     
		   osd.plant_cd  
		   ,X.대그룹_코드  AS ITEM_GRP1      
		   ,X.대그룹_명칭 AS ITEM_GRP1_NM      
		   ,X.중그룹_코드 AS ITEM_GRP2       
		   ,X.중그룹_명칭 AS ITEM_GRP2_NM
			,X.소그룹_코드 AS ITEM_GRP3       
		   ,X.소그룹_명칭 AS ITEM_GRP3_NM     
		   ,X.모품목_코드 AS PRNT_ITEM_CD    
		   ,BI.ITEM_NM   AS PRNT_ITEM_NM     
		   ,X.모품목_유저 AS USER_SPEC_CD    
		   ,X.자품목_코드 AS CHILD_ITEM_CD    
		   ,X.자품목_품명 AS CHILD_ITEM_NM    
		   ,OSD.SL_CD    
		   ,OSD.PREV_GOOD_QTY    
		   ,OSD.GOOD_ON_HAND_QTY    
		  --,CASE WHEN X.GB IS NULL THEN '전용자재' ELSE X.GB END AS GB    
		  FROM (    
		   SELECT DISTINCT  대그룹_코드, 대그룹_명칭, 중그룹_코드, 중그룹_명칭, 소그룹_코드, 소그룹_명칭, 모품목_코드, 모품목_유저, 자품목_코드, 자품목_품명    
		    ,(SELECT DISTINCT '공용자재'    
		    FROM  P_TEMP_LIM_2 B (NOLOCK)    
		    WHERE B.자품목_수량 <> 0    
		    --AND 모품목_코드 <> @ITEM_CD    
		    --AND 모품목_유저 <> @TRACKING_NO    
		    --AND 중그룹_코드 <> @ITEM_GRP2    
		    AND 대그룹_코드 <> @ITEM_GRP1    
		    AND 자품목_코드 =  A.자품목_코드    
		     ) AS GB    
		    FROM P_TEMP_LIM_2 A (NOLOCK)     
		    WHERE 자품목_수량 <> 0    
		    --AND 모품목_코드 = @ITEM_CD    
		    --AND 모품목_유저 = @TRACKING_NO    
		    --AND 중그룹_코드 = @ITEM_GRP2    
		    AND 대그룹_코드 = @ITEM_GRP1    
		    AND 자품목_계정 = '30'    
		   ) X LEFT JOIN I_ONHAND_STOCK_DETAIL OSD(NOLOCK) ON X.자품목_코드 = OSD.ITEM_CD    
		   INNER JOIN B_ITEM BI(NOLOCK) ON X.모품목_코드 = BI.ITEM_CD    
		  WHERE X.GB IS NULL    
		  AND OSD.SL_CD <> ''
		  AND X.자품목_코드 LIKE @CHILD_ITEM_CD    
    
  END    
     
 IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 <> '%' AND @ITEM_CD = '%' AND @TRACKING_NO = '%') --중분류    
 --IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 <> '%') --중분류    
  BEGIN      
		  SELECT DISTINCT 
		   osd.plant_cd  
		   ,X.대그룹_코드  AS ITEM_GRP1      
		   ,X.대그룹_명칭 AS ITEM_GRP1_NM      
		   ,X.중그룹_코드 AS ITEM_GRP2       
		   ,X.중그룹_명칭 AS ITEM_GRP2_NM
			,X.소그룹_코드 AS ITEM_GRP3       
		   ,X.소그룹_명칭 AS ITEM_GRP3_NM
		   ,X.모품목_코드 AS PRNT_ITEM_CD     
		   ,BI.ITEM_NM   AS PRNT_ITEM_NM     
		   ,X.모품목_유저 AS USER_SPEC_CD    
		   ,X.자품목_코드 AS CHILD_ITEM_CD    
		   ,X.자품목_품명 AS CHILD_ITEM_NM    
		   ,OSD.SL_CD    
		   ,OSD.PREV_GOOD_QTY    
		   ,OSD.GOOD_ON_HAND_QTY    
		  --,CASE WHEN X.GB IS NULL THEN '전용자재' ELSE X.GB END AS GB    
		  FROM (    
		   SELECT DISTINCT  대그룹_코드, 대그룹_명칭, 중그룹_코드, 중그룹_명칭, 소그룹_코드, 소그룹_명칭, 모품목_코드, 모품목_유저, 자품목_코드, 자품목_품명    
		    ,(SELECT DISTINCT '공용자재'    
		    FROM  P_TEMP_LIM_2 B (NOLOCK)    
		    WHERE B.자품목_수량 <> 0    
		    --AND 모품목_코드 <> @ITEM_CD    
		    --AND 모품목_유저 <> @TRACKING_NO    
		      AND 중그룹_코드 <> @ITEM_GRP2    
		    --AND 대그룹_코드 <> @ITEM_GRP1    
		    AND 자품목_코드 =  A.자품목_코드    
		     ) AS GB    
		    FROM P_TEMP_LIM_2 A (NOLOCK)     
		    WHERE 자품목_수량 <> 0    
		    --AND 모품목_코드 = @ITEM_CD    
		    --AND 모품목_유저 = @TRACKING_NO    
		    AND 중그룹_코드 = @ITEM_GRP2    
		    --AND 대그룹_코드 = @ITEM_GRP1    
		    AND 자품목_계정 = '30'    
		        
		  ) X  LEFT JOIN I_ONHAND_STOCK_DETAIL OSD(NOLOCK) ON X.자품목_코드 = OSD.ITEM_CD    
		  INNER JOIN B_ITEM BI(NOLOCK) ON X.모품목_코드 = BI.ITEM_CD    
		  WHERE X.GB IS NULL    
		  AND OSD.SL_CD <> ''
		  AND X.자품목_코드 LIKE @CHILD_ITEM_CD    
  END     
 
 IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 <> '%' AND @ITEM_GRP3 <> '%' AND @ITEM_CD = '%' AND @TRACKING_NO = '%') --소분류      
 --IF (@ITEM_GRP3 <> '%') --소분류    
  BEGIN      
		  SELECT DISTINCT 
		   osd.plant_cd  
		   ,X.대그룹_코드  AS ITEM_GRP1      
		   ,X.대그룹_명칭 AS ITEM_GRP1_NM      
		   ,X.중그룹_코드 AS ITEM_GRP2       
		   ,X.중그룹_명칭 AS ITEM_GRP2_NM
			,X.소그룹_코드 AS ITEM_GRP3       
		   ,X.소그룹_명칭 AS ITEM_GRP3_NM
		   ,X.모품목_코드 AS PRNT_ITEM_CD     
		   ,BI.ITEM_NM   AS PRNT_ITEM_NM     
		   ,X.모품목_유저 AS USER_SPEC_CD    
		   ,X.자품목_코드 AS CHILD_ITEM_CD    
		   ,X.자품목_품명 AS CHILD_ITEM_NM    
		   ,OSD.SL_CD    
		   ,OSD.PREV_GOOD_QTY    
		   ,OSD.GOOD_ON_HAND_QTY    
		  --,CASE WHEN X.GB IS NULL THEN '전용자재' ELSE X.GB END AS GB    
		  FROM (    
		   SELECT DISTINCT  대그룹_코드, 대그룹_명칭, 중그룹_코드, 중그룹_명칭, 소그룹_코드, 소그룹_명칭, 모품목_코드, 모품목_유저, 자품목_코드, 자품목_품명    
		    ,(SELECT DISTINCT '공용자재'    
		    FROM  P_TEMP_LIM_2 B (NOLOCK)    
		    WHERE B.자품목_수량 <> 0    
		    --AND 모품목_코드 <> @ITEM_CD    
		    --AND 모품목_유저 <> @TRACKING_NO
			   AND 소그룹_코드 <> @ITEM_GRP3    	 
		    --AND 중그룹_코드 <> @ITEM_GRP2    
		    --AND 대그룹_코드 <> @ITEM_GRP1    
		    AND 자품목_코드 =  A.자품목_코드    
		     ) AS GB    
		    FROM P_TEMP_LIM_2 A (NOLOCK)     
		    WHERE 자품목_수량 <> 0    
		    --AND 모품목_코드 = @ITEM_CD    
		    --AND 모품목_유저 = @TRACKING_NO
			   AND 소그룹_코드 = @ITEM_GRP3 
		    --AND 중그룹_코드 = @ITEM_GRP2    
		    --AND 대그룹_코드 = @ITEM_GRP1    
		    AND 자품목_계정 = '30'    
		        
		  ) X  LEFT JOIN I_ONHAND_STOCK_DETAIL OSD(NOLOCK) ON X.자품목_코드 = OSD.ITEM_CD    
		  INNER JOIN B_ITEM BI(NOLOCK) ON X.모품목_코드 = BI.ITEM_CD    
		  WHERE X.GB IS NULL    
		  AND OSD.SL_CD <> ''
		  AND X.자품목_코드 LIKE @CHILD_ITEM_CD    
  END     
 
 IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 <> '%' AND @ITEM_GRP3 <> '%' AND @ITEM_CD <> '%' AND @TRACKING_NO = '%') -- 제품분류    
 --IF (@ITEM_CD <> '%' AND @TRACKING_NO = '%') -- 제품분류    
  BEGIN      
		  SELECT DISTINCT 
		   osd.plant_cd  
		   ,X.대그룹_코드  AS ITEM_GRP1      
		   ,X.대그룹_명칭 AS ITEM_GRP1_NM      
		   ,X.중그룹_코드 AS ITEM_GRP2       
		   ,X.중그룹_명칭 AS ITEM_GRP2_NM
			,X.소그룹_코드 AS ITEM_GRP3       
		   ,X.소그룹_명칭 AS ITEM_GRP3_NM
		   ,X.모품목_코드 AS PRNT_ITEM_CD     
		   ,BI.ITEM_NM   AS PRNT_ITEM_NM     
		   ,X.모품목_유저 AS USER_SPEC_CD    
		   ,X.자품목_코드 AS CHILD_ITEM_CD    
		   ,X.자품목_품명 AS CHILD_ITEM_NM    
		   ,OSD.SL_CD    
		   ,OSD.PREV_GOOD_QTY    
		   ,OSD.GOOD_ON_HAND_QTY    
		  --,CASE WHEN X.GB IS NULL THEN '전용자재' ELSE X.GB END AS GB    
		  FROM (    
		   SELECT DISTINCT  대그룹_코드, 대그룹_명칭, 중그룹_코드, 중그룹_명칭, 소그룹_코드, 소그룹_명칭, 모품목_코드, 모품목_유저, 자품목_코드, 자품목_품명    
		    ,(SELECT DISTINCT '공용자재'    
		    FROM  P_TEMP_LIM_2 B (NOLOCK)    
		    WHERE B.자품목_수량 <> 0    
		    AND 모품목_코드 <> @ITEM_CD    
		    --AND 모품목_유저 <> @TRACKING_NO    
		    --AND 중그룹_코드 <> @ITEM_GRP2    
		    --AND 대그룹_코드 <> @ITEM_GRP1    
		    AND 자품목_코드 =  A.자품목_코드    
		     ) AS GB    
		    FROM P_TEMP_LIM_2 A (NOLOCK)     
		    WHERE 자품목_수량 <> 0    
		    AND 모품목_코드 = @ITEM_CD    
		    --AND 모품목_유저 = @TRACKING_NO    
		    --AND 중그룹_코드 = @ITEM_GRP2    
		    --AND 대그룹_코드 = @ITEM_GRP1    
		    AND 자품목_계정 = '30'    
		        
		  ) X  LEFT JOIN I_ONHAND_STOCK_DETAIL OSD(NOLOCK) ON X.자품목_코드 = OSD.ITEM_CD    
		  INNER JOIN B_ITEM BI(NOLOCK) ON X.모품목_코드 = BI.ITEM_CD    
		  WHERE X.GB IS NULL    
		  AND OSD.SL_CD <> ''
		  AND X.자품목_코드 LIKE @CHILD_ITEM_CD    
  END     
    
    
      
 IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 <> '%' AND @ITEM_GRP3 <> '%' AND @ITEM_CD <> '%' AND @TRACKING_NO <> '%') --유저분류    
 --IF (@ITEM_CD <> '%' AND @TRACKING_NO <> '%') --유저분류    
    
  BEGIN      
		   SELECT DISTINCT 
		    osd.plant_cd   
		    ,X.대그룹_코드  AS ITEM_GRP1      
		    ,X.대그룹_명칭 AS ITEM_GRP1_NM      
		    ,X.중그룹_코드 AS ITEM_GRP2       
		    ,X.중그룹_명칭 AS ITEM_GRP2_NM
			,X.소그룹_코드 AS ITEM_GRP3       
		    ,X.소그룹_명칭 AS ITEM_GRP3_NM
		    ,X.모품목_코드 AS PRNT_ITEM_CD     
		    ,BI.ITEM_NM   AS PRNT_ITEM_NM     
		    ,X.모품목_유저 AS USER_SPEC_CD    
		    ,X.자품목_코드 AS CHILD_ITEM_CD    
		    ,X.자품목_품명 AS CHILD_ITEM_NM    
		    ,OSD.SL_CD    
		    ,OSD.PREV_GOOD_QTY    
		    ,OSD.GOOD_ON_HAND_QTY    
		   --,CASE WHEN X.GB IS NULL THEN '전용자재' ELSE X.GB END AS GB    
		   FROM (    
		    SELECT DISTINCT  대그룹_코드, 대그룹_명칭, 중그룹_코드, 중그룹_명칭, 소그룹_코드, 소그룹_명칭, 모품목_코드, 모품목_유저, 자품목_코드, 자품목_품명    
		     ,(SELECT DISTINCT '공용자재'    
		     FROM  P_TEMP_LIM_2 B (NOLOCK)    
		     WHERE B.자품목_수량 <> 0    
		     --AND 모품목_코드 <> @ITEM_CD    
		     --AND 모품목_유저 <> @TRACKING_NO    
		     AND (모품목_코드 <> @ITEM_CD AND 모품목_유저 <> @TRACKING_NO)    
		     --AND 중그룹_코드 <> @ITEM_GRP2    
		     --AND 대그룹_코드 <> @ITEM_GRP1    
		     AND 자품목_코드 =  A.자품목_코드    
		      ) AS GB    
		     FROM P_TEMP_LIM_2 A (NOLOCK)     
		     WHERE 자품목_수량 <> 0    
		     AND (모품목_코드 = @ITEM_CD   AND 모품목_유저 = @TRACKING_NO)    
		     --AND 중그룹_코드 = @ITEM_GRP2    
		     --AND 대그룹_코드 = @ITEM_GRP1    
		     AND 자품목_계정 = '30'    
		         
		   ) X LEFT JOIN I_ONHAND_STOCK_DETAIL OSD(NOLOCK) ON X.자품목_코드 = OSD.ITEM_CD    
		   INNER JOIN B_ITEM BI(NOLOCK) ON X.모품목_코드 = BI.ITEM_CD    
		   WHERE X.GB IS NULL   
		   AND OSD.SL_CD <> '' 
		   AND X.자품목_코드 LIKE @CHILD_ITEM_CD    
  END     
end 