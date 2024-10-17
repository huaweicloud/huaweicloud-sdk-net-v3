using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Msgsms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class UpdateSignatureResponse : SdkResponse
    {

        /// <summary>
        /// 签名主键ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 签名ID
        /// </summary>
        [JsonProperty("signature_id", NullValueHandling = NullValueHandling.Ignore)]
        public string SignatureId { get; set; }

        /// <summary>
        /// 签名名称
        /// </summary>
        [JsonProperty("signature_name", NullValueHandling = NullValueHandling.Ignore)]
        public string SignatureName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateSignatureResponse {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  signatureId: ").Append(SignatureId).Append("\n");
            sb.Append("  signatureName: ").Append(SignatureName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateSignatureResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateSignatureResponse input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.SignatureId != input.SignatureId || (this.SignatureId != null && !this.SignatureId.Equals(input.SignatureId))) return false;
            if (this.SignatureName != input.SignatureName || (this.SignatureName != null && !this.SignatureName.Equals(input.SignatureName))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.SignatureId != null) hashCode = hashCode * 59 + this.SignatureId.GetHashCode();
                if (this.SignatureName != null) hashCode = hashCode * 59 + this.SignatureName.GetHashCode();
                return hashCode;
            }
        }
    }
}
