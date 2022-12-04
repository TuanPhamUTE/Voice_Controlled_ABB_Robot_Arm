MODULE Module1
    
    ! SET UP FOR TOOL
    PERS tooldata toolEquipment;   
    CONST robtarget homeTool0:= [[521.814,0,847.754],[0.5,0,0.866025404,0],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];
    !CONST robtarget homeSpintecTool:=[[704.990919137,0,705.74730631],[0.190808996,0,0.981627183,0],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];
    PERS pos position := [521.814,0,847.754];  ! search robtarget -> components
    
    ! SET UP DATA RECEIVED 
    PERS string dataRe ; 
    PERS string HomeStop;
    PERS string dataDISTANCE;
    PERS string dataAUTO;
    PERS string dataLR;  
    ! SET UP HOME POSITION    
    VAR robtarget homePosition;
    CONST robtarget Home:=[[521.813982554,0,847.753985316],[0.500000015,0,0.866025395,0],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];
    
    ! SET UP PARAMETER
    VAR num disXYZ_m{3} := [0,0,0];
    VAR num degXYZ_m{3} := [0,0,0];
    VAR num posDis := 0; VAR bool boolDis;
    VAR num posDeg := 0; VAR bool boolDeg;
    ! VARIABLES OF DISTANCE FUNCTION 
    VAR string optionFunc; ! 1
    VAR string optionDIR;  ! 2 
    VAR string optionPARA; ! 3
    PERS string dataReOPTION;
    VAR num selectOption := 0;
    PERS string dataSelectOption_Distance;
    VAR num lenDataRe; ! chieu dai cua chuoi nhan duoc  
    VAR bool s;
    
    ! VARIABLES OF AUTO FUNCTION 
    PERS string selectedAxis;
    PERS robtarget createdRobTarget;    
    PERS num robotSpeed :=10; 
    PERS num robotRotateSpeed := 5;
    VAR string axis;
    VAR num deg;
    VAR num dis;
    ! Setup speeddata and zonedata
    VAR speeddata selectedSpeed := [ 200, 30, 200, 15 ];
    VAR zonedata selectedZone := [ FALSE, 25, 40, 40, 10, 35, 5 ];
    VAR num myPosArray{3} := [0,0,0];
    
    ! VARIABLES FOR TOO MATCH ERROR
    PERS num tooMatchError := 0;
    
    LOCAL PERS tooldata tSpintec:=[TRUE,[[31.792631019,0,229.638935148],[0.945518576,0,0.325568154,0]],[3,[-51.132047978,0,99.657990242],[1,0,0,0],0,0,0]];
    LOCAL CONST robtarget homePos:=[[704.990919137,0,705.74730631],[0.190808996,0,0.981627183,0],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];
    
    PROC main()
        homePosition := homeTool0;
        !toolEquipment := tSpintec ;
        toolEquipment := tool0;
        position := homePosition.trans;
        MoveJ homePosition,v100,fine,toolEquipment\WObj:=wobj0;   
        myPosArray{1} := position.x;
        myPosArray{2} := position.y; 
        myPosArray{3} := position.z; 
        tooMatchError := 0;
        WHILE TRUE DO 
            IF ( HomeStop = "Home" OR HomeStop = "HOME") THEN
                MoveJ homePosition,v100,fine,toolEquipment\WObj:=wobj0;  
                disXYZ_m := [0,0,0];
                degXYZ_m := [0,0,0];
                HomeStop := "";
            ELSEIF  ( HomeStop = "Stop" OR HomeStop = "STOP" OR HomeStop ="7") THEN
                IF (HomeStop ="7") THEN 
                    Stop;
                ENDIF
                dataLR := "";
                HomeStop := "";
            ELSEIF ( dataDISTANCE = "DISTANCE" ) THEN 
                DISTANCE_OP;
            ELSEIF ( dataAUTO ="AUTO") THEN    
                AUTO_OP;
            ENDIF 
            TOOMATCH_FUNC;
        ENDWHILE 
    ENDPROC 
    ! ================================================================================
    
    ! AUTO FUNCTION 
    PROC AUTO_OP()
       IF ( dataLR = "Linear" ) THEN 
           AUTO_LINEAR_FUNC;
       ELSEIF (dataLR ="Reorient") THEN 
           AUTO_REORIENT_FUNC;
       ENDIF 
    ENDPROC
    PROC AUTO_LINEAR_FUNC()
        selectedSpeed.v_tcp := robotSpeed;
        IF HomeStop ="stop" or HomeStop ="Stop"THEN 
            selectedAxis := "";
        ELSE 
            !position := CreatePosition(position, selectedAxis);
            dis := CreatePosition(position,selectedAxis);
            !createdRobTarget := CreateRobtarget(position);
            MoveL RelTool(homePosition, disXYZ_m{1},disXYZ_m{2},disXYZ_m{3}, \Rx:= degXYZ_m{1}, \Ry:= degXYZ_m{2}, \Rz:= degXYZ_m{3}) , selectedSpeed,selectedZone,toolEquipment\WObj:=wobj0;
            !MoveJ createdRobTarget,selectedSpeed,selectedZone,toolEquipment1\WObj:=wobj0;           
        ENDIF             
    ENDPROC
    
    PROC AUTO_REORIENT_FUNC() 
        selectedSpeed.v_ori := robotRotateSpeed;
        IF HomeStop ="stop" or HomeStop ="Stop"THEN 
            selectedAxis := ""; 
        ELSE 
            deg := CreateRotation(selectedAxis);
            MoveL RelTool(homePosition, disXYZ_m{1},disXYZ_m{2},disXYZ_m{3}, \Rx:= degXYZ_m{1}, \Ry:= degXYZ_m{2}, \Rz:= degXYZ_m{3}) , selectedSpeed,selectedZone,toolEquipment\WObj:=wobj0;         
        ENDIF 
    ENDPROC
    
    FUNC num CreateRotation( string axis )
        TEST axis
            CASE "Plus  X"  : 
                IF degXYZ_m{1} = 125 THEN 
                    degXYZ_m{1} := 125;    tooMatchError := 1 ;      
                ELSE degXYZ_m{1} := degXYZ_m{1} + 1;
                ENDIF
                RETURN degXYZ_m{1};
            CASE "Minus X" :         ! minus X
                IF degXYZ_m{1} = -125 THEN 
                    degXYZ_m{1} := -125;   tooMatchError := 2 ;
                ELSE degXYZ_m{1} := degXYZ_m{1} - 1;
                ENDIF
                RETURN degXYZ_m{1};
            CASE "Plus  Y":  ! plus Y
                IF degXYZ_m{2} = 90 THEN 
                    degXYZ_m{2} := 90;     tooMatchError := 3 ;
                ELSE degXYZ_m{2} := degXYZ_m{2} + 1;
                ENDIF
                RETURN degXYZ_m{2};
            CASE  "Minus Y":   ! minus Y
                IF degXYZ_m{2} = -18 THEN 
                    degXYZ_m{2} := -18;    tooMatchError := 4 ;
                ELSE degXYZ_m{2} := degXYZ_m{2} - 1;
                ENDIF
                RETURN degXYZ_m{2};
            CASE "Plus  Z" : ! plus Z
                degXYZ_m{3} := degXYZ_m{3} + 1;
                RETURN degXYZ_m{3};
            CASE "Minus z": ! minus Z
                degXYZ_m{3} := degXYZ_m{3} - 1;
                RETURN degXYZ_m{3};   
            DEFAULT:
                RETURN deg;
            ENDTEST
    ENDFUNC 
    
    FUNC num CreatePosition(pos position, string axis )
        TEST axis
        CASE "Plus  X" :
            IF position.x >= -750 THEN  ! plus X
                IF disXYZ_m{1}  = 260  THEN 
                    disXYZ_m{1} := 260;
                ELSE 
                    position.x := position.x +1;
                    disXYZ_m{1} := disXYZ_m{1} + 1;
                ENDIF 
                RETURN disXYZ_m{1};
            ENDIF
        CASE "Minus X" :        ! minus X
            IF position.x <= 950   THEN 
                IF disXYZ_m{1}  = -230  THEN 
                    disXYZ_m{1} := -230;
                ELSE 
                    position.x := position.x -1;
                    disXYZ_m{1} := disXYZ_m{1} - 1;
                ENDIF 
                RETURN disXYZ_m{1};
            ENDIF
        CASE "Plus  Y" : ! plus Y
            IF position.y >= -750 THEN 
                IF disXYZ_m{2} = 600 THEN 
                    disXYZ_m{2} := 600;
                ELSE 
                    position.y := position.y + 1;        
                    disXYZ_m{2} := disXYZ_m{2} +1 ;
                ENDIF 
                RETURN disXYZ_m{2};
            ENDIF
        CASE "Minus Y" :   ! minus Y
            IF position.y  <= 750 THEN
                IF disXYZ_m{2} = -600 THEN 
                    disXYZ_m{2} := -600;
                ELSE
                    position.y := position.y - 1;        
                    disXYZ_m{2} := disXYZ_m{2} - 1 ;
                ENDIF 
                RETURN disXYZ_m{2};
            ENDIF
        CASE "Plus  Z" : ! plus Z
            IF position.z >= 100 THEN 
                IF disXYZ_m{3} = 470 THEN 
                    disXYZ_m{3} := 470;
                ELSE
                    position.z := position.z + 1;
                    disXYZ_m{3} := disXYZ_m{3} + 1 ;
                ENDIF 
                RETURN disXYZ_m{3};
            ENDIF
        CASE "Minus Z" :  ! minus Z
            IF position.z <= 860 THEN 
                IF disXYZ_m{3} = -510 THEN 
                    disXYZ_m{3} := -510;
                ELSE
                    position.z := position.z - 1;
                    disXYZ_m{3} := disXYZ_m{3} - 1 ;
                ENDIF 
                RETURN disXYZ_m{3};
            ENDIF
        DEFAULT:  
            RETURN dis;  
        ENDTEST
    ENDFUNC
    FUNC robtarget CreateRobtarget(pos position)
        RETURN [position,[0.5,0,0.866025404,0],[0,0,0,0],[9E+09,9E+09,9E+09,9E+09,9E+09,9E+09]];
    ENDFUNC
    
    ! ================================================================================
    ! DISTANCE FUNCTION
    PROC DISTANCE_OP()
        determined_DISTANCE;
        boolDeg := StrToVal(optionPARA,posDeg); 
        boolDis := StrToVal(optionPARA,posDis);
        IF(optionFunc = "Linear") THEN
            TEST optionDIR
                CASE "Plus  X": disXYZ_m{1} := disXYZ_m{1} + posDis; 
                CASE "Minus X": disXYZ_m{1} := disXYZ_m{1} - posDis; 
                CASE "Plus  Y": disXYZ_m{2} := disXYZ_m{2} + posDis; 
                CASE "Minus Y": disXYZ_m{2} := disXYZ_m{2} - posDis; 
                CASE "Plus  Z": disXYZ_m{3} := disXYZ_m{3} + posDis; 
                CASE "Minus Z": disXYZ_m{3} := disXYZ_m{3} - posDis; 
            ENDTEST
            MoveL RelTool(homePosition,disXYZ_m{1},disXYZ_m{2},disXYZ_m{3} \Rx:= degXYZ_m{1} \Ry:= degXYZ_m{2} \Rz:= degXYZ_m{3} ), v50, fine, toolEquipment\WObj:=wobj0;
        ELSEIF (optionFunc = "Reorie") THEN 
            TEST optionDIR
                CASE "Plus  X": degXYZ_m{1} := degXYZ_m{1} + posDeg; 
                CASE "Minus X": degXYZ_m{1} := degXYZ_m{1} - posDeg; 
                CASE "Plus  Y": degXYZ_m{2} := degXYZ_m{2} + posDeg; 
                CASE "Minus Y": degXYZ_m{2} := degXYZ_m{2} - posDeg; 
                CASE "Plus  Z": degXYZ_m{3} := degXYZ_m{3} + posDeg; 
                CASE "Minus Z": degXYZ_m{3} := degXYZ_m{3} - posDeg; 
            ENDTEST
            MoveL RelTool(homePosition,disXYZ_m{1},disXYZ_m{2},disXYZ_m{3} \Rx:= degXYZ_m{1} \Ry:= degXYZ_m{2} \Rz:= degXYZ_m{3} ), v50, fine, toolEquipment\WObj:=wobj0;
        ENDIF 
        optionFunc := ""; 
        optionDIR  := "";
        optionPARA := "";
    ENDPROC 
    
    ! DETERMINED FUNCTION, DIRECTION, PARAMETER
    PROC determined_DISTANCE()
        lenDataRe := StrLen(dataReOPTION);
            s :=  StrToVal(dataSelectOption_Distance, selectOption);
            TEST selectOption
                CASE 1: !123
                    optionLinearReorient(1),(2),(3);
                CASE 2: !132
                    optionLinearReorient(1),(3),(2);
                CASE 3: !213
                    optionLinearReorient(2),(1),(3);
                CASE 4: !231
                    optionLinearReorient(2),(1),(3);
                CASE 5: !312
                    optionLinearReorient(2),(3),(1);
                CASE 6: !321
                    optionLinearReorient(3),(2),(1);
            ENDTEST
    ENDPROC 
    
    
    PROC optionLinearReorient(num element_1 , num element_2, num element_3 ) ! length of string 
        TEST lenDataRe
            CASE 16:
                
                IF element_3 = 1 THEN 
                    optionPARA := strpart(dataReOPTION, 1 ,1);
                    IF element_1 > element_2 THEN
                        optionFunc := strpart(dataReOPTION, 11 ,6);   optionDIR := strpart(dataReOPTION, 3 ,7);
                    ELSEIF element_1 < element_2 THEN 
                        optionFunc := strpart(dataReOPTION, 3 ,6); 
                        IF strpart( dataReOPTION,3,1) = "L" THEN
                            optionDIR := strpart(dataReOPTION, 10 ,7);
                        ELSE 
                            optionDIR := strpart(dataReOPTION, 12 ,7);
                        ENDIF
                    ENDIF 
                    
                ELSEIF element_1 = 1 THEN 
                    IF strpart(dataReOPTION,10,1) = "M" OR strpart(dataReOPTION,10,1) = "P" THEN
                        optionFunc := strpart(dataReOPTION, 1 ,6); optionDIR := strpart(dataReOPTION, 10 ,7);   optionPARA := strpart(dataReOPTION, 8,1);
                    ELSE optionFunc := strpart(dataReOPTION, 1 ,6); optionDIR := strpart(dataReOPTION, 8 ,7);   optionPARA := strpart(dataReOPTION, 16,1);
                    ENDIF 
                ELSEIF element_2 = 1 THEN
                    IF strpart(dataReOPTION, 11,1) =  "L" THEN
                        optionDIR := strpart(dataReOPTION, 11 ,7);  optionFunc := strpart(dataReOPTION, 1 ,7);  optionPARA := strpart(dataReOPTION, 9,1);
                    ELSE
                        optionDIR := strpart(dataReOPTION, 1 ,7);  optionFunc := strpart(dataReOPTION, 9 ,6);  optionPARA := strpart(dataReOPTION, 16,1); 
                    ENDIF 
                ENDIF 
                lenDataRe := 0;
                dataReOPTION := "0";
            CASE 17:
                IF element_3 = 1 THEN 
                    optionPARA := strpart(dataReOPTION, 1 ,2);
                    IF element_1 > element_2 THEN
                        optionFunc := strpart(dataReOPTION, 12 ,6);   optionDIR := strpart(dataReOPTION, 4 ,7);  
                    ELSEIF element_1 < element_2 THEN 
                        optionFunc := strpart(dataReOPTION, 4 ,6); 
                        IF strpart( dataReOPTION,4,1) = "L" THEN
                            optionDIR := strpart(dataReOPTION, 11 ,7);
                        ELSE 
                            optionDIR := strpart(dataReOPTION, 13 ,7);
                        ENDIF  
                    ENDIF 
                ELSEIF element_1 = 1 THEN 
                    IF strpart(dataReOPTION,11,1) = "M" OR strpart(dataReOPTION,11,1) = "P" OR strpart(dataReOPTION,11,1) = "m" OR strpart(dataReOPTION,11,1) = "p" THEN
                        optionFunc := strpart(dataReOPTION, 1 ,6); optionDIR := strpart(dataReOPTION, 11 ,7);   optionPARA := strpart(dataReOPTION, 8,2);
                    ELSE optionFunc := strpart(dataReOPTION, 1 ,6); optionDIR := strpart(dataReOPTION, 8 ,7);   optionPARA := strpart(dataReOPTION, 16,2);
                    ENDIF 
                ELSEIF element_2 = 1 THEN
                    IF strpart(dataReOPTION, 12,1) =  "L" THEN
                        optionDIR := strpart(dataReOPTION, 1 ,7);  optionFunc := strpart(dataReOPTION, 12 ,7);  optionPARA := strpart(dataReOPTION, 9,2);
                    ELSE
                        optionDIR := strpart(dataReOPTION, 1 ,7);  optionFunc := strpart(dataReOPTION, 9 ,6);  optionPARA := strpart(dataReOPTION, 16,2); 
                    ENDIF  
                ENDIF
                lenDataRe := 0;
                dataReOPTION := "0";
            CASE 18:
                IF element_3 = 1 THEN 
                    optionPARA := strpart(dataReOPTION, 1 ,3);
                    IF element_1 > element_2 THEN
                        optionFunc := strpart(dataReOPTION, 13 ,6);   optionDIR := strpart(dataReOPTION, 5 ,7);  
                    ELSEIF element_1 < element_2 THEN 
                        optionFunc := strpart(dataReOPTION, 5 ,6); 
                        IF strpart( dataReOPTION,4,1) = "L" THEN
                            optionDIR := strpart(dataReOPTION, 12 ,7);
                        ELSE 
                            optionDIR := strpart(dataReOPTION, 14 ,7);
                        ENDIF 
                    ENDIF 
                !==============================================================  
                ELSEIF element_1 = 1 THEN 
                    IF strpart(dataReOPTION,1,1) = "L" AND (strpart(dataReOPTION,8,1) ="P" OR strpart(dataReOPTION,8,1) ="M") THEN 
                        optionFunc := strpart(dataReOPTION, 1 ,6); optionDIR := strpart(dataReOPTION, 8 ,7);   optionPARA := strpart(dataReOPTION, 16 ,3);
                    ELSEIF strpart(dataReOPTION,1,1) = "L" AND (strpart(dataReOPTION,12,1) ="P" OR strpart(dataReOPTION,12,1) ="M") THEN 
                        optionFunc := strpart(dataReOPTION, 1 ,6); optionDIR := strpart(dataReOPTION, 12 ,7);   optionPARA := strpart(dataReOPTION, 8 ,3);
                        
                    ELSEIF strpart(dataReOPTION,1,1) = "R" AND (strpart(dataReOPTION,10,1) ="P" OR strpart(dataReOPTION,10,1) ="M") THEN 
                        optionFunc := strpart(dataReOPTION, 1 ,6); optionDIR := strpart(dataReOPTION, 10 ,7);   optionPARA := strpart(dataReOPTION, 18 ,1);
                    ELSE
                        optionFunc := strpart(dataReOPTION, 1 ,6); optionDIR := strpart(dataReOPTION, 12 ,7);   optionPARA := strpart(dataReOPTION, 10 ,1);
                    ENDIF 
                    
                !==============================================================  
                ELSEIF element_2 = 1 THEN
                    IF strpart(dataReOPTION,9,1) = "L" AND (strpart(dataReOPTION,1,1) ="P" OR strpart(dataReOPTION,1,1) ="M") THEN 
                        optionFunc := strpart(dataReOPTION, 9 ,6); optionDIR := strpart(dataReOPTION, 1 ,7);   optionPARA := strpart(dataReOPTION, 16 ,3);
                    ELSEIF strpart(dataReOPTION,13,1) = "L" AND (strpart(dataReOPTION,1,1) ="P" OR strpart(dataReOPTION,1,1) ="M") THEN 
                        optionFunc := strpart(dataReOPTION, 13 ,6); optionDIR := strpart(dataReOPTION, 1 ,7);   optionPARA := strpart(dataReOPTION, 9 ,3);
                        
                    ELSEIF strpart(dataReOPTION,9,1) = "R" AND (strpart(dataReOPTION,1,1) ="P" OR strpart(dataReOPTION,1,1) ="M") THEN 
                        optionFunc := strpart(dataReOPTION, 9 ,6); optionDIR := strpart(dataReOPTION, 1 ,7);   optionPARA := strpart(dataReOPTION, 18 ,1);
                    ELSE
                        optionFunc := strpart(dataReOPTION, 11 ,6); optionDIR := strpart(dataReOPTION, 1 ,7);   optionPARA := strpart(dataReOPTION, 10 ,1);
                    ENDIF 
                ENDIF 
                lenDataRe := 0;
                dataReOPTION := "0";            
            CASE 19: ! REORIENT 
                IF element_3 = 1 THEN 
                    optionPARA := strpart(dataReOPTION, 1 ,2);
                    IF element_1 > element_2 THEN
                        optionFunc := strpart(dataReOPTION, 12 ,6);   optionDIR := strpart(dataReOPTION, 4 ,7);  
                    ELSEIF element_1 < element_2 THEN 
                        optionFunc := strpart(dataReOPTION, 4 ,6);   optionDIR := strpart(dataReOPTION, 13 ,7);  
                    ENDIF 
                !==============================================================  
                ELSEIF element_1 = 1 THEN 
                    IF strpart(dataReOPTION,10,1) = "M" OR strpart(dataReOPTION,10,1) = "P" THEN
                        optionFunc := strpart(dataReOPTION, 1 ,6); optionDIR := strpart(dataReOPTION, 10 ,7);   optionPARA := strpart(dataReOPTION, 18,2);
                    ELSE optionFunc := strpart(dataReOPTION, 1 ,6); optionDIR := strpart(dataReOPTION, 13 ,7);   optionPARA := strpart(dataReOPTION, 10,2);
                    ENDIF 
                !==============================================================  
                ELSEIF element_2 = 1 THEN
                    IF strpart(dataReOPTION,9,1) = "R" THEN
                        optionFunc := strpart(dataReOPTION, 9 ,6); optionDIR := strpart(dataReOPTION, 1 ,7);   optionPARA := strpart(dataReOPTION, 18,2);
                    ELSE optionFunc := strpart(dataReOPTION, 12 ,6); optionDIR := strpart(dataReOPTION, 1 ,7);   optionPARA := strpart(dataReOPTION, 9,2);
                    ENDIF 
                ENDIF
                lenDataRe := 0;
                dataReOPTION := "0";
            CASE 20:
                IF element_3 = 1 THEN 
                    optionPARA := strpart(dataReOPTION, 1 ,3);
                    IF element_1 > element_2 THEN
                        optionFunc := strpart(dataReOPTION, 13 ,6);   optionDIR := strpart(dataReOPTION, 5 ,7);  
                    ELSEIF element_1 < element_2 THEN 
                        optionFunc := strpart(dataReOPTION, 5 ,6);   optionDIR := strpart(dataReOPTION,14,7);  
                    ENDIF 
                !==============================================================  
                ELSEIF element_1 = 1 THEN 
                    IF strpart(dataReOPTION,10,1) = "M" OR strpart(dataReOPTION,10,1) = "P" THEN
                        optionFunc := strpart(dataReOPTION, 1 ,6); optionDIR := strpart(dataReOPTION, 10 ,7);   optionPARA := strpart(dataReOPTION, 18,3);
                    ELSE optionFunc := strpart(dataReOPTION, 1 ,6); optionDIR := strpart(dataReOPTION, 14 ,7);   optionPARA := strpart(dataReOPTION, 10,3);
                    ENDIF 
                !==============================================================  
                ELSEIF element_2 = 1 THEN
                    IF strpart(dataReOPTION,9,1) = "R"  THEN
                        optionFunc := strpart(dataReOPTION, 9 ,6); optionDIR := strpart(dataReOPTION, 1 ,7);   optionPARA := strpart(dataReOPTION, 18,3);
                    ELSE optionFunc := strpart(dataReOPTION, 13 ,6); optionDIR := strpart(dataReOPTION, 1 ,7);   optionPARA := strpart(dataReOPTION, 9,3);
                    ENDIF
                ENDIF
                lenDataRe := 0;
                dataReOPTION := "0";
            DEFAULT:
                s :=  StrToVal(dataSelectOption_Distance, selectOption);
                !Break;
        ENDTEST
    ENDPROC
    
    PROC Home_1()
        MoveL Home,v1000,z100,tool0\WObj:=wobj0;
    ENDPROC
    PROC TOOMATCH_FUNC()
        IF ( disXYZ_m{1} >= 260 OR disXYZ_m{1} <= -230 OR degXYZ_m{1} >=125 OR degXYZ_m{1} <= -125 ) THEN     tooMatchError := 1;
        ELSEIF ( disXYZ_m{2} >= 600 OR disXYZ_m{2} <= -600 OR degXYZ_m{2} >=90 OR degXYZ_m{2} <= -18 ) THEN   tooMatchError := 1;
        ELSEIF ( disXYZ_m{3} >= 470 OR disXYZ_m{3} <= -510 OR degXYZ_m{3} >=125 OR degXYZ_m{3} <= -125 ) THEN tooMatchError := 1;
        ENDIF 
    ENDPROC
ENDMODULE