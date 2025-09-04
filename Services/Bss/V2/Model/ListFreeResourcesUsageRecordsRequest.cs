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
    /// Request Object
    /// </summary>
    public class ListFreeResourcesUsageRecordsRequest 
    {

        /// <summary>
        /// 资源项ID，一个资源包中会含有多个资源项，一个使用量类型对应一个资源项。资源项ID来自查询资源包列表接口的响应。 此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("free_resource_id", IsQuery = true)]
        [JsonProperty("free_resource_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FreeResourceId { get; set; }

        /// <summary>
        /// 产品ID，即资源包ID。 此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("product_id", IsQuery = true)]
        [JsonProperty("product_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProductId { get; set; }

        /// <summary>
        /// 资源类型编码，例如ECS的VM为“hws.resource.type.vm”。您可以调用查询资源类型列表接口获取。 此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("resource_type_code", IsQuery = true)]
        [JsonProperty("resource_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ResourceTypeCode { get; set; }

        /// <summary>
        /// 资源抵扣的起始时间。东八区时间，格式为YYYY-MM-DD。
        /// </summary>
        [SDKProperty("deduct_time_begin", IsQuery = true)]
        [JsonProperty("deduct_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string DeductTimeBegin { get; set; }

        /// <summary>
        /// 资源抵扣的结束时间。东八区时间，格式为YYYY-MM-DD。  说明： 抵扣结束时间-抵扣起始时间&lt;&#x3D;90天。
        /// </summary>
        [SDKProperty("deduct_time_end", IsQuery = true)]
        [JsonProperty("deduct_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string DeductTimeEnd { get; set; }

        /// <summary>
        /// 偏移量，从0开始。默认值为0。  说明： offset用于分页处理，如不涉及分页，请使用默认值0。offset表示相对于满足条件的第一个数据的偏移量。如offset &#x3D; 1，则返回满足条件的第二个数据至最后一个数据。 例如，满足查询条件的结果共10条数据，limit取值为10，offset取值为1，则返回的数据为2~10，第一条数据不返回。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每次查询的数量限制。默认值为10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListFreeResourcesUsageRecordsRequest {\n");
            sb.Append("  freeResourceId: ").Append(FreeResourceId).Append("\n");
            sb.Append("  productId: ").Append(ProductId).Append("\n");
            sb.Append("  resourceTypeCode: ").Append(ResourceTypeCode).Append("\n");
            sb.Append("  deductTimeBegin: ").Append(DeductTimeBegin).Append("\n");
            sb.Append("  deductTimeEnd: ").Append(DeductTimeEnd).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListFreeResourcesUsageRecordsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListFreeResourcesUsageRecordsRequest input)
        {
            if (input == null) return false;
            if (this.FreeResourceId != input.FreeResourceId || (this.FreeResourceId != null && !this.FreeResourceId.Equals(input.FreeResourceId))) return false;
            if (this.ProductId != input.ProductId || (this.ProductId != null && !this.ProductId.Equals(input.ProductId))) return false;
            if (this.ResourceTypeCode != input.ResourceTypeCode || (this.ResourceTypeCode != null && !this.ResourceTypeCode.Equals(input.ResourceTypeCode))) return false;
            if (this.DeductTimeBegin != input.DeductTimeBegin || (this.DeductTimeBegin != null && !this.DeductTimeBegin.Equals(input.DeductTimeBegin))) return false;
            if (this.DeductTimeEnd != input.DeductTimeEnd || (this.DeductTimeEnd != null && !this.DeductTimeEnd.Equals(input.DeductTimeEnd))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;

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
                if (this.ProductId != null) hashCode = hashCode * 59 + this.ProductId.GetHashCode();
                if (this.ResourceTypeCode != null) hashCode = hashCode * 59 + this.ResourceTypeCode.GetHashCode();
                if (this.DeductTimeBegin != null) hashCode = hashCode * 59 + this.DeductTimeBegin.GetHashCode();
                if (this.DeductTimeEnd != null) hashCode = hashCode * 59 + this.DeductTimeEnd.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                return hashCode;
            }
        }
    }
}
