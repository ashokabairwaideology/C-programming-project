cr tab vender
 VNO                             NOT NULL NUMBER(8)
 VNAME                                    VARCHAR2(10)
 VADDR                                    VARCHAR2(20)
cr tab ind_hdr
 INDENTOR                                 VARCHAR2(6)
 INDATE                                   DATE
 INDENTNO                        NOT NULL VARCHAR2(10)
 TOT_EST_VAL                              NUMBER(8,2)
 DEPT                                     VARCHAR2(10)
 ITEMCODE                                 VARCHAR2(10)
 QTY                                      NUMBER(6,3)
 RATE                                     NUMBER(6,2)
 DT_REQ                                   DATE

SQL> desc item;
 Name                            Null?    Type
 ------------------------------- -------- ----
 ITEMCODE                        NOT NULL VARCHAR2(10)
 DESCRIPTION                              VARCHAR2(15)
 QUANTITY                                 NUMBER(6,3)
 VALUE                                    NUMBER(6,2)
 RATE                                     NUMBER(6,2)

SQL> desc enq_hdr;
 Name                            Null?    Type
 ------------------------------- -------- ----
 ENQNO                           NOT NULL VARCHAR2(10)
 INDENTNO                                 VARCHAR2(10)
 ENQDATE                                  DATE
 VNO                                      NUMBER(8)
 ITEMCODE                                 VARCHAR2(10)
 QTY                                      NUMBER(6,3)
 DT_REQ                                   DATE

SQL> desc qutn_hdr;
 Name                            Null?    Type
 ------------------------------- -------- ----
 QUTNO                           NOT NULL VARCHAR2(10)
 ENQNO                                    VARCHAR2(10)
 ENQDATE                                  DATE
 VNO                                      NUMBER(8)
 ITEMCODE                                 VARCHAR2(10)
 QTY                                      NUMBER(6,3)
 RATE                                     NUMBER(6,2)
 DT_REQ                                   DATE

SQL> desc po_hdr;
 Name                            Null?    Type
 ------------------------------- -------- ----
 PONO                            NOT NULL VARCHAR2(6)
 QUTNO                                    VARCHAR2(6)
 PODATE                                   DATE
 VNO                                      NUMBER(8)
 ITEMCODE                                 VARCHAR2(6)
 QTY                                      NUMBER(6,3)
 RATE                                     NUMBER(6,2)
 DT_REQ                                   DATE
 POVAL                                    NUMBER(8,2)

SQL> desc recpt_hdr;
 Name                            Null?    Type
 ------------------------------- -------- ----
 RP_NO                           NOT NULL VARCHAR2(10)
 PONO                                     VARCHAR2(10)
 RDATE                                    DATE
 SUP_BY                                   VARCHAR2(10)
 RECD_BY                                  VARCHAR2(10)
 ITEMCODE                                 VARCHAR2(10)
 QTY                                      NUMBER(6,3)
 VAL                                      NUMBER(6,2)
 CHK_BY                                   VARCHAR2(20)
 REMKS                                    VARCHAR2(20)

SQL> desc isue_hdr;
 Name                            Null?    Type
 ------------------------------- -------- ----
 ISUNO                           NOT NULL VARCHAR2(10)
 ISDAT                                    DATE
 DEPT                                     VARCHAR2(10)
 ISU_BY                                   VARCHAR2(10)
 ITEMCODE                                 VARCHAR2(8)
 QTY                                      NUMBER(6,2)
 VAL                                      NUMBER(6,2)
 HANDOVR_TO                               VARCHAR2(10)
 REMAK                                    VARCHAR2(20)

SQL> desc retun_hdr;
 Name                            Null?    Type
 ------------------------------- -------- ----
 RETNO                           NOT NULL VARCHAR2(5)
 RTDAT                                    DATE
 ISUNO                                    VARCHAR2(10)
 DEPT                                     VARCHAR2(10)
 RETN_TO                                  VARCHAR2(10)
 RETN_BY                                  VARCHAR2(10)
 ITEMCODE                                 VARCHAR2(10)
 QTY                                      NUMBER(6,3)
 VAL                                      NUMBER(6,2)
 REMKS                                    VARCHAR2(10)




