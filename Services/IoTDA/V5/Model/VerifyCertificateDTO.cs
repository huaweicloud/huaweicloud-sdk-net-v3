using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.IoTDA.V5.Model
{
    /// <summary>
    /// 验证CA证书结构体。
    /// </summary>
    public class VerifyCertificateDTO 
    {

        /// <summary>
        /// 验证证书的内容信息。
        /// </summary>
        [JsonProperty("verify_content", NullValueHandling = NullValueHandling.Ignore)]
        public string VerifyContent { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyCertificateDTO {\n");
            sb.Append("  verifyContent: ").Append(VerifyContent).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VerifyCertificateDTO);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VerifyCertificateDTO input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.VerifyContent == input.VerifyContent ||
                    (this.VerifyContent != null &&
                    this.VerifyContent.Equals(input.VerifyContent))
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
                if (this.VerifyContent != null)
                    hashCode = hashCode * 59 + this.VerifyContent.GetHashCode();
                return hashCode;
            }
        }
    }
}
