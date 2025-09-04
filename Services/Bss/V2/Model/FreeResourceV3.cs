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
    /// 
    /// </summary>
    public class FreeResourceV3 
    {

        /// <summary>
        /// 资源项ID，一个资源包中会含有多个资源项，一个使用量类型对应一个资源项。
        /// </summary>
        [JsonProperty("free_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FreeResourceId { get; set; }

        /// <summary>
        /// 使用量类型名称。
        /// </summary>
        [JsonProperty("usage_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UsageTypeName { get; set; }

        /// <summary>
        /// 资源剩余额度，针对可重置资源包，是指当前重置周期内的剩余量。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public string Amount { get; set; }

        /// <summary>
        /// 资源原始额度，针对可重置资源包，是指每个重置周期内的总量。
        /// </summary>
        [JsonProperty("original_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string OriginalAmount { get; set; }

        /// <summary>
        /// 度量单位，免费资源套餐额度度量单位。您可以调用查询度量单位列表接口获取。
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FreeResourceV3 {\n");
            sb.Append("  freeResourceId: ").Append(FreeResourceId).Append("\n");
            sb.Append("  usageTypeName: ").Append(UsageTypeName).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  originalAmount: ").Append(OriginalAmount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FreeResourceV3);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FreeResourceV3 input)
        {
            if (input == null) return false;
            if (this.FreeResourceId != input.FreeResourceId || (this.FreeResourceId != null && !this.FreeResourceId.Equals(input.FreeResourceId))) return false;
            if (this.UsageTypeName != input.UsageTypeName || (this.UsageTypeName != null && !this.UsageTypeName.Equals(input.UsageTypeName))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.OriginalAmount != input.OriginalAmount || (this.OriginalAmount != null && !this.OriginalAmount.Equals(input.OriginalAmount))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;

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
                if (this.FreeResourceId != null) hashCode = hashCode * 59 + this.FreeResourceId.GetHashCode();
                if (this.UsageTypeName != null) hashCode = hashCode * 59 + this.UsageTypeName.GetHashCode();
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.OriginalAmount != null) hashCode = hashCode * 59 + this.OriginalAmount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                return hashCode;
            }
        }
    }
}
