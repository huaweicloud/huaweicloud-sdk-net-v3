using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cbr.V1.Model
{
    /// <summary>
    /// 创建参数
    /// </summary>
    public class BillingCreate 
    {
        /// <summary>
        /// 云平台，公有云或者混合云
        /// </summary>
        /// <value>云平台，公有云或者混合云</value>
        [JsonConverter(typeof(EnumClassConverter<CloudTypeEnum>))]
        public class CloudTypeEnum
        {
            /// <summary>
            /// Enum PUBLIC for value: public
            /// </summary>
            public static readonly CloudTypeEnum PUBLIC = new CloudTypeEnum("public");

            /// <summary>
            /// Enum HYBRID for value: hybrid
            /// </summary>
            public static readonly CloudTypeEnum HYBRID = new CloudTypeEnum("hybrid");

            private static readonly Dictionary<string, CloudTypeEnum> StaticFields =
            new Dictionary<string, CloudTypeEnum>()
            {
                { "public", PUBLIC },
                { "hybrid", HYBRID },
            };

            private string Value;

            public CloudTypeEnum(string value)
            {
                Value = value;
            }

            public static CloudTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as CloudTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(CloudTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(CloudTypeEnum a, CloudTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(CloudTypeEnum a, CloudTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 规格，崩溃一致性（crash_consistent）或应用一致性（app_consistent）
        /// </summary>
        /// <value>规格，崩溃一致性（crash_consistent）或应用一致性（app_consistent）</value>
        [JsonConverter(typeof(EnumClassConverter<ConsistentLevelEnum>))]
        public class ConsistentLevelEnum
        {
            /// <summary>
            /// Enum APP_CONSISTENT for value: app_consistent
            /// </summary>
            public static readonly ConsistentLevelEnum APP_CONSISTENT = new ConsistentLevelEnum("app_consistent");

            /// <summary>
            /// Enum CRASH_CONSISTENT for value: crash_consistent
            /// </summary>
            public static readonly ConsistentLevelEnum CRASH_CONSISTENT = new ConsistentLevelEnum("crash_consistent");

            private static readonly Dictionary<string, ConsistentLevelEnum> StaticFields =
            new Dictionary<string, ConsistentLevelEnum>()
            {
                { "app_consistent", APP_CONSISTENT },
                { "crash_consistent", CRASH_CONSISTENT },
            };

            private string Value;

            public ConsistentLevelEnum(string value)
            {
                Value = value;
            }

            public static ConsistentLevelEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ConsistentLevelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ConsistentLevelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ConsistentLevelEnum a, ConsistentLevelEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ConsistentLevelEnum a, ConsistentLevelEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 对象类型：云服务器（server），云硬盘（disk），文件系统（turbo）。
        /// </summary>
        /// <value>对象类型：云服务器（server），云硬盘（disk），文件系统（turbo）。</value>
        [JsonConverter(typeof(EnumClassConverter<ObjectTypeEnum>))]
        public class ObjectTypeEnum
        {
            /// <summary>
            /// Enum SERVER for value: server
            /// </summary>
            public static readonly ObjectTypeEnum SERVER = new ObjectTypeEnum("server");

            /// <summary>
            /// Enum DISK for value: disk
            /// </summary>
            public static readonly ObjectTypeEnum DISK = new ObjectTypeEnum("disk");

            /// <summary>
            /// Enum TURBO for value: turbo
            /// </summary>
            public static readonly ObjectTypeEnum TURBO = new ObjectTypeEnum("turbo");

            private static readonly Dictionary<string, ObjectTypeEnum> StaticFields =
            new Dictionary<string, ObjectTypeEnum>()
            {
                { "server", SERVER },
                { "disk", DISK },
                { "turbo", TURBO },
            };

            private string Value;

            public ObjectTypeEnum(string value)
            {
                Value = value;
            }

            public static ObjectTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ObjectTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ObjectTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ObjectTypeEnum a, ObjectTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ObjectTypeEnum a, ObjectTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 保护类型：备份（backup）、复制(replication)
        /// </summary>
        /// <value>保护类型：备份（backup）、复制(replication)</value>
        [JsonConverter(typeof(EnumClassConverter<ProtectTypeEnum>))]
        public class ProtectTypeEnum
        {
            /// <summary>
            /// Enum BACKUP for value: backup
            /// </summary>
            public static readonly ProtectTypeEnum BACKUP = new ProtectTypeEnum("backup");

            /// <summary>
            /// Enum REPLICATION for value: replication
            /// </summary>
            public static readonly ProtectTypeEnum REPLICATION = new ProtectTypeEnum("replication");

            private static readonly Dictionary<string, ProtectTypeEnum> StaticFields =
            new Dictionary<string, ProtectTypeEnum>()
            {
                { "backup", BACKUP },
                { "replication", REPLICATION },
            };

            private string Value;

            public ProtectTypeEnum(string value)
            {
                Value = value;
            }

            public static ProtectTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ProtectTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ProtectTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ProtectTypeEnum a, ProtectTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ProtectTypeEnum a, ProtectTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 创建模式，按需：post_paid，包周期：pre_paid，默认为post_paid
        /// </summary>
        /// <value>创建模式，按需：post_paid，包周期：pre_paid，默认为post_paid</value>
        [JsonConverter(typeof(EnumClassConverter<ChargingModeEnum>))]
        public class ChargingModeEnum
        {
            /// <summary>
            /// Enum POST_PAID for value: post_paid
            /// </summary>
            public static readonly ChargingModeEnum POST_PAID = new ChargingModeEnum("post_paid");

            /// <summary>
            /// Enum PRE_PAID for value: pre_paid
            /// </summary>
            public static readonly ChargingModeEnum PRE_PAID = new ChargingModeEnum("pre_paid");

            private static readonly Dictionary<string, ChargingModeEnum> StaticFields =
            new Dictionary<string, ChargingModeEnum>()
            {
                { "post_paid", POST_PAID },
                { "pre_paid", PRE_PAID },
            };

            private string Value;

            public ChargingModeEnum(string value)
            {
                Value = value;
            }

            public static ChargingModeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as ChargingModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ChargingModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ChargingModeEnum a, ChargingModeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ChargingModeEnum a, ChargingModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 创建类型，charging_mode为pre_paid必填，按年(year)或者按月(month)
        /// </summary>
        /// <value>创建类型，charging_mode为pre_paid必填，按年(year)或者按月(month)</value>
        [JsonConverter(typeof(EnumClassConverter<PeriodTypeEnum>))]
        public class PeriodTypeEnum
        {
            /// <summary>
            /// Enum YEAR for value: year
            /// </summary>
            public static readonly PeriodTypeEnum YEAR = new PeriodTypeEnum("year");

            /// <summary>
            /// Enum MONTH for value: month
            /// </summary>
            public static readonly PeriodTypeEnum MONTH = new PeriodTypeEnum("month");

            private static readonly Dictionary<string, PeriodTypeEnum> StaticFields =
            new Dictionary<string, PeriodTypeEnum>()
            {
                { "year", YEAR },
                { "month", MONTH },
            };

            private string Value;

            public PeriodTypeEnum(string value)
            {
                Value = value;
            }

            public static PeriodTypeEnum FromValue(string value)
            {
                if(value == null){
                    return null;
                }

                if (StaticFields.ContainsKey(value))
                {
                    return StaticFields[value];
                }

                return null;
            }

            public string GetValue()
            {
                return Value;
            }

            public override string ToString()
            {
                return $"{Value}";
            }

            public override int GetHashCode()
            {
                return this.Value.GetHashCode();
            }

            public override bool Equals(object obj)
            {
                if (obj == null)
                {
                    return false;
                }

                if (ReferenceEquals(this, obj))
                {
                    return true;
                }

                if (this.Equals(obj as PeriodTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PeriodTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(PeriodTypeEnum a, PeriodTypeEnum b)
            {
                if (System.Object.ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(PeriodTypeEnum a, PeriodTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 云平台，公有云或者混合云
        /// </summary>
        [JsonProperty("cloud_type", NullValueHandling = NullValueHandling.Ignore)]
        public CloudTypeEnum CloudType { get; set; }
        /// <summary>
        /// 规格，崩溃一致性（crash_consistent）或应用一致性（app_consistent）
        /// </summary>
        [JsonProperty("consistent_level", NullValueHandling = NullValueHandling.Ignore)]
        public ConsistentLevelEnum ConsistentLevel { get; set; }
        /// <summary>
        /// 对象类型：云服务器（server），云硬盘（disk），文件系统（turbo）。
        /// </summary>
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectTypeEnum ObjectType { get; set; }
        /// <summary>
        /// 保护类型：备份（backup）、复制(replication)
        /// </summary>
        [JsonProperty("protect_type", NullValueHandling = NullValueHandling.Ignore)]
        public ProtectTypeEnum ProtectType { get; set; }
        /// <summary>
        /// 容量，单位GB
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 创建模式，按需：post_paid，包周期：pre_paid，默认为post_paid
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargingModeEnum ChargingMode { get; set; }
        /// <summary>
        /// 创建类型，charging_mode为pre_paid必填，按年(year)或者按月(month)
        /// </summary>
        [JsonProperty("period_type", NullValueHandling = NullValueHandling.Ignore)]
        public PeriodTypeEnum PeriodType { get; set; }
        /// <summary>
        /// 创建类型的数量，charging_mode为pre_paid必填
        /// </summary>
        [JsonProperty("period_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? PeriodNum { get; set; }

        /// <summary>
        /// 到期后是否自动续期，默认不续期
        /// </summary>
        [JsonProperty("is_auto_renew", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoRenew { get; set; }

        /// <summary>
        /// 是否自动付费，默认为不自动付费
        /// </summary>
        [JsonProperty("is_auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoPay { get; set; }

        /// <summary>
        /// 跳转URL
        /// </summary>
        [JsonProperty("console_url", NullValueHandling = NullValueHandling.Ignore)]
        public string ConsoleUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("extra_info", NullValueHandling = NullValueHandling.Ignore)]
        public BillbingCreateExtraInfo ExtraInfo { get; set; }

        /// <summary>
        /// 存储库多az属性，默认为false
        /// </summary>
        [JsonProperty("is_multi_az", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMultiAz { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BillingCreate {\n");
            sb.Append("  cloudType: ").Append(CloudType).Append("\n");
            sb.Append("  consistentLevel: ").Append(ConsistentLevel).Append("\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  protectType: ").Append(ProtectType).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  periodType: ").Append(PeriodType).Append("\n");
            sb.Append("  periodNum: ").Append(PeriodNum).Append("\n");
            sb.Append("  isAutoRenew: ").Append(IsAutoRenew).Append("\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("  consoleUrl: ").Append(ConsoleUrl).Append("\n");
            sb.Append("  extraInfo: ").Append(ExtraInfo).Append("\n");
            sb.Append("  isMultiAz: ").Append(IsMultiAz).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BillingCreate);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BillingCreate input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CloudType == input.CloudType ||
                    (this.CloudType != null &&
                    this.CloudType.Equals(input.CloudType))
                ) && 
                (
                    this.ConsistentLevel == input.ConsistentLevel ||
                    (this.ConsistentLevel != null &&
                    this.ConsistentLevel.Equals(input.ConsistentLevel))
                ) && 
                (
                    this.ObjectType == input.ObjectType ||
                    (this.ObjectType != null &&
                    this.ObjectType.Equals(input.ObjectType))
                ) && 
                (
                    this.ProtectType == input.ProtectType ||
                    (this.ProtectType != null &&
                    this.ProtectType.Equals(input.ProtectType))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.ChargingMode == input.ChargingMode ||
                    (this.ChargingMode != null &&
                    this.ChargingMode.Equals(input.ChargingMode))
                ) && 
                (
                    this.PeriodType == input.PeriodType ||
                    (this.PeriodType != null &&
                    this.PeriodType.Equals(input.PeriodType))
                ) && 
                (
                    this.PeriodNum == input.PeriodNum ||
                    (this.PeriodNum != null &&
                    this.PeriodNum.Equals(input.PeriodNum))
                ) && 
                (
                    this.IsAutoRenew == input.IsAutoRenew ||
                    (this.IsAutoRenew != null &&
                    this.IsAutoRenew.Equals(input.IsAutoRenew))
                ) && 
                (
                    this.IsAutoPay == input.IsAutoPay ||
                    (this.IsAutoPay != null &&
                    this.IsAutoPay.Equals(input.IsAutoPay))
                ) && 
                (
                    this.ConsoleUrl == input.ConsoleUrl ||
                    (this.ConsoleUrl != null &&
                    this.ConsoleUrl.Equals(input.ConsoleUrl))
                ) && 
                (
                    this.ExtraInfo == input.ExtraInfo ||
                    (this.ExtraInfo != null &&
                    this.ExtraInfo.Equals(input.ExtraInfo))
                ) && 
                (
                    this.IsMultiAz == input.IsMultiAz ||
                    (this.IsMultiAz != null &&
                    this.IsMultiAz.Equals(input.IsMultiAz))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.CloudType != null)
                    hashCode = hashCode * 59 + this.CloudType.GetHashCode();
                if (this.ConsistentLevel != null)
                    hashCode = hashCode * 59 + this.ConsistentLevel.GetHashCode();
                if (this.ObjectType != null)
                    hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.ProtectType != null)
                    hashCode = hashCode * 59 + this.ProtectType.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.ChargingMode != null)
                    hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                if (this.PeriodType != null)
                    hashCode = hashCode * 59 + this.PeriodType.GetHashCode();
                if (this.PeriodNum != null)
                    hashCode = hashCode * 59 + this.PeriodNum.GetHashCode();
                if (this.IsAutoRenew != null)
                    hashCode = hashCode * 59 + this.IsAutoRenew.GetHashCode();
                if (this.IsAutoPay != null)
                    hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                if (this.ConsoleUrl != null)
                    hashCode = hashCode * 59 + this.ConsoleUrl.GetHashCode();
                if (this.ExtraInfo != null)
                    hashCode = hashCode * 59 + this.ExtraInfo.GetHashCode();
                if (this.IsMultiAz != null)
                    hashCode = hashCode * 59 + this.IsMultiAz.GetHashCode();
                return hashCode;
            }
        }
    }
}
