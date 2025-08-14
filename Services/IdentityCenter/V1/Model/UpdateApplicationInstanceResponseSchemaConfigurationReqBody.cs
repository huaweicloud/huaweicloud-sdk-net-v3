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
    /// UpdateApplicationInstanceResponseSchemaConfiguration的请求体
    /// </summary>
    public class UpdateApplicationInstanceResponseSchemaConfigurationReqBody 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("response_schema_config", NullValueHandling = NullValueHandling.Ignore)]
        public ResponseSchemaConfigDto ResponseSchemaConfig { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateApplicationInstanceResponseSchemaConfigurationReqBody {\n");
            sb.Append("  responseSchemaConfig: ").Append(ResponseSchemaConfig).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateApplicationInstanceResponseSchemaConfigurationReqBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateApplicationInstanceResponseSchemaConfigurationReqBody input)
        {
            if (input == null) return false;
            if (this.ResponseSchemaConfig != input.ResponseSchemaConfig || (this.ResponseSchemaConfig != null && !this.ResponseSchemaConfig.Equals(input.ResponseSchemaConfig))) return false;

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
                if (this.ResponseSchemaConfig != null) hashCode = hashCode * 59 + this.ResponseSchemaConfig.GetHashCode();
                return hashCode;
            }
        }
    }
}
