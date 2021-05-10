using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cce.V3.Model
{
    /// <summary>
    /// 集群证书有效期
    /// </summary>
    public class CertDuration 
    {

        /// <summary>
        /// 集群证书有效时间，单位为天，用户可申请1-10950天，若填写-1则为最大值10950天，10950天约为30年。
        /// </summary>
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public int? Duration { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CertDuration {\n");
            sb.Append("  duration: ").Append(Duration).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as CertDuration);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(CertDuration input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Duration == input.Duration ||
                    (this.Duration != null &&
                    this.Duration.Equals(input.Duration))
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
                if (this.Duration != null)
                    hashCode = hashCode * 59 + this.Duration.GetHashCode();
                return hashCode;
            }
        }
    }
}
