USE [bixolon_dev]
GO
/****** Object:  StoredProcedure [dbo].[USP_P2383MA1_KO611]    Script Date: 2022-01-03 ���� 2:10:23 ******/
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
--     @t_��ǰ��                   varchar(20) 
--    ,@t_��ǰ��                   varchar(20) 
--    ,@t_�������                 varchar(20) 
--    ,@t_��ǰ�����               varchar(20) 
--    ,@t_��ǰ�����               varchar(20) 
--    ,@t_��ü                     varchar(1) 
--    ,@t_��ǰ��ǰ��               varchar(100) 
--    ,@t_��ǰ��԰�               varchar(100) 
--    ,@t_��ǰ�����               numeric(18,6)
--    ,@w_��ǰ�����               numeric(18,6)
--    ,@t_row_id                   int

--    ,@kount                      int
--    ,@t_temp                     varchar(80)
--    ,@w_end_flag	         varchar(1)

--		drop table   p_temp_lim_2
		

--		create table p_temp_lim_2
--		(      
--		     ��ǰ��_�ڵ�                 varchar(20) 
--		    ,��ǰ��_����                 varchar(20) 
--		    ,��ǰ��_����                 varchar(20) 
--		    ,��ǰ��_����                 numeric(7,0)  default 0    
--		    ,��ǰ��_�ڵ�                 varchar(20) 
--		    ,��ǰ��_����                 varchar(20) 
--		    ,��ǰ��_��ü                 varchar(1) 
--		    ,��ǰ��_ǰ��                 varchar(100) 
--		    ,��ǰ��_�԰�                 varchar(100) 
--		    ,��ǰ��_����                 numeric(18,6) default 0
--		    ,��׷�_�ڵ�                 varchar(100) 
--		    ,��׷�_��Ī                 varchar(100) 
--			,�߱׷�_�ڵ�                 varchar(100) 
--		    ,�߱׷�_��Ī                 varchar(100) 
--			,�ұ׷�_�ڵ�                 varchar(100) 
--		    ,�ұ׷�_��Ī                 varchar(100) 
--		    ,row_id                      int identity
--		)       

--	        create index idx_row_id      ON p_temp_lim_2(row_id);
--	        create index idx_��ǰ��_�ڵ� ON p_temp_lim_2(��ǰ��_�ڵ�);
--	        create index idx_3           ON p_temp_lim_2(��ǰ��_�ڵ�,��ǰ��_����,��ǰ��_�ڵ�);

--       		/*--------- bom select ���� ----------*/
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
--				@t_��ǰ��,	@t_��ǰ�����,	@t_��ǰ��,		@t_��ǰ�����,
--				@t_��ǰ��ǰ��,	@t_��ǰ��԰�,	@t_��ǰ�����
--			WHILE @@FETCH_STATUS = 0
--			BEGIN
--				select  @t_�������     = 'STD'

--				select  @t_��ü         = 'N'
--			        if     (@t_��ǰ�����  >= '30')    select @t_��ü = 'Y'

--				select  @kount = count(*)
--				  from  p_temp_lim_2 (nolock)
--				 where  ��ǰ��_�ڵ� = @t_��ǰ��
--				   and  ��ǰ��_���� = @t_�������
--				   and  ��ǰ��_�ڵ� = @t_��ǰ��

--				if     (@kount = 0)
--				insert into p_temp_lim_2
--				       (
--					��ǰ��_�ڵ�,	��ǰ��_����,	��ǰ��_����,	��ǰ��_�ڵ�,	��ǰ��_����,	��ǰ��_��ü,	��ǰ��_ǰ��,	��ǰ��_�԰�,	��ǰ��_����
--				       )
--				 	values
--				       (
--					@t_��ǰ��,	@t_�������,	@t_��ǰ�����,	@t_��ǰ��,	@t_��ǰ�����,	@t_��ü,	@t_��ǰ��ǰ��,	@t_��ǰ��԰�,	@t_��ǰ�����
--				       )
                        	
--                                       /* ------------------------------ */
--					DECLARE cursor_2 CURSOR FOR
--		    	     	     	 select	distinct user_spec_cd
--		  			   from B_ITEM_BY_USER_OPTION_KO611 iu (nolock)
--		 			  where iu.plant_cd = 'P110'
--		 			    and iu.item_cd  =  @t_��ǰ��
		 
