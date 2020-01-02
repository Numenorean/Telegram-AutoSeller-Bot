using System;
using System.CodeDom.Compiler;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace TelegramBotBankStore.Properties
{
	// Token: 0x020000D6 RID: 214
	[CompilerGenerated]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.2.0.0")]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x17000024 RID: 36
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00041DB0 File Offset: 0x0003FFB0
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060003DD RID: 989 RVA: 0x00041DC8 File Offset: 0x0003FFC8
		// (set) Token: 0x060003DE RID: 990 RVA: 0x0000323C File Offset: 0x0000143C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string BotToken
		{
			get
			{
				return (string)this["BotToken"];
			}
			set
			{
				this["BotToken"] = value;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060003DF RID: 991 RVA: 0x00041DEC File Offset: 0x0003FFEC
		// (set) Token: 0x060003E0 RID: 992 RVA: 0x0000324C File Offset: 0x0000144C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string BotChannel
		{
			get
			{
				return (string)this["BotChannel"];
			}
			set
			{
				this["BotChannel"] = value;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060003E1 RID: 993 RVA: 0x00041E10 File Offset: 0x00040010
		// (set) Token: 0x060003E2 RID: 994 RVA: 0x0000325C File Offset: 0x0000145C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string BlockChainApiKey
		{
			get
			{
				return (string)this["BlockChainApiKey"];
			}
			set
			{
				this["BlockChainApiKey"] = value;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060003E3 RID: 995 RVA: 0x00041E34 File Offset: 0x00040034
		// (set) Token: 0x060003E4 RID: 996 RVA: 0x0000326C File Offset: 0x0000146C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string BlockChainIdWallet
		{
			get
			{
				return (string)this["BlockChainIdWallet"];
			}
			set
			{
				this["BlockChainIdWallet"] = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060003E5 RID: 997 RVA: 0x00041E58 File Offset: 0x00040058
		// (set) Token: 0x060003E6 RID: 998 RVA: 0x0000327C File Offset: 0x0000147C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string BlockChainServiceHost
		{
			get
			{
				return (string)this["BlockChainServiceHost"];
			}
			set
			{
				this["BlockChainServiceHost"] = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060003E7 RID: 999 RVA: 0x00041E7C File Offset: 0x0004007C
		// (set) Token: 0x060003E8 RID: 1000 RVA: 0x0000328C File Offset: 0x0000148C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string BlockChainPassword
		{
			get
			{
				return (string)this["BlockChainPassword"];
			}
			set
			{
				this["BlockChainPassword"] = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00041EA0 File Offset: 0x000400A0
		// (set) Token: 0x060003EA RID: 1002 RVA: 0x0000329C File Offset: 0x0000149C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Greeting
		{
			get
			{
				return (string)this["Greeting"];
			}
			set
			{
				this["Greeting"] = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060003EB RID: 1003 RVA: 0x00041EC4 File Offset: 0x000400C4
		// (set) Token: 0x060003EC RID: 1004 RVA: 0x000032AC File Offset: 0x000014AC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("The item is out of stock at the moment. Please follow NEWS channel @NEWStelegram")]
		public string PositionOutOfStock
		{
			get
			{
				return (string)this["PositionOutOfStock"];
			}
			set
			{
				this["PositionOutOfStock"] = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x00041EE8 File Offset: 0x000400E8
		// (set) Token: 0x060003EE RID: 1006 RVA: 0x000032BC File Offset: 0x000014BC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("@Supportcontact")]
		public string Support
		{
			get
			{
				return (string)this["Support"];
			}
			set
			{
				this["Support"] = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060003EF RID: 1007 RVA: 0x00041F0C File Offset: 0x0004010C
		// (set) Token: 0x060003F0 RID: 1008 RVA: 0x000032CC File Offset: 0x000014CC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("/iamasupport")]
		public string CommandSupport
		{
			get
			{
				return (string)this["CommandSupport"];
			}
			set
			{
				this["CommandSupport"] = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060003F1 RID: 1009 RVA: 0x00041F30 File Offset: 0x00040130
		// (set) Token: 0x060003F2 RID: 1010 RVA: 0x000032DC File Offset: 0x000014DC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Key
		{
			get
			{
				return (string)this["Key"];
			}
			set
			{
				this["Key"] = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060003F3 RID: 1011 RVA: 0x00041F54 File Offset: 0x00040154
		// (set) Token: 0x060003F4 RID: 1012 RVA: 0x000032EC File Offset: 0x000014EC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string UniqueID
		{
			get
			{
				return (string)this["UniqueID"];
			}
			set
			{
				this["UniqueID"] = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060003F5 RID: 1013 RVA: 0x00041F78 File Offset: 0x00040178
		// (set) Token: 0x060003F6 RID: 1014 RVA: 0x000032FC File Offset: 0x000014FC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string ExmoKey
		{
			get
			{
				return (string)this["ExmoKey"];
			}
			set
			{
				this["ExmoKey"] = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060003F7 RID: 1015 RVA: 0x00041F9C File Offset: 0x0004019C
		// (set) Token: 0x060003F8 RID: 1016 RVA: 0x0000330C File Offset: 0x0000150C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string ExmoSecret
		{
			get
			{
				return (string)this["ExmoSecret"];
			}
			set
			{
				this["ExmoSecret"] = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060003F9 RID: 1017 RVA: 0x00041FC0 File Offset: 0x000401C0
		// (set) Token: 0x060003FA RID: 1018 RVA: 0x0000331C File Offset: 0x0000151C
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int QiwiMethod
		{
			get
			{
				return (int)this["QiwiMethod"];
			}
			set
			{
				this["QiwiMethod"] = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060003FB RID: 1019 RVA: 0x00041FE4 File Offset: 0x000401E4
		// (set) Token: 0x060003FC RID: 1020 RVA: 0x00003331 File Offset: 0x00001531
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsExmoAvailable
		{
			get
			{
				return (bool)this["IsExmoAvailable"];
			}
			set
			{
				this["IsExmoAvailable"] = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00042008 File Offset: 0x00040208
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x00003346 File Offset: 0x00001546
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsQiwiAvailable
		{
			get
			{
				return (bool)this["IsQiwiAvailable"];
			}
			set
			{
				this["IsQiwiAvailable"] = value;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x0004202C File Offset: 0x0004022C
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x0000335B File Offset: 0x0000155B
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsApironeAvailable
		{
			get
			{
				return (bool)this["IsApironeAvailable"];
			}
			set
			{
				this["IsApironeAvailable"] = value;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000401 RID: 1025 RVA: 0x00042050 File Offset: 0x00040250
		// (set) Token: 0x06000402 RID: 1026 RVA: 0x00003370 File Offset: 0x00001570
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string ApironeWalletLTCAddress
		{
			get
			{
				return (string)this["ApironeWalletLTCAddress"];
			}
			set
			{
				this["ApironeWalletLTCAddress"] = value;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x00042074 File Offset: 0x00040274
		// (set) Token: 0x06000404 RID: 1028 RVA: 0x00003380 File Offset: 0x00001580
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string ApironeWalletBTCAddress
		{
			get
			{
				return (string)this["ApironeWalletBTCAddress"];
			}
			set
			{
				this["ApironeWalletBTCAddress"] = value;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000405 RID: 1029 RVA: 0x00042098 File Offset: 0x00040298
		// (set) Token: 0x06000406 RID: 1030 RVA: 0x00003390 File Offset: 0x00001590
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool ApironePayBTC
		{
			get
			{
				return (bool)this["ApironePayBTC"];
			}
			set
			{
				this["ApironePayBTC"] = value;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x000420BC File Offset: 0x000402BC
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x000033A5 File Offset: 0x000015A5
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool ApironePayLTC
		{
			get
			{
				return (bool)this["ApironePayLTC"];
			}
			set
			{
				this["ApironePayLTC"] = value;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x000420E0 File Offset: 0x000402E0
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x000033BA File Offset: 0x000015BA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string AUA
		{
			get
			{
				return (string)this["AUA"];
			}
			set
			{
				this["AUA"] = value;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x0600040D RID: 1037 RVA: 0x00042128 File Offset: 0x00040328
		// (set) Token: 0x0600040E RID: 1038 RVA: 0x000033DA File Offset: 0x000015DA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string CardNumber
		{
			get
			{
				return (string)this["CardNumber"];
			}
			set
			{
				this["CardNumber"] = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x0600040F RID: 1039 RVA: 0x0004214C File Offset: 0x0004034C
		// (set) Token: 0x06000410 RID: 1040 RVA: 0x000033EA File Offset: 0x000015EA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsCardAvailable
		{
			get
			{
				return (bool)this["IsCardAvailable"];
			}
			set
			{
				this["IsCardAvailable"] = value;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000411 RID: 1041 RVA: 0x00042170 File Offset: 0x00040370
		// (set) Token: 0x06000412 RID: 1042 RVA: 0x000033FF File Offset: 0x000015FF
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public decimal DiscountBTC
		{
			get
			{
				return (decimal)this["DiscountBTC"];
			}
			set
			{
				this["DiscountBTC"] = value;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000413 RID: 1043 RVA: 0x00042194 File Offset: 0x00040394
		// (set) Token: 0x06000414 RID: 1044 RVA: 0x00003414 File Offset: 0x00001614
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public decimal DiscountLTC
		{
			get
			{
				return (decimal)this["DiscountLTC"];
			}
			set
			{
				this["DiscountLTC"] = value;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000415 RID: 1045 RVA: 0x000421B8 File Offset: 0x000403B8
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x00003429 File Offset: 0x00001629
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsReviewAvailable
		{
			get
			{
				return (bool)this["IsReviewAvailable"];
			}
			set
			{
				this["IsReviewAvailable"] = value;
			}
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x000421DC File Offset: 0x000403DC
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x0000343E File Offset: 0x0000163E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool IsUserPayWalletAvailable
		{
			get
			{
				return (bool)this["IsUserPayWalletAvailable"];
			}
			set
			{
				this["IsUserPayWalletAvailable"] = value;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x00042200 File Offset: 0x00040400
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x00003453 File Offset: 0x00001653
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsReserveAndPayInTheEndAvailable
		{
			get
			{
				return (bool)this["IsReserveAndPayInTheEndAvailable"];
			}
			set
			{
				this["IsReserveAndPayInTheEndAvailable"] = value;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x00042224 File Offset: 0x00040424
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x00003468 File Offset: 0x00001668
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public decimal TimeToCancelOrder
		{
			get
			{
				return (decimal)this["TimeToCancelOrder"];
			}
			set
			{
				this["TimeToCancelOrder"] = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00042248 File Offset: 0x00040448
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x0000347D File Offset: 0x0000167D
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int Currency
		{
			get
			{
				return (int)this["Currency"];
			}
			set
			{
				this["Currency"] = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x0004226C File Offset: 0x0004046C
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x00003492 File Offset: 0x00001692
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("True")]
		public bool IsButtonLanguageAvailable
		{
			get
			{
				return (bool)this["IsButtonLanguageAvailable"];
			}
			set
			{
				this["IsButtonLanguageAvailable"] = value;
			}
		}

		// Token: 0x17000047 RID: 71
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00042290 File Offset: 0x00040490
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x000034A7 File Offset: 0x000016A7
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsPromoCodeAvailable
		{
			get
			{
				return (bool)this["IsPromoCodeAvailable"];
			}
			set
			{
				this["IsPromoCodeAvailable"] = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x000422B4 File Offset: 0x000404B4
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x000034BC File Offset: 0x000016BC
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsNotEnterAmountToBuy
		{
			get
			{
				return (bool)this["IsNotEnterAmountToBuy"];
			}
			set
			{
				this["IsNotEnterAmountToBuy"] = value;
			}
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x000422D8 File Offset: 0x000404D8
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x000034D1 File Offset: 0x000016D1
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsButtonIPaidForCard
		{
			get
			{
				return (bool)this["IsButtonIPaidForCard"];
			}
			set
			{
				this["IsButtonIPaidForCard"] = value;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x000422FC File Offset: 0x000404FC
		// (set) Token: 0x06000428 RID: 1064 RVA: 0x000034E6 File Offset: 0x000016E6
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsLockCheckPayment
		{
			get
			{
				return (bool)this["IsLockCheckPayment"];
			}
			set
			{
				this["IsLockCheckPayment"] = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000429 RID: 1065 RVA: 0x00042320 File Offset: 0x00040520
		// (set) Token: 0x0600042A RID: 1066 RVA: 0x000034FB File Offset: 0x000016FB
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsButtonIPaidForElse
		{
			get
			{
				return (bool)this["IsButtonIPaidForElse"];
			}
			set
			{
				this["IsButtonIPaidForElse"] = value;
			}
		}

		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600042B RID: 1067 RVA: 0x00042344 File Offset: 0x00040544
		// (set) Token: 0x0600042C RID: 1068 RVA: 0x00003510 File Offset: 0x00001710
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string YandexAddress
		{
			get
			{
				return (string)this["YandexAddress"];
			}
			set
			{
				this["YandexAddress"] = value;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600042D RID: 1069 RVA: 0x00042368 File Offset: 0x00040568
		// (set) Token: 0x0600042E RID: 1070 RVA: 0x00003520 File Offset: 0x00001720
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsYandexAvailable
		{
			get
			{
				return (bool)this["IsYandexAvailable"];
			}
			set
			{
				this["IsYandexAvailable"] = value;
			}
		}

		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600042F RID: 1071 RVA: 0x0004238C File Offset: 0x0004058C
		// (set) Token: 0x06000430 RID: 1072 RVA: 0x00003535 File Offset: 0x00001735
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string YansexClientId
		{
			get
			{
				return (string)this["YansexClientId"];
			}
			set
			{
				this["YansexClientId"] = value;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000431 RID: 1073 RVA: 0x000423B0 File Offset: 0x000405B0
		// (set) Token: 0x06000432 RID: 1074 RVA: 0x00003545 File Offset: 0x00001745
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string YandexRedirectUri
		{
			get
			{
				return (string)this["YandexRedirectUri"];
			}
			set
			{
				this["YandexRedirectUri"] = value;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000433 RID: 1075 RVA: 0x000423D4 File Offset: 0x000405D4
		// (set) Token: 0x06000434 RID: 1076 RVA: 0x00003555 File Offset: 0x00001755
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string YandexProxyNamePass
		{
			get
			{
				return (string)this["YandexProxyNamePass"];
			}
			set
			{
				this["YandexProxyNamePass"] = value;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x000423F8 File Offset: 0x000405F8
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x00003565 File Offset: 0x00001765
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string YandexProxyIpPort
		{
			get
			{
				return (string)this["YandexProxyIpPort"];
			}
			set
			{
				this["YandexProxyIpPort"] = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000437 RID: 1079 RVA: 0x0004241C File Offset: 0x0004061C
		// (set) Token: 0x06000438 RID: 1080 RVA: 0x00003575 File Offset: 0x00001775
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string YandexToken
		{
			get
			{
				return (string)this["YandexToken"];
			}
			set
			{
				this["YandexToken"] = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x00042440 File Offset: 0x00040640
		// (set) Token: 0x0600043A RID: 1082 RVA: 0x00003585 File Offset: 0x00001785
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("0")]
		public int RefferalRewarding
		{
			get
			{
				return (int)this["RefferalRewarding"];
			}
			set
			{
				this["RefferalRewarding"] = value;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600043B RID: 1083 RVA: 0x00042464 File Offset: 0x00040664
		// (set) Token: 0x0600043C RID: 1084 RVA: 0x0000359A File Offset: 0x0000179A
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Referral
		{
			get
			{
				return (string)this["Referral"];
			}
			set
			{
				this["Referral"] = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600043D RID: 1085 RVA: 0x00042488 File Offset: 0x00040688
		// (set) Token: 0x0600043E RID: 1086 RVA: 0x000035AA File Offset: 0x000017AA
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsReferalAvailable
		{
			get
			{
				return (bool)this["IsReferalAvailable"];
			}
			set
			{
				this["IsReferalAvailable"] = value;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600043F RID: 1087 RVA: 0x000424AC File Offset: 0x000406AC
		// (set) Token: 0x06000440 RID: 1088 RVA: 0x000035BF File Offset: 0x000017BF
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsTele2Available
		{
			get
			{
				return (bool)this["IsTele2Available"];
			}
			set
			{
				this["IsTele2Available"] = value;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x000424D0 File Offset: 0x000406D0
		// (set) Token: 0x06000442 RID: 1090 RVA: 0x000035D4 File Offset: 0x000017D4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Tele2Number
		{
			get
			{
				return (string)this["Tele2Number"];
			}
			set
			{
				this["Tele2Number"] = value;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x000424F4 File Offset: 0x000406F4
		// (set) Token: 0x06000444 RID: 1092 RVA: 0x000035E4 File Offset: 0x000017E4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string Tele2Password
		{
			get
			{
				return (string)this["Tele2Password"];
			}
			set
			{
				this["Tele2Password"] = value;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000445 RID: 1093 RVA: 0x00042518 File Offset: 0x00040718
		// (set) Token: 0x06000446 RID: 1094 RVA: 0x000035F4 File Offset: 0x000017F4
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsMainButtonAvailability
		{
			get
			{
				return (bool)this["IsMainButtonAvailability"];
			}
			set
			{
				this["IsMainButtonAvailability"] = value;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000447 RID: 1095 RVA: 0x0004253C File Offset: 0x0004073C
		// (set) Token: 0x06000448 RID: 1096 RVA: 0x00003609 File Offset: 0x00001809
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsMainButtonStatistics
		{
			get
			{
				return (bool)this["IsMainButtonStatistics"];
			}
			set
			{
				this["IsMainButtonStatistics"] = value;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000449 RID: 1097 RVA: 0x00042560 File Offset: 0x00040760
		// (set) Token: 0x0600044A RID: 1098 RVA: 0x0000361E File Offset: 0x0000181E
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsNotFoundAvailable
		{
			get
			{
				return (bool)this["IsNotFoundAvailable"];
			}
			set
			{
				this["IsNotFoundAvailable"] = value;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x0600044B RID: 1099 RVA: 0x00042584 File Offset: 0x00040784
		// (set) Token: 0x0600044C RID: 1100 RVA: 0x00003633 File Offset: 0x00001833
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string NotFoundText
		{
			get
			{
				return (string)this["NotFoundText"];
			}
			set
			{
				this["NotFoundText"] = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600044D RID: 1101 RVA: 0x000425A8 File Offset: 0x000407A8
		// (set) Token: 0x0600044E RID: 1102 RVA: 0x00003643 File Offset: 0x00001843
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("")]
		public string NotFoundChennel
		{
			get
			{
				return (string)this["NotFoundChennel"];
			}
			set
			{
				this["NotFoundChennel"] = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600044F RID: 1103 RVA: 0x000425CC File Offset: 0x000407CC
		// (set) Token: 0x06000450 RID: 1104 RVA: 0x00003653 File Offset: 0x00001853
		[UserScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("False")]
		public bool IsSendMoneyButtonAvailabile
		{
			get
			{
				return (bool)this["IsSendMoneyButtonAvailabile"];
			}
			set
			{
				this["IsSendMoneyButtonAvailabile"] = value;
			}
		}

		// Token: 0x04000777 RID: 1911
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
