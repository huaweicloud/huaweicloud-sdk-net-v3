using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bss.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowMultiAccountTransferAmountResponse : SdkResponse
    {

        /// <summary>
        /// 记录条数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 可拨款余额信息，如果是余额账户，只会有一条记录。 具体请参见表2。
        /// </summary>
        [JsonProperty("amount_infos", NullValueHandling = NullValueHandling.Ignore)]
        public List<TransferAmountInfoV2> AmountInfos { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowMultiAccountTransferAmountResponse {\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  amountInfos: ").Append(AmountInfos).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowMultiAccountTransferAmountResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowMultiAccountTransferAmountResponse input)
        {
            if (input == null) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.AmountInfos != input.AmountInfos || (this.AmountInfos != null && input.AmountInfos != null && !this.AmountInfos.SequenceEqual(input.AmountInfos))) return false;

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
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.AmountInfos != null) hashCode = hashCode * 59 + this.AmountInfos.GetHashCode();
                return hashCode;
            }
        }
    }
}