--		    	    	    	begin
--						OPEN cursor_2
			
--						FETCH NEXT FROM cursor_2
--						   INTO
--							@t_�������
						
--						WHILE @@FETCH_STATUS = 0
--						BEGIN
							
--							if     (@kount <> 0)
--								update  a
--								   set  ��ǰ��_���� = ��ǰ��_���� + @t_��ǰ�����
--								  from  p_temp_lim_2  a
--								 where  ��ǰ��_�ڵ� = @t_��ǰ��
--							           and  ��ǰ��_���� = @t_�������
--								   and  ��ǰ��_�ڵ� = @t_��ǰ��

			
--							if     (@kount = 0)
--							insert into p_temp_lim_2
--							       (
--								��ǰ��_�ڵ�,	��ǰ��_����,	��ǰ��_����,	��ǰ��_�ڵ�,	��ǰ��_����,	��ǰ��_��ü,	��ǰ��_ǰ��,	��ǰ��_�԰�,	��ǰ��_����
--							       )
--							 	values
--							       (
--								@t_��ǰ��,	@t_�������,	@t_��ǰ�����,	@t_��ǰ��,	@t_��ǰ�����,	@t_��ü,	@t_��ǰ��ǰ��,	@t_��ǰ��԰�,	@t_��ǰ�����
--							       )
		
--						        FETCH NEXT FROM cursor_2   into
--							@t_�������
--						END
--						CLOSE cursor_2
--						DEALLOCATE cursor_2
--					end


--                                       /* ------------------------------ */
--			        FETCH NEXT FROM cursor_1   into
--				@t_��ǰ��,	@t_��ǰ�����,	@t_��ǰ��,		@t_��ǰ�����,
--				@t_��ǰ��ǰ��,	@t_��ǰ��԰�,	@t_��ǰ�����

--			END

--			CLOSE cursor_1
--			DEALLOCATE cursor_1
--                end
--       		/*--------- bom select ���� ----------*/


--       		/*--------- user��� select ���� ----------*/

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
--				@t_��ǰ��,	@t_��ǰ�����,	@t_��ǰ��,		@t_��ǰ�����,
--				@t_��ǰ��ǰ��,	@t_��ǰ��԰�,	@t_��ǰ�����,		@t_�������
--			WHILE @@FETCH_STATUS = 0
--			BEGIN
--				select  @t_��ü         = 'N'
--			        if     (@t_��ǰ�����  >= '30')    select @t_��ü = 'Y'

--				select  @kount = count(*)
--				  from  p_temp_lim_2 (nolock)
--				 where  ��ǰ��_�ڵ� = @t_��ǰ��
--				   and  ��ǰ��_���� = @t_�������
--				   and  ��ǰ��_�ڵ� = @t_��ǰ��

--				if     (@kount <> 0)
--					update  a
--					   set  ��ǰ��_���� = ��ǰ��_���� + @t_��ǰ�����
--					  from  p_temp_lim_2 a
--					 where  ��ǰ��_�ڵ� = @t_��ǰ��
--					   and  ��ǰ��_���� = @t_�������
--					   and  ��ǰ��_�ڵ� = @t_��ǰ��

--				if     (@kount = 0)
--				insert into p_temp_lim_2
--				       (
--					��ǰ��_�ڵ�,	��ǰ��_����,	��ǰ��_����,	��ǰ��_�ڵ�,	��ǰ��_����,	��ǰ��_��ü,	��ǰ��_ǰ��,	��ǰ��_�԰�,	��ǰ��_����
--				       )
--				 	values
--				       (
--					@t_��ǰ��,	@t_�������,	@t_��ǰ�����,	@t_��ǰ��,	@t_��ǰ�����,	@t_��ü,	@t_��ǰ��ǰ��,	@t_��ǰ��԰�,	@t_��ǰ�����
--				       )
                        	
--                                       /* ------------------------------ */
--			        FETCH NEXT FROM cursor_1   into
--				@t_��ǰ��,	@t_��ǰ�����,	@t_��ǰ��,		@t_��ǰ�����,
--				@t_��ǰ��ǰ��,	@t_��ǰ��԰�,	@t_��ǰ�����,		@t_�������

