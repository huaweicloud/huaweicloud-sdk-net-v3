using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Bssintl.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class FreeResourceRecord 
    {

        /// <summary>
        /// 资源抵扣时间。 UTC时间，格式：yyyy-MM-dd&#39;T&#39;HH:mm:ss&#39;Z&#39;，如\&quot;2021-10-13T10:01:49Z\&quot;。
        /// </summary>
        [JsonProperty("deduct_time", NullValueHandling = NullValueHandling.Ignore)]
        public string DeductTime { get; set; }

        /// <summary>
        /// 资源项ID，一个资源包中会含有多个资源项，一个使用量类型对应一个资源项。
        /// </summary>
        [JsonProperty("free_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FreeResourceId { get; set; }

        /// <summary>
        /// 资源ID。
        /// </summary>
        [JsonProperty("resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceId { get; set; }

        /// <summary>
        /// 资源类型编码。例如ECS的VM为“hws.resource.type.vm”。
        /// </summary>
        [JsonProperty("resource_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeCode { get; set; }

        /// <summary>
        /// 资源类型名称。例如ECS的资源类型名称为“云主机”。
        /// </summary>
        [JsonProperty("resource_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeName { get; set; }

        /// <summary>
        /// 资源标签。
        /// </summary>
        [JsonProperty("resource_tag", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTag { get; set; }

        /// <summary>
        /// 产品ID，即资源包ID。
        /// </summary>
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 产品名称，即资源包名称。
        /// </summary>
        [JsonProperty("product_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductName { get; set; }

        /// <summary>
        /// 使用量类型。
        /// </summary>
        [JsonProperty("usage_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string UsageTypeCode { get; set; }

        /// <summary>
        /// 资源抵扣前余量。
        /// </summary>
        [JsonProperty("available_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string AvailableAmount { get; set; }

        /// <summary>
        /// 资源抵扣后余量。
        /// </summary>
        [JsonProperty("remaining_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string RemainingAmount { get; set; }

        /// <summary>
        /// 抵扣量。
        /// </summary>
        [JsonProperty("used_amount", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedAmount { get; set; }

        /// <summary>
        /// 度量单位，免费资源套餐额度度量单位。您可以调用查询度量单位列表接口获取。
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? MeasureId { get; set; }

        /// <summary>
        /// 资源使用的开始时间，UTC时间。
        /// </summary>
        [JsonProperty("effective_time", NullValueHandling = NullValueHandling.Ignore)]
        public string EffectiveTime { get; set; }

        /// <summary>
        /// 资源使用的结束时间，UTC时间。
        /// </summary>
        [JsonProperty("expire_time", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FreeResourceRecord {\n");
            sb.Append("  deductTime: ").Append(DeductTime).Append("\n");
            sb.Append("  freeResourceId: ").Append(FreeResourceId).Append("\n");
            sb.Append("  resourceId: ").Append(ResourceId).Append("\n");
            sb.Append("  resourceTypeCode: ").Append(ResourceTypeCode).Append("\n");
            sb.Append("  resourceTypeName: ").Append(ResourceTypeName).Append("\n");
            sb.Append("  resourceTag: ").Append(ResourceTag).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  productName: ").Append(ProductName).Append("\n");
            sb.Append("  usageTypeCode: ").Append(UsageTypeCode).Append("\n");
            sb.Append("  availableAmount: ").Append(AvailableAmount).Append("\n");
            sb.Append("  remainingAmount: ").Append(RemainingAmount).Append("\n");
            sb.Append("  usedAmount: ").Append(UsedAmount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  effectiveTime: ").Append(EffectiveTime).Append("\n");
            sb.Append("  expireTime: ").Append(ExpireTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as FreeResourceRecord);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(FreeResourceRecord input)
        {
            if (input == null) return false;
            if (this.DeductTime != input.DeductTime || (this.DeductTime != null && !this.DeductTime.Equals(input.DeductTime))) return false;
            if (this.FreeResourceId != input.FreeResourceId || (this.FreeResourceId != null && !this.FreeResourceId.Equals(input.FreeResourceId))) return false;
            if (this.ResourceId != input.ResourceId || (this.ResourceId != null && !this.ResourceId.Equals(input.ResourceId))) return false;
            if (this.ResourceTypeCode != input.ResourceTypeCode || (this.ResourceTypeCode != null && !this.ResourceTypeCode.Equals(input.ResourceTypeCode))) return false;
            if (this.ResourceTypeName != input.ResourceTypeName || (this.ResourceTypeName != null && !this.ResourceTypeName.Equals(input.ResourceTypeName))) return false;
            if (this.ResourceTag != input.ResourceTag || (this.ResourceTag != null && !this.ResourceTag.Equals(input.ResourceTag))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ProductName != input.ProductName || (this.ProductName != null && !this.ProductName.Equals(input.ProductName))) return false;
            if (this.UsageTypeCode != input.UsageTypeCode || (this.UsageTypeCode != null && !this.UsageTypeCode.Equals(input.UsageTypeCode))) return false;
            if (this.AvailableAmount != input.AvailableAmount || (this.AvailableAmount != null && !this.AvailableAmount.Equals(input.AvailableAmount))) return false;
            if (this.RemainingAmount != input.RemainingAmount || (this.RemainingAmount != null && !this.RemainingAmount.Equals(input.RemainingAmount))) return false;
            if (this.UsedAmount != input.UsedAmount || (this.UsedAmount != null && !this.UsedAmount.Equals(input.UsedAmount))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.EffectiveTime != input.EffectiveTime || (this.EffectiveTime != null && !this.EffectiveTime.Equals(input.EffectiveTime))) return false;
            if (this.ExpireTime != input.ExpireTime || (this.ExpireTime != null && !this.ExpireTime.Equals(input.ExpireTime))) return false;

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
                if (this.DeductTime != null) hashCode = hashCode * 59 + this.DeductTime.GetHashCode();
                if (this.FreeResourceId != null) hashCode = hashCode * 59 + this.FreeResourceId.GetHashCode();
                if (this.ResourceId != null) hashCode = hashCode * 59 + this.ResourceId.GetHashCode();
                if (this.ResourceTypeCode != null) hashCode = hashCode * 59 + this.ResourceTypeCode.GetHashCode();
                if (this.ResourceTypeName != null) hashCode = hashCode * 59 + this.ResourceTypeName.GetHashCode();
                if (this.ResourceTag != null) hashCode = hashCode * 59 + this.ResourceTag.GetHashCode();
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ProductName != null) hashCode = hashCode * 59 + this.ProductName.GetHashCode();
                if (this.UsageTypeCode != null) hashCode = hashCode * 59 + this.UsageTypeCode.GetHashCode();
                if (this.AvailableAmount != null) hashCode = hashCode * 59 + this.AvailableAmount.GetHashCode();
                if (this.RemainingAmount != null) hashCode = hashCode * 59 + this.RemainingAmount.GetHashCode();
                if (this.UsedAmount != null) hashCode = hashCode * 59 + this.UsedAmount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.EffectiveTime != null) hashCode = hashCode * 59 + this.EffectiveTime.GetHashCode();
                if (this.ExpireTime != null) hashCode = hashCode * 59 + this.ExpireTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
