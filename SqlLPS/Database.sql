USE [LPS]
GO
/****** Object:  Table [dbo].[Product]    Script Date: 10/1/2023 5:55:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[nama_barang] [varchar](200) NOT NULL,
	[kode_barang] [varchar](50) NOT NULL,
	[jumlah_barang] [int] NOT NULL,
	[tanggal] [datetime] NOT NULL,
 CONSTRAINT [PK_Product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Delete_Data]    Script Date: 10/1/2023 5:55:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[Delete_Data]
(
@id int
)
AS
BEGIN
Delete From Product
where id=@id
END
GO
/****** Object:  StoredProcedure [dbo].[Insert_Data]    Script Date: 10/1/2023 5:55:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[Insert_Data]
(
@nama_barang varchar(200),
@kode_barang varchar(50),
@jumlah_barang int,
@tanggal Datetime
)
AS
BEGIN
INsert INto Product (nama_barang,kode_barang,jumlah_barang,tanggal) values (@nama_barang,@kode_barang,@jumlah_barang,@tanggal)
END
GO
/****** Object:  StoredProcedure [dbo].[Search_Data]    Script Date: 10/1/2023 5:55:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE Procedure [dbo].[Search_Data]
(
@searchdata varchar(max)
)
as
Begin

	Select * from Product where 
	id like '%' + ISNULL(@searchdata,'') + '%'
	OR nama_barang like '%' +  ISNULL(@searchdata,'') + '%'
	OR jumlah_barang like '%' +  ISNULL(@searchdata,0) + '%'
	OR kode_barang like '%' +  ISNULL(@searchdata,'') + '%' 
	OR CONVERT(DATE,tanggal) like '%' + @searchdata + '%'
END
GO
/****** Object:  StoredProcedure [dbo].[Update_Data]    Script Date: 10/1/2023 5:55:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create Procedure [dbo].[Update_Data]
(
@id int,
@nama_barang varchar(200),
@kode_barang varchar(50),
@jumlah_barang int,
@tanggal Datetime
)
AS
BEGIN
Update Product set nama_barang=@nama_barang,kode_barang=@kode_barang,jumlah_barang=@jumlah_barang,tanggal=@tanggal
where id=@id
END
GO
