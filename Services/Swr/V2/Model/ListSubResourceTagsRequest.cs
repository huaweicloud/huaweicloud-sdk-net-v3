using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListSubResourceTagsRequest 
    {
        /// <summary>
        /// 资源类型，支持的资源类型为：instances
        /// </summary>
        /// <value>资源类型，支持的资源类型为：instances</value>
        [JsonConverter(typeof(EnumClassConverter<ResourceTypeEnum>))]
        public class ResourceTypeEnum
        {
            /// <summary>
            /// Enum INSTANCES for value: instances
            /// </summary>
            public static readonly ResourceTypeEnum INSTANCES = new ResourceTypeEnum("instances");

            private static readonly Dictionary<string, ResourceTypeEnum> StaticFields =
            new Dictionary<string, ResourceTypeEnum>()
            {
                { "instances", INSTANCES },
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

            public static bool operator !=(ResourceTypeEnum a, ResourceTypeEnum b)
            {
                return !(a == b);
            }
        }

        /// <summary>
        /// 子资源类型，支持的子资源类型为：namespaces
        /// </summary>
        /// <value>子资源类型，支持的子资源类型为：namespaces</value>
        [JsonConverter(typeof(EnumClassConverter<SubResourceTypeEnum>))]
        public class SubResourceTypeEnum
        {
            /// <summary>
            /// Enum NAMESPACES for value: namespaces
            /// </summary>
            public static readonly SubResourceTypeEnum NAMESPACES = new SubResourceTypeEnum("namespaces");

            private static readonly Dictionary<string, SubResourceTypeEnum> StaticFields =
            new Dictionary<string, SubResourceTypeEnum>()
            {
                { "namespaces", NAMESPACES },
            };

            private string _value;

            public SubResourceTypeEnum()
            {

            }

            public SubResourceTypeEnum(string value)
            {
                _value = value;
            }

            public static SubResourceTypeEnum FromValue(string value)
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

                if (this.Equals(obj as SubResourceTypeEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(SubResourceTypeEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(SubResourceTypeEnum a, SubResourceTypeEnum b)
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

            public static bool operator !=(SubResourceTypeEnum a, SubResourceTypeEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 资源类型，支持的资源类型为：instances
        /// </summary>
        [SDKProperty("resource_type", IsPath = true)]
        [JsonProperty("resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceTypeEnum ResourceType { get; set; }
        /// <summary>
        /// 资源id
        /// </summary>
        [SDKProperty("resource_id", IsPath = true)]
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 子资源类型，支持的子资源类型为：namespaces
        /// </summary>
        [SDKProperty("sub_resource_type", IsPath = true)]
        [JsonProperty("sub_resource_type", NullValueHandling = NullValueHandling.Ignore)]
        public SubResourceTypeEnum SubResourceType { get; set; }
        /// <summary>
        /// 子资源id
        /// </summary>
        [SDKProperty("sub_resource_id", IsPath = true)]
        [JsonProperty("sub_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SubResourceId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListSubResourceTagsRequest {\n");
            sb.Append("  resourceType: ").Append(ResourceType).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  subResourceType: ").Append(SubResourceType).Append("\n");
            sb.Append("  subResourceId: ").Append(SubResourceId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListSubResourceTagsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListSubResourceTagsRequest input)
        {
            if (input == null) return false;
            if (this.ResourceType != input.ResourceType) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.SubResourceType != input.SubResourceType) return false;
            if (this.SubResourceId != input.SubResourceId || (this.SubResourceId != null && !this.SubResourceId.Equals(input.SubResourceId))) return false;

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
                hashCode = hashCode * 59 + this.ResourceType.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                hashCode = hashCode * 59 + this.SubResourceType.GetHashCode();
                if (this.SubResourceId != null) hashCode = hashCode * 59 + this.SubResourceId.GetHashCode();
                return hashCode;
            }
        }
    }
}