--			END

--			CLOSE cursor_1
--			DEALLOCATE cursor_1
--                end

--       		/*--------- user��� select ���� ----------*/
      		
---------------------------------------------------------------          
	
--		select  @w_end_flag = '0'
--		while   @w_end_flag = '0'
--		begin	
--    	   		/*--------- temp table loop ----------*/
--			DECLARE cursor_1 CURSOR FOR
--    	             	 select	��ǰ��_�ڵ�,	��ǰ��_����,	��ǰ��_����,	��ǰ��_�ڵ�,	��ǰ��_����,	row_id
--  			   from p_temp_lim_2 (nolock)
-- 			  where ��ǰ��_��ü = 'N'
-- 			    and ��ǰ��_���� < '30'
-- 			    and ��ǰ��_���� <> 0
 
--			OPEN cursor_1
	
--			FETCH NEXT FROM cursor_1
--			   INTO
--				@t_��ǰ��,	@t_�������,	@t_��ǰ�����,	@t_��ǰ��,	@w_��ǰ�����,	@t_row_id
			
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
--		 		    and bd.prnt_item_cd  =  @t_��ǰ��
--		 		    and bd.valid_to_dt  >= getdate()
		 
--		    	    	begin
--					OPEN cursor_2
			
--					FETCH NEXT FROM cursor_2
--					   INTO
--						@t_��ǰ��,	@t_��ǰ�����,		@t_��ǰ�����,		@t_��ǰ��ǰ��,		@t_��ǰ��԰�
					
--					WHILE @@FETCH_STATUS = 0
--					BEGIN
--						select  @t_��ü         = 'N'
--					        if     (@t_��ǰ����� >= '30')    select @t_��ü = 'Y'
			
--						select  @kount = count(*)
--						  from  p_temp_lim_2 (nolock)
--						 where  ��ǰ��_�ڵ� = @t_��ǰ��
--					           and  ��ǰ��_���� = @t_�������
--						   and  ��ǰ��_�ڵ� = @t_��ǰ��

--						if     (@w_��ǰ����� < 0.0) select @t_��ǰ����� = @t_��ǰ����� * -1
						
--						if     (@kount <> 0)
--							update  a
--							   set  ��ǰ��_���� = ��ǰ��_���� + @t_��ǰ�����
--							  from  p_temp_lim_2  a
--							 where  ��ǰ��_�ڵ� = @t_��ǰ��
--						           and  ��ǰ��_���� = @t_�������
--							   and  ��ǰ��_�ڵ� = @t_��ǰ��

			
--						if     (@kount = 0)
--						insert into p_temp_lim_2
--						       (
--							��ǰ��_�ڵ�,	��ǰ��_����,	��ǰ��_����,	��ǰ��_�ڵ�,	��ǰ��_����,	��ǰ��_��ü,	��ǰ��_ǰ��,	��ǰ��_�԰�,	��ǰ��_����
--						       )
--						 	values
--						       (
--							@t_��ǰ��,	@t_�������,	@t_��ǰ�����,	@t_��ǰ��,	@t_��ǰ�����,	@t_��ü,	@t_��ǰ��ǰ��,	@t_��ǰ��԰�,	@t_��ǰ�����
--						       )
		
--					        FETCH NEXT FROM cursor_2   into
--						@t_��ǰ��,	@t_��ǰ�����,		@t_��ǰ�����,		@t_��ǰ��ǰ��,		@t_��ǰ��԰�
--					END
--					CLOSE cursor_2
--					DEALLOCATE cursor_2
--				end
--				/*--------------------------------------------------------------*/					       
--				update a
--				   set ��ǰ��_��ü = 'Y'
--				  from p_temp_lim_2 a
--				 where row_id      = @t_row_id
    	                
--                               /* ------------------------------ */
--			        FETCH NEXT FROM cursor_1   into
--				@t_��ǰ��,	@t_�������,	@t_��ǰ�����,	@t_��ǰ��,	@w_��ǰ�����,	@t_row_id
--			END
--		    loop_end:
--			CLOSE cursor_1
--			DEALLOCATE cursor_1
--    	        end
--       		/*--------- temp table loop ----------*/

