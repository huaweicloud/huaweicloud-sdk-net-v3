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
    /// Request Object
    /// </summary>
    public class ListBackupsRequest 
    {
        /// <summary>
        /// **参数解释：** 备份类型。 **约束限制：** 当该字段取值为“Incremental”时，实例ID必传。 **取值范围：** - 取值为“Auto”，表示自动全量备份。 - 取值为“Manual”，表示手动全量备份。 - 取值为“Incremental”，表示自动增量备份。 - 当该字段未传入值时，默认只查询所有的全量备份，包括自动全备备份和手动全量备份。当该字段取值为“Incremental”时，实例ID必传。  **默认取值：** 不涉及。
        /// </summary>
        /// <value>**参数解释：** 备份类型。 **约束限制：** 当该字段取值为“Incremental”时，实例ID必传。 **取值范围：** - 取值为“Auto”，表示自动全量备份。 - 取值为“Manual”，表示手动全量备份。 - 取值为“Incremental”，表示自动增量备份。 - 当该字段未传入值时，默认只查询所有的全量备份，包括自动全备备份和手动全量备份。当该字段取值为“Incremental”时，实例ID必传。  **默认取值：** 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<BackupTypeEnum>))]
        public class BackupTypeEnum
        {
            /// <summary>
            /// Enum AUTO for value: Auto
            /// </summary>
            public static readonly BackupTypeEnum AUTO = new BackupTypeEnum("Auto");

            /// <summary>
            /// Enum MANUAL for value: Manual
            /// </summary>
            public static readonly BackupTypeEnum MANUAL = new BackupTypeEnum("Manual");

            /// <summary>
            /// Enum INCREMENTAL for value: Incremental
            /// </summary>
            public static readonly BackupTypeEnum INCREMENTAL = new BackupTypeEnum("Incremental");

            private static readonly Dictionary<string, BackupTypeEnum> StaticFields =
            new Dictionary<string, BackupTypeEnum>()
            {
                { "Auto", AUTO },
                { "Manual", MANUAL },
                { "Incremental", INCREMENTAL },
            };

            private string _value;

            public BackupTypeEnum()
            {

            }

            public BackupTypeEnum(string value)
            {
                _value = value;
            }

            public static BackupTypeEnum FromValue(string value)
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

                if (this.Equals(obj as BackupTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(BackupTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(BackupTypeEnum a, BackupTypeEnum b)
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

            public static bool operator !=(BackupTypeEnum a, BackupTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// **参数解释：** 实例模式。 **约束限制：** 不涉及。 **取值范围：** - Sharding - ReplicaSet - Single  **默认取值：** 不涉及。
        /// </summary>
        /// <value>**参数解释：** 实例模式。 **约束限制：** 不涉及。 **取值范围：** - Sharding - ReplicaSet - Single  **默认取值：** 不涉及。</value>
        [JsonConverter(typeof(EnumClassConverter<ModeEnum>))]
        public class ModeEnum
        {
            /// <summary>
            /// Enum SHARDING for value: Sharding
            /// </summary>
            public static readonly ModeEnum SHARDING = new ModeEnum("Sharding");

            /// <summary>
            /// Enum REPLICASET for value: ReplicaSet
            /// </summary>
            public static readonly ModeEnum REPLICASET = new ModeEnum("ReplicaSet");

            /// <summary>
            /// Enum SINGLE for value: Single
            /// </summary>
            public static readonly ModeEnum SINGLE = new ModeEnum("Single");

            private static readonly Dictionary<string, ModeEnum> StaticFields =
            new Dictionary<string, ModeEnum>()
            {
                { "Sharding", SHARDING },
                { "ReplicaSet", REPLICASET },
                { "Single", SINGLE },
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
        /// **参数解释：** 实例ID，可以调用“查询实例列表和详情-QueryingInstancesandDetails”接口获取。如果未申请实例，可以调用“创建实例-CreatingaDBInstance”接口创建。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// **参数解释：** 备份ID。 **约束限制：** 当该字段传入的备份ID归属为自动增量备份时，实例ID必传。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("backup_id", IsQuery = true)]
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// **参数解释：** 备份类型。 **约束限制：** 当该字段取值为“Incremental”时，实例ID必传。 **取值范围：** - 取值为“Auto”，表示自动全量备份。 - 取值为“Manual”，表示手动全量备份。 - 取值为“Incremental”，表示自动增量备份。 - 当该字段未传入值时，默认只查询所有的全量备份，包括自动全备备份和手动全量备份。当该字段取值为“Incremental”时，实例ID必传。  **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("backup_type", IsQuery = true)]
        [JsonProperty("backup_type", NullValueHandling = NullValueHandling.Ignore)]
        public BackupTypeEnum BackupType { get; set; }
        /// <summary>
        /// **参数解释：** 索引位置偏移量，表示从指定project ID下最新的备份创建时间开始，按时间的先后顺序偏移offset条数据后查询对应的备份信息。 **约束限制：** 不涉及。 **取值范围：** 大于或等于0。 **默认取值：** 0，表示从最新的备份创建时间对应的备份开始查询。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// **参数解释：** 查询备份个数上限值。 **约束限制：** 不涉及。 **取值范围：** 1~100。 **默认取值：** 100。不传该参数时，默认查询前100条备份信息。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// **参数解释：** 查询备份开始的时间，格式为“yyyy-mm-dd hh:mm:ss”。该时间为UTC时间。 **约束限制：** “end_time”有值时，“begin_time”必选。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("begin_time", IsQuery = true)]
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// **参数解释：** 查询备份开始的结束时间，格式为“yyyy-mm-dd hh:mm:ss”。该时间为UTC时间。 **约束限制：** “begin_time”有值时，“end_time”必选。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// **参数解释：** 实例模式。 **约束限制：** 不涉及。 **取值范围：** - Sharding - ReplicaSet - Single  **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("mode", IsQuery = true)]
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// **参数解释：** 排序字段。 **约束限制：** “order_rule”有值时，“order_field”必选。 **取值范围：** - name，备份名称。 - instanceName，实例名称。 - type，备份类型。 - datastoreType，引擎类型。 - beginTime，开始时间。 - status，备份状态。  **默认取值：** 如果不传值，则默认根据备份开始时间，即响应参数的begin_time，倒序排序。
        /// </summary>
        [SDKProperty("order_field", IsQuery = true)]
        [JsonProperty("order_field", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderField { get; set; }

        /// <summary>
        /// **参数解释：** 排序规则。 **约束限制：** “order_field”有值时，“order_rule”必选。 **取值范围：** - asc: 升序排序。 - desc: 降序排序。  **默认取值：** 如果不传值，则默认根据备份开始时间，即响应参数的begin_time，倒序排序。
        /// </summary>
        [SDKProperty("order_rule", IsQuery = true)]
        [JsonProperty("order_rule", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderRule { get; set; }

        /// <summary>
        /// **参数解释：** 备份状态。 **约束限制：** 不涉及。 **取值范围：** - COMPLETED - BUILDING - FAILED  **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("backup_status", IsQuery = true)]
        [JsonProperty("backup_status", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupStatus { get; set; }

        /// <summary>
        /// **参数解释：** 备份名称，支持模糊匹配。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("backup_name", IsQuery = true)]
        [JsonProperty("backup_name", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupName { get; set; }

        /// <summary>
        /// **参数解释：** 备份描述，支持模糊匹配。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("backup_description", IsQuery = true)]
        [JsonProperty("backup_description", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupDescription { get; set; }

        /// <summary>
        /// **参数解释：** 实例名称，支持模糊匹配。 **约束限制：** 不涉及。 **取值范围：** 不涉及。 **默认取值：** 不涉及。
        /// </summary>
        [SDKProperty("instance_name", IsQuery = true)]
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBackupsRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  backupType: ").Append(BackupType).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("  mode: ").Append(Mode).Append("\n");
            sb.Append("  orderField: ").Append(OrderField).Append("\n");
            sb.Append("  orderRule: ").Append(OrderRule).Append("\n");
            sb.Append("  backupStatus: ").Append(BackupStatus).Append("\n");
            sb.Append("  backupName: ").Append(BackupName).Append("\n");
            sb.Append("  backupDescription: ").Append(BackupDescription).Append("\n");
            sb.Append("  instanceName: ").Append(InstanceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBackupsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBackupsRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.BackupId != input.BackupId || (this.BackupId != null && !this.BackupId.Equals(input.BackupId))) return false;
            if (this.BackupType != input.BackupType) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.BeginTime != input.BeginTime || (this.BeginTime != null && !this.BeginTime.Equals(input.BeginTime))) return false;
            if (this.EndTime != input.EndTime || (this.EndTime != null && !this.EndTime.Equals(input.EndTime))) return false;
            if (this.Mode != input.Mode) return false;
            if (this.OrderField != input.OrderField || (this.OrderField != null && !this.OrderField.Equals(input.OrderField))) return false;
            if (this.OrderRule != input.OrderRule || (this.OrderRule != null && !this.OrderRule.Equals(input.OrderRule))) return false;
            if (this.BackupStatus != input.BackupStatus || (this.BackupStatus != null && !this.BackupStatus.Equals(input.BackupStatus))) return false;
            if (this.BackupName != input.BackupName || (this.BackupName != null && !this.BackupName.Equals(input.BackupName))) return false;
            if (this.BackupDescription != input.BackupDescription || (this.BackupDescription != null && !this.BackupDescription.Equals(input.BackupDescription))) return false;
            if (this.InstanceName != input.InstanceName || (this.InstanceName != null && !this.InstanceName.Equals(input.InstanceName))) return false;

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
                if (this.InstanceId != null) hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.BackupId != null) hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                hashCode = hashCode * 59 + this.BackupType.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.BeginTime != null) hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null) hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                hashCode = hashCode * 59 + this.Mode.GetHashCode();
                if (this.OrderField != null) hashCode = hashCode * 59 + this.OrderField.GetHashCode();
                if (this.OrderRule != null) hashCode = hashCode * 59 + this.OrderRule.GetHashCode();
                if (this.BackupStatus != null) hashCode = hashCode * 59 + this.BackupStatus.GetHashCode();
                if (this.BackupName != null) hashCode = hashCode * 59 + this.BackupName.GetHashCode();
                if (this.BackupDescription != null) hashCode = hashCode * 59 + this.BackupDescription.GetHashCode();
                if (this.InstanceName != null) hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
