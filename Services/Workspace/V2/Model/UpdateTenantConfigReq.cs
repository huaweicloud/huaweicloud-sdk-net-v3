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
    /// 
    /// </summary>
    public class UpdateTenantConfigReq 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("function_config", NullValueHandling = NullValueHandling.Ignore)]
        public FunctionConfig FunctionConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTenantConfigReq {\n");
            sb.Append("  functionConfig: ").Append(FunctionConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTenantConfigReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTenantConfigReq input)
        {
            if (input == null) return false;
            if (this.FunctionConfig != input.FunctionConfig || (this.FunctionConfig != null && !this.FunctionConfig.Equals(input.FunctionConfig))) return false;

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
                if (this.FunctionConfig != null) hashCode = hashCode * 59 + this.FunctionConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
