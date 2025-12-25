using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// 备份信息。
    /// </summary>
    public class BackupForList 
    {
        /// <summary>
        /// **参数解释：** 备份类型。 **取值范围：** - 取值为“Auto”，表示自动全量备份。 - 取值为“Manual”，表示手动全量备份。 - 取值为“Incremental”，表示自动增量备份。
        /// </summary>
        /// <value>**参数解释：** 备份类型。 **取值范围：** - 取值为“Auto”，表示自动全量备份。 - 取值为“Manual”，表示手动全量备份。 - 取值为“Incremental”，表示自动增量备份。</value>
        [JsonConverter(typeof(EnumClassConverter<TypeEnum>))]
        public class TypeEnum
        {
            /// <summary>
            /// Enum AUTO for value: auto
            /// </summary>
            public static readonly TypeEnum AUTO = new TypeEnum("auto");

            /// <summary>
            /// Enum MANUAL for value: manual
            /// </summary>
            public static readonly TypeEnum MANUAL = new TypeEnum("manual");

            /// <summary>
            /// Enum FRAGMENT for value: fragment
            /// </summary>
            public static readonly TypeEnum FRAGMENT = new TypeEnum("fragment");

            /// <summary>
            /// Enum INCREMENTAL for value: incremental
            /// </summary>
            public static readonly TypeEnum INCREMENTAL = new TypeEnum("incremental");

            private static readonly Dictionary<string, TypeEnum> StaticFields =
            new Dictionary<string, TypeEnum>()
            {
                { "auto", AUTO },
                { "manual", MANUAL },
                { "fragment", FRAGMENT },
                { "incremental", INCREMENTAL },
            };

            private string _value;

            public TypeEnum()
            {

            }

            public TypeEnum(string value)
            {
                _value = value;
            }

            public static TypeEnum FromValue(string value)
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

                if (this.Equals(obj as TypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(TypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 备份状态。 **取值范围：** - BUILDING：备份中。 - COMPLETED：备份完成。 - FAILED：备份失败。 - DISABLED：备份删除中。
        /// </summary>
        /// <value>**参数解释：** 备份状态。 **取值范围：** - BUILDING：备份中。 - COMPLETED：备份完成。 - FAILED：备份失败。 - DISABLED：备份删除中。</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum BUILDING for value: BUILDING
            /// </summary>
            public static readonly StatusEnum BUILDING = new StatusEnum("BUILDING");

            /// <summary>
            /// Enum COMPLETED for value: COMPLETED
            /// </summary>
            public static readonly StatusEnum COMPLETED = new StatusEnum("COMPLETED");

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            public static readonly StatusEnum FAILED = new StatusEnum("FAILED");

            /// <summary>
            /// Enum DELETING for value: DELETING
            /// </summary>
            public static readonly StatusEnum DELETING = new StatusEnum("DELETING");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "BUILDING", BUILDING },
                { "COMPLETED", COMPLETED },
                { "FAILED", FAILED },
                { "DELETING", DELETING },
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

            public static bool operator !=(StatusEnum a, StatusEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 实例状态。 **取值范围：** - normal，表示实例正常。 - abnormal，表示实例异常。 - creating，表示实例创建中。 - frozen，表示实例被冻结。 - data_disk_full，表示存储空间满。 - enlargefail，表示实例扩容节点个数失败。
        /// </summary>
        /// <value>**参数解释：** 实例状态。 **取值范围：** - normal，表示实例正常。 - abnormal，表示实例异常。 - creating，表示实例创建中。 - frozen，表示实例被冻结。 - data_disk_full，表示存储空间满。 - enlargefail，表示实例扩容节点个数失败。</value>
        [JsonConverter(typeof(EnumClassConverter<InstanceStatusEnum>))]
        public class InstanceStatusEnum
        {
            /// <summary>
            /// Enum NORMAL for value: normal
            /// </summary>
            public static readonly InstanceStatusEnum NORMAL = new InstanceStatusEnum("normal");

            /// <summary>
            /// Enum ABNORMAL for value: abnormal
            /// </summary>
            public static readonly InstanceStatusEnum ABNORMAL = new InstanceStatusEnum("abnormal");

            /// <summary>
            /// Enum CREATING for value: creating
            /// </summary>
            public static readonly InstanceStatusEnum CREATING = new InstanceStatusEnum("creating");

            /// <summary>
            /// Enum FROZEN for value: frozen
            /// </summary>
            public static readonly InstanceStatusEnum FROZEN = new InstanceStatusEnum("frozen");

            /// <summary>
            /// Enum DATA_DISK_FULL for value: data_disk_full
            /// </summary>
            public static readonly InstanceStatusEnum DATA_DISK_FULL = new InstanceStatusEnum("data_disk_full");

            /// <summary>
            /// Enum ENLARGEFAIL for value: enlargefail
            /// </summary>
            public static readonly InstanceStatusEnum ENLARGEFAIL = new InstanceStatusEnum("enlargefail");

            private static readonly Dictionary<string, InstanceStatusEnum> StaticFields =
            new Dictionary<string, InstanceStatusEnum>()
            {
                { "normal", NORMAL },
                { "abnormal", ABNORMAL },
                { "creating", CREATING },
                { "frozen", FROZEN },
                { "data_disk_full", DATA_DISK_FULL },
                { "enlargefail", ENLARGEFAIL },
            };

            private string _value;

            public InstanceStatusEnum()
            {

            }

            public InstanceStatusEnum(string value)
            {
                _value = value;
            }

            public static InstanceStatusEnum FromValue(string value)
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

                if (this.Equals(obj as InstanceStatusEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(InstanceStatusEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(InstanceStatusEnum a, InstanceStatusEnum b)
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

            public static bool operator !=(InstanceStatusEnum a, InstanceStatusEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// **参数解释：** 备份ID。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// **参数解释：** 备份名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// **参数解释：** 备份所属的实例ID，可以调用“查询实例列表”接口获取。如果未申请实例，可以调用“创建实例”接口创建。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释：** 备份所属的实例名称。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("datastore", NullValueHandling = NullValueHandling.Ignore)]
        public BackupDatabase Datastore { get; set; }

        /// <summary>
        /// **参数解释：** 备份类型。 **取值范围：** - 取值为“Auto”，表示自动全量备份。 - 取值为“Manual”，表示手动全量备份。 - 取值为“Incremental”，表示自动增量备份。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// **参数解释：** 备份开始时间，格式为“yyyy-mm-dd hh:mm:ss”。该时间为UTC时间。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// **参数解释：** 备份结束时间，格式为“yyyy-mm-dd hh:mm:ss”。该时间为UTC时间。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释：** 备份状态。 **取值范围：** - BUILDING：备份中。 - COMPLETED：备份完成。 - FAILED：备份失败。 - DISABLED：备份删除中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// **参数解释：** 备份大小，单位：KB。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public long? Size { get; set; }

        /// <summary>
        /// **参数解释：** 备份描述。 **取值范围：** 不涉及。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// **参数解释：** 实例状态。 **取值范围：** - normal，表示实例正常。 - abnormal，表示实例异常。 - creating，表示实例创建中。 - frozen，表示实例被冻结。 - data_disk_full，表示存储空间满。 - enlargefail，表示实例扩容节点个数失败。
        /// </summary>
        [JsonProperty("instance_status", NullValueHandling = NullValueHandling.Ignore)]
        public InstanceStatusEnum InstanceStatus { get; set; }
        /// <summary>
        /// **参数解释：** 实例模式。 **取值范围：** - Sharding - ReplicaSet - Single
        /// </summary>
        [JsonProperty("instance_mode", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceMode { get; set; }

        /// <summary>
        /// **参数解释：** 当前实例是否处于恢复中或者恢复检查中。 **取值范围：** - true，表示实例处于恢复中或者恢复检查中，不允许删除该实例备份。 - false，当前实例未处于恢复中或者恢复检查中，允许删除该实例备份。
        /// </summary>
        [JsonProperty("is_instance_restoring", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsInstanceRestoring { get; set; }

        /// <summary>
        /// **参数解释：** 备份方式。 **取值范围：** - Snapshot，快照备份。 - Physical，物理备份。 - Logical，逻辑备份。 - Incremental，增量备份。
        /// </summary>
        [JsonProperty("backup_method", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupMethod { get; set; }

        /// <summary>
        /// **参数解释：** 是否开启kms加密。 **取值范围：** - true，已开启kms加密。 - false，未开启kms加密。
        /// </summary>
        [JsonProperty("kms_enable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? KmsEnable { get; set; }

        /// <summary>
        /// **参数解释：** 是否支持删除该备份。当全备策略存在时，不允许删除自动备份。手动备份允许删除。 **取值范围：** - true，允许删除该备份。 - false，不允许删除该备份。
        /// </summary>
        [JsonProperty("deletable", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Deletable { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BackupForList {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("  datastore: ").Append(Datastore).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  size: ").Append(Size).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  instanceStatus: ").Append(InstanceStatus).Append("\n");
            sb.Append("  instanceMode: ").Append(InstanceMode).Append("\n");
            sb.Append("  isInstanceRestoring: ").Append(IsInstanceRestoring).Append("\n");
            sb.Append("  backupMethod: ").Append(BackupMethod).Append("\n");
            sb.Append("  kmsEnable: ").Append(KmsEnable).Append("\n");
            sb.Append("  deletable: ").Append(Deletable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BackupForList);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BackupForList input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;
            if (this.Datastore != input.Datastore || (this.Datastore != null && !this.Datastore.Equals(input.Datastore))) return false;
            if (this.Type != input.Type) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Status != input.Status) return false;
            if (this.Size != input.Size || (this.Size != null && !this.Size.Equals(input.Size))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.InstanceStatus != input.InstanceStatus) return false;
            if (this.InstanceMode != input.InstanceMode || (this.InstanceMode != null && !this.InstanceMode.Equals(input.InstanceMode))) return false;
            if (this.IsInstanceRestoring != input.IsInstanceRestoring || (this.IsInstanceRestoring != null && !this.IsInstanceRestoring.Equals(input.IsInstanceRestoring))) return false;
            if (this.BackupMethod != input.BackupMethod || (this.BackupMethod != null && !this.BackupMethod.Equals(input.BackupMethod))) return false;
            if (this.KmsEnable != input.KmsEnable || (this.KmsEnable != null && !this.KmsEnable.Equals(input.KmsEnable))) return false;
            if (this.Deletable != input.Deletable || (this.Deletable != null && !this.Deletable.Equals(input.Deletable))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.Datastore != null) hashCode = hashCode * 59 + this.Datastore.GetHashCode();
                hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Size != null) hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                hashCode = hashCode * 59 + this.InstanceStatus.GetHashCode();
                if (this.InstanceMode != null) hashCode = hashCode * 59 + this.InstanceMode.GetHashCode();
                if (this.IsInstanceRestoring != null) hashCode = hashCode * 59 + this.IsInstanceRestoring.GetHashCode();
                if (this.BackupMethod != null) hashCode = hashCode * 59 + this.BackupMethod.GetHashCode();
                if (this.KmsEnable != null) hashCode = hashCode * 59 + this.KmsEnable.GetHashCode();
                if (this.Deletable != null) hashCode = hashCode * 59 + this.Deletable.GetHashCode();
                return hashCode;
            }
        }
    }
}
