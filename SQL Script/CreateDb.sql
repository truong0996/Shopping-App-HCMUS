/*==============================================================*/
/* DBMS NAME:      MICROSOFT SQL SERVER 2016                    */
/* CREATED ON:     12/3/2020 3:09:40 PM                         */
/*==============================================================*/


CREATE DATABASE QuanLyBanHang
GO
USE QuanLyBanHang
GO

/*==============================================================*/
/* TABLE: CHI_TIET_DON_HANG                                     */
/*==============================================================*/
CREATE TABLE CHI_TIET_DON_HANG (
   MA_DON_HANG          INT                  NOT NULL,
   MA_SP                INT                  NOT NULL,
   SO_LUONG             INT                  NULL,
   TEN_SP				NVARCHAR(50)			 NULL,
   GIA                  MONEY                NULL,
   NGAY_MUA             DATE				 NOT NULL,
   CONSTRAINT PK_CHI_TIET_DON_HANG PRIMARY KEY (MA_DON_HANG, MA_SP, NGAY_MUA)
)
GO

/*==============================================================*/
/* TABLE: CHI_TIET_GIO_HANG                                     */
/*==============================================================*/
CREATE TABLE CHI_TIET_GIO_HANG (
   MA_GIO_HANG          NVARCHAR(50)          NOT NULL,
   MA_SP                INT                  NOT NULL,
   SO_LUONG             INT                  NULL,
   TEN_SP				NVARCHAR(50)			 NULL,
   GIA                  MONEY                NULL,
   CONSTRAINT PK_CHI_TIET_GIO_HANG PRIMARY KEY (MA_GIO_HANG, MA_SP)
)
GO

/*==============================================================*/
/* TABLE: CUA_HANG                                              */
/*==============================================================*/
CREATE TABLE CUA_HANG (
   MA_CUA_HANG          NVARCHAR(50)          NOT NULL,
   MA_KH                NVARCHAR(50)          NULL,
   SDT                  NVARCHAR(20)          NULL,
   EMAIL                NVARCHAR(20)          NULL,
   CONSTRAINT PK_CUA_HANG PRIMARY KEY (MA_CUA_HANG)
)
GO

/*==============================================================*/
/* TABLE: DANH_MUC                                              */
/*==============================================================*/
CREATE TABLE DANH_MUC (
   TEN_DM               NVARCHAR(50)          NOT NULL,
   CONSTRAINT PK_DANH_MUC PRIMARY KEY (TEN_DM)
)
GO


/*==============================================================*/
/* TABLE: DANH_SACH_DON_HANG                                    */
/*==============================================================*/
CREATE TABLE DANH_SACH_DON_HANG (
   MA_DON_HANG          INT                  IDENTITY(1,1),
   MA_KH                NVARCHAR(50)          NULL,
   MA_CUA_HANG          NVARCHAR(50)          NOT NULL,
   DIA_CHI              NVARCHAR(50)          NULL,
   NGAY_MUA             DATE				  NULL,
   TONG_TIEN			MONEY				  NULL,
   TRANG_THAI           NVARCHAR(10)          NULL,
   CONSTRAINT PK_DANH_SACH_DON_HANG PRIMARY KEY (MA_DON_HANG)
)
GO

/*==============================================================*/
/* TABLE: GIO_HANG                                              */
/*==============================================================*/
CREATE TABLE GIO_HANG (
   MA_GIO_HANG          NVARCHAR(50)          NOT NULL,
   MA_KH                NVARCHAR(50)          NULL,
   TONG_TIEN            MONEY                NULL,
   CONSTRAINT PK_GIO_HANG PRIMARY KEY (MA_GIO_HANG)
)
GO

/*==============================================================*/
/* TABLE: KHACH_HANG                                            */
/*==============================================================*/
CREATE TABLE KHACH_HANG (
   MA_KH                NVARCHAR(50)          NOT NULL,
   MA_GIO_HANG          NVARCHAR(50)          NULL,
   MA_CUA_HANG          NVARCHAR(50)          NULL,
   TEN_KH               NVARCHAR(50)          NULL,
   NGAY_SINH            DATE				 NULL,
   DIA_CHI              NVARCHAR(50)          NULL,
   SDT                  NVARCHAR(20)          NULL,
   EMAIL                NVARCHAR(20)          NULL,
   CONSTRAINT PK_KHACH_HANG PRIMARY KEY (MA_KH)
)
GO

