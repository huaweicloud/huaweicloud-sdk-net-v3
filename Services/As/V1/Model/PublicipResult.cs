using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.As.V1.Model
{
    /// <summary>
    /// 弹性IP信息
    /// </summary>
    public class PublicipResult 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("eip", NullValueHandling = NullValueHandling.Ignore)]
        public EipResult Eip { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicipResult {\n");
            sb.Append("  eip: ").Append(Eip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicipResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublicipResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Eip == input.Eip ||
                    (this.Eip != null &&
                    this.Eip.Equals(input.Eip))
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
                if (this.Eip != null)
                    hashCode = hashCode * 59 + this.Eip.GetHashCode();
                return hashCode;
            }
        }
    }
}
