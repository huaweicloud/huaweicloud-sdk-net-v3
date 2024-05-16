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
    /// The request body of the AssociateResourceSharePermission operation.
    /// </summary>
    public class AssociatePermissionReqBody 
    {

        /// <summary>
        /// 指定特定的权限替换或绑定到与资源共享实例关联的现有资源类型。设置为\&quot;true\&quot;可将相同的资源类型的权限替换为当前权限。设置为\&quot;false\&quot;将权限绑定到当前资源类型。默认值为\&quot;false\&quot;。资源共享实例中的每个资源类型只能绑定一个权限。如果资源共享实例中已具有指定资源类型的权限，并且将\&quot;replace\&quot;设置为\&quot;false\&quot;，则操作返回错误。这有助于防止意外覆盖权限。
        /// </summary>
        [JsonProperty("replace", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Replace { get; set; }

        /// <summary>
        /// 共享资源权限的ID。
        /// </summary>
        [JsonProperty("permission_id", NullValueHandling = NullValueHandling.Ignore)]
        public string PermissionId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AssociatePermissionReqBody {\n");
            sb.Append("  replace: ").Append(Replace).Append("\n");
            sb.Append("  permissionId: ").Append(PermissionId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AssociatePermissionReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AssociatePermissionReqBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Replace == input.Replace ||
                    (this.Replace != null &&
                    this.Replace.Equals(input.Replace))
                ) && 
                (
                    this.PermissionId == input.PermissionId ||
                    (this.PermissionId != null &&
                    this.PermissionId.Equals(input.PermissionId))
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
                if (this.Replace != null)
                    hashCode = hashCode * 59 + this.Replace.GetHashCode();
                if (this.PermissionId != null)
                    hashCode = hashCode * 59 + this.PermissionId.GetHashCode();
                return hashCode;
            }
        }
    }
}
