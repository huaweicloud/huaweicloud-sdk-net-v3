using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cpcs.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class KmsResourceInfo 
    {

        /// <summary>
        /// KMS密钥数量
        /// </summary>
        [JsonProperty("total_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalNum { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public KmsInfo Result { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class KmsResourceInfo {\n");
            sb.Append("  totalNum: ").Append(TotalNum).Append("\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as KmsResourceInfo);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(KmsResourceInfo input)
        {
            if (input == null) return false;
            if (this.TotalNum != input.TotalNum || (this.TotalNum != null && !this.TotalNum.Equals(input.TotalNum))) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;

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
                if (this.TotalNum != null) hashCode = hashCode * 59 + this.TotalNum.GetHashCode();
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                return hashCode;
            }
        }
    }
}
