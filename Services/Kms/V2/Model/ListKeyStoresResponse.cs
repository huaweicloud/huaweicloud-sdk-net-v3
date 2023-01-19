using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Kms.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ListKeyStoresResponse : SdkResponse
    {

        /// <summary>
        /// 密钥库总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public int? Total { get; set; }

        /// <summary>
        /// 密钥详情列表。详情参见KeystoreDetails
        /// </summary>
        [JsonProperty("keystores", NullValueHandling = NullValueHandling.Ignore)]
        public List<KeystoreDetails> Keystores { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListKeyStoresResponse {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  keystores: ").Append(Keystores).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListKeyStoresResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListKeyStoresResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Total == input.Total ||
                    (this.Total != null &&
                    this.Total.Equals(input.Total))
                ) && 
                (
                    this.Keystores == input.Keystores ||
                    this.Keystores != null &&
                    input.Keystores != null &&
                    this.Keystores.SequenceEqual(input.Keystores)
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
                if (this.Total != null)
                    hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.Keystores != null)
                    hashCode = hashCode * 59 + this.Keystores.GetHashCode();
                return hashCode;
            }
        }
    }
}
