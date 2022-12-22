using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpcep.V1.Model
{
    /// <summary>
    /// 批量删除终端节点服务白名单列表。
    /// </summary>
    public class BatchRemovePermissionRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("permissions", NullValueHandling = NullValueHandling.Ignore)]
        public List<EpsRemovePermissionRequest> Permissions { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BatchRemovePermissionRequest {\n");
            sb.Append("  permissions: ").Append(Permissions).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as BatchRemovePermissionRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(BatchRemovePermissionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Permissions == input.Permissions ||
                    this.Permissions != null &&
                    input.Permissions != null &&
                    this.Permissions.SequenceEqual(input.Permissions)
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
                if (this.Permissions != null)
                    hashCode = hashCode * 59 + this.Permissions.GetHashCode();
                return hashCode;
            }
        }
    }
}
