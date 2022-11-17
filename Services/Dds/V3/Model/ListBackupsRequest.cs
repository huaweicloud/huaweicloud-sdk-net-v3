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
        /// 备份类型。 - 取值为“Auto”，表示自动全量备份。 - 取值为“Manual”，表示手动全量备份。 - 取值为“Incremental”，表示自动增量备份。 - 当该字段未传入值时，默认只查询所有的全量备份，包括自动全备备份和手动全量备份。当该字段取值为“Incremental”时，实例ID必传。
        /// </summary>
        /// <value>备份类型。 - 取值为“Auto”，表示自动全量备份。 - 取值为“Manual”，表示手动全量备份。 - 取值为“Incremental”，表示自动增量备份。 - 当该字段未传入值时，默认只查询所有的全量备份，包括自动全备备份和手动全量备份。当该字段取值为“Incremental”时，实例ID必传。</value>
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

            private string Value;

            public BackupTypeEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(BackupTypeEnum a, BackupTypeEnum b)
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

            public static bool operator !=(BackupTypeEnum a, BackupTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 实例模式。 取值： - Sharding - ReplicaSet - Single
        /// </summary>
        /// <value>实例模式。 取值： - Sharding - ReplicaSet - Single</value>
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

            private string Value;

            public ModeEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(ModeEnum a, ModeEnum b)
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

            public static bool operator !=(ModeEnum a, ModeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例ID，可以调用“查询实例列表和详情”接口获取。如果未申请实例，可以调用“创建实例”接口创建。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 备份ID。 - 当该字段传入的备份ID归属为自动增量备份时，实例ID必传。
        /// </summary>
        [SDKProperty("backup_id", IsQuery = true)]
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// 备份类型。 - 取值为“Auto”，表示自动全量备份。 - 取值为“Manual”，表示手动全量备份。 - 取值为“Incremental”，表示自动增量备份。 - 当该字段未传入值时，默认只查询所有的全量备份，包括自动全备备份和手动全量备份。当该字段取值为“Incremental”时，实例ID必传。
        /// </summary>
        [SDKProperty("backup_type", IsQuery = true)]
        [JsonProperty("backup_type", NullValueHandling = NullValueHandling.Ignore)]
        public BackupTypeEnum BackupType { get; set; }
        /// <summary>
        /// 索引位置偏移量，表示从指定project ID下最新的实例创建时间开始，按时间的先后顺序偏移offset条数据后查询对应的实例信息。 取值大于或等于0。不传该参数时，查询偏移量默认为0，表示从最新的实例创建时间对应的实例开始查询。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询备份个数上限值。 取值范围：1~100。不传该参数时，默认查询前100条实例信息。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询开始时间，格式为“yyyy-mm-dd hh:mm:ss”。该时间为UTC时间。 “end_time”有值时，“begin_time”必选。
        /// </summary>
        [SDKProperty("begin_time", IsQuery = true)]
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 查询结束时间，格式为“yyyy-mm-ddThh:mm:ssZ”，且大于查询开始时间。其中，T指某个时间的开始；Z指时区偏移量，例如北京时间偏移显示为+0800。 “begin_time”有值时，“end_time”必选。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 实例模式。 取值： - Sharding - ReplicaSet - Single
        /// </summary>
        [SDKProperty("mode", IsQuery = true)]
        [JsonProperty("mode", NullValueHandling = NullValueHandling.Ignore)]
        public ModeEnum Mode { get; set; }

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
            if (input == null)
                return false;

            return 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.BackupId == input.BackupId ||
                    (this.BackupId != null &&
                    this.BackupId.Equals(input.BackupId))
                ) && 
                (
                    this.BackupType == input.BackupType ||
                    (this.BackupType != null &&
                    this.BackupType.Equals(input.BackupType))
                ) && 
                (
                    this.Offset == input.Offset ||
                    (this.Offset != null &&
                    this.Offset.Equals(input.Offset))
                ) && 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.BeginTime == input.BeginTime ||
                    (this.BeginTime != null &&
                    this.BeginTime.Equals(input.BeginTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Mode == input.Mode ||
                    (this.Mode != null &&
                    this.Mode.Equals(input.Mode))
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
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.BackupId != null)
                    hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.BackupType != null)
                    hashCode = hashCode * 59 + this.BackupType.GetHashCode();
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.BeginTime != null)
                    hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Mode != null)
                    hashCode = hashCode * 59 + this.Mode.GetHashCode();
                return hashCode;
            }
        }
    }
}
