USE [bixolon_dev]
GO
/****** Object:  StoredProcedure [dbo].[USP_P2383MA1_KO611]    Script Date: 2022-01-03 오후 2:10:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- exec [USP_P2383MA1_KO611] 'P110', 'B10','','','',''
ALTER proc [dbo].[USP_P2383MA1_KO611](
		  @plant_cd NVARCHAR(04)
		, @item_grp1 NVARCHAR(50)
		, @item_grp2 NVARCHAR(50)
		, @item_grp3 NVARCHAR(50)
		, @item_cd NVARCHAR(50)
		--, @tracking_no NVARCHAR(25)
		, @child_item_cd NVARCHAR(50)


)

 as      
 begin
 IF isnull(@item_grp2, '') = ''
		SELECT @item_grp2 = '%'
 IF isnull(@item_grp3, '') = ''
		SELECT @item_grp3 = '%'
 IF isnull(@item_cd, '') = ''
		SELECT @item_cd = '%'
 --IF isnull(@tracking_no, '') = ''
	--	SELECT @tracking_no = '%'
 IF isnull(@child_item_cd, '') = ''
		SELECT @child_item_cd = '%'

--   declare @i                    int
----------------------------------------------------
--declare
--     @t_자품목                   varchar(20) 
--    ,@t_모품목                   varchar(20) 
--    ,@t_유저사양                 varchar(20) 
--    ,@t_모품목계정               varchar(20) 
--    ,@t_자품목계정               varchar(20) 
--    ,@t_해체                     varchar(1) 
--    ,@t_자품목품명               varchar(100) 
--    ,@t_자품목규격               varchar(100) 
--    ,@t_자품목수량               numeric(18,6)
--    ,@w_자품목수량               numeric(18,6)
--    ,@t_row_id                   int

--    ,@kount                      int
--    ,@t_temp                     varchar(80)
--    ,@w_end_flag	         varchar(1)

--		drop table   p_temp_lim_2
		

--		create table p_temp_lim_2
--		(      
--		     모품목_코드                 varchar(20) 
--		    ,모품목_유저                 varchar(20) 
--		    ,모품목_계정                 varchar(20) 
--		    ,모품목_갯수                 numeric(7,0)  default 0    
--		    ,자품목_코드                 varchar(20) 
--		    ,자품목_계정                 varchar(20) 
--		    ,자품목_해체                 varchar(1) 
--		    ,자품목_품명                 varchar(100) 
--		    ,자품목_규격                 varchar(100) 
--		    ,자품목_수량                 numeric(18,6) default 0
--		    ,대그룹_코드                 varchar(100) 
--		    ,대그룹_명칭                 varchar(100) 
--			,중그룹_코드                 varchar(100) 
--		    ,중그룹_명칭                 varchar(100) 
--			,소그룹_코드                 varchar(100) 
--		    ,소그룹_명칭                 varchar(100) 
--		    ,row_id                      int identity
--		)       

--	        create index idx_row_id      ON p_temp_lim_2(row_id);
--	        create index idx_자품목_코드 ON p_temp_lim_2(자품목_코드);
--	        create index idx_3           ON p_temp_lim_2(모품목_코드,모품목_유저,자품목_코드);

--       		/*--------- bom select 시작 ----------*/
--		DECLARE cursor_1 CURSOR FOR
--                 select	bd.prnt_item_cd,	bi.item_acct,	bd.child_item_cd,	b2.item_acct,
--                 	b2.item_nm,		b2.spec,	bd.child_item_qty	
--  		   from P_BOM_DETAIL bd (nolock)
--  		        inner join b_item bi (nolock) on (bi.item_cd = bd.prnt_item_cd and bi.item_acct < '20')
--  		        inner join b_item b2 (nolock) on (b2.item_cd = bd.child_item_cd)
-- 		  where bd.prnt_plant_cd = 'P110'
-- 		    and bd.valid_to_dt  >= getdate()

--                begin
--			OPEN cursor_1

--			FETCH NEXT FROM cursor_1
--			   INTO
--				@t_모품목,	@t_모품목계정,	@t_자품목,		@t_자품목계정,
--				@t_자품목품명,	@t_자품목규격,	@t_자품목수량
--			WHILE @@FETCH_STATUS = 0
--			BEGIN
--				select  @t_유저사양     = 'STD'

