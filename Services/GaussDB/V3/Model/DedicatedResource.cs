using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 专属资源池信息。
    /// </summary>
    public class DedicatedResource 
    {
        /// <summary>
        /// 专属资源池状态
        /// </summary>
        /// <value>专属资源池状态</value>
        [JsonConverter(typeof(EnumClassConverter<StatusEnum>))]
        public class StatusEnum
        {
            /// <summary>
            /// Enum NORMAL for value: NORMAL
            /// </summary>
            public static readonly StatusEnum NORMAL = new StatusEnum("NORMAL");

            /// <summary>
            /// Enum BUILDING for value: BUILDING
            /// </summary>
            public static readonly StatusEnum BUILDING = new StatusEnum("BUILDING");

            /// <summary>
            /// Enum EXTENDING for value: EXTENDING
            /// </summary>
            public static readonly StatusEnum EXTENDING = new StatusEnum("EXTENDING");

            /// <summary>
            /// Enum DELETED for value: DELETED
            /// </summary>
            public static readonly StatusEnum DELETED = new StatusEnum("DELETED");

            private static readonly Dictionary<string, StatusEnum> StaticFields =
            new Dictionary<string, StatusEnum>()
            {
                { "NORMAL", NORMAL },
                { "BUILDING", BUILDING },
                { "EXTENDING", EXTENDING },
                { "DELETED", DELETED },
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
        /// 专属资源池ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 专属资源池名称
        /// </summary>
        [JsonProperty("resource_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceName { get; set; }

        /// <summary>
        /// 数据库引擎名称
        /// </summary>
        [JsonProperty("engine_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EngineName { get; set; }

        /// <summary>
        /// CPU架构
        /// </summary>
        [JsonProperty("architecture", NullValueHandling = NullValueHandling.Ignore)]
        public string Architecture { get; set; }

        /// <summary>
        /// 专属资源池状态
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("capacity", NullValueHandling = NullValueHandling.Ignore)]
        public DedicatedResourceCapacity Capacity { get; set; }

        /// <summary>
        /// 专属资源池可用区信息。
        /// </summary>
        [JsonProperty("availability_zone", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> AvailabilityZone { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DedicatedResource {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  resourceName: ").Append(ResourceName).Append("\n");
            sb.Append("  engineName: ").Append(EngineName).Append("\n");
            sb.Append("  architecture: ").Append(Architecture).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  capacity: ").Append(Capacity).Append("\n");
            sb.Append("  availabilityZone: ").Append(AvailabilityZone).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DedicatedResource);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DedicatedResource input)
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
                    this.ResourceName == input.ResourceName ||
                    (this.ResourceName != null &&
                    this.ResourceName.Equals(input.ResourceName))
                ) && 
                (
                    this.EngineName == input.EngineName ||
                    (this.EngineName != null &&
                    this.EngineName.Equals(input.EngineName))
                ) && 
                (
                    this.Architecture == input.Architecture ||
                    (this.Architecture != null &&
                    this.Architecture.Equals(input.Architecture))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Capacity == input.Capacity ||
                    (this.Capacity != null &&
                    this.Capacity.Equals(input.Capacity))
                ) && 
                (
                    this.AvailabilityZone == input.AvailabilityZone ||
                    this.AvailabilityZone != null &&
                    input.AvailabilityZone != null &&
                    this.AvailabilityZone.SequenceEqual(input.AvailabilityZone)
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
                if (this.ResourceName != null)
                    hashCode = hashCode * 59 + this.ResourceName.GetHashCode();
                if (this.EngineName != null)
                    hashCode = hashCode * 59 + this.EngineName.GetHashCode();
                if (this.Architecture != null)
                    hashCode = hashCode * 59 + this.Architecture.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Capacity != null)
                    hashCode = hashCode * 59 + this.Capacity.GetHashCode();
                if (this.AvailabilityZone != null)
                    hashCode = hashCode * 59 + this.AvailabilityZone.GetHashCode();
                return hashCode;
            }
        }
    }
}
