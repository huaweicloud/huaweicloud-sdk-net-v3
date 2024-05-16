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
    /// Response Object
    /// </summary>
    public class ListResourceSharePermissionsResponse : SdkResponse
    {

        /// <summary>
        /// 资源共享实例关联的共享资源权限信息列表。
        /// </summary>
        [JsonProperty("associated_permissions", NullValueHandling = NullValueHandling.Ignore)]
        public List<AssociatedPermission> AssociatedPermissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("page_info", NullValueHandling = NullValueHandling.Ignore)]
        public PageInfo PageInfo { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListResourceSharePermissionsResponse {\n");
            sb.Append("  associatedPermissions: ").Append(AssociatedPermissions).Append("\n");
            sb.Append("  pageInfo: ").Append(PageInfo).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListResourceSharePermissionsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListResourceSharePermissionsResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AssociatedPermissions == input.AssociatedPermissions ||
                    this.AssociatedPermissions != null &&
                    input.AssociatedPermissions != null &&
                    this.AssociatedPermissions.SequenceEqual(input.AssociatedPermissions)
                ) && 
                (
                    this.PageInfo == input.PageInfo ||
                    (this.PageInfo != null &&
                    this.PageInfo.Equals(input.PageInfo))
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
                if (this.AssociatedPermissions != null)
                    hashCode = hashCode * 59 + this.AssociatedPermissions.GetHashCode();
                if (this.PageInfo != null)
                    hashCode = hashCode * 59 + this.PageInfo.GetHashCode();
                return hashCode;
            }
        }
    }
}
