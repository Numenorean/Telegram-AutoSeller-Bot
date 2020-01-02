using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace TelegramBotBankStore.Languages
{
	// Token: 0x020000D8 RID: 216
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
	[DebuggerNonUserCode]
	[CompilerGenerated]
	internal class Language
	{
		// Token: 0x06000455 RID: 1109 RVA: 0x00002308 File Offset: 0x00000508
		internal Language()
		{
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x06000456 RID: 1110 RVA: 0x000425F0 File Offset: 0x000407F0
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				bool flag = Language.resourceMan == null;
				if (flag)
				{
					ResourceManager resourceManager = new ResourceManager("TelegramBotBankStore.Languages.Language", typeof(Language).Assembly);
					Language.resourceMan = resourceManager;
				}
				return Language.resourceMan;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000457 RID: 1111 RVA: 0x00042638 File Offset: 0x00040838
		// (set) Token: 0x06000458 RID: 1112 RVA: 0x000036A4 File Offset: 0x000018A4
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Language.resourceCulture;
			}
			set
			{
				Language.resourceCulture = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000459 RID: 1113 RVA: 0x00042650 File Offset: 0x00040850
		internal static string ActualCourse
		{
			get
			{
				return Language.ResourceManager.GetString("ActualCourse", Language.resourceCulture);
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x0600045A RID: 1114 RVA: 0x00042678 File Offset: 0x00040878
		internal static string AddCategory
		{
			get
			{
				return Language.ResourceManager.GetString("AddCategory", Language.resourceCulture);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x0600045B RID: 1115 RVA: 0x000426A0 File Offset: 0x000408A0
		internal static string AdditionalInformation
		{
			get
			{
				return Language.ResourceManager.GetString("AdditionalInformation", Language.resourceCulture);
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x0600045C RID: 1116 RVA: 0x000426C8 File Offset: 0x000408C8
		internal static string AdditionalInformationUnavailable
		{
			get
			{
				return Language.ResourceManager.GetString("AdditionalInformationUnavailable", Language.resourceCulture);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x0600045D RID: 1117 RVA: 0x000426F0 File Offset: 0x000408F0
		internal static string AddPosition
		{
			get
			{
				return Language.ResourceManager.GetString("AddPosition", Language.resourceCulture);
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600045E RID: 1118 RVA: 0x00042718 File Offset: 0x00040918
		internal static string AddProduct
		{
			get
			{
				return Language.ResourceManager.GetString("AddProduct", Language.resourceCulture);
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600045F RID: 1119 RVA: 0x00042740 File Offset: 0x00040940
		internal static string Address
		{
			get
			{
				return Language.ResourceManager.GetString("Address", Language.resourceCulture);
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x06000460 RID: 1120 RVA: 0x00042768 File Offset: 0x00040968
		internal static string Admin
		{
			get
			{
				return Language.ResourceManager.GetString("Admin", Language.resourceCulture);
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x00042790 File Offset: 0x00040990
		internal static string Amount
		{
			get
			{
				return Language.ResourceManager.GetString("Amount", Language.resourceCulture);
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000462 RID: 1122 RVA: 0x000427B8 File Offset: 0x000409B8
		internal static string AmountOfLoad
		{
			get
			{
				return Language.ResourceManager.GetString("AmountOfLoad", Language.resourceCulture);
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x000427E0 File Offset: 0x000409E0
		internal static string AmountOfSpend
		{
			get
			{
				return Language.ResourceManager.GetString("AmountOfSpend", Language.resourceCulture);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x06000464 RID: 1124 RVA: 0x00042808 File Offset: 0x00040A08
		internal static string AmountQuantityIsNotRigth
		{
			get
			{
				return Language.ResourceManager.GetString("AmountQuantityIsNotRigth", Language.resourceCulture);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x00042830 File Offset: 0x00040A30
		internal static string AmountToLoad
		{
			get
			{
				return Language.ResourceManager.GetString("AmountToLoad", Language.resourceCulture);
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x00042858 File Offset: 0x00040A58
		internal static string AvailablePositions
		{
			get
			{
				return Language.ResourceManager.GetString("AvailablePositions", Language.resourceCulture);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x06000467 RID: 1127 RVA: 0x00042880 File Offset: 0x00040A80
		internal static string Back
		{
			get
			{
				return Language.ResourceManager.GetString("Back", Language.resourceCulture);
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x000428A8 File Offset: 0x00040AA8
		internal static string Balance
		{
			get
			{
				return Language.ResourceManager.GetString("Balance", Language.resourceCulture);
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000469 RID: 1129 RVA: 0x000428D0 File Offset: 0x00040AD0
		internal static string BalanceYouWallet
		{
			get
			{
				return Language.ResourceManager.GetString("BalanceYouWallet", Language.resourceCulture);
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x000428F8 File Offset: 0x00040AF8
		internal static string Buy
		{
			get
			{
				return Language.ResourceManager.GetString("Buy", Language.resourceCulture);
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x0600046B RID: 1131 RVA: 0x00042920 File Offset: 0x00040B20
		internal static string BuySuccess
		{
			get
			{
				return Language.ResourceManager.GetString("BuySuccess", Language.resourceCulture);
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x00042948 File Offset: 0x00040B48
		internal static string Cancel
		{
			get
			{
				return Language.ResourceManager.GetString("Cancel", Language.resourceCulture);
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600046D RID: 1133 RVA: 0x00042970 File Offset: 0x00040B70
		internal static string Category
		{
			get
			{
				return Language.ResourceManager.GetString("Category", Language.resourceCulture);
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x00042998 File Offset: 0x00040B98
		internal static string CheckOrderLeftTime
		{
			get
			{
				return Language.ResourceManager.GetString("CheckOrderLeftTime", Language.resourceCulture);
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x000429C0 File Offset: 0x00040BC0
		internal static string Confirm
		{
			get
			{
				return Language.ResourceManager.GetString("Confirm", Language.resourceCulture);
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x000429E8 File Offset: 0x00040BE8
		internal static string ContactSupport
		{
			get
			{
				return Language.ResourceManager.GetString("ContactSupport", Language.resourceCulture);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x00042A10 File Offset: 0x00040C10
		internal static string ConvertTo
		{
			get
			{
				return Language.ResourceManager.GetString("ConvertTo", Language.resourceCulture);
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x06000472 RID: 1138 RVA: 0x00042A38 File Offset: 0x00040C38
		internal static string Date
		{
			get
			{
				return Language.ResourceManager.GetString("Date", Language.resourceCulture);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x00042A60 File Offset: 0x00040C60
		internal static string DeleteCategory
		{
			get
			{
				return Language.ResourceManager.GetString("DeleteCategory", Language.resourceCulture);
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x00042A88 File Offset: 0x00040C88
		internal static string DeleteProduct
		{
			get
			{
				return Language.ResourceManager.GetString("DeleteProduct", Language.resourceCulture);
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x00042AB0 File Offset: 0x00040CB0
		internal static string Discount
		{
			get
			{
				return Language.ResourceManager.GetString("Discount", Language.resourceCulture);
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000476 RID: 1142 RVA: 0x00042AD8 File Offset: 0x00040CD8
		internal static string EditCategory
		{
			get
			{
				return Language.ResourceManager.GetString("EditCategory", Language.resourceCulture);
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x00042B00 File Offset: 0x00040D00
		internal static string EditProduct
		{
			get
			{
				return Language.ResourceManager.GetString("EditProduct", Language.resourceCulture);
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000478 RID: 1144 RVA: 0x00042B28 File Offset: 0x00040D28
		internal static string EnterAmountToBuy
		{
			get
			{
				return Language.ResourceManager.GetString("EnterAmountToBuy", Language.resourceCulture);
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x00042B50 File Offset: 0x00040D50
		internal static string EnterCategoryName
		{
			get
			{
				return Language.ResourceManager.GetString("EnterCategoryName", Language.resourceCulture);
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x00042B78 File Offset: 0x00040D78
		internal static string EnterExmoCode
		{
			get
			{
				return Language.ResourceManager.GetString("EnterExmoCode", Language.resourceCulture);
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x00042BA0 File Offset: 0x00040DA0
		internal static string EnterLogin
		{
			get
			{
				return Language.ResourceManager.GetString("EnterLogin", Language.resourceCulture);
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x00042BC8 File Offset: 0x00040DC8
		internal static string EnterPassword
		{
			get
			{
				return Language.ResourceManager.GetString("EnterPassword", Language.resourceCulture);
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00042BF0 File Offset: 0x00040DF0
		internal static string EnterProductName
		{
			get
			{
				return Language.ResourceManager.GetString("EnterProductName", Language.resourceCulture);
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x00042C18 File Offset: 0x00040E18
		internal static string EnterProductPrice
		{
			get
			{
				return Language.ResourceManager.GetString("EnterProductPrice", Language.resourceCulture);
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x0600047F RID: 1151 RVA: 0x00042C40 File Offset: 0x00040E40
		internal static string EnterProductType
		{
			get
			{
				return Language.ResourceManager.GetString("EnterProductType", Language.resourceCulture);
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x00042C68 File Offset: 0x00040E68
		internal static string EnterProductValue
		{
			get
			{
				return Language.ResourceManager.GetString("EnterProductValue", Language.resourceCulture);
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000481 RID: 1153 RVA: 0x00042C90 File Offset: 0x00040E90
		internal static string ErrorConfirmTheOrder
		{
			get
			{
				return Language.ResourceManager.GetString("ErrorConfirmTheOrder", Language.resourceCulture);
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00042CB8 File Offset: 0x00040EB8
		internal static string HereIsYorLastOrders
		{
			get
			{
				return Language.ResourceManager.GetString("HereIsYorLastOrders", Language.resourceCulture);
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000483 RID: 1155 RVA: 0x00042CE0 File Offset: 0x00040EE0
		internal static string History
		{
			get
			{
				return Language.ResourceManager.GetString("History", Language.resourceCulture);
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x00042D08 File Offset: 0x00040F08
		internal static string IPaid
		{
			get
			{
				return Language.ResourceManager.GetString("IPaid", Language.resourceCulture);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x00042D30 File Offset: 0x00040F30
		internal static string IPaiedForBTC
		{
			get
			{
				return Language.ResourceManager.GetString("IPaiedForBTC", Language.resourceCulture);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x00042D58 File Offset: 0x00040F58
		internal static string IPaiedForCard
		{
			get
			{
				return Language.ResourceManager.GetString("IPaiedForCard", Language.resourceCulture);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000487 RID: 1159 RVA: 0x00042D80 File Offset: 0x00040F80
		internal static string IPaiedForLTC
		{
			get
			{
				return Language.ResourceManager.GetString("IPaiedForLTC", Language.resourceCulture);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x00042DA8 File Offset: 0x00040FA8
		internal static string IPaiedForOneMore
		{
			get
			{
				return Language.ResourceManager.GetString("IPaiedForOneMore", Language.resourceCulture);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00042DD0 File Offset: 0x00040FD0
		internal static string IPaiedForQiwi
		{
			get
			{
				return Language.ResourceManager.GetString("IPaiedForQiwi", Language.resourceCulture);
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600048A RID: 1162 RVA: 0x00042DF8 File Offset: 0x00040FF8
		internal static string IPaiedWait
		{
			get
			{
				return Language.ResourceManager.GetString("IPaiedWait", Language.resourceCulture);
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x00042E20 File Offset: 0x00041020
		internal static string Load
		{
			get
			{
				return Language.ResourceManager.GetString("Load", Language.resourceCulture);
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x0600048C RID: 1164 RVA: 0x00042E48 File Offset: 0x00041048
		internal static string Load_Card
		{
			get
			{
				return Language.ResourceManager.GetString("Load_Card", Language.resourceCulture);
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x0600048D RID: 1165 RVA: 0x00042E70 File Offset: 0x00041070
		internal static string Load_Exmo
		{
			get
			{
				return Language.ResourceManager.GetString("Load_Exmo", Language.resourceCulture);
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x00042E98 File Offset: 0x00041098
		internal static string Load_LTC
		{
			get
			{
				return Language.ResourceManager.GetString("Load_LTC", Language.resourceCulture);
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600048F RID: 1167 RVA: 0x00042EC0 File Offset: 0x000410C0
		internal static string Load_Qiwi
		{
			get
			{
				return Language.ResourceManager.GetString("Load_Qiwi", Language.resourceCulture);
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000490 RID: 1168 RVA: 0x00042EE8 File Offset: 0x000410E8
		internal static string Load_Tele2
		{
			get
			{
				return Language.ResourceManager.GetString("Load_Tele2", Language.resourceCulture);
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000491 RID: 1169 RVA: 0x00042F10 File Offset: 0x00041110
		internal static string Load_Yandex
		{
			get
			{
				return Language.ResourceManager.GetString("Load_Yandex", Language.resourceCulture);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000492 RID: 1170 RVA: 0x00042F38 File Offset: 0x00041138
		internal static string LoadCard
		{
			get
			{
				return Language.ResourceManager.GetString("LoadCard", Language.resourceCulture);
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000493 RID: 1171 RVA: 0x00042F60 File Offset: 0x00041160
		internal static string LoadCard2
		{
			get
			{
				return Language.ResourceManager.GetString("LoadCard2", Language.resourceCulture);
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000494 RID: 1172 RVA: 0x00042F88 File Offset: 0x00041188
		internal static string LoadTele2
		{
			get
			{
				return Language.ResourceManager.GetString("LoadTele2", Language.resourceCulture);
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000495 RID: 1173 RVA: 0x00042FB0 File Offset: 0x000411B0
		internal static string MainButtonAvailability
		{
			get
			{
				return Language.ResourceManager.GetString("MainButtonAvailability", Language.resourceCulture);
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000496 RID: 1174 RVA: 0x00042FD8 File Offset: 0x000411D8
		internal static string MainButtonStatistics
		{
			get
			{
				return Language.ResourceManager.GetString("MainButtonStatistics", Language.resourceCulture);
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000497 RID: 1175 RVA: 0x00043000 File Offset: 0x00041200
		internal static string Method
		{
			get
			{
				return Language.ResourceManager.GetString("Method", Language.resourceCulture);
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000498 RID: 1176 RVA: 0x00043028 File Offset: 0x00041228
		internal static string MultiplePosition
		{
			get
			{
				return Language.ResourceManager.GetString("MultiplePosition", Language.resourceCulture);
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000499 RID: 1177 RVA: 0x00043050 File Offset: 0x00041250
		internal static string Name
		{
			get
			{
				return Language.ResourceManager.GetString("Name", Language.resourceCulture);
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x0600049A RID: 1178 RVA: 0x00043078 File Offset: 0x00041278
		internal static string NoProduct
		{
			get
			{
				return Language.ResourceManager.GetString("NoProduct", Language.resourceCulture);
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x0600049B RID: 1179 RVA: 0x000430A0 File Offset: 0x000412A0
		internal static string NotEnoughMoney
		{
			get
			{
				return Language.ResourceManager.GetString("NotEnoughMoney", Language.resourceCulture);
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x000430C8 File Offset: 0x000412C8
		internal static string NotEnoughPosition
		{
			get
			{
				return Language.ResourceManager.GetString("NotEnoughPosition", Language.resourceCulture);
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600049D RID: 1181 RVA: 0x000430F0 File Offset: 0x000412F0
		internal static string NotFound
		{
			get
			{
				return Language.ResourceManager.GetString("NotFound", Language.resourceCulture);
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x00043118 File Offset: 0x00041318
		internal static string NotFoundConfirmed
		{
			get
			{
				return Language.ResourceManager.GetString("NotFoundConfirmed", Language.resourceCulture);
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x0600049F RID: 1183 RVA: 0x00043140 File Offset: 0x00041340
		internal static string NotFoundText
		{
			get
			{
				return Language.ResourceManager.GetString("NotFoundText", Language.resourceCulture);
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x00043168 File Offset: 0x00041368
		internal static string NotFoundYourStatistic
		{
			get
			{
				return Language.ResourceManager.GetString("NotFoundYourStatistic", Language.resourceCulture);
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060004A1 RID: 1185 RVA: 0x00043190 File Offset: 0x00041390
		internal static string OrderCanceled
		{
			get
			{
				return Language.ResourceManager.GetString("OrderCanceled", Language.resourceCulture);
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x000431B8 File Offset: 0x000413B8
		internal static string OrderHistory
		{
			get
			{
				return Language.ResourceManager.GetString("OrderHistory", Language.resourceCulture);
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060004A3 RID: 1187 RVA: 0x000431E0 File Offset: 0x000413E0
		internal static string PayFromWallet
		{
			get
			{
				return Language.ResourceManager.GetString("PayFromWallet", Language.resourceCulture);
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x00043208 File Offset: 0x00041408
		internal static string PayToCard
		{
			get
			{
				return Language.ResourceManager.GetString("PayToCard", Language.resourceCulture);
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060004A5 RID: 1189 RVA: 0x00043230 File Offset: 0x00041430
		internal static string PayWithReserve
		{
			get
			{
				return Language.ResourceManager.GetString("PayWithReserve", Language.resourceCulture);
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x00043258 File Offset: 0x00041458
		internal static string PleaseEnterAMessage
		{
			get
			{
				return Language.ResourceManager.GetString("PleaseEnterAMessage", Language.resourceCulture);
			}
		}

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x00043280 File Offset: 0x00041480
		internal static string PleaseEnterExmoCode
		{
			get
			{
				return Language.ResourceManager.GetString("PleaseEnterExmoCode", Language.resourceCulture);
			}
		}

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x000432A8 File Offset: 0x000414A8
		internal static string Product
		{
			get
			{
				return Language.ResourceManager.GetString("Product", Language.resourceCulture);
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x060004A9 RID: 1193 RVA: 0x000432D0 File Offset: 0x000414D0
		internal static string PromoCode
		{
			get
			{
				return Language.ResourceManager.GetString("PromoCode", Language.resourceCulture);
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x000432F8 File Offset: 0x000414F8
		internal static string PromoCodeDiscount
		{
			get
			{
				return Language.ResourceManager.GetString("PromoCodeDiscount", Language.resourceCulture);
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060004AB RID: 1195 RVA: 0x00043320 File Offset: 0x00041520
		internal static string PromoCodeIsNotValid
		{
			get
			{
				return Language.ResourceManager.GetString("PromoCodeIsNotValid", Language.resourceCulture);
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x00043348 File Offset: 0x00041548
		internal static string PromoCodePleaseEnter
		{
			get
			{
				return Language.ResourceManager.GetString("PromoCodePleaseEnter", Language.resourceCulture);
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x060004AD RID: 1197 RVA: 0x00043370 File Offset: 0x00041570
		internal static string PromoCodeToWalletApplied
		{
			get
			{
				return Language.ResourceManager.GetString("PromoCodeToWalletApplied", Language.resourceCulture);
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x00043398 File Offset: 0x00041598
		internal static string PromoCodeWillBeApplied
		{
			get
			{
				return Language.ResourceManager.GetString("PromoCodeWillBeApplied", Language.resourceCulture);
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x060004AF RID: 1199 RVA: 0x000433C0 File Offset: 0x000415C0
		internal static string QiwiAttentionWithoutComment
		{
			get
			{
				return Language.ResourceManager.GetString("QiwiAttentionWithoutComment", Language.resourceCulture);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x000433E8 File Offset: 0x000415E8
		internal static string QiwiNumberFromPaid
		{
			get
			{
				return Language.ResourceManager.GetString("QiwiNumberFromPaid", Language.resourceCulture);
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00043410 File Offset: 0x00041610
		internal static string QiwiPayToOrder
		{
			get
			{
				return Language.ResourceManager.GetString("QiwiPayToOrder", Language.resourceCulture);
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x060004B2 RID: 1202 RVA: 0x00043438 File Offset: 0x00041638
		internal static string QiwiPayToWallet
		{
			get
			{
				return Language.ResourceManager.GetString("QiwiPayToWallet", Language.resourceCulture);
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00043460 File Offset: 0x00041660
		internal static string QiwiTransferToWallet
		{
			get
			{
				return Language.ResourceManager.GetString("QiwiTransferToWallet", Language.resourceCulture);
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x060004B4 RID: 1204 RVA: 0x00043488 File Offset: 0x00041688
		internal static string QiwiWaitForTransaction
		{
			get
			{
				return Language.ResourceManager.GetString("QiwiWaitForTransaction", Language.resourceCulture);
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x060004B5 RID: 1205 RVA: 0x000434B0 File Offset: 0x000416B0
		internal static string QiwiWaitForTransactionWallwet
		{
			get
			{
				return Language.ResourceManager.GetString("QiwiWaitForTransactionWallwet", Language.resourceCulture);
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x000434D8 File Offset: 0x000416D8
		internal static string QiwiWithComment
		{
			get
			{
				return Language.ResourceManager.GetString("QiwiWithComment", Language.resourceCulture);
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x00043500 File Offset: 0x00041700
		internal static string QuantityIsNotAvailable
		{
			get
			{
				return Language.ResourceManager.GetString("QuantityIsNotAvailable", Language.resourceCulture);
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x060004B8 RID: 1208 RVA: 0x00043528 File Offset: 0x00041728
		internal static string Refferal
		{
			get
			{
				return Language.ResourceManager.GetString("Refferal", Language.resourceCulture);
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x00043550 File Offset: 0x00041750
		internal static string RefferalGet
		{
			get
			{
				return Language.ResourceManager.GetString("RefferalGet", Language.resourceCulture);
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00043578 File Offset: 0x00041778
		internal static string RefferalSumGet
		{
			get
			{
				return Language.ResourceManager.GetString("RefferalSumGet", Language.resourceCulture);
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060004BB RID: 1211 RVA: 0x000435A0 File Offset: 0x000417A0
		internal static string RefferalYours
		{
			get
			{
				return Language.ResourceManager.GetString("RefferalYours", Language.resourceCulture);
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060004BC RID: 1212 RVA: 0x000435C8 File Offset: 0x000417C8
		internal static string RefundPolicy
		{
			get
			{
				return Language.ResourceManager.GetString("RefundPolicy", Language.resourceCulture);
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060004BD RID: 1213 RVA: 0x000435F0 File Offset: 0x000417F0
		internal static string RemoveCategory
		{
			get
			{
				return Language.ResourceManager.GetString("RemoveCategory", Language.resourceCulture);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x060004BE RID: 1214 RVA: 0x00043618 File Offset: 0x00041818
		internal static string Review
		{
			get
			{
				return Language.ResourceManager.GetString("Review", Language.resourceCulture);
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x060004BF RID: 1215 RVA: 0x00043640 File Offset: 0x00041840
		internal static string SelectPaymentMethod
		{
			get
			{
				return Language.ResourceManager.GetString("SelectPaymentMethod", Language.resourceCulture);
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x00043668 File Offset: 0x00041868
		internal static string Shop
		{
			get
			{
				return Language.ResourceManager.GetString("Shop", Language.resourceCulture);
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x060004C1 RID: 1217 RVA: 0x00043690 File Offset: 0x00041890
		internal static string SinglePosition
		{
			get
			{
				return Language.ResourceManager.GetString("SinglePosition", Language.resourceCulture);
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x000436B8 File Offset: 0x000418B8
		internal static string Store
		{
			get
			{
				return Language.ResourceManager.GetString("Store", Language.resourceCulture);
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x000436E0 File Offset: 0x000418E0
		internal static string String1
		{
			get
			{
				return Language.ResourceManager.GetString("String1", Language.resourceCulture);
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x060004C4 RID: 1220 RVA: 0x00043708 File Offset: 0x00041908
		internal static string Sum
		{
			get
			{
				return Language.ResourceManager.GetString("Sum", Language.resourceCulture);
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x00043730 File Offset: 0x00041930
		internal static string SumToBePaid
		{
			get
			{
				return Language.ResourceManager.GetString("SumToBePaid", Language.resourceCulture);
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x060004C6 RID: 1222 RVA: 0x00043758 File Offset: 0x00041958
		internal static string Support
		{
			get
			{
				return Language.ResourceManager.GetString("Support", Language.resourceCulture);
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00043780 File Offset: 0x00041980
		internal static string TakeOff
		{
			get
			{
				return Language.ResourceManager.GetString("TakeOff", Language.resourceCulture);
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x060004C8 RID: 1224 RVA: 0x000437A8 File Offset: 0x000419A8
		internal static string ThankForBuy
		{
			get
			{
				return Language.ResourceManager.GetString("ThankForBuy", Language.resourceCulture);
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x000437D0 File Offset: 0x000419D0
		internal static string TimeForPay
		{
			get
			{
				return Language.ResourceManager.GetString("TimeForPay", Language.resourceCulture);
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x060004CA RID: 1226 RVA: 0x000437F8 File Offset: 0x000419F8
		internal static string UnpaidOrder
		{
			get
			{
				return Language.ResourceManager.GetString("UnpaidOrder", Language.resourceCulture);
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00043820 File Offset: 0x00041A20
		internal static string Value
		{
			get
			{
				return Language.ResourceManager.GetString("Value", Language.resourceCulture);
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x060004CC RID: 1228 RVA: 0x00043848 File Offset: 0x00041A48
		internal static string Wallet
		{
			get
			{
				return Language.ResourceManager.GetString("Wallet", Language.resourceCulture);
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00043870 File Offset: 0x00041A70
		internal static string WalletForWorkCancelOrder
		{
			get
			{
				return Language.ResourceManager.GetString("WalletForWorkCancelOrder", Language.resourceCulture);
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060004CE RID: 1230 RVA: 0x00043898 File Offset: 0x00041A98
		internal static string WrongCode
		{
			get
			{
				return Language.ResourceManager.GetString("WrongCode", Language.resourceCulture);
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x000438C0 File Offset: 0x00041AC0
		internal static string YouAreAdmin
		{
			get
			{
				return Language.ResourceManager.GetString("YouAreAdmin", Language.resourceCulture);
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060004D0 RID: 1232 RVA: 0x000438E8 File Offset: 0x00041AE8
		internal static string YouAreNotSupport
		{
			get
			{
				return Language.ResourceManager.GetString("YouAreNotSupport", Language.resourceCulture);
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00043910 File Offset: 0x00041B10
		internal static string YouAreNotSupport1
		{
			get
			{
				return Language.ResourceManager.GetString("YouAreNotSupport1", Language.resourceCulture);
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060004D2 RID: 1234 RVA: 0x00043938 File Offset: 0x00041B38
		internal static string YouAreSupport
		{
			get
			{
				return Language.ResourceManager.GetString("YouAreSupport", Language.resourceCulture);
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x00043960 File Offset: 0x00041B60
		internal static string YouHaveNotOrders
		{
			get
			{
				return Language.ResourceManager.GetString("YouHaveNotOrders", Language.resourceCulture);
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060004D4 RID: 1236 RVA: 0x00043988 File Offset: 0x00041B88
		internal static string YouHaveNotTransactions
		{
			get
			{
				return Language.ResourceManager.GetString("YouHaveNotTransactions", Language.resourceCulture);
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x000439B0 File Offset: 0x00041BB0
		internal static string YouPaidTheOrder
		{
			get
			{
				return Language.ResourceManager.GetString("YouPaidTheOrder", Language.resourceCulture);
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060004D6 RID: 1238 RVA: 0x000439D8 File Offset: 0x00041BD8
		internal static string YourBalanceEncrease
		{
			get
			{
				return Language.ResourceManager.GetString("YourBalanceEncrease", Language.resourceCulture);
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x00043A00 File Offset: 0x00041C00
		internal static string YourLastTransactions
		{
			get
			{
				return Language.ResourceManager.GetString("YourLastTransactions", Language.resourceCulture);
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060004D8 RID: 1240 RVA: 0x00043A28 File Offset: 0x00041C28
		internal static string YourOrderBTCAddress
		{
			get
			{
				return Language.ResourceManager.GetString("YourOrderBTCAddress", Language.resourceCulture);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00043A50 File Offset: 0x00041C50
		internal static string YourOrderLTCAddress
		{
			get
			{
				return Language.ResourceManager.GetString("YourOrderLTCAddress", Language.resourceCulture);
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x060004DA RID: 1242 RVA: 0x00043A78 File Offset: 0x00041C78
		internal static string YourOwnBTCAddress
		{
			get
			{
				return Language.ResourceManager.GetString("YourOwnBTCAddress", Language.resourceCulture);
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x00043AA0 File Offset: 0x00041CA0
		internal static string YourOwnLTCAddress
		{
			get
			{
				return Language.ResourceManager.GetString("YourOwnLTCAddress", Language.resourceCulture);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060004DC RID: 1244 RVA: 0x00043AC8 File Offset: 0x00041CC8
		internal static string YourRefferalLink
		{
			get
			{
				return Language.ResourceManager.GetString("YourRefferalLink", Language.resourceCulture);
			}
		}

		// Token: 0x04000778 RID: 1912
		private static ResourceManager resourceMan;

		// Token: 0x04000779 RID: 1913
		private static CultureInfo resourceCulture;
	}
}