--				select  @t_해체         = 'N'
--			        if     (@t_자품목계정  >= '30')    select @t_해체 = 'Y'

--				select  @kount = count(*)
--				  from  p_temp_lim_2 (nolock)
--				 where  모품목_코드 = @t_모품목
--				   and  모품목_유저 = @t_유저사양
--				   and  자품목_코드 = @t_자품목

--				if     (@kount = 0)
--				insert into p_temp_lim_2
--				       (
--					모품목_코드,	모품목_유저,	모품목_계정,	자품목_코드,	자품목_계정,	자품목_해체,	자품목_품명,	자품목_규격,	자품목_수량
--				       )
--				 	values
--				       (
--					@t_모품목,	@t_유저사양,	@t_모품목계정,	@t_자품목,	@t_자품목계정,	@t_해체,	@t_자품목품명,	@t_자품목규격,	@t_자품목수량
--				       )
                        	
--                                       /* ------------------------------ */
--					DECLARE cursor_2 CURSOR FOR
--		    	     	     	 select	distinct user_spec_cd
--		  			   from B_ITEM_BY_USER_OPTION_KO611 iu (nolock)
--		 			  where iu.plant_cd = 'P110'
--		 			    and iu.item_cd  =  @t_모품목
		 
--		    	    	    	begin
--						OPEN cursor_2
			
--						FETCH NEXT FROM cursor_2
--						   INTO
--							@t_유저사양
						
--						WHILE @@FETCH_STATUS = 0
--						BEGIN
							
--							if     (@kount <> 0)
--								update  a
--								   set  자품목_수량 = 자품목_수량 + @t_자품목수량
--								  from  p_temp_lim_2  a
--								 where  모품목_코드 = @t_모품목
--							           and  모품목_유저 = @t_유저사양
--								   and  자품목_코드 = @t_자품목

			
--							if     (@kount = 0)
--							insert into p_temp_lim_2
--							       (
--								모품목_코드,	모품목_유저,	모품목_계정,	자품목_코드,	자품목_계정,	자품목_해체,	자품목_품명,	자품목_규격,	자품목_수량
--							       )
--							 	values
--							       (
--								@t_모품목,	@t_유저사양,	@t_모품목계정,	@t_자품목,	@t_자품목계정,	@t_해체,	@t_자품목품명,	@t_자품목규격,	@t_자품목수량
--							       )
		
--						        FETCH NEXT FROM cursor_2   into
--							@t_유저사양
--						END
--						CLOSE cursor_2
--						DEALLOCATE cursor_2
--					end


--                                       /* ------------------------------ */
--			        FETCH NEXT FROM cursor_1   into
--				@t_모품목,	@t_모품목계정,	@t_자품목,		@t_자품목계정,
--				@t_자품목품명,	@t_자품목규격,	@t_자품목수량

--			END

--			CLOSE cursor_1
--			DEALLOCATE cursor_1
--                end
--       		/*--------- bom select 종료 ----------*/


--       		/*--------- user사양 select 시작 ----------*/

--		DECLARE cursor_1 CURSOR FOR
--                 select	iu.item_cd,		bi.item_acct,	iu.child_item_cd,	b2.item_acct,
--                 	b2.item_nm,		b2.spec,	iu.child_item_qty,	iu.user_spec_cd	
--  		   from B_ITEM_BY_USER_OPTION_KO611 iu (nolock)
--  		        inner join b_item bi (nolock) on (bi.item_cd = iu.item_cd)
--  		        inner join b_item b2 (nolock) on (b2.item_cd = iu.child_item_cd)
-- 		  where iu.plant_cd = 'P110'

--                begin
--			OPEN cursor_1

--			FETCH NEXT FROM cursor_1
--			   INTO
--				@t_모품목,	@t_모품목계정,	@t_자품목,		@t_자품목계정,
--				@t_자품목품명,	@t_자품목규격,	@t_자품목수량,		@t_유저사양
--			WHILE @@FETCH_STATUS = 0
--			BEGIN
--				select  @t_해체         = 'N'
--			        if     (@t_자품목계정  >= '30')    select @t_해체 = 'Y'

