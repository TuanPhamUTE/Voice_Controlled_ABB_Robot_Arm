MODULE Server
    VAR string IPAdress := "127.0.0.1";
    VAR num nPort := 5000; ! local port
    VAR socketdev serverSocket; 
    VAR socketdev clientSocket;
    ! DATA FROM CLIENT 
    VAR string dataReceived;
    PERS string dataSelectOption_Distance;
    PERS string selectedAxis;
    PERS string dataRe;
    PERS string dataReOPTION;
    PERS string dataDISTANCE;
    PERS string dataAUTO;
    PERS string dataLR;
    PERS string HomeStop;

    ! VARIABLES FOR TOO MATCH ERROR
    PERS num tooMatchError := 0;
    
    PROC main()
        selectedAxis := "";
        tooMatchError := 0;
        SocketCreate serverSocket;
        SocketBind serverSocket, IPAdress, nPort; ! LocalAddress , LocalPort
        SocketListen serverSocket;
        !SocketAccept serverSocket , clientSocket ;
        SocketAccept serverSocket , clientSocket,\Time:= WAIT_MAX;
        dataDISTANCE := ""; dataAUTO := ""; dataReceived := ""; HomeStop :="";
        WHILE TRUE DO 
            TOOMATCH;
            SocketReceive clientSocket \Str:= dataReceived;
            !SocketSend clientSocket \Str:= "RAPID CONTROLLER RECEIVED";
            TEST dataReceived
                CASE "1","2","3","4","5","6","7":
                    dataSelectOption_Distance:= dataReceived;
                CASE "Plus  X","Minus X","Plus  Y","Minus Y","Plus  Z","Minus Z":
                    selectedAxis := dataReceived;
                CASE "Stop","Home":
                    HomeStop := dataReceived;
                    IF (HomeStop ="Home") THEN 
                        SocketSend clientSocket \Str:= "HOME POSITION";
                    ELSEIF (HomeStop ="Stop") THEN 
                        SocketSend clientSocket \Str:= "ROBOT STOP";
                    ENDIF 
                CASE "Linear", "Reorient":
                    dataLR := dataReceived;
                CASE "DISTANCE":
                    HomeStop :="";
                    SocketSend clientSocket \Str:= "DISTANCE OPTION";
                    dataAUTO := "";
                    dataDISTANCE := dataReceived;
                CASE "AUTO":
                    HomeStop:="";
                    SocketSend clientSocket \Str:= "AUTO OPTION";
                    dataDISTANCE := "";
                    dataAUTO := dataReceived;
                    dataReOPTION := dataReceived;
                    
                DEFAULT:
                    dataReOPTION := dataReceived;
            ENDTEST 
            selectedAxis := dataReceived;
            dataRe := dataReceived;
            dataReOPTION := dataReceived;
            !dataRe := "      ";
            !SocketClose clientSocket;
            !SocketClose serverSocket;
            TOOMATCH;
        ENDWHILE 
        ERROR
            IF ERRNO = ERR_SOCK_TIMEOUT THEN ! maximum 4 times
                RETRY ;
            ELSEIF ERRNO = ERR_SOCK_CLOSED THEN
                SocketClose clientSocket;
                SocketClose serverSocket;
                SocketCreate serverSocket;
                SocketBind serverSocket, IPAdress, nPort;
                SocketListen serverSocket;
                SocketAccept serverSocket , clientSocket, \Time:= WAIT_MAX;
                RETRY;
            ELSE
                stop;
            ENDIF 
    ENDPROC
    PROC TOOMATCH()
        IF tooMatchError = 1 THEN 
            SocketSend clientSocket \Str:= "ROBOT CONFIGURATION ERROR";
            tooMatchError :=0;
        ENDIF 
    ENDPROC
ENDMODULE