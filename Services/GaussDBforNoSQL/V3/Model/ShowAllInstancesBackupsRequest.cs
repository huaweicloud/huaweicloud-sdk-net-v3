using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ShowAllInstancesBackupsRequest 
    {
        /// <summary>
        /// 引擎类型 不传该参数则查询所有的引擎。
        /// </summary>
        /// <value>引擎类型 不传该参数则查询所有的引擎。</value>
        [JsonConverter(typeof(EnumClassConverter<DatastoreTypeEnum>))]
        public class DatastoreTypeEnum
        {
            /// <summary>
            /// Enum CASSANDRA for value: cassandra
            /// </summary>
            public static readonly DatastoreTypeEnum CASSANDRA = new DatastoreTypeEnum("cassandra");

            /// <summary>
            /// Enum MONGODB for value: mongodb
            /// </summary>
            public static readonly DatastoreTypeEnum MONGODB = new DatastoreTypeEnum("mongodb");

            /// <summary>
            /// Enum REDIS for value: redis
            /// </summary>
            public static readonly DatastoreTypeEnum REDIS = new DatastoreTypeEnum("redis");

            /// <summary>
            /// Enum INFLUXDB for value: influxdb
            /// </summary>
            public static readonly DatastoreTypeEnum INFLUXDB = new DatastoreTypeEnum("influxdb");

            private static readonly Dictionary<string, DatastoreTypeEnum> StaticFields =
            new Dictionary<string, DatastoreTypeEnum>()
            {
                { "cassandra", CASSANDRA },
                { "mongodb", MONGODB },
                { "redis", REDIS },
                { "influxdb", INFLUXDB },
            };

            private string _value;

            public DatastoreTypeEnum()
            {

            }

            public DatastoreTypeEnum(string value)
            {
                _value = value;
            }

            public static DatastoreTypeEnum FromValue(string value)
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

                if (this.Equals(obj as DatastoreTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(DatastoreTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(DatastoreTypeEnum a, DatastoreTypeEnum b)
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

            public static bool operator !=(DatastoreTypeEnum a, DatastoreTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 备份类型。
        /// </summary>
        /// <value>备份类型。</value>
        [JsonConverter(typeof(EnumClassConverter<BackupTypeEnum>))]
        public class BackupTypeEnum
        {
            /// <summary>
            /// Enum AUTO_ for value: Auto 自动全量备份
            /// </summary>
            public static readonly BackupTypeEnum AUTO_ = new BackupTypeEnum("Auto 自动全量备份");

            /// <summary>
            /// Enum MANUAL_ for value: Manual 手动全量备份。
            /// </summary>
            public static readonly BackupTypeEnum MANUAL_ = new BackupTypeEnum("Manual 手动全量备份。");

            private static readonly Dictionary<string, BackupTypeEnum> StaticFields =
            new Dictionary<string, BackupTypeEnum>()
            {
                { "Auto 自动全量备份", AUTO_ },
                { "Manual 手动全量备份。", MANUAL_ },
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
        /// 分页页码。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页条数。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 引擎类型 不传该参数则查询所有的引擎。
        /// </summary>
        [SDKProperty("datastore_type", IsQuery = true)]
        [JsonProperty("datastore_type", NullValueHandling = NullValueHandling.Ignore)]
        public DatastoreTypeEnum DatastoreType { get; set; }
        /// <summary>
        /// 实例ID 不传该参数则查询所有备份列表。
        /// </summary>
        [SDKProperty("instance_id", IsQuery = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 备份ID。
        /// </summary>
        [SDKProperty("backup_id", IsQuery = true)]
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// 备份类型。
        /// </summary>
        [SDKProperty("backup_type", IsQuery = true)]
        [JsonProperty("backup_type", NullValueHandling = NullValueHandling.Ignore)]
        public BackupTypeEnum BackupType { get; set; }
        /// <summary>
        /// 查询备份开始的时间，格式为“yyyy-mm-dd hh:mm:ss”。该时间为UTC时间。
        /// </summary>
        [SDKProperty("begin_time", IsQuery = true)]
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 查询备份开始的结束时间，格式为“yyyy-mm-dd hh:mm:ss”。该时间为UTC时间。
        /// </summary>
        [SDKProperty("end_time", IsQuery = true)]
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowAllInstancesBackupsRequest {\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  datastoreType: ").Append(DatastoreType).Append("\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  backupType: ").Append(BackupType).Append("\n");
            sb.Append("  beginTime: ").Append(BeginTime).Append("\n");
            sb.Append("  endTime: ").Append(EndTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowAllInstancesBackupsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowAllInstancesBackupsRequest input)
        {
            if (input == null)
                return false;

            return 
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
                    this.DatastoreType == input.DatastoreType ||
                    (this.DatastoreType != null &&
                    this.DatastoreType.Equals(input.DatastoreType))
                ) && 
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
                    this.BeginTime == input.BeginTime ||
                    (this.BeginTime != null &&
                    this.BeginTime.Equals(input.BeginTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
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
                if (this.Offset != null)
                    hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.DatastoreType != null)
                    hashCode = hashCode * 59 + this.DatastoreType.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.BackupId != null)
                    hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.BackupType != null)
                    hashCode = hashCode * 59 + this.BackupType.GetHashCode();
                if (this.BeginTime != null)
                    hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