---------------------------------------------------------------          


--       		/*--------- ��ǰ��_����select ���� ----------*/
--		DECLARE cursor_1 CURSOR FOR
--                 select	��ǰ��_�ڵ�,	count(*)
--  		   from p_temp_lim_2 (nolock)
-- 		  where ��ǰ��_���� between '30' and '39'
-- 		    and ��ǰ��_���� > 0.000001
-- 		  group by ��ǰ��_�ڵ�

--                begin
--			OPEN cursor_1

--			FETCH NEXT FROM cursor_1
--			   INTO
--				@t_��ǰ��,	@kount
--			WHILE @@FETCH_STATUS = 0
--			BEGIN
--				update  a
--				   set  ��ǰ��_���� = @kount
--				  from  p_temp_lim_2 a
--				 where  ��ǰ��_�ڵ� = @t_��ǰ��

--			        FETCH NEXT FROM cursor_1   into
--				@t_��ǰ��,	@kount

--			END

--			CLOSE cursor_1
--			DEALLOCATE cursor_1
--                end
--       		/*--------- ��ǰ��_���� select ���� ----------*/
                
                
--       		/*--------- ǰ��׷� ���� ----------*/
--                begin
--			update a
--			   set a.�ұ׷�_�ڵ� = isnull(BI.item_group_cd,'')
--			      ,a.�ұ׷�_��Ī = isnull(BG3.item_group_nm,'')
--				  ,a.�߱׷�_�ڵ� = isnull(BG2.item_group_cd,'')
--			      ,a.�߱׷�_��Ī = isnull(BG2.item_group_nm,'')
--				  ,a.��׷�_�ڵ� = isnull(BG1.item_group_cd,'')
--			      ,a.��׷�_��Ī = isnull(BG1.item_group_nm,'')
--			  from p_temp_lim_2 a
--		       	   -- inner join b_item       i (nolock) on (i.item_cd = a.��ǰ��_�ڵ�)
--			       --left  join b_item_group g (nolock) on (g.item_group_cd = i.item_group_cd)

