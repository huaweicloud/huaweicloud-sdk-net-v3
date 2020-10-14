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
    public class ListBackupsResult 
    {
        /// <summary>
        /// 备份类型。 - 取值为“Auto”，表示自动全量备份。 - 取值为“Manual”，表示手动全量备份。
        /// </summary>
        /// <value>备份类型。 - 取值为“Auto”，表示自动全量备份。 - 取值为“Manual”，表示手动全量备份。</value>
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

            private string Value;

            public TypeEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
            }

            public static bool operator ==(TypeEnum a, TypeEnum b)
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

            public static bool operator !=(TypeEnum a, TypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 备份状态。 取值： - BUILDING：备份中。 - COMPLETED：备份完成。 - FAILED：备份失败。 - DISABLED：备份删除中。
        /// </summary>
        /// <value>备份状态。 取值： - BUILDING：备份中。 - COMPLETED：备份完成。 - FAILED：备份失败。 - DISABLED：备份删除中。</value>
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

            private string Value;

            public StatusEnum(string value)
            {
                Value = value;
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
                return StringComparer.OrdinalIgnoreCase.Equals(this.Value, obj.Value);
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
        /// 备份ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 备份名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 备份所属的实例ID。
        /// </summary>
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 备份所属的实例名称。
        /// </summary>
        [JsonProperty("instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceName { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("datastore", NullValueHandling = NullValueHandling.Ignore)]
        public ListBackupsDatastoreResult Datastore { get; set; }

        /// <summary>
        /// 备份类型。 - 取值为“Auto”，表示自动全量备份。 - 取值为“Manual”，表示手动全量备份。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// 备份开始时间，格式为“yyyy-mm-dd hh:mm:ss”。该时间为UTC时间。
        /// </summary>
        [JsonProperty("begin_time", NullValueHandling = NullValueHandling.Ignore)]
        public string BeginTime { get; set; }

        /// <summary>
        /// 备份结束时间，格式为“yyyy-mm-dd hh:mm:ss”。该时间为UTC时间。
        /// </summary>
        [JsonProperty("end_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EndTime { get; set; }

        /// <summary>
        /// 备份状态。 取值： - BUILDING：备份中。 - COMPLETED：备份完成。 - FAILED：备份失败。 - DISABLED：备份删除中。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 备份大小，单位：KB。
        /// </summary>
        [JsonProperty("size", NullValueHandling = NullValueHandling.Ignore)]
        public int? Size { get; set; }

        /// <summary>
        /// 备份描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListBackupsResult {\n");
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
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListBackupsResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListBackupsResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.InstanceId == input.InstanceId ||
                    (this.InstanceId != null &&
                    this.InstanceId.Equals(input.InstanceId))
                ) && 
                (
                    this.InstanceName == input.InstanceName ||
                    (this.InstanceName != null &&
                    this.InstanceName.Equals(input.InstanceName))
                ) && 
                (
                    this.Datastore == input.Datastore ||
                    (this.Datastore != null &&
                    this.Datastore.Equals(input.Datastore))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Size == input.Size ||
                    (this.Size != null &&
                    this.Size.Equals(input.Size))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.InstanceId != null)
                    hashCode = hashCode * 59 + this.InstanceId.GetHashCode();
                if (this.InstanceName != null)
                    hashCode = hashCode * 59 + this.InstanceName.GetHashCode();
                if (this.Datastore != null)
                    hashCode = hashCode * 59 + this.Datastore.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.BeginTime != null)
                    hashCode = hashCode * 59 + this.BeginTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Size != null)
                    hashCode = hashCode * 59 + this.Size.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                return hashCode;
            }
        }
    }
}
