using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ApplyConfigurationRequestBody 
    {

        /// <summary>
        /// 实例ID列表对象。
        /// </summary>
        [JsonProperty("instance_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> InstanceIds { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApplyConfigurationRequestBody {\n");
            sb.Append("  instanceIds: ").Append(InstanceIds).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApplyConfigurationRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApplyConfigurationRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InstanceIds == input.InstanceIds ||
                    this.InstanceIds != null &&
                    input.InstanceIds != null &&
                    this.InstanceIds.SequenceEqual(input.InstanceIds)
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
                if (this.InstanceIds != null)
                    hashCode = hashCode * 59 + this.InstanceIds.GetHashCode();
                return hashCode;
            }
        }
    }
}
