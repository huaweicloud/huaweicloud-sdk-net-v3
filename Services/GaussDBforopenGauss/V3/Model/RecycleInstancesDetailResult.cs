using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforopenGauss.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RecycleInstancesDetailResult 
    {
        /// <summary>
        /// 部署形态(Ha:主备版;Independent:独立部署;Combined:混合部署)。
        /// </summary>
        /// <value>部署形态(Ha:主备版;Independent:独立部署;Combined:混合部署)。</value>
        [JsonConverter(typeof(EnumClassConverter<HaModeEnum>))]
        public class HaModeEnum
        {
            /// <summary>
            /// Enum HA for value: Ha
            /// </summary>
            public static readonly HaModeEnum HA = new HaModeEnum("Ha");

            /// <summary>
            /// Enum INDEPENDENT for value: Independent
            /// </summary>
            public static readonly HaModeEnum INDEPENDENT = new HaModeEnum("Independent");

            private static readonly Dictionary<string, HaModeEnum> StaticFields =
            new Dictionary<string, HaModeEnum>()
            {
                { "Ha", HA },
                { "Independent", INDEPENDENT },
            };

            private string _value;

            public HaModeEnum()
            {

            }

            public HaModeEnum(string value)
            {
                _value = value;
            }

            public static HaModeEnum FromValue(string value)
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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

                if (this.Equals(obj as HaModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(HaModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(HaModeEnum a, HaModeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(HaModeEnum a, HaModeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 计费模式（0：按需计费；1：包年/包月）。
        /// </summary>
        /// <value>计费模式（0：按需计费；1：包年/包月）。</value>
        [JsonConverter(typeof(EnumClassConverter<PayModelEnum>))]
        public class PayModelEnum
        {
            /// <summary>
            /// Enum _0 for value: 0
            /// </summary>
            public static readonly PayModelEnum _0 = new PayModelEnum("0");

            /// <summary>
            /// Enum _1 for value: 1
            /// </summary>
            public static readonly PayModelEnum _1 = new PayModelEnum("1");

            private static readonly Dictionary<string, PayModelEnum> StaticFields =
            new Dictionary<string, PayModelEnum>()
            {
                { "0", _0 },
                { "1", _1 },
            };

            private string _value;

            public PayModelEnum()
            {

            }

            public PayModelEnum(string value)
            {
                _value = value;
            }

            public static PayModelEnum FromValue(string value)
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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

                if (this.Equals(obj as PayModelEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(PayModelEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(PayModelEnum a, PayModelEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(PayModelEnum a, PayModelEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 磁盘类型。（SAS：high；SSD：ultrahigh；ESSD：essd）。
        /// </summary>
        /// <value>磁盘类型。（SAS：high；SSD：ultrahigh；ESSD：essd）。</value>
        [JsonConverter(typeof(EnumClassConverter<VolumeTypeEnum>))]
        public class VolumeTypeEnum
        {
            /// <summary>
            /// Enum HIGH for value: high
            /// </summary>
            public static readonly VolumeTypeEnum HIGH = new VolumeTypeEnum("high");

            /// <summary>
            /// Enum ULTRAHIGH for value: ultrahigh
            /// </summary>
            public static readonly VolumeTypeEnum ULTRAHIGH = new VolumeTypeEnum("ultrahigh");

            /// <summary>
            /// Enum ESSD for value: essd
            /// </summary>
            public static readonly VolumeTypeEnum ESSD = new VolumeTypeEnum("essd");

            private static readonly Dictionary<string, VolumeTypeEnum> StaticFields =
            new Dictionary<string, VolumeTypeEnum>()
            {
                { "high", HIGH },
                { "ultrahigh", ULTRAHIGH },
                { "essd", ESSD },
            };

            private string _value;

            public VolumeTypeEnum()
            {

            }

            public VolumeTypeEnum(string value)
            {
                _value = value;
            }

            public static VolumeTypeEnum FromValue(string value)
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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

                if (this.Equals(obj as VolumeTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(VolumeTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(VolumeTypeEnum a, VolumeTypeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(VolumeTypeEnum a, VolumeTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 回收站备份状态。（Running：运行中；Active：有效的）。
        /// </summary>
        /// <value>回收站备份状态。（Running：运行中；Active：有效的）。</value>
        [JsonConverter(typeof(EnumClassConverter<RecycleStatusEnum>))]
        public class RecycleStatusEnum
        {
            /// <summary>
            /// Enum RUNNING for value: Running
            /// </summary>
            public static readonly RecycleStatusEnum RUNNING = new RecycleStatusEnum("Running");

            /// <summary>
            /// Enum ACTIVE for value: Active
            /// </summary>
            public static readonly RecycleStatusEnum ACTIVE = new RecycleStatusEnum("Active");

            private static readonly Dictionary<string, RecycleStatusEnum> StaticFields =
            new Dictionary<string, RecycleStatusEnum>()
            {
                { "Running", RUNNING },
                { "Active", ACTIVE },
            };

            private string _value;

            public RecycleStatusEnum()
            {

            }

            public RecycleStatusEnum(string value)
            {
                _value = value;
            }

            public static RecycleStatusEnum FromValue(string value)
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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

                if (this.Equals(obj as RecycleStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(RecycleStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(RecycleStatusEnum a, RecycleStatusEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(RecycleStatusEnum a, RecycleStatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 产品类型（basic：基础版；standard：标准版；enterprise：企业版）。
        /// </summary>
        /// <value>产品类型（basic：基础版；standard：标准版；enterprise：企业版）。</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum BASIC for value: basic
            /// </summary>
            public static readonly ModeEnum BASIC = new ModeEnum("basic");

            /// <summary>
            /// Enum STANDARD for value: standard
            /// </summary>
            public static readonly ModeEnum STANDARD = new ModeEnum("standard");

            /// <summary>
            /// Enum ENTERPRISE for value: enterprise
            /// </summary>
            public static readonly ModeEnum ENTERPRISE = new ModeEnum("enterprise");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "basic", BASIC },
                { "standard", STANDARD },
                { "enterprise", ENTERPRISE },
            };

            private string _value;

            public ModeEnum()
            {

            }

            public ModeEnum(string value)
            {
                _value = value;
            }

            public static ModeEnum FromValue(string value)
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
                return _value;
            }

            public override string ToString()
            {
                return $"{_value}";
            }

            public override int GetHashCode()
            {
                return this._value.GetHashCode();
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

                if (this.Equals(obj as ModeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ModeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
            {
                if (ReferenceEquals(a, b))
                {
                    return true;
                }

                if ((object)a == null)
                {
                    return false;
                }

                return a.Equals(b);
            }

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 部署形态(Ha:主备版;Independent:独立部署;Combined:混合部署)。
        /// </summary>
        [JsonProperty("ha_mode", NullValueHandling = NullValueHandling.Ignore)]
        public HaModeEnum HaMode { get; set; }
        /// <summary>
        /// 引擎名称
        /// </summary>
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// 引擎版本号。
        /// </summary>
        [JsonProperty("engine_version", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineVersion { get; set; }

        /// <summary>
        /// 计费模式（0：按需计费；1：包年/包月）。
        /// </summary>
        [JsonProperty("pay_model", NullValueHandling = NullValueHandling.Ignore)]
        public PayModelEnum PayModel { get; set; }
        /// <summary>
        /// 创建时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("created_at", NullValueHandling = NullValueHandling.Ignore)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// 删除时间，格式为“yyyy-mm-ddThh:mm:ssZ”。 其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。
        /// </summary>
        [JsonProperty("deleted_at", NullValueHandling = NullValueHandling.Ignore)]
        public string DeletedAt { get; set; }

        /// <summary>
        /// 磁盘类型。（SAS：high；SSD：ultrahigh；ESSD：essd）。
        /// </summary>
        [JsonProperty("volume_type", NullValueHandling = NullValueHandling.Ignore)]
        public VolumeTypeEnum VolumeType { get; set; }
        /// <summary>
        /// 磁盘大小
        /// </summary>
        [JsonProperty("volume_size", NullValueHandling = NullValueHandling.Ignore)]
        public string VolumeSize { get; set; }

        /// <summary>
        /// 数据vip。
        /// </summary>
        [JsonProperty("data_vip", NullValueHandling = NullValueHandling.Ignore)]
        public string DataVip { get; set; }

        /// <summary>
        /// 企业项目ID。
        /// </summary>
        [JsonProperty("enterprise_project_id", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectId { get; set; }

        /// <summary>
        /// 企业项目名称
        /// </summary>
        [JsonProperty("enterprise_project_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterpriseProjectName { get; set; }

        /// <summary>
        /// 备份级别
        /// </summary>
        [JsonProperty("backup_level", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupLevel { get; set; }

        /// <summary>
        /// 备份ID。（指删除实例时产生备份信息中的备份ID）。
        /// </summary>
        [JsonProperty("recycle_backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RecycleBackupId { get; set; }

        /// <summary>
        /// 回收站备份状态。（Running：运行中；Active：有效的）。
        /// </summary>
        [JsonProperty("recycle_status", NullValueHandling = NullValueHandling.Ignore)]
        public RecycleStatusEnum RecycleStatus { get; set; }
        /// <summary>
        /// 产品类型（basic：基础版；standard：标准版；enterprise：企业版）。
        /// </summary>
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecycleInstancesDetailResult {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  haMode: ").Append(HaMode).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  engineVersion: ").Append(EngineVersion).Append("\n");
            sb.Append("  payModel: ").Append(PayModel).Append("\n");
            sb.Append("  createdAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  deletedAt: ").Append(DeletedAt).Append("\n");
            sb.Append("  volumeType: ").Append(VolumeType).Append("\n");
            sb.Append("  volumeSize: ").Append(VolumeSize).Append("\n");
            sb.Append("  dataVip: ").Append(DataVip).Append("\n");
            sb.Append("  enterpriseProjectId: ").Append(EnterpriseProjectId).Append("\n");
            sb.Append("  enterpriseProjectName: ").Append(EnterpriseProjectName).Append("\n");
            sb.Append("  backupLevel: ").Append(BackupLevel).Append("\n");
            sb.Append("  recycleBackupId: ").Append(RecycleBackupId).Append("\n");
            sb.Append("  recycleStatus: ").Append(RecycleStatus).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecycleInstancesDetailResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecycleInstancesDetailResult input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.HaMode != input.HaMode) return false;
            if (this.EngineName != input.EngineName || (this.EngineName != null && !this.EngineName.Equals(input.EngineName))) return false;
            if (this.EngineVersion != input.EngineVersion || (this.EngineVersion != null && !this.EngineVersion.Equals(input.EngineVersion))) return false;
            if (this.PayModel != input.PayModel) return false;
            if (this.CreatedAt != input.CreatedAt || (this.CreatedAt != null && !this.CreatedAt.Equals(input.CreatedAt))) return false;
            if (this.DeletedAt != input.DeletedAt || (this.DeletedAt != null && !this.DeletedAt.Equals(input.DeletedAt))) return false;
            if (this.VolumeType != input.VolumeType) return false;
            if (this.VolumeSize != input.VolumeSize || (this.VolumeSize != null && !this.VolumeSize.Equals(input.VolumeSize))) return false;
            if (this.DataVip != input.DataVip || (this.DataVip != null && !this.DataVip.Equals(input.DataVip))) return false;
            if (this.EnterpriseProjectId != input.EnterpriseProjectId || (this.EnterpriseProjectId != null && !this.EnterpriseProjectId.Equals(input.EnterpriseProjectId))) return false;
            if (this.EnterpriseProjectName != input.EnterpriseProjectName || (this.EnterpriseProjectName != null && !this.EnterpriseProjectName.Equals(input.EnterpriseProjectName))) return false;
            if (this.BackupLevel != input.BackupLevel || (this.BackupLevel != null && !this.BackupLevel.Equals(input.BackupLevel))) return false;
            if (this.RecycleBackupId != input.RecycleBackupId || (this.RecycleBackupId != null && !this.RecycleBackupId.Equals(input.RecycleBackupId))) return false;
            if (this.RecycleStatus != input.RecycleStatus) return false;
            if (this.Mode != input.Mode) return false;

            return true;
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.HaMode.GetHashCode();
                if (this.EngineName != null) hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.EngineVersion != null) hashCode = hashCode * 59 + this.EngineVersion.GetHashCode();
                hashCode = hashCode * 59 + this.PayModel.GetHashCode();
                if (this.CreatedAt != null) hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.DeletedAt != null) hashCode = hashCode * 59 + this.DeletedAt.GetHashCode();
                hashCode = hashCode * 59 + this.VolumeType.GetHashCode();
                if (this.VolumeSize != null) hashCode = hashCode * 59 + this.VolumeSize.GetHashCode();
                if (this.DataVip != null) hashCode = hashCode * 59 + this.DataVip.GetHashCode();
                if (this.EnterpriseProjectId != null) hashCode = hashCode * 59 + this.EnterpriseProjectId.GetHashCode();
                if (this.EnterpriseProjectName != null) hashCode = hashCode * 59 + this.EnterpriseProjectName.GetHashCode();
                if (this.BackupLevel != null) hashCode = hashCode * 59 + this.BackupLevel.GetHashCode();
                if (this.RecycleBackupId != null) hashCode = hashCode * 59 + this.RecycleBackupId.GetHashCode();
                hashCode = hashCode * 59 + this.RecycleStatus.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
