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
    /// 
    /// </summary>
    public class Billing 
    {
        /// <summary>
        /// 创建模式
        /// </summary>
        /// <value>创建模式</value>
        [JsonConverter(typeof(EnumClassConverter<ChargingModeEnum>))]
        public class ChargingModeEnum
        {
            /// <summary>
            /// Enum PRE_PAID for value: pre_paid
            /// </summary>
            public static readonly ChargingModeEnum PRE_PAID = new ChargingModeEnum("pre_paid");

            /// <summary>
            /// Enum POST_PAID for value: post_paid
            /// </summary>
            public static readonly ChargingModeEnum POST_PAID = new ChargingModeEnum("post_paid");

            private static readonly Dictionary<string, ChargingModeEnum> StaticFields =
            new Dictionary<string, ChargingModeEnum>()
            {
                { "pre_paid", PRE_PAID },
                { "post_paid", POST_PAID },
            };

            private string _value;

            public ChargingModeEnum()
            {

            }

            public ChargingModeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 云平台
        /// </summary>
        /// <value>云平台</value>
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

            private string _value;

            public CloudTypeEnum()
            {

            }

            public CloudTypeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 崩溃一致性（crash_consistent）或应用一致性（app_consistent）
        /// </summary>
        /// <value>崩溃一致性（crash_consistent）或应用一致性（app_consistent）</value>
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

            private string _value;

            public ConsistentLevelEnum()
            {

            }

            public ConsistentLevelEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 对象类型：云服务器（server），云硬盘（disk），文件系统（turbo），云桌面（workspace），VMware（vmware），关系型数据库（rds），文件（file）。
        /// </summary>
        /// <value>对象类型：云服务器（server），云硬盘（disk），文件系统（turbo），云桌面（workspace），VMware（vmware），关系型数据库（rds），文件（file）。</value>
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

            /// <summary>
            /// Enum WORKSPACE for value: workspace
            /// </summary>
            public static readonly ObjectTypeEnum WORKSPACE = new ObjectTypeEnum("workspace");

            /// <summary>
            /// Enum VMWARE for value: vmware
            /// </summary>
            public static readonly ObjectTypeEnum VMWARE = new ObjectTypeEnum("vmware");

            /// <summary>
            /// Enum RDS for value: rds
            /// </summary>
            public static readonly ObjectTypeEnum RDS = new ObjectTypeEnum("rds");

            /// <summary>
            /// Enum FILE for value: file
            /// </summary>
            public static readonly ObjectTypeEnum FILE = new ObjectTypeEnum("file");

            private static readonly Dictionary<string, ObjectTypeEnum> StaticFields =
            new Dictionary<string, ObjectTypeEnum>()
            {
                { "server", SERVER },
                { "disk", DISK },
                { "turbo", TURBO },
                { "workspace", WORKSPACE },
                { "vmware", VMWARE },
                { "rds", RDS },
                { "file", FILE },
            };

            private string _value;

            public ObjectTypeEnum()
            {

            }

            public ObjectTypeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 保护类型
        /// </summary>
        /// <value>保护类型</value>
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

            /// <summary>
            /// Enum HYBRID for value: hybrid
            /// </summary>
            public static readonly ProtectTypeEnum HYBRID = new ProtectTypeEnum("hybrid");

            private static readonly Dictionary<string, ProtectTypeEnum> StaticFields =
            new Dictionary<string, ProtectTypeEnum>()
            {
                { "backup", BACKUP },
                { "replication", REPLICATION },
                { "hybrid", HYBRID },
            };

            private string _value;

            public ProtectTypeEnum()
            {

            }

            public ProtectTypeEnum(string value)
            {
                _value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
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
        /// 规格编码: 云服务备份存储库:vault.backup.server.normal;云硬盘备份存储库:vault.backup.volume.normal;文件备份存储库:vault.backup.turbo.normal;数据库备份存储库:vault.backup.database.normal;混合云备份存储库:vault.hybrid.server.normal;复制备份存储库:vault.replication.server.normal
        /// </summary>
        /// <value>规格编码: 云服务备份存储库:vault.backup.server.normal;云硬盘备份存储库:vault.backup.volume.normal;文件备份存储库:vault.backup.turbo.normal;数据库备份存储库:vault.backup.database.normal;混合云备份存储库:vault.hybrid.server.normal;复制备份存储库:vault.replication.server.normal</value>
        [JsonConverter(typeof(EnumClassConverter<SpecCodeEnum>))]
        public class SpecCodeEnum
        {
            /// <summary>
            /// Enum VAULT_BACKUP_SERVER_NORMAL for value: vault.backup.server.normal
            /// </summary>
            public static readonly SpecCodeEnum VAULT_BACKUP_SERVER_NORMAL = new SpecCodeEnum("vault.backup.server.normal");

            /// <summary>
            /// Enum VAULT_BACKUP_VOLUME_NORMAL for value: vault.backup.volume.normal
            /// </summary>
            public static readonly SpecCodeEnum VAULT_BACKUP_VOLUME_NORMAL = new SpecCodeEnum("vault.backup.volume.normal");

            /// <summary>
            /// Enum VAULT_BACKUP_TURBO_NORMAL for value: vault.backup.turbo.normal
            /// </summary>
            public static readonly SpecCodeEnum VAULT_BACKUP_TURBO_NORMAL = new SpecCodeEnum("vault.backup.turbo.normal");

            /// <summary>
            /// Enum VAULT_BACKUP_DATABASE_NORMAL for value: vault.backup.database.normal
            /// </summary>
            public static readonly SpecCodeEnum VAULT_BACKUP_DATABASE_NORMAL = new SpecCodeEnum("vault.backup.database.normal");

            /// <summary>
            /// Enum VAULT_HYBRID_SERVER_NORMAL for value: vault.hybrid.server.normal
            /// </summary>
            public static readonly SpecCodeEnum VAULT_HYBRID_SERVER_NORMAL = new SpecCodeEnum("vault.hybrid.server.normal");

            /// <summary>
            /// Enum VAULT_REPLICATION_SERVER_NORMAL for value: vault.replication.server.normal
            /// </summary>
            public static readonly SpecCodeEnum VAULT_REPLICATION_SERVER_NORMAL = new SpecCodeEnum("vault.replication.server.normal");

            private static readonly Dictionary<string, SpecCodeEnum> StaticFields =
            new Dictionary<string, SpecCodeEnum>()
            {
                { "vault.backup.server.normal", VAULT_BACKUP_SERVER_NORMAL },
                { "vault.backup.volume.normal", VAULT_BACKUP_VOLUME_NORMAL },
                { "vault.backup.turbo.normal", VAULT_BACKUP_TURBO_NORMAL },
                { "vault.backup.database.normal", VAULT_BACKUP_DATABASE_NORMAL },
                { "vault.hybrid.server.normal", VAULT_HYBRID_SERVER_NORMAL },
                { "vault.replication.server.normal", VAULT_REPLICATION_SERVER_NORMAL },
            };

            private string _value;

            public SpecCodeEnum()
            {

            }

            public SpecCodeEnum(string value)
            {
                _value = value;
            }

            public static SpecCodeEnum FromValue(string value)
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

                if (this.Equals(obj as SpecCodeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SpecCodeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SpecCodeEnum a, SpecCodeEnum b)
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

            public static bool operator !=(SpecCodeEnum a, SpecCodeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 存储库状态
        /// </summary>
        /// <value>存储库状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum AVAILABLE for value: available
            /// </summary>
            public static readonly StatusEnum AVAILABLE = new StatusEnum("available");

            /// <summary>
            /// Enum LOCK for value: lock
            /// </summary>
            public static readonly StatusEnum LOCK = new StatusEnum("lock");

            /// <summary>
            /// Enum FROZEN for value: frozen
            /// </summary>
            public static readonly StatusEnum FROZEN = new StatusEnum("frozen");

            /// <summary>
            /// Enum DELETING for value: deleting
            /// </summary>
            public static readonly StatusEnum DELETING = new StatusEnum("deleting");

            /// <summary>
            /// Enum ERROR for value: error
            /// </summary>
            public static readonly StatusEnum ERROR = new StatusEnum("error");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "available", AVAILABLE },
                { "lock", LOCK },
                { "frozen", FROZEN },
                { "deleting", DELETING },
                { "error", ERROR },
            };

            private string _value;

            public StatusEnum()
            {

            }

            public StatusEnum(string value)
            {
                _value = value;
            }

            public static StatusEnum FromValue(string value)
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

                if (this.Equals(obj as StatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(StatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(StatusEnum a, StatusEnum b)
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 已分配容量，单位GB
        /// </summary>
        [JsonProperty("allocated", NullValueHandling = NullValueHandling.Ignore)]
        public int? Allocated { get; set; }

        /// <summary>
        /// 创建模式
        /// </summary>
        [JsonProperty("charging_mode", NullValueHandling = NullValueHandling.Ignore)]
        public ChargingModeEnum ChargingMode { get; set; }
        /// <summary>
        /// 云平台
        /// </summary>
        [JsonProperty("cloud_type", NullValueHandling = NullValueHandling.Ignore)]
        public CloudTypeEnum CloudType { get; set; }
        /// <summary>
        /// 崩溃一致性（crash_consistent）或应用一致性（app_consistent）
        /// </summary>
        [JsonProperty("consistent_level", NullValueHandling = NullValueHandling.Ignore)]
        public ConsistentLevelEnum ConsistentLevel { get; set; }
        /// <summary>
        /// 对象类型：云服务器（server），云硬盘（disk），文件系统（turbo），云桌面（workspace），VMware（vmware），关系型数据库（rds），文件（file）。
        /// </summary>
        [JsonProperty("object_type", NullValueHandling = NullValueHandling.Ignore)]
        public ObjectTypeEnum ObjectType { get; set; }
        /// <summary>
        /// 订单ID
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 保护类型
        /// </summary>
        [JsonProperty("protect_type", NullValueHandling = NullValueHandling.Ignore)]
        public ProtectTypeEnum ProtectType { get; set; }
        /// <summary>
        /// 容量，单位GB
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 规格编码: 云服务备份存储库:vault.backup.server.normal;云硬盘备份存储库:vault.backup.volume.normal;文件备份存储库:vault.backup.turbo.normal;数据库备份存储库:vault.backup.database.normal;混合云备份存储库:vault.hybrid.server.normal;复制备份存储库:vault.replication.server.normal
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public SpecCodeEnum SpecCode { get; set; }
        /// <summary>
        /// 存储库状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 存储库桶名
        /// </summary>
        [JsonProperty("storage_unit", NullValueHandling = NullValueHandling.Ignore)]
        public string StorageUnit { get; set; }

        /// <summary>
        /// 已使用容量，单位MB
        /// </summary>
        [JsonProperty("used", NullValueHandling = NullValueHandling.Ignore)]
        public int? Used { get; set; }

        /// <summary>
        /// 冻结场景
        /// </summary>
        [JsonProperty("frozen_scene", NullValueHandling = NullValueHandling.Ignore)]
        public string FrozenScene { get; set; }

        /// <summary>
        /// 存储库多az属性
        /// </summary>
        [JsonProperty("is_multi_az", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsMultiAz { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Billing {\n");
            sb.Append("  allocated: ").Append(Allocated).Append("\n");
            sb.Append("  chargingMode: ").Append(ChargingMode).Append("\n");
            sb.Append("  cloudType: ").Append(CloudType).Append("\n");
            sb.Append("  consistentLevel: ").Append(ConsistentLevel).Append("\n");
            sb.Append("  objectType: ").Append(ObjectType).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  protectType: ").Append(ProtectType).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  storageUnit: ").Append(StorageUnit).Append("\n");
            sb.Append("  used: ").Append(Used).Append("\n");
            sb.Append("  frozenScene: ").Append(FrozenScene).Append("\n");
            sb.Append("  isMultiAz: ").Append(IsMultiAz).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as Billing);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(Billing input)
        {
            if (input == null) return false;
            if (this.Allocated != input.Allocated || (this.Allocated != null && !this.Allocated.Equals(input.Allocated))) return false;
            if (this.ChargingMode != input.ChargingMode) return false;
            if (this.CloudType != input.CloudType) return false;
            if (this.ConsistentLevel != input.ConsistentLevel) return false;
            if (this.ObjectType != input.ObjectType) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ProtectType != input.ProtectType) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.SpecCode != input.SpecCode) return false;
            if (this.Status != input.Status) return false;
            if (this.StorageUnit != input.StorageUnit || (this.StorageUnit != null && !this.StorageUnit.Equals(input.StorageUnit))) return false;
            if (this.Used != input.Used || (this.Used != null && !this.Used.Equals(input.Used))) return false;
            if (this.FrozenScene != input.FrozenScene || (this.FrozenScene != null && !this.FrozenScene.Equals(input.FrozenScene))) return false;
            if (this.IsMultiAz != input.IsMultiAz || (this.IsMultiAz != null && !this.IsMultiAz.Equals(input.IsMultiAz))) return false;

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
                if (this.Allocated != null) hashCode = hashCode * 59 + this.Allocated.GetHashCode();
                hashCode = hashCode * 59 + this.ChargingMode.GetHashCode();
                hashCode = hashCode * 59 + this.CloudType.GetHashCode();
                hashCode = hashCode * 59 + this.ConsistentLevel.GetHashCode();
                hashCode = hashCode * 59 + this.ObjectType.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                hashCode = hashCode * 59 + this.ProtectType.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.StorageUnit != null) hashCode = hashCode * 59 + this.StorageUnit.GetHashCode();
                if (this.Used != null) hashCode = hashCode * 59 + this.Used.GetHashCode();
                if (this.FrozenScene != null) hashCode = hashCode * 59 + this.FrozenScene.GetHashCode();
                if (this.IsMultiAz != null) hashCode = hashCode * 59 + this.IsMultiAz.GetHashCode();
                return hashCode;
            }
        }
    }
}
