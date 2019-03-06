SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[m_bag_type](
	[bagId] [int] NOT NULL,
	[bagName] [nvarchar](50) NULL,
	[bagDesc] [nvarchar](200) NULL,
	[enterBy] [int] NULL,
	[enterDate] [smalldatetime] NULL,
	[updateBy] [int] NULL,
	[updateDate] [smalldatetime] NULL,
	[active] [bit] NULL,
	[bag_category_no] [smallint] NULL,
	[per_bag_wt] [numeric](9, 2) NOT NULL,
 CONSTRAINT [PK_m_bag_type] PRIMARY KEY CLUSTERED 
(
	[bagId] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY],
 CONSTRAINT [UQ_BagName] UNIQUE NONCLUSTERED 
(
	[bagName] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[m_bag_type] ADD  CONSTRAINT [DF_m_bag_type_active]  DEFAULT ((1)) FOR [active]
GO

ALTER TABLE [dbo].[m_bag_type] ADD  CONSTRAINT [DF_m_bag_type_per_bag_wt]  DEFAULT ((0)) FOR [per_bag_wt]
GO


INSERT [dbo].[m_bag_type] ([bagId], [bagName], [bagDesc], [enterBy], [enterDate], [updateBy], [updateDate], [active], [bag_category_no], [per_bag_wt]) VALUES (0, N'Test Bag Name', N'Test Description', 1, CAST(0xA9E5000C AS SmallDateTime), 1, CAST(0xA9E5029F AS SmallDateTime), 1, 1, CAST(1.00 AS Numeric(9, 2)))
INSERT [dbo].[m_bag_type] ([bagId], [bagName], [bagDesc], [enterBy], [enterDate], [updateBy], [updateDate], [active], [bag_category_no], [per_bag_wt]) VALUES (1, N'BG Name # 1', N'BG Desc # 1', 2, CAST(0xA59C0000 AS SmallDateTime), 238, CAST(0xA6E4025F AS SmallDateTime), 1, 3, CAST(6.00 AS Numeric(9, 2)))
INSERT [dbo].[m_bag_type] ([bagId], [bagName], [bagDesc], [enterBy], [enterDate], [updateBy], [updateDate], [active], [bag_category_no], [per_bag_wt]) VALUES (2, N'bg name 2', N'bg desc 2', 2, CAST(0xA59C0264 AS SmallDateTime), 138, CAST(0xA59C026E AS SmallDateTime), 0, 1, CAST(0.00 AS Numeric(9, 2)))
INSERT [dbo].[m_bag_type] ([bagId], [bagName], [bagDesc], [enterBy], [enterDate], [updateBy], [updateDate], [active], [bag_category_no], [per_bag_wt]) VALUES (3, N'Medium Parachute-HTFC', N'Parachute bags , medium size for hand, face, KT, wash cloth, OL ', 138, CAST(0xA59C0000 AS SmallDateTime), 27, CAST(0xA67502D1 AS SmallDateTime), 1, 1, CAST(0.00 AS Numeric(9, 2)))
INSERT [dbo].[m_bag_type] ([bagId], [bagName], [bagDesc], [enterBy], [enterDate], [updateBy], [updateDate], [active], [bag_category_no], [per_bag_wt]) VALUES (4, N'Large Parachute-BT', N'Parachute bags , large size for bath towel or bath sheet', 27, CAST(0xA6630358 AS SmallDateTime), 104, CAST(0xA70002CC AS SmallDateTime), 1, 1, CAST(0.16 AS Numeric(9, 2)))
INSERT [dbo].[m_bag_type] ([bagId], [bagName], [bagDesc], [enterBy], [enterDate], [updateBy], [updateDate], [active], [bag_category_no], [per_bag_wt]) VALUES (5, N'Poly bag for bath towel.', N'Poly bag for bath towel packing', 104, CAST(0xA72902D9 AS SmallDateTime), NULL, NULL, 1, 2, CAST(0.19 AS Numeric(9, 2)))
INSERT [dbo].[m_bag_type] ([bagId], [bagName], [bagDesc], [enterBy], [enterDate], [updateBy], [updateDate], [active], [bag_category_no], [per_bag_wt]) VALUES (6, N'Poly bag Hand Towel', N'Poly bag Hand Towel', 104, CAST(0xA72902D9 AS SmallDateTime), 104, CAST(0xA72F0228 AS SmallDateTime), 1, 2, CAST(0.10 AS Numeric(9, 2)))
INSERT [dbo].[m_bag_type] ([bagId], [bagName], [bagDesc], [enterBy], [enterDate], [updateBy], [updateDate], [active], [bag_category_no], [per_bag_wt]) VALUES (7, N'Transparent Bags for FC , WC & HT', N'Transparent Bags for FC , WC & HT', 390, CAST(0xA8BE03AE AS SmallDateTime), 390, CAST(0xA8BE03D1 AS SmallDateTime), 1, 3, CAST(0.09 AS Numeric(9, 2)))
INSERT [dbo].[m_bag_type] ([bagId], [bagName], [bagDesc], [enterBy], [enterDate], [updateBy], [updateDate], [active], [bag_category_no], [per_bag_wt]) VALUES (8, N'Transparent Bags for BT and BS', N'Transparent Bags for BT and BS', 390, CAST(0xA8BE03AE AS SmallDateTime), 390, CAST(0xA8BE03D1 AS SmallDateTime), 1, 3, CAST(0.12 AS Numeric(9, 2)))
INSERT [dbo].[m_bag_type] ([bagId], [bagName], [bagDesc], [enterBy], [enterDate], [updateBy], [updateDate], [active], [bag_category_no], [per_bag_wt]) VALUES (9, N'Test Bag 2', N'Test Bag 2', 1, CAST(0xA9E502B3 AS SmallDateTime), 339, CAST(0xA9E5044E AS SmallDateTime), 1, 1, CAST(0.00 AS Numeric(9, 2)))
INSERT [dbo].[m_bag_type] ([bagId], [bagName], [bagDesc], [enterBy], [enterDate], [updateBy], [updateDate], [active], [bag_category_no], [per_bag_wt]) VALUES (10, N'10p bag', N'new bag', 339, CAST(0xA9E6032E AS SmallDateTime), NULL, NULL, 1, 1, CAST(44.00 AS Numeric(9, 2)))
INSERT [dbo].[m_bag_type] ([bagId], [bagName], [bagDesc], [enterBy], [enterDate], [updateBy], [updateDate], [active], [bag_category_no], [per_bag_wt]) VALUES (11, N'10 bag big', N'new bag', 339, CAST(0xA9E60335 AS SmallDateTime), NULL, NULL, 1, 1, CAST(78.00 AS Numeric(9, 2)))
INSERT [dbo].[m_bag_type] ([bagId], [bagName], [bagDesc], [enterBy], [enterDate], [updateBy], [updateDate], [active], [bag_category_no], [per_bag_wt]) VALUES (12, N'new bag', N'bag', 339, CAST(0xA9E702A6 AS SmallDateTime), NULL, NULL, 1, 1, CAST(44.00 AS Numeric(9, 2)))
