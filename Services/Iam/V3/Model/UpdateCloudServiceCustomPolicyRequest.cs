using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Iam.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class UpdateCloudServiceCustomPolicyRequest 
    {

        /// <summary>
        /// 待修改的自定义策略ID，获取方式请参见：[自定义策略ID](https://apiexplorer.developer.huaweicloud.com/apiexplorer/doc?product&#x3D;IAM&amp;api&#x3D;ListCustomPolicies)。
        /// </summary>
        [SDKProperty("role_id", IsPath = true)]
        [JsonProperty("role_id", NullValueHandling = NullValueHandling.Ignore)]
        public string RoleId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [SDKProperty("body", IsBody = true)]
        [JsonProperty("body", NullValueHandling = NullValueHandling.Ignore)]
        public UpdateCloudServiceCustomPolicyRequestBody Body { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCloudServiceCustomPolicyRequest {\n");
            sb.Append("  roleId: ").Append(RoleId).Append("\n");
            sb.Append("  body: ").Append(Body).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateCloudServiceCustomPolicyRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateCloudServiceCustomPolicyRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RoleId == input.RoleId ||
                    (this.RoleId != null &&
                    this.RoleId.Equals(input.RoleId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.RoleId != null)
                    hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                return hashCode;
            }
        }
    }
}
