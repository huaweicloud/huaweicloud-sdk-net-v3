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
    public class QueryResourcesReq 
    {

        /// <summary>
        /// 资源ID列表。 查询指定资源ID的资源（当only_main_resource&#x3D;0时，查询指定资源及其附属资源）。最大支持50个ID同时作为条件查询，多个ID以英文逗号分隔。  说明： 资源ID是指开通资源以后，云服务针对该资源分配的标志，譬如云主机ECS的资源ID是server_id。
        /// </summary>
        [JsonProperty("resource_ids", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ResourceIds { get; set; }

        /// <summary>
        /// 订单号。查询指定订单下的资源。  说明： 使用特殊字符进行查询的时候，请注意进行URL编码转换，如“%”的转码应为“%25”。
        /// </summary>
        [JsonProperty("order_id", NullValueHandling = NullValueHandling.Ignore)]
        public string OrderId { get; set; }

        /// <summary>
        /// 是否只查询主资源，该参数对于请求参数是子资源ID的时候无效，如果resource_ids是子资源ID，只能查询自己。 0：查询主资源及附属资源。1：只查询主资源。 默认值为0。  说明： 主资源是指有关联的几个资源中，处于主导位置的资源。 对于ECS而言，虚拟机VM是主资源，磁盘EVS是辅资源。对于VPC而言，共享带宽的情况下，带宽为主资源，对应的从资源为弹性IP（可能包含多个IP）；独享带宽的情况下，弹性IP为主资源，对应的从资源为带宽。
        /// </summary>
        [JsonProperty("only_main_resource", NullValueHandling = NullValueHandling.Ignore)]
        public int? OnlyMainResource { get; set; }

        /// <summary>
        /// 资源状态。 查询指定状态的资源。多个状态以英文逗号分隔。 2：使用中3：已关闭4：已冻结5：已过期
        /// </summary>
        [JsonProperty("status_list", NullValueHandling = NullValueHandling.Ignore)]
        public List<int?> StatusList { get; set; }

        /// <summary>
        /// 偏移量，从0开始。默认值为0。  说明： offset用于分页处理，如不涉及分页，请使用默认值0。offset表示相对于满足条件的第一个数据的偏移量。如offset &#x3D; 1，则返回满足条件的第二个数据至最后一个数据。 例如，满足查询条件的结果共10条数据，limit取值为10，offset取值为1，则返回的数据为2~10，第一条数据不返回。
        /// </summary>
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每次查询的条数。默认值为10。
        /// </summary>
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询指定时间段内失效的资源列表，时间段的起始时间，UTC时间。
        /// </summary>
        [JsonProperty("expire_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTimeBegin { get; set; }

        /// <summary>
        /// 查询指定时间段内失效的资源列表，时间段的结束时间，UTC时间。
        /// </summary>
        [JsonProperty("expire_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string ExpireTimeEnd { get; set; }

        /// <summary>
        /// 云服务类型编码，例如OBS的云服务类型编码为“hws.service.type.obs”。您可以调用查询云服务类型列表接口获取。 此参数不携带、携带值为null，不作为筛选条件。此参数不允许为空串，有参数校验。
        /// </summary>
        [JsonProperty("service_type_code", NullValueHandling = NullValueHandling.Ignore)]
        public string ServiceTypeCode { get; set; }

        /// <summary>
        /// 客户账号ID，非必填，范围限制:0-64，伙伴查询子客户包年/包月资源列表时必须携带该字段。除此之外，此参数不做处理。
        /// </summary>
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class QueryResourcesReq {\n");
            sb.Append("  resourceIds: ").Append(ResourceIds).Append("\n");
            sb.Append("  orderId: ").Append(OrderId).Append("\n");
            sb.Append("  onlyMainResource: ").Append(OnlyMainResource).Append("\n");
            sb.Append("  statusList: ").Append(StatusList).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  expireTimeBegin: ").Append(ExpireTimeBegin).Append("\n");
            sb.Append("  expireTimeEnd: ").Append(ExpireTimeEnd).Append("\n");
            sb.Append("  serviceTypeCode: ").Append(ServiceTypeCode).Append("\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as QueryResourcesReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(QueryResourcesReq input)
        {
            if (input == null) return false;
            if (this.ResourceIds != input.ResourceIds || (this.ResourceIds != null && input.ResourceIds != null && !this.ResourceIds.SequenceEqual(input.ResourceIds))) return false;
            if (this.OrderId != input.OrderId || (this.OrderId != null && !this.OrderId.Equals(input.OrderId))) return false;
            if (this.OnlyMainResource != input.OnlyMainResource || (this.OnlyMainResource != null && !this.OnlyMainResource.Equals(input.OnlyMainResource))) return false;
            if (this.StatusList != input.StatusList || (this.StatusList != null && input.StatusList != null && !this.StatusList.SequenceEqual(input.StatusList))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.ExpireTimeBegin != input.ExpireTimeBegin || (this.ExpireTimeBegin != null && !this.ExpireTimeBegin.Equals(input.ExpireTimeBegin))) return false;
            if (this.ExpireTimeEnd != input.ExpireTimeEnd || (this.ExpireTimeEnd != null && !this.ExpireTimeEnd.Equals(input.ExpireTimeEnd))) return false;
            if (this.ServiceTypeCode != input.ServiceTypeCode || (this.ServiceTypeCode != null && !this.ServiceTypeCode.Equals(input.ServiceTypeCode))) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;

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
                if (this.ResourceIds != null) hashCode = hashCode * 59 + this.ResourceIds.GetHashCode();
                if (this.OrderId != null) hashCode = hashCode * 59 + this.OrderId.GetHashCode();
                if (this.OnlyMainResource != null) hashCode = hashCode * 59 + this.OnlyMainResource.GetHashCode();
                if (this.StatusList != null) hashCode = hashCode * 59 + this.StatusList.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.ExpireTimeBegin != null) hashCode = hashCode * 59 + this.ExpireTimeBegin.GetHashCode();
                if (this.ExpireTimeEnd != null) hashCode = hashCode * 59 + this.ExpireTimeEnd.GetHashCode();
                if (this.ServiceTypeCode != null) hashCode = hashCode * 59 + this.ServiceTypeCode.GetHashCode();
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
