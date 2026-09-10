using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class GetInstancesOpsResourceUsageRequest 
    {
        /// <summary>
        /// 资源类型。取值范围：cpu、mem、disk、disk_week、io。
        /// </summary>
        /// <value>资源类型。取值范围：cpu、mem、disk、disk_week、io。</value>
        [JsonConverter(typeof(EnumClassConverter<ResourceTypeEnum>))]
        public class ResourceTypeEnum
        {
            /// <summary>
            /// Enum CPU for value: cpu
            /// </summary>
            public static readonly ResourceTypeEnum CPU = new ResourceTypeEnum("cpu");

            /// <summary>
            /// Enum MEM for value: mem
            /// </summary>
            public static readonly ResourceTypeEnum MEM = new ResourceTypeEnum("mem");

            /// <summary>
            /// Enum DISK for value: disk
            /// </summary>
            public static readonly ResourceTypeEnum DISK = new ResourceTypeEnum("disk");

            /// <summary>
            /// Enum DISK_WEEK for value: disk_week
            /// </summary>
            public static readonly ResourceTypeEnum DISK_WEEK = new ResourceTypeEnum("disk_week");

            /// <summary>
            /// Enum IO for value: io
            /// </summary>
            public static readonly ResourceTypeEnum IO = new ResourceTypeEnum("io");

            private static readonly Dictionary<string, ResourceTypeEnum> StaticFields =
            new Dictionary<string, ResourceTypeEnum>()
            {
                { "cpu", CPU },
                { "mem", MEM },
                { "disk", DISK },
                { "disk_week", DISK_WEEK },
                { "io", IO },
            };

            private string _value;

            public ResourceTypeEnum()
            {

            }

            public ResourceTypeEnum(string value)
            {
                _value = value;
            }

            public static ResourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as ResourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResourceTypeEnum a, ResourceTypeEnum b)
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

            public static bool operator !=(ResourceTypeEnum a, ResourceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 实例ID
        /// </summary>
        [SDKProperty("instance_id", IsPath = true)]
        [JsonProperty("instance_id", NullValueHandling = NullValueHandling.Ignore)]
        public string InstanceId { get; set; }

        /// <summary>
        /// 语言。默认en-us。
        /// </summary>
        [SDKProperty("X-Language", IsHeader = true)]
        [JsonProperty("X-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string XLanguage { get; set; }

        /// <summary>
        /// 资源类型。取值范围：cpu、mem、disk、disk_week、io。
        /// </summary>
        [SDKProperty("resource_type", IsQuery = true)]
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceTypeEnum ResourceType { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetInstancesOpsResourceUsageRequest {\n");
            sb.Append("  instanceId: ").Append(InstanceId).Append("\n");
            sb.Append("  xLanguage: ").Append(XLanguage).Append("\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as GetInstancesOpsResourceUsageRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(GetInstancesOpsResourceUsageRequest input)
        {
            if (input == null) return false;
            if (this.InstanceId != input.InstanceId || (this.InstanceId != null && !this.InstanceId.Equals(input.InstanceId))) return false;
            if (this.XLanguage != input.XLanguage || (this.XLanguage != null && !this.XLanguage.Equals(input.XLanguage))) return false;
            if (this.ResourceType != input.ResourceType) return false;

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
                if (this.XLanguage != null) hashCode = hashCode * 59 + this.XLanguage.GetHashCode();
                hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                return hashCode;
            }
        }
    }
}
