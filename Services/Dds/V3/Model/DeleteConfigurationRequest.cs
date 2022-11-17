using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class DeleteConfigurationRequest 
    {

        /// <summary>
        /// 参数模板ID。
        /// </summary>
        [SDKProperty("config_id", IsPath = true)]
        [JsonProperty("config_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ConfigId { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteConfigurationRequest {\n");
            sb.Append("  configId: ").Append(ConfigId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteConfigurationRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteConfigurationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ConfigId == input.ConfigId ||
                    (this.ConfigId != null &&
                    this.ConfigId.Equals(input.ConfigId))
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
                if (this.ConfigId != null)
                    hashCode = hashCode * 59 + this.ConfigId.GetHashCode();
                return hashCode;
            }
        }
    }
}
