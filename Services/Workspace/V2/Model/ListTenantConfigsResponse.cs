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
    public class ListTenantConfigsResponse : SdkResponse
    {

        /// <summary>
        /// 租户个性配置列表
        /// </summary>
        [JsonProperty("function_configs", NullValueHandling = NullValueHandling.Ignore)]
        public List<FunctionConfig> FunctionConfigs { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTenantConfigsResponse {\n");
            sb.Append("  functionConfigs: ").Append(FunctionConfigs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTenantConfigsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTenantConfigsResponse input)
        {
            if (input == null) return false;
            if (this.FunctionConfigs != input.FunctionConfigs || (this.FunctionConfigs != null && input.FunctionConfigs != null && !this.FunctionConfigs.SequenceEqual(input.FunctionConfigs))) return false;

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
                if (this.FunctionConfigs != null) hashCode = hashCode * 59 + this.FunctionConfigs.GetHashCode();
                return hashCode;
            }
        }
    }
}
