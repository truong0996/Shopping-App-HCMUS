use QuanLyBanHang
go

-- Tạo non-clustered index trên mã sản phẩm
CREATE NONCLUSTERED INDEX MA_SP_INDEX
	ON SAN_PHAM(MA_SP)

-- Tạo non-clustered index trên tên danh mục
CREATE NONCLUSTERED INDEX MA_DM_INDEX
	ON DANH_MUC(TEN_DM)