--				select  @kount = count(*)
--				  from  p_temp_lim_2 (nolock)
--				 where  모품목_코드 = @t_모품목
--				   and  모품목_유저 = @t_유저사양
--				   and  자품목_코드 = @t_자품목

--				if     (@kount <> 0)
--					update  a
--					   set  자품목_수량 = 자품목_수량 + @t_자품목수량
--					  from  p_temp_lim_2 a
--					 where  모품목_코드 = @t_모품목
--					   and  모품목_유저 = @t_유저사양
--					   and  자품목_코드 = @t_자품목

--				if     (@kount = 0)
--				insert into p_temp_lim_2
--				       (
--					모품목_코드,	모품목_유저,	모품목_계정,	자품목_코드,	자품목_계정,	자품목_해체,	자품목_품명,	자품목_규격,	자품목_수량
--				       )
--				 	values
--				       (
--					@t_모품목,	@t_유저사양,	@t_모품목계정,	@t_자품목,	@t_자품목계정,	@t_해체,	@t_자품목품명,	@t_자품목규격,	@t_자품목수량
--				       )
                        	
--                                       /* ------------------------------ */
--			        FETCH NEXT FROM cursor_1   into
--				@t_모품목,	@t_모품목계정,	@t_자품목,		@t_자품목계정,
--				@t_자품목품명,	@t_자품목규격,	@t_자품목수량,		@t_유저사양

--			END

--			CLOSE cursor_1
--			DEALLOCATE cursor_1
--                end

--       		/*--------- user사양 select 종료 ----------*/
      		
---------------------------------------------------------------          
	
--		select  @w_end_flag = '0'
--		while   @w_end_flag = '0'
--		begin	
--    	   		/*--------- temp table loop ----------*/
--			DECLARE cursor_1 CURSOR FOR
--    	             	 select	모품목_코드,	모품목_유저,	모품목_계정,	자품목_코드,	자품목_수량,	row_id
--  			   from p_temp_lim_2 (nolock)
-- 			  where 자품목_해체 = 'N'
-- 			    and 모품목_계정 < '30'
-- 			    and 자품목_수량 <> 0
 
--			OPEN cursor_1
	
--			FETCH NEXT FROM cursor_1
--			   INTO
--				@t_모품목,	@t_유저사양,	@t_모품목계정,	@t_자품목,	@w_자품목수량,	@t_row_id
			
--			if     (@@FETCH_STATUS <> 0) 	select  @w_end_flag = '1'
--			if     (@@FETCH_STATUS <> 0)	goto    loop_end
			
--			WHILE @@FETCH_STATUS = 0
--			BEGIN
--				/*--------------------------------------------------------------*/
--				DECLARE cursor_2 CURSOR FOR
--		    	     	 select	bd.child_item_cd,	bd.child_item_qty,	bi.item_acct,		bi.item_nm,		bi.spec
--		  		   from p_bom_detail bd (nolock)
--		  		        inner join b_item bi (nolock) on (bi.item_cd = bd.child_item_cd)
--		 		  where bd.prnt_plant_cd = 'P110'
--		 		    and bd.prnt_item_cd  =  @t_자품목
--		 		    and bd.valid_to_dt  >= getdate()
		 
--		    	    	begin
--					OPEN cursor_2
			
--					FETCH NEXT FROM cursor_2
--					   INTO
--						@t_자품목,	@t_자품목수량,		@t_자품목계정,		@t_자품목품명,		@t_자품목규격
					
--					WHILE @@FETCH_STATUS = 0
--					BEGIN
--						select  @t_해체         = 'N'
--					        if     (@t_자품목계정 >= '30')    select @t_해체 = 'Y'
			
--						select  @kount = count(*)
--						  from  p_temp_lim_2 (nolock)
--						 where  모품목_코드 = @t_모품목
--					           and  모품목_유저 = @t_유저사양
--						   and  자품목_코드 = @t_자품목

--						if     (@w_자품목수량 < 0.0) select @t_자품목수량 = @t_자품목수량 * -1
						
