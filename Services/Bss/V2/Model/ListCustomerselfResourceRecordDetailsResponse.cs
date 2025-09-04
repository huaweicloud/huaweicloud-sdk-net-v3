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
    public class ListCustomerselfResourceRecordDetailsResponse : SdkResponse
    {

        /// <summary>
        /// 资源详单数据记录。 具体请参见表1。
        /// </summary>
        [JsonProperty("monthly_records", NullValueHandling = NullValueHandling.Ignore)]
        public List<MonthlyBillRes> MonthlyRecords { get; set; }

        /// <summary>
        /// 结果集数量，只有成功才返回这个参数。
        /// </summary>
        [JsonProperty("total_count", NullValueHandling = NullValueHandling.Ignore)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// 货币单位代码： CNY：人民币
        /// </summary>
        [JsonProperty("currency", NullValueHandling = NullValueHandling.Ignore)]
        public string Currency { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListCustomerselfResourceRecordDetailsResponse {\n");
            sb.Append("  monthlyRecords: ").Append(MonthlyRecords).Append("\n");
            sb.Append("  totalCount: ").Append(TotalCount).Append("\n");
            sb.Append("  currency: ").Append(Currency).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListCustomerselfResourceRecordDetailsResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListCustomerselfResourceRecordDetailsResponse input)
        {
            if (input == null) return false;
            if (this.MonthlyRecords != input.MonthlyRecords || (this.MonthlyRecords != null && input.MonthlyRecords != null && !this.MonthlyRecords.SequenceEqual(input.MonthlyRecords))) return false;
            if (this.TotalCount != input.TotalCount || (this.TotalCount != null && !this.TotalCount.Equals(input.TotalCount))) return false;
            if (this.Currency != input.Currency || (this.Currency != null && !this.Currency.Equals(input.Currency))) return false;

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
                if (this.MonthlyRecords != null) hashCode = hashCode * 59 + this.MonthlyRecords.GetHashCode();
                if (this.TotalCount != null) hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
                if (this.Currency != null) hashCode = hashCode * 59 + this.Currency.GetHashCode();
                return hashCode;
            }
        }
    }
}
