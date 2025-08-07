using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ram.V1.Model
{
    /// <summary>
    /// The request body of the SearchSharedResources operation.
    /// </summary>
    public class SearchDistinctSharedResourcesReqBody 
    {
        /// <summary>
        /// 指定资源共享实例的所有者（self或者other-accounts）。
        /// </summary>
        /// <value>指定资源共享实例的所有者（self或者other-accounts）。</value>
        [JsonConverter(typeof(EnumClassConverter<ResourceOwnerEnum>))]
        public class ResourceOwnerEnum
        {
            /// <summary>
            /// Enum SELF for value: self
            /// </summary>
            public static readonly ResourceOwnerEnum SELF = new ResourceOwnerEnum("self");

            /// <summary>
            /// Enum OTHER_ACCOUNTS for value: other-accounts
            /// </summary>
            public static readonly ResourceOwnerEnum OTHER_ACCOUNTS = new ResourceOwnerEnum("other-accounts");

            private static readonly Dictionary<string, ResourceOwnerEnum> StaticFields =
            new Dictionary<string, ResourceOwnerEnum>()
            {
                { "self", SELF },
                { "other-accounts", OTHER_ACCOUNTS },
            };

            private string _value;

            public ResourceOwnerEnum()
            {

            }

            public ResourceOwnerEnum(string value)
            {
                _value = value;
            }

            public static ResourceOwnerEnum FromValue(string value)
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

                if (this.Equals(obj as ResourceOwnerEnum))
                {
                    return true;
                }

                return false;
            }

            public bool Equals(ResourceOwnerEnum obj)
            {
                if ((object)obj == null)
                {
                    return false;
                }
                return StringComparer.OrdinalIgnoreCase.Equals(this._value, obj.GetValue());
            }

            public static bool operator ==(ResourceOwnerEnum a, ResourceOwnerEnum b)
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

            public static bool operator !=(ResourceOwnerEnum a, ResourceOwnerEnum b)
            {
                return !(a == b);
            }
        }


        /// <summary>
        /// 分页页面的最大值。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 页面标记。
        /// </summary>
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 指定资源ID。
        /// </summary>
        [JsonProperty("resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// 指定资源使用者。
        /// </summary>
        [JsonProperty("principal", NullValueHandling = NullValueHandling.Ignore)]
        public string Principal { get; set; }

        /// <summary>
        /// 资源所在的区域。
        /// </summary>
        [JsonProperty("resource_region", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceRegion { get; set; }

        /// <summary>
        /// 指定资源URN的列表。
        /// </summary>
        [JsonProperty("resource_urns", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceUrns { get; set; }

        /// <summary>
        /// 指定资源共享实例的所有者（self或者other-accounts）。
        /// </summary>
        [JsonProperty("resource_owner", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceOwnerEnum ResourceOwner { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchDistinctSharedResourcesReqBody {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  resourceIds: ").Append(ResourceIds).Append("\n");
            sb.Append("  principal: ").Append(Principal).Append("\n");
            sb.Append("  resourceRegion: ").Append(ResourceRegion).Append("\n");
            sb.Append("  resourceUrns: ").Append(ResourceUrns).Append("\n");
            sb.Append("  resourceOwner: ").Append(ResourceOwner).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchDistinctSharedResourcesReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchDistinctSharedResourcesReqBody input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Marker != input.Marker || (this.Marker != null && !this.Marker.Equals(input.Marker))) return false;
            if (this.ResourceIds != input.ResourceIds || (this.ResourceIds != null && input.ResourceIds != null && !this.ResourceIds.SequenceEqual(input.ResourceIds))) return false;
            if (this.Principal != input.Principal || (this.Principal != null && !this.Principal.Equals(input.Principal))) return false;
            if (this.ResourceRegion != input.ResourceRegion || (this.ResourceRegion != null && !this.ResourceRegion.Equals(input.ResourceRegion))) return false;
            if (this.ResourceUrns != input.ResourceUrns || (this.ResourceUrns != null && input.ResourceUrns != null && !this.ResourceUrns.SequenceEqual(input.ResourceUrns))) return false;
            if (this.ResourceOwner != input.ResourceOwner) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Marker != null) hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.ResourceIds != null) hashCode = hashCode * 59 + this.ResourceIds.GetHashCode();
                if (this.Principal != null) hashCode = hashCode * 59 + this.Principal.GetHashCode();
                if (this.ResourceRegion != null) hashCode = hashCode * 59 + this.ResourceRegion.GetHashCode();
                if (this.ResourceUrns != null) hashCode = hashCode * 59 + this.ResourceUrns.GetHashCode();
                hashCode = hashCode * 59 + this.ResourceOwner.GetHashCode();
                return hashCode;
            }
        }
    }
}
