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
    public class RecoveryBackupSource 
    {
        /// <summary>
        /// 备份级别取值, 默认值：INSTANCE
        /// </summary>
        /// <value>备份级别取值, 默认值：INSTANCE</value>
        [JsonConverter(typeof(EnumClassConverter<SchemaTypeEnum>))]
        public class SchemaTypeEnum
        {
            /// <summary>
            /// Enum INSTANCE_ for value: INSTANCE 实例级备份
            /// </summary>
            public static readonly SchemaTypeEnum INSTANCE_ = new SchemaTypeEnum("INSTANCE 实例级备份");

            /// <summary>
            /// Enum DATABASE_ for value: DATABASE 库级备份
            /// </summary>
            public static readonly SchemaTypeEnum DATABASE_ = new SchemaTypeEnum("DATABASE 库级备份");

            /// <summary>
            /// Enum DATABASE_TABLE_ for value: DATABASE_TABLE 表级备份
            /// </summary>
            public static readonly SchemaTypeEnum DATABASE_TABLE_ = new SchemaTypeEnum("DATABASE_TABLE 表级备份");

            private static readonly Dictionary<string, SchemaTypeEnum> StaticFields =
            new Dictionary<string, SchemaTypeEnum>()
            {
                { "INSTANCE 实例级备份", INSTANCE_ },
                { "DATABASE 库级备份", DATABASE_ },
                { "DATABASE_TABLE 表级备份", DATABASE_TABLE_ },
            };

            private string _value;

            public SchemaTypeEnum()
            {

            }

            public SchemaTypeEnum(string value)
            {
                _value = value;
            }

            public static SchemaTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SchemaTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SchemaTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SchemaTypeEnum a, SchemaTypeEnum b)
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

            public static bool operator !=(SchemaTypeEnum a, SchemaTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例ID
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 恢复备份类型：backup，timestamp，different
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 用于恢复的备份ID。
        /// </summary>
        [JsonProperty("backup_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BackupId { get; set; }

        /// <summary>
        /// UTC时间，时间戳
        /// </summary>
        [JsonProperty("restore_time", NullValueHandling = NullValueHandling.Ignore)]
        public string RestoreTime { get; set; }

        /// <summary>
        /// 表基础信息。
        /// </summary>
        [JsonProperty("table_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<RestoreTableListDetail> TableList { get; set; }

        /// <summary>
        /// 备份级别取值, 默认值：INSTANCE
        /// </summary>
        [JsonProperty("schema_type", NullValueHandling = NullValueHandling.Ignore)]
        public SchemaTypeEnum SchemaType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RecoveryBackupSource {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  backupId: ").Append(BackupId).Append("\n");
            sb.Append("  restoreTime: ").Append(RestoreTime).Append("\n");
            sb.Append("  tableList: ").Append(TableList).Append("\n");
            sb.Append("  schemaType: ").Append(SchemaType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RecoveryBackupSource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RecoveryBackupSource input)
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
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.BackupId == input.BackupId ||
                    (this.BackupId != null &&
                    this.BackupId.Equals(input.BackupId))
                ) && 
                (
                    this.RestoreTime == input.RestoreTime ||
                    (this.RestoreTime != null &&
                    this.RestoreTime.Equals(input.RestoreTime))
                ) && 
                (
                    this.TableList == input.TableList ||
                    this.TableList != null &&
                    input.TableList != null &&
                    this.TableList.SequenceEqual(input.TableList)
                ) && 
                (
                    this.SchemaType == input.SchemaType ||
                    (this.SchemaType != null &&
                    this.SchemaType.Equals(input.SchemaType))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.BackupId != null)
                    hashCode = hashCode * 59 + this.BackupId.GetHashCode();
                if (this.RestoreTime != null)
                    hashCode = hashCode * 59 + this.RestoreTime.GetHashCode();
                if (this.TableList != null)
                    hashCode = hashCode * 59 + this.TableList.GetHashCode();
                if (this.SchemaType != null)
                    hashCode = hashCode * 59 + this.SchemaType.GetHashCode();
                return hashCode;
            }
        }
    }
}
