USE [ARGOPOS]
GO
/****** Object:  Table [dbo].[pos_customer]    Script Date: 7/29/2018 9:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pos_customer](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[customername] [varchar](200) NOT NULL,
	[customeraddrees] [varchar](200) NOT NULL,
	[customercontact] [int] NOT NULL,
	[loyaltypoint] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_pos_customer] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pos_grnheader]    Script Date: 7/29/2018 9:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pos_grnheader](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[number] [varchar](10) NOT NULL,
	[time] [datetime] NOT NULL,
	[suplier] [int] NOT NULL,
	[total] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_pos_grnheader] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [IX_pos_grnheader] UNIQUE NONCLUSTERED 
(
	[number] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = ON, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pos_grnitem]    Script Date: 7/29/2018 9:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pos_grnitem](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[itemid] [int] NOT NULL,
	[itemquntity] [decimal](18, 2) NOT NULL,
	[itemcost] [decimal](18, 2) NOT NULL,
	[grnid] [int] NOT NULL,
 CONSTRAINT [PK_pos_grnitem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pos_item]    Script Date: 7/29/2018 9:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pos_item](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[itemname] [varchar](50) NOT NULL,
	[unit] [int] NOT NULL,
	[discreption] [nvarchar](50) NOT NULL,
	[itemcategory] [int] NOT NULL,
	[stock] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_pos_item] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pos_itemcategory]    Script Date: 7/29/2018 9:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pos_itemcategory](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[category] [varchar](50) NOT NULL,
 CONSTRAINT [PK_pos_category] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pos_itemstock]    Script Date: 7/29/2018 9:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pos_itemstock](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[initalstock] [decimal](18, 2) NOT NULL,
	[grnid] [int] NOT NULL,
	[curentstock] [decimal](18, 2) NOT NULL,
	[stockcost] [decimal](18, 2) NOT NULL,
	[itemcost] [decimal](18, 2) NULL,
	[stocknumber] [nchar](10) NULL,
	[itemid] [int] NULL,
 CONSTRAINT [PK_pos_itemS] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pos_role]    Script Date: 7/29/2018 9:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pos_role](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[role] [varchar](10) NOT NULL,
 CONSTRAINT [PK_pos_role] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pos_sales]    Script Date: 7/29/2018 9:41:18 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pos_sales](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[salesnumber] [nchar](10) NOT NULL,
	[time] [datetime] NOT NULL,
	[customerid] [int] NOT NULL,
	[total] [decimal](18, 2) NOT NULL,
	[loyltypoint] [decimal](18, 2) NULL,
 CONSTRAINT [PK_pos_sales] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pos_salesitem]    Script Date: 7/29/2018 9:41:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pos_salesitem](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[salesid] [int] NOT NULL,
	[itemid] [int] NOT NULL,
	[itemprice] [decimal](18, 2) NOT NULL,
	[itemqty] [decimal](18, 2) NOT NULL,
	[itemcost] [decimal](18, 2) NULL,
 CONSTRAINT [PK_pos_salesitem] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pos_supplier]    Script Date: 7/29/2018 9:41:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pos_supplier](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[suppliernmae] [varchar](200) NOT NULL,
	[suppliercontact] [int] NOT NULL,
	[suppliersddress] [varchar](200) NOT NULL,
 CONSTRAINT [PK_pos_supplier] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [pos_supplier_uk] UNIQUE NONCLUSTERED 
(
	[suppliernmae] ASC,
	[suppliercontact] ASC,
	[suppliersddress] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pos_unit]    Script Date: 7/29/2018 9:41:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pos_unit](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[unit] [nchar](10) NOT NULL,
	[name] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Table_1] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[pos_user]    Script Date: 7/29/2018 9:41:19 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[pos_user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](200) NOT NULL,
	[password] [varchar](200) NOT NULL,
	[role] [int] NOT NULL,
 CONSTRAINT [PK_pos_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[pos_grnheader]  WITH CHECK ADD  CONSTRAINT [FK_pos_grnheader_pos_supplier] FOREIGN KEY([suplier])
REFERENCES [dbo].[pos_supplier] ([id])
GO
ALTER TABLE [dbo].[pos_grnheader] CHECK CONSTRAINT [FK_pos_grnheader_pos_supplier]
GO
ALTER TABLE [dbo].[pos_grnitem]  WITH CHECK ADD  CONSTRAINT [FK_pos_grnitem_pos_grnheader] FOREIGN KEY([grnid])
REFERENCES [dbo].[pos_grnheader] ([id])
GO
ALTER TABLE [dbo].[pos_grnitem] CHECK CONSTRAINT [FK_pos_grnitem_pos_grnheader]
GO
ALTER TABLE [dbo].[pos_itemstock]  WITH CHECK ADD  CONSTRAINT [FK_pos_itemstock_pos_grnheader] FOREIGN KEY([grnid])
REFERENCES [dbo].[pos_grnheader] ([id])
GO
ALTER TABLE [dbo].[pos_itemstock] CHECK CONSTRAINT [FK_pos_itemstock_pos_grnheader]
GO
ALTER TABLE [dbo].[pos_itemstock]  WITH CHECK ADD  CONSTRAINT [FK_pos_itemstock_pos_item] FOREIGN KEY([itemid])
REFERENCES [dbo].[pos_item] ([id])
GO
ALTER TABLE [dbo].[pos_itemstock] CHECK CONSTRAINT [FK_pos_itemstock_pos_item]
GO
ALTER TABLE [dbo].[pos_sales]  WITH CHECK ADD  CONSTRAINT [FK_pos_sales_pos_customer] FOREIGN KEY([customerid])
REFERENCES [dbo].[pos_customer] ([id])
GO
ALTER TABLE [dbo].[pos_sales] CHECK CONSTRAINT [FK_pos_sales_pos_customer]
GO
ALTER TABLE [dbo].[pos_salesitem]  WITH CHECK ADD  CONSTRAINT [FK_pos_salesitem_pos_sales] FOREIGN KEY([salesid])
REFERENCES [dbo].[pos_sales] ([id])
GO
ALTER TABLE [dbo].[pos_salesitem] CHECK CONSTRAINT [FK_pos_salesitem_pos_sales]
GO
ALTER TABLE [dbo].[pos_user]  WITH CHECK ADD  CONSTRAINT [FK_pos_user_pos_role] FOREIGN KEY([role])
REFERENCES [dbo].[pos_role] ([id])
GO
ALTER TABLE [dbo].[pos_user] CHECK CONSTRAINT [FK_pos_user_pos_role]
GO
