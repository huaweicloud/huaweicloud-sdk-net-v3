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
    /// 配置云服务器的弹性IP信息
    /// </summary>
    public class PublicIp 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("eip", NullValueHandling = NullValueHandling.Ignore)]
        public EipInfo Eip { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PublicIp {\n");
            sb.Append("  eip: ").Append(Eip).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PublicIp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PublicIp input)
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