--						if     (@kount <> 0)
--							update  a
--							   set  자품목_수량 = 자품목_수량 + @t_자품목수량
--							  from  p_temp_lim_2  a
--							 where  모품목_코드 = @t_모품목
--						           and  모품목_유저 = @t_유저사양
--							   and  자품목_코드 = @t_자품목

			
--						if     (@kount = 0)
--						insert into p_temp_lim_2
--						       (
--							모품목_코드,	모품목_유저,	모품목_계정,	자품목_코드,	자품목_계정,	자품목_해체,	자품목_품명,	자품목_규격,	자품목_수량
--						       )
--						 	values
--						       (
--							@t_모품목,	@t_유저사양,	@t_모품목계정,	@t_자품목,	@t_자품목계정,	@t_해체,	@t_자품목품명,	@t_자품목규격,	@t_자품목수량
--						       )
		
--					        FETCH NEXT FROM cursor_2   into
--						@t_자품목,	@t_자품목수량,		@t_자품목계정,		@t_자품목품명,		@t_자품목규격
--					END
--					CLOSE cursor_2
--					DEALLOCATE cursor_2
--				end
--				/*--------------------------------------------------------------*/					       
--				update a
--				   set 자품목_해체 = 'Y'
--				  from p_temp_lim_2 a
--				 where row_id      = @t_row_id
    	                
--                               /* ------------------------------ */
--			        FETCH NEXT FROM cursor_1   into
--				@t_모품목,	@t_유저사양,	@t_모품목계정,	@t_자품목,	@w_자품목수량,	@t_row_id
--			END
--		    loop_end:
--			CLOSE cursor_1
--			DEALLOCATE cursor_1
--    	        end
--       		/*--------- temp table loop ----------*/

---------------------------------------------------------------          


--       		/*--------- 모품목_갯수select 시작 ----------*/
--		DECLARE cursor_1 CURSOR FOR
--                 select	자품목_코드,	count(*)
--  		   from p_temp_lim_2 (nolock)
-- 		  where 자품목_계정 between '30' and '39'
-- 		    and 자품목_수량 > 0.000001
-- 		  group by 자품목_코드

--                begin
--			OPEN cursor_1

--			FETCH NEXT FROM cursor_1
--			   INTO
--				@t_자품목,	@kount
--			WHILE @@FETCH_STATUS = 0
--			BEGIN
--				update  a
--				   set  모품목_갯수 = @kount
--				  from  p_temp_lim_2 a
--				 where  자품목_코드 = @t_자품목

--			        FETCH NEXT FROM cursor_1   into
--				@t_자품목,	@kount

--			END

--			CLOSE cursor_1
--			DEALLOCATE cursor_1
--                end
--       		/*--------- 모품목_갯수 select 종료 ----------*/
                
                
--       		/*--------- 품목그룹 시작 ----------*/
--                begin
--			update a
--			   set a.소그룹_코드 = isnull(BI.item_group_cd,'')
--			      ,a.소그룹_명칭 = isnull(BG3.item_group_nm,'')
--				  ,a.중그룹_코드 = isnull(BG2.item_group_cd,'')
--			      ,a.중그룹_명칭 = isnull(BG2.item_group_nm,'')
--				  ,a.대그룹_코드 = isnull(BG1.item_group_cd,'')
--			      ,a.대그룹_명칭 = isnull(BG1.item_group_nm,'')
--			  from p_temp_lim_2 a
--		       	   -- inner join b_item       i (nolock) on (i.item_cd = a.모품목_코드)
--			       --left  join b_item_group g (nolock) on (g.item_group_cd = i.item_group_cd)