/*==============================================================*/
/* TABLE: SAN_PHAM                                              */
/*==============================================================*/
CREATE TABLE SAN_PHAM (
   MA_SP                INT                  IDENTITY(1,1),
   MA_CUA_HANG          NVARCHAR(50)          NOT NULL,
   TEN_DM               NVARCHAR(50)          NULL,
   TEN_SP               NVARCHAR(50)          NULL,
   GIA_SP               MONEY                NULL,
   SO_LUONG_CON_LAI     INT                  NULL,
   MO_TA                NVARCHAR(2000)        NULL,
   CONSTRAINT PK_SAN_PHAM PRIMARY KEY (MA_SP)
)
GO

/*==============================================================*/
/* TABLE: TAI_KHOAN                                             */
/*==============================================================*/
CREATE TABLE TAI_KHOAN (
   MA_KH                NVARCHAR(50)          NOT NULL,
   MAT_KHAU             NVARCHAR(50)          NOT NULL
)
GO

ALTER TABLE CHI_TIET_DON_HANG
   ADD CONSTRAINT FK_CHI_TIET_CHI_TIET__DANH_SAC FOREIGN KEY (MA_DON_HANG)
      REFERENCES DANH_SACH_DON_HANG (MA_DON_HANG)
GO

ALTER TABLE CHI_TIET_DON_HANG
   ADD CONSTRAINT FK_CHI_TIET_CHI_TIET__SAN_PHAM FOREIGN KEY (MA_SP)
      REFERENCES SAN_PHAM (MA_SP)
GO

ALTER TABLE CHI_TIET_GIO_HANG
   ADD CONSTRAINT FK_CHI_TIET_CHI_TIET__GIO_HANG FOREIGN KEY (MA_GIO_HANG)
      REFERENCES GIO_HANG (MA_GIO_HANG)
GO

ALTER TABLE CHI_TIET_GIO_HANG
   ADD CONSTRAINT FK_CHI_TIET_CHI_TIET__SAN_PHAM2 FOREIGN KEY (MA_SP)
      REFERENCES SAN_PHAM (MA_SP)
GO

ALTER TABLE CUA_HANG
   ADD CONSTRAINT FK_CUA_HANG_RELATIONS_KHACH_HA FOREIGN KEY (MA_KH)
      REFERENCES KHACH_HANG (MA_KH)
GO

ALTER TABLE DANH_SACH_DON_HANG
   ADD CONSTRAINT FK_DANH_SAC_RELATIONS_CUA_HANG FOREIGN KEY (MA_CUA_HANG)
      REFERENCES CUA_HANG (MA_CUA_HANG)
GO

ALTER TABLE DANH_SACH_DON_HANG
   ADD CONSTRAINT FK_DANH_SAC_RELATIONS_KHACH_HA FOREIGN KEY (MA_KH)
      REFERENCES KHACH_HANG (MA_KH)
GO

ALTER TABLE GIO_HANG
   ADD CONSTRAINT FK_GIO_HANG_RELATIONS_KHACH_HA FOREIGN KEY (MA_KH)
      REFERENCES KHACH_HANG (MA_KH)
GO

ALTER TABLE KHACH_HANG
   ADD CONSTRAINT FK_KHACH_HA_RELATIONS_CUA_HANG FOREIGN KEY (MA_CUA_HANG)
      REFERENCES CUA_HANG (MA_CUA_HANG)
GO

ALTER TABLE KHACH_HANG
   ADD CONSTRAINT FK_KHACH_HA_RELATIONS_GIO_HANG FOREIGN KEY (MA_GIO_HANG)
      REFERENCES GIO_HANG (MA_GIO_HANG)
GO

ALTER TABLE SAN_PHAM
   ADD CONSTRAINT FK_SAN_PHAM_RELATIONS_DANH_MUC FOREIGN KEY (TEN_DM)
      REFERENCES DANH_MUC (TEN_DM)
GO

ALTER TABLE SAN_PHAM
   ADD CONSTRAINT FK_SAN_PHAM_RELATIONS_CUA_HANG FOREIGN KEY (MA_CUA_HANG)
      REFERENCES CUA_HANG (MA_CUA_HANG)
GO

ALTER TABLE TAI_KHOAN
   ADD CONSTRAINT FK_TAI_KHOA_RELATIONS_KHACH_HA FOREIGN KEY (MA_KH)
      REFERENCES KHACH_HANG (MA_KH)
GO

