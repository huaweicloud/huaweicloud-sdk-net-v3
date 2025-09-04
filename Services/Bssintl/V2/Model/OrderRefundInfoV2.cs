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
    public class OrderRefundInfoV2 
    {

        /// <summary>
        /// 该记录的ID。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 金额。 金额为负数，表示退订金额。金额为正数，表示已消费金额或收取的退订手续费。
        /// </summary>
        [JsonProperty("amount", NullValueHandling = NullValueHandling.Ignore)]
        public decimal? Amount { get; set; }

        /// <summary>
        /// 金额的度量单位。 1：元
        /// </summary>
        [JsonProperty("measure_id", NullValueHandling = NullValueHandling.Ignore)]
        public string MeasureId { get; set; }

        /// <summary>
        /// 客户账号ID。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 资源类型编码，例如ECS的VM为“hws.resource.type.vm”。
        /// </summary>
        [JsonProperty("resource_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeCode { get; set; }

        /// <summary>
        /// 云服务类型编码，例如OBS的云服务类型编码为“hws.service.type.obs”。
        /// </summary>
        [JsonProperty("service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeCode { get; set; }

        /// <summary>
        /// 资源类型名称。例如ECS的资源类型名称为“云主机”。
        /// </summary>
        [JsonProperty("resource_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeName { get; set; }

        /// <summary>
        /// 云服务类型名称。例如ECS的云服务类型名称为“弹性云服务器”。
        /// </summary>
        [JsonProperty("service_type_name", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeName { get; set; }

        /// <summary>
        /// 云服务区编码，例如：“ap-southeast-1”。具体请参见地区和终端节点对应云服务的“区域”列的值。
        /// </summary>
        [JsonProperty("region_code", NullValueHandling = NullValueHandling.Ignore)]
        public string RegionCode { get; set; }

        /// <summary>
        /// 退订金额、已消费金额或收取退订手续费对应的原订单ID。
        /// </summary>
        [JsonProperty("base_order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string BaseOrderId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OrderRefundInfoV2 {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  amount: ").Append(Amount).Append("\n");
            sb.Append("  measureId: ").Append(MeasureId).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  resourceTypeCode: ").Append(ResourceTypeCode).Append("\n");
            sb.Append("  serviceTypeCode: ").Append(ServiceTypeCode).Append("\n");
            sb.Append("  resourceTypeName: ").Append(ResourceTypeName).Append("\n");
            sb.Append("  serviceTypeName: ").Append(ServiceTypeName).Append("\n");
            sb.Append("  regionCode: ").Append(RegionCode).Append("\n");
            sb.Append("  baseOrderId: ").Append(BaseOrderId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as OrderRefundInfoV2);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(OrderRefundInfoV2 input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Amount != input.Amount || (this.Amount != null && !this.Amount.Equals(input.Amount))) return false;
            if (this.MeasureId != input.MeasureId || (this.MeasureId != null && !this.MeasureId.Equals(input.MeasureId))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.ResourceTypeCode != input.ResourceTypeCode || (this.ResourceTypeCode != null && !this.ResourceTypeCode.Equals(input.ResourceTypeCode))) return false;
            if (this.ServiceTypeCode != input.ServiceTypeCode || (this.ServiceTypeCode != null && !this.ServiceTypeCode.Equals(input.ServiceTypeCode))) return false;
            if (this.ResourceTypeName != input.ResourceTypeName || (this.ResourceTypeName != null && !this.ResourceTypeName.Equals(input.ResourceTypeName))) return false;
            if (this.ServiceTypeName != input.ServiceTypeName || (this.ServiceTypeName != null && !this.ServiceTypeName.Equals(input.ServiceTypeName))) return false;
            if (this.RegionCode != input.RegionCode || (this.RegionCode != null && !this.RegionCode.Equals(input.RegionCode))) return false;
            if (this.BaseOrderId != input.BaseOrderId || (this.BaseOrderId != null && !this.BaseOrderId.Equals(input.BaseOrderId))) return false;

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
                if (this.Amount != null) hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.MeasureId != null) hashCode = hashCode * 59 + this.MeasureId.GetHashCode();
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.ResourceTypeCode != null) hashCode = hashCode * 59 + this.ResourceTypeCode.GetHashCode();
                if (this.ServiceTypeCode != null) hashCode = hashCode * 59 + this.ServiceTypeCode.GetHashCode();
                if (this.ResourceTypeName != null) hashCode = hashCode * 59 + this.ResourceTypeName.GetHashCode();
                if (this.ServiceTypeName != null) hashCode = hashCode * 59 + this.ServiceTypeName.GetHashCode();
                if (this.RegionCode != null) hashCode = hashCode * 59 + this.RegionCode.GetHashCode();
                if (this.BaseOrderId != null) hashCode = hashCode * 59 + this.BaseOrderId.GetHashCode();
                return hashCode;
            }
        }
    }
}
