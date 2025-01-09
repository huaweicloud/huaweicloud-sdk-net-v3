using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListAccessPolicyObjectsResponse : SdkResponse
    {

        /// <summary>
        /// 查询接入策略应用对象响应。
        /// </summary>
        [JsonProperty("policy_objects_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<AccessPolicyObject> PolicyObjectsList { get; set; }

        /// <summary>
        /// 对象总数。
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListAccessPolicyObjectsResponse {\n");
            sb.Append("  policyObjectsList: ").Append(PolicyObjectsList).Append("\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListAccessPolicyObjectsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListAccessPolicyObjectsResponse input)
        {
            if (input == null) return false;
            if (this.PolicyObjectsList != input.PolicyObjectsList || (this.PolicyObjectsList != null && input.PolicyObjectsList != null && !this.PolicyObjectsList.SequenceEqual(input.PolicyObjectsList))) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;

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
                if (this.PolicyObjectsList != null) hashCode = hashCode * 59 + this.PolicyObjectsList.GetHashCode();
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                return hashCode;
            }
        }
    }
}
