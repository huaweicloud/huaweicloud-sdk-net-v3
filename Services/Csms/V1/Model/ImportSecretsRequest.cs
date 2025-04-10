using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Csms.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ImportSecretsRequest 
    {

        /// <summary>
        /// 批量创建凭据参数
        /// </summary>
        [JsonProperty("secrets", NullValueHandling = NullValueHandling.Ignore)]
        public List<CreateSecretRequestBody> Secrets { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ImportSecretsRequest {\n");
            sb.Append("  secrets: ").Append(Secrets).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ImportSecretsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ImportSecretsRequest input)
        {
            if (input == null) return false;
            if (this.Secrets != input.Secrets || (this.Secrets != null && input.Secrets != null && !this.Secrets.SequenceEqual(input.Secrets))) return false;

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
                if (this.Secrets != null) hashCode = hashCode * 59 + this.Secrets.GetHashCode();
                return hashCode;
            }
        }
    }
}
