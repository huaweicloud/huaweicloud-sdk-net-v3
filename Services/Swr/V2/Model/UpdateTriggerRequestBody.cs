using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Swr.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class UpdateTriggerRequestBody 
    {

        /// <summary>
        /// 是否生效,true启用，false不启用
        /// </summary>
        [JsonProperty("enable", NullValueHandling = NullValueHandling.Ignore)]
        public string Enable { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTriggerRequestBody {\n");
            sb.Append("  enable: ").Append(Enable).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateTriggerRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateTriggerRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enable == input.Enable ||
                    (this.Enable != null &&
                    this.Enable.Equals(input.Enable))
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
                if (this.Enable != null)
                    hashCode = hashCode * 59 + this.Enable.GetHashCode();
                return hashCode;
            }
        }
    }
}