--					INNER JOIN B_ITEM BI (NOLOCK) ON (BI.ITEM_CD = A.모품목_코드)  --1E47
--					left JOIN B_ITEM_GROUP BG3 (NOLOCK) ON (BI.ITEM_GROUP_CD = BG3.ITEM_GROUP_CD) --D0910
--					left JOIN B_ITEM_GROUP BG2 (NOLOCK) ON (BG3.UPPER_ITEM_GROUP_CD = BG2.ITEM_GROUP_CD) --C090
--					left JOIN B_ITEM_GROUP BG1 (NOLOCK) ON (BG2.UPPER_ITEM_GROUP_CD = BG1.ITEM_GROUP_CD)--b10
--                end
--       		/*--------- 품목그룹 종료 ----------*/


			--SELECT	OSD.PLANT_CD
			--		,PTL.대그룹_코드 AS ITEM_GRP1
			--		,PTL.대그룹_명칭 AS ITEM_GRP1_NM
			--		,PTL.중그룹_코드 AS ITEM_GRP2
			--		,PTL.중그룹_명칭 AS ITEM_GRP2_NM
			--		,PTL.소그룹_코드 AS ITEM_GRP3
			--		,PTL.소그룹_명칭 AS ITEM_GRP3_NM
			--		,PTL.모품목_코드 AS PRNT_ITEM_CD
			--		,BI.ITEM_NM		 AS PRNT_ITEM_NM
			--		,PTL.모품목_유저 AS USER_SPEC_CD
			--		,PTL.자품목_코드 AS CHILD_ITEM_CD
			--		,PTL.자품목_품명 AS CHILD_ITEM_NM
			--		,OSD.SL_CD		
			--		,OSD.PREV_GOOD_QTY
			--		,OSD.GOOD_ON_HAND_QTY

			--FROM p_temp_lim_2 PTL (NOLOCK)
			--INNER JOIN B_ITEM BI (NOLOCK) ON PTL.모품목_코드 = BI.ITEM_CD
			--LEFT JOIN I_ONHAND_STOCK_DETAIL OSD(NOLOCK) ON PTL.자품목_코드 = OSD.ITEM_CD
			--WHERE OSD.PLANT_CD = @PLANT_CD
			--AND PTL.대그룹_코드 = @ITEM_GRP1
			--AND PTL.중그룹_코드 LIKE @ITEM_GRP2
			--AND PTL.소그룹_코드 LIKE @ITEM_GRP3
			--AND PTL.모품목_코드 LIKE @ITEM_CD
			--AND PTL.모품목_유저 LIKE @TRACKING_NO
			--AND PTL.모품목_갯수 = 1


	IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 = '%' AND @ITEM_CD = '%') -- 대분류
		BEGIN		
				SELECT DISTINCT 
				OSD.PLANT_CD 
				,X.대그룹_코드  AS ITEM_GRP1  
				,X.대그룹_명칭 AS ITEM_GRP1_NM  
				,X.중그룹_코드 AS ITEM_GRP2   
				,X.중그룹_명칭 AS ITEM_GRP2_NM 
				,X.모품목_코드 AS PRNT_ITEM_CD
				,BI.ITEM_NM		 AS PRNT_ITEM_NM	
				,X.모품목_유저 AS USER_SPEC_CD
				,X.자품목_코드 AS CHILD_ITEM_CD
				,X.자품목_품명 AS CHILD_ITEM_NM
				,OSD.SL_CD
				,OSD.PREV_GOOD_QTY
				,OSD.GOOD_ON_HAND_QTY
			--,CASE WHEN X.GB IS NULL THEN '전용자재' ELSE X.GB END AS GB
			FROM (
				SELECT DISTINCT  대그룹_코드, 대그룹_명칭, 중그룹_코드, 중그룹_명칭, 모품목_코드, 모품목_유저, 자품목_코드, 자품목_품명
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
			AND X.자품목_코드 like @child_item_cd

		END
	
	IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 <> '%' AND @ITEM_CD = '%') --중분류
		BEGIN		
			SELECT DISTINCT OSD.PLANT_CD 
				,X.대그룹_코드  AS ITEM_GRP1  
				,X.대그룹_명칭 AS ITEM_GRP1_NM  
				,X.중그룹_코드 AS ITEM_GRP2   
				,X.중그룹_명칭 AS ITEM_GRP2_NM 
				,X.모품목_코드 AS PRNT_ITEM_CD	
				,BI.ITEM_NM		 AS PRNT_ITEM_NM	
				,X.모품목_유저 AS USER_SPEC_CD
				,X.자품목_코드 AS CHILD_ITEM_CD
				,X.자품목_품명 AS CHILD_ITEM_NM
				,OSD.SL_CD
				,OSD.PREV_GOOD_QTY
				,OSD.GOOD_ON_HAND_QTY
			--,CASE WHEN X.GB IS NULL THEN '전용자재' ELSE X.GB END AS GB
			FROM (
				SELECT DISTINCT  대그룹_코드, 대그룹_명칭, 중그룹_코드, 중그룹_명칭, 모품목_코드, 모품목_유저, 자품목_코드, 자품목_품명
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
			AND X.자품목_코드 like @child_item_cd
		END	
	
	IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 <> '%' AND @ITEM_CD <> '%') -- 제품분류
		BEGIN		
			SELECT DISTINCT OSD.PLANT_CD 
				,X.대그룹_코드  AS ITEM_GRP1  
				,X.대그룹_명칭 AS ITEM_GRP1_NM  
				,X.중그룹_코드 AS ITEM_GRP2   
				,X.중그룹_명칭 AS ITEM_GRP2_NM 
				,X.모품목_코드 AS PRNT_ITEM_CD	
				,BI.ITEM_NM		 AS PRNT_ITEM_NM	
				,X.모품목_유저 AS USER_SPEC_CD
				,X.자품목_코드 AS CHILD_ITEM_CD
				,X.자품목_품명 AS CHILD_ITEM_NM
				,OSD.SL_CD
				,OSD.PREV_GOOD_QTY
				,OSD.GOOD_ON_HAND_QTY
			--,CASE WHEN X.GB IS NULL THEN '전용자재' ELSE X.GB END AS GB
			FROM (
				SELECT DISTINCT  대그룹_코드, 대그룹_명칭, 중그룹_코드, 중그룹_명칭, 모품목_코드, 모품목_유저, 자품목_코드, 자품목_품명
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
			AND X.자품목_코드 like @child_item_cd
		END	


		
	--IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 <> '%' AND @ITEM_CD <> '%' AND @tracking_no <> '%') --유저분류

	--	BEGIN		
	--		SELECT DISTINCT OSD.PLANT_CD 
	--			,X.대그룹_코드  AS ITEM_GRP1  
	--			,X.대그룹_명칭 AS ITEM_GRP1_NM  
	--			,X.중그룹_코드 AS ITEM_GRP2   
	--			,X.중그룹_명칭 AS ITEM_GRP2_NM 
	--			,X.모품목_코드 AS PRNT_ITEM_CD	
	--			,BI.ITEM_NM		 AS PRNT_ITEM_NM	
	--			,X.모품목_유저 AS USER_SPEC_CD
	--			,X.자품목_코드 AS CHILD_ITEM_CD
	--			,X.자품목_품명 AS CHILD_ITEM_NM
	--			,OSD.SL_CD
	--			,OSD.PREV_GOOD_QTY
	--			,OSD.GOOD_ON_HAND_QTY
	--		--,CASE WHEN X.GB IS NULL THEN '전용자재' ELSE X.GB END AS GB
	--		FROM (
	--			SELECT DISTINCT  대그룹_코드, 대그룹_명칭, 중그룹_코드, 중그룹_명칭, 모품목_코드, 모품목_유저, 자품목_코드, 자품목_품명
	--				,(SELECT DISTINCT '공용자재'
	--				FROM  P_TEMP_LIM_2 B (NOLOCK)
	--				WHERE B.자품목_수량 <> 0
	--				AND 모품목_코드 <> @ITEM_CD
	--				AND 모품목_유저 = @TRACKING_NO
	--				--AND 중그룹_코드 <> @ITEM_GRP2
	--				--AND 대그룹_코드 <> @ITEM_GRP1
	--				AND 자품목_코드 =  A.자품목_코드
	--				 ) AS GB
	--				FROM P_TEMP_LIM_2 A (NOLOCK) 
	--				WHERE 자품목_수량 <> 0
	--				AND (모품목_코드 = @ITEM_CD
	--				AND 모품목_유저 = @TRACKING_NO)
	--				--AND 중그룹_코드 = @ITEM_GRP2
	--				--AND 대그룹_코드 = @ITEM_GRP1
	--				AND 자품목_계정 = '30'
					
	--		) X LEFT JOIN I_ONHAND_STOCK_DETAIL OSD(NOLOCK) ON X.자품목_코드 = OSD.ITEM_CD
	--		INNER JOIN B_ITEM BI(NOLOCK) ON X.모품목_코드 = BI.ITEM_CD
	--		WHERE X.GB IS NULL
	--		AND X.자품목_코드 like @child_item_cd
	--	END	
end