--					INNER JOIN B_ITEM BI (NOLOCK) ON (BI.ITEM_CD = A.��ǰ��_�ڵ�)  --1E47
--					left JOIN B_ITEM_GROUP BG3 (NOLOCK) ON (BI.ITEM_GROUP_CD = BG3.ITEM_GROUP_CD) --D0910
--					left JOIN B_ITEM_GROUP BG2 (NOLOCK) ON (BG3.UPPER_ITEM_GROUP_CD = BG2.ITEM_GROUP_CD) --C090
--					left JOIN B_ITEM_GROUP BG1 (NOLOCK) ON (BG2.UPPER_ITEM_GROUP_CD = BG1.ITEM_GROUP_CD)--b10
--                end
--       		/*--------- ǰ��׷� ���� ----------*/


			--SELECT	OSD.PLANT_CD
			--		,PTL.��׷�_�ڵ� AS ITEM_GRP1
			--		,PTL.��׷�_��Ī AS ITEM_GRP1_NM
			--		,PTL.�߱׷�_�ڵ� AS ITEM_GRP2
			--		,PTL.�߱׷�_��Ī AS ITEM_GRP2_NM
			--		,PTL.�ұ׷�_�ڵ� AS ITEM_GRP3
			--		,PTL.�ұ׷�_��Ī AS ITEM_GRP3_NM
			--		,PTL.��ǰ��_�ڵ� AS PRNT_ITEM_CD
			--		,BI.ITEM_NM		 AS PRNT_ITEM_NM
			--		,PTL.��ǰ��_���� AS USER_SPEC_CD
			--		,PTL.��ǰ��_�ڵ� AS CHILD_ITEM_CD
			--		,PTL.��ǰ��_ǰ�� AS CHILD_ITEM_NM
			--		,OSD.SL_CD		
			--		,OSD.PREV_GOOD_QTY
			--		,OSD.GOOD_ON_HAND_QTY

			--FROM p_temp_lim_2 PTL (NOLOCK)
			--INNER JOIN B_ITEM BI (NOLOCK) ON PTL.��ǰ��_�ڵ� = BI.ITEM_CD
			--LEFT JOIN I_ONHAND_STOCK_DETAIL OSD(NOLOCK) ON PTL.��ǰ��_�ڵ� = OSD.ITEM_CD
			--WHERE OSD.PLANT_CD = @PLANT_CD
			--AND PTL.��׷�_�ڵ� = @ITEM_GRP1
			--AND PTL.�߱׷�_�ڵ� LIKE @ITEM_GRP2
			--AND PTL.�ұ׷�_�ڵ� LIKE @ITEM_GRP3
			--AND PTL.��ǰ��_�ڵ� LIKE @ITEM_CD
			--AND PTL.��ǰ��_���� LIKE @TRACKING_NO
			--AND PTL.��ǰ��_���� = 1


	IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 = '%' AND @ITEM_CD = '%') -- ��з�
		BEGIN		
				SELECT DISTINCT 
				OSD.PLANT_CD 
				,X.��׷�_�ڵ�  AS ITEM_GRP1  
				,X.��׷�_��Ī AS ITEM_GRP1_NM  
				,X.�߱׷�_�ڵ� AS ITEM_GRP2   
				,X.�߱׷�_��Ī AS ITEM_GRP2_NM 
				,X.��ǰ��_�ڵ� AS PRNT_ITEM_CD
				,BI.ITEM_NM		 AS PRNT_ITEM_NM	
				,X.��ǰ��_���� AS USER_SPEC_CD
				,X.��ǰ��_�ڵ� AS CHILD_ITEM_CD
				,X.��ǰ��_ǰ�� AS CHILD_ITEM_NM
				,OSD.SL_CD
				,OSD.PREV_GOOD_QTY
				,OSD.GOOD_ON_HAND_QTY
			--,CASE WHEN X.GB IS NULL THEN '��������' ELSE X.GB END AS GB
			FROM (
				SELECT DISTINCT  ��׷�_�ڵ�, ��׷�_��Ī, �߱׷�_�ڵ�, �߱׷�_��Ī, ��ǰ��_�ڵ�, ��ǰ��_����, ��ǰ��_�ڵ�, ��ǰ��_ǰ��
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
			AND X.��ǰ��_�ڵ� like @child_item_cd

		END
	
	IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 <> '%' AND @ITEM_CD = '%') --�ߺз�
		BEGIN		
			SELECT DISTINCT OSD.PLANT_CD 
				,X.��׷�_�ڵ�  AS ITEM_GRP1  
				,X.��׷�_��Ī AS ITEM_GRP1_NM  
				,X.�߱׷�_�ڵ� AS ITEM_GRP2   
				,X.�߱׷�_��Ī AS ITEM_GRP2_NM 
				,X.��ǰ��_�ڵ� AS PRNT_ITEM_CD	
				,BI.ITEM_NM		 AS PRNT_ITEM_NM	
				,X.��ǰ��_���� AS USER_SPEC_CD
				,X.��ǰ��_�ڵ� AS CHILD_ITEM_CD
				,X.��ǰ��_ǰ�� AS CHILD_ITEM_NM
				,OSD.SL_CD
				,OSD.PREV_GOOD_QTY
				,OSD.GOOD_ON_HAND_QTY
			--,CASE WHEN X.GB IS NULL THEN '��������' ELSE X.GB END AS GB
			FROM (
				SELECT DISTINCT  ��׷�_�ڵ�, ��׷�_��Ī, �߱׷�_�ڵ�, �߱׷�_��Ī, ��ǰ��_�ڵ�, ��ǰ��_����, ��ǰ��_�ڵ�, ��ǰ��_ǰ��
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
			AND X.��ǰ��_�ڵ� like @child_item_cd
		END	
	
	IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 <> '%' AND @ITEM_CD <> '%') -- ��ǰ�з�
		BEGIN		
			SELECT DISTINCT OSD.PLANT_CD 
				,X.��׷�_�ڵ�  AS ITEM_GRP1  
				,X.��׷�_��Ī AS ITEM_GRP1_NM  
				,X.�߱׷�_�ڵ� AS ITEM_GRP2   
				,X.�߱׷�_��Ī AS ITEM_GRP2_NM 
				,X.��ǰ��_�ڵ� AS PRNT_ITEM_CD	
				,BI.ITEM_NM		 AS PRNT_ITEM_NM	
				,X.��ǰ��_���� AS USER_SPEC_CD
				,X.��ǰ��_�ڵ� AS CHILD_ITEM_CD
				,X.��ǰ��_ǰ�� AS CHILD_ITEM_NM
				,OSD.SL_CD
				,OSD.PREV_GOOD_QTY
				,OSD.GOOD_ON_HAND_QTY
			--,CASE WHEN X.GB IS NULL THEN '��������' ELSE X.GB END AS GB
			FROM (
				SELECT DISTINCT  ��׷�_�ڵ�, ��׷�_��Ī, �߱׷�_�ڵ�, �߱׷�_��Ī, ��ǰ��_�ڵ�, ��ǰ��_����, ��ǰ��_�ڵ�, ��ǰ��_ǰ��
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
			AND X.��ǰ��_�ڵ� like @child_item_cd
		END	


		
	--IF (@ITEM_GRP1 <> '%' AND @ITEM_GRP2 <> '%' AND @ITEM_CD <> '%' AND @tracking_no <> '%') --�����з�

	--	BEGIN		
	--		SELECT DISTINCT OSD.PLANT_CD 
	--			,X.��׷�_�ڵ�  AS ITEM_GRP1  
	--			,X.��׷�_��Ī AS ITEM_GRP1_NM  
	--			,X.�߱׷�_�ڵ� AS ITEM_GRP2   
	--			,X.�߱׷�_��Ī AS ITEM_GRP2_NM 
	--			,X.��ǰ��_�ڵ� AS PRNT_ITEM_CD	
	--			,BI.ITEM_NM		 AS PRNT_ITEM_NM	
	--			,X.��ǰ��_���� AS USER_SPEC_CD
	--			,X.��ǰ��_�ڵ� AS CHILD_ITEM_CD
	--			,X.��ǰ��_ǰ�� AS CHILD_ITEM_NM
	--			,OSD.SL_CD
	--			,OSD.PREV_GOOD_QTY
	--			,OSD.GOOD_ON_HAND_QTY
	--		--,CASE WHEN X.GB IS NULL THEN '��������' ELSE X.GB END AS GB
	--		FROM (
	--			SELECT DISTINCT  ��׷�_�ڵ�, ��׷�_��Ī, �߱׷�_�ڵ�, �߱׷�_��Ī, ��ǰ��_�ڵ�, ��ǰ��_����, ��ǰ��_�ڵ�, ��ǰ��_ǰ��
	--				,(SELECT DISTINCT '��������'
	--				FROM  P_TEMP_LIM_2 B (NOLOCK)
	--				WHERE B.��ǰ��_���� <> 0
	--				AND ��ǰ��_�ڵ� <> @ITEM_CD
	--				AND ��ǰ��_���� = @TRACKING_NO
	--				--AND �߱׷�_�ڵ� <> @ITEM_GRP2
	--				--AND ��׷�_�ڵ� <> @ITEM_GRP1
	--				AND ��ǰ��_�ڵ� =  A.��ǰ��_�ڵ�
	--				 ) AS GB
	--				FROM P_TEMP_LIM_2 A (NOLOCK) 
	--				WHERE ��ǰ��_���� <> 0
	--				AND (��ǰ��_�ڵ� = @ITEM_CD
	--				AND ��ǰ��_���� = @TRACKING_NO)
	--				--AND �߱׷�_�ڵ� = @ITEM_GRP2
	--				--AND ��׷�_�ڵ� = @ITEM_GRP1
	--				AND ��ǰ��_���� = '30'
					
	--		) X LEFT JOIN I_ONHAND_STOCK_DETAIL OSD(NOLOCK) ON X.��ǰ��_�ڵ� = OSD.ITEM_CD
	--		INNER JOIN B_ITEM BI(NOLOCK) ON X.��ǰ��_�ڵ� = BI.ITEM_CD
	--		WHERE X.GB IS NULL
	--		AND X.��ǰ��_�ڵ� like @child_item_cd
	--	END	
end
