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
    /// The request body of the SearchResourceShares operation.
    /// </summary>
    public class SearchResourceSharesReqBody 
    {
        /// <summary>
        /// 检索您创建的或共享给您的（self或者other-accounts）资源共享实例。
        /// </summary>
        /// <value>检索您创建的或共享给您的（self或者other-accounts）资源共享实例。</value>
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
        /// 资源共享实例名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 页面标记。
        /// </summary>
        [JsonProperty("marker", NullValueHandling = NullValueHandling.Ignore)]
        public string Marker { get; set; }

        /// <summary>
        /// 权限ID。
        /// </summary>
        [JsonProperty("permission_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PermissionId { get; set; }

        /// <summary>
        /// 检索您创建的或共享给您的（self或者other-accounts）资源共享实例。
        /// </summary>
        [JsonProperty("resource_owner", NullValueHandling = NullValueHandling.Ignore)]
        public ResourceOwnerEnum ResourceOwner { get; set; }
        /// <summary>
        /// 资源共享实例的ID列表。
        /// </summary>
        [JsonProperty("resource_share_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceShareIds { get; set; }

        /// <summary>
        /// 资源共享实例的状态。
        /// </summary>
        [JsonProperty("resource_share_status", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceShareStatus { get; set; }

        /// <summary>
        /// 资源共享实例的标签。
        /// </summary>
        [JsonProperty("tag_filters", NullValueHandling = NullValueHandling.Ignore)]
        public List<TagFilter> TagFilters { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchResourceSharesReqBody {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  marker: ").Append(Marker).Append("\n");
            sb.Append("  permissionId: ").Append(PermissionId).Append("\n");
            sb.Append("  resourceOwner: ").Append(ResourceOwner).Append("\n");
            sb.Append("  resourceShareIds: ").Append(ResourceShareIds).Append("\n");
            sb.Append("  resourceShareStatus: ").Append(ResourceShareStatus).Append("\n");
            sb.Append("  tagFilters: ").Append(TagFilters).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchResourceSharesReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchResourceSharesReqBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Limit == input.Limit ||
                    (this.Limit != null &&
                    this.Limit.Equals(input.Limit))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Marker == input.Marker ||
                    (this.Marker != null &&
                    this.Marker.Equals(input.Marker))
                ) && 
                (
                    this.PermissionId == input.PermissionId ||
                    (this.PermissionId != null &&
                    this.PermissionId.Equals(input.PermissionId))
                ) && 
                (
                    this.ResourceOwner == input.ResourceOwner ||
                    (this.ResourceOwner != null &&
                    this.ResourceOwner.Equals(input.ResourceOwner))
                ) && 
                (
                    this.ResourceShareIds == input.ResourceShareIds ||
                    this.ResourceShareIds != null &&
                    input.ResourceShareIds != null &&
                    this.ResourceShareIds.SequenceEqual(input.ResourceShareIds)
                ) && 
                (
                    this.ResourceShareStatus == input.ResourceShareStatus ||
                    (this.ResourceShareStatus != null &&
                    this.ResourceShareStatus.Equals(input.ResourceShareStatus))
                ) && 
                (
                    this.TagFilters == input.TagFilters ||
                    this.TagFilters != null &&
                    input.TagFilters != null &&
                    this.TagFilters.SequenceEqual(input.TagFilters)
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
                if (this.Limit != null)
                    hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Marker != null)
                    hashCode = hashCode * 59 + this.Marker.GetHashCode();
                if (this.PermissionId != null)
                    hashCode = hashCode * 59 + this.PermissionId.GetHashCode();
                if (this.ResourceOwner != null)
                    hashCode = hashCode * 59 + this.ResourceOwner.GetHashCode();
                if (this.ResourceShareIds != null)
                    hashCode = hashCode * 59 + this.ResourceShareIds.GetHashCode();
                if (this.ResourceShareStatus != null)
                    hashCode = hashCode * 59 + this.ResourceShareStatus.GetHashCode();
                if (this.TagFilters != null)
                    hashCode = hashCode * 59 + this.TagFilters.GetHashCode();
                return hashCode;
            }
        }
    }
}
