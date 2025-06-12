using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsBuild.V3.Model
{
    /// <summary>
    /// 租户下文件列表
    /// </summary>
    public class ListKeystoreSearchResponseBodyResult 
    {

        /// <summary>
        /// 总数
        /// </summary>
        [JsonProperty("total", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Total { get; set; }

        /// <summary>
        /// 文件列表
        /// </summary>
        [JsonProperty("keystore_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<ListKeystoreSearchResponseBodyResultKeystoreList> KeystoreList { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListKeystoreSearchResponseBodyResult {\n");
            sb.Append("  total: ").Append(Total).Append("\n");
            sb.Append("  keystoreList: ").Append(KeystoreList).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListKeystoreSearchResponseBodyResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListKeystoreSearchResponseBodyResult input)
        {
            if (input == null) return false;
            if (this.Total != input.Total || (this.Total != null && !this.Total.Equals(input.Total))) return false;
            if (this.KeystoreList != input.KeystoreList || (this.KeystoreList != null && input.KeystoreList != null && !this.KeystoreList.SequenceEqual(input.KeystoreList))) return false;

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
                if (this.Total != null) hashCode = hashCode * 59 + this.Total.GetHashCode();
                if (this.KeystoreList != null) hashCode = hashCode * 59 + this.KeystoreList.GetHashCode();
                return hashCode;
            }
        }
    }
}
