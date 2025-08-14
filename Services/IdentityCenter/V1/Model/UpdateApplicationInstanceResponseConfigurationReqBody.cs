using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IdentityCenter.V1.Model
{
    /// <summary>
    /// UpdateApplicationInstanceResponseConfiguration的请求体
    /// </summary>
    public class UpdateApplicationInstanceResponseConfigurationReqBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response_config", NullValueHandling = NullValueHandling.Ignore)]
        public ResponseConfigDto ResponseConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateApplicationInstanceResponseConfigurationReqBody {\n");
            sb.Append("  responseConfig: ").Append(ResponseConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateApplicationInstanceResponseConfigurationReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateApplicationInstanceResponseConfigurationReqBody input)
        {
            if (input == null) return false;
            if (this.ResponseConfig != input.ResponseConfig || (this.ResponseConfig != null && !this.ResponseConfig.Equals(input.ResponseConfig))) return false;

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
                if (this.ResponseConfig != null) hashCode = hashCode * 59 + this.ResponseConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
