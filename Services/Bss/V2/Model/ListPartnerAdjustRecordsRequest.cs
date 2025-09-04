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
    public class ListPartnerAdjustRecordsRequest 
    {

        /// <summary>
        /// 客户账号ID。您可以调用[查询客户列表](https://support.huaweicloud.com/api-bpconsole/mc_00021.html)获取customer_id。为空表示查询所有的调账记录。不为空表示仅查询与该客户相关的调账记录。此参数不携带或携带值为空时，默认查询所有客户的调账记录。 说明： 此处的客户包含伙伴的子客户，以及华为云总经销商关联的云经销商（二级经销商）。
        /// </summary>
        [SDKProperty("customer_id", IsQuery = true)]
        [JsonProperty("customer_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CustomerId { get; set; }

        /// <summary>
        /// 操作类型。SOURCE_OPERATION_BEADJUST：拨款,SOURCE_OPERATION_BERETRIEVE：回收,SOURCE_OPERATION_BEUNBIND：解绑回收,此参数不携带或携带值为空时，默认查询所有类型。
        /// </summary>
        [SDKProperty("operation_type", IsQuery = true)]
        [JsonProperty("operation_type", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationType { get; set; }

        /// <summary>
        /// 调账起始时间。UTC时间，格式为：2016-03-28T14:45:38Z。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("operation_time_begin", IsQuery = true)]
        [JsonProperty("operation_time_begin", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationTimeBegin { get; set; }

        /// <summary>
        /// 调账截止时间。UTC时间，格式为：2016-03-28T14:45:38Z。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("operation_time_end", IsQuery = true)]
        [JsonProperty("operation_time_end", NullValueHandling = NullValueHandling.Ignore)]
        public string OperationTimeEnd { get; set; }

        /// <summary>
        /// 事务ID。此参数不携带或携带值为空时，不作为筛选条件。
        /// </summary>
        [SDKProperty("trans_id", IsQuery = true)]
        [JsonProperty("trans_id", NullValueHandling = NullValueHandling.Ignore)]
        public string TransId { get; set; }

        /// <summary>
        /// 偏移量，从0开始。默认值为0。 说明： offset用于分页处理，如不涉及分页，请使用默认值0。offset表示相对于满足条件的第一个数据的偏移量。如offset &#x3D; 1，则返回满足条件的第二个数据至最后一个数据。例如，满足查询条件的结果共10条数据，limit取值为10，offset取值为1，则返回的数据为2~10，第一条数据不返回。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 每页的显示条数。默认值为10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 云经销商ID。获取方法请参见[查询云经销商列表](https://support.huaweicloud.com/api-bpconsole/espp_00003.html)。华为云总经销商（一级经销商）查询云经销商（二级经销商）的子客户调账记录时，需携带此参数；除此之外，此参数不做处理。否则只能查询自己的子客户调账记录。
        /// </summary>
        [SDKProperty("indirect_partner_id", IsQuery = true)]
        [JsonProperty("indirect_partner_id", NullValueHandling = NullValueHandling.Ignore)]
        public string IndirectPartnerId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListPartnerAdjustRecordsRequest {\n");
            sb.Append("  customerId: ").Append(CustomerId).Append("\n");
            sb.Append("  operationType: ").Append(OperationType).Append("\n");
            sb.Append("  operationTimeBegin: ").Append(OperationTimeBegin).Append("\n");
            sb.Append("  operationTimeEnd: ").Append(OperationTimeEnd).Append("\n");
            sb.Append("  transId: ").Append(TransId).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  indirectPartnerId: ").Append(IndirectPartnerId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListPartnerAdjustRecordsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListPartnerAdjustRecordsRequest input)
        {
            if (input == null) return false;
            if (this.CustomerId != input.CustomerId || (this.CustomerId != null && !this.CustomerId.Equals(input.CustomerId))) return false;
            if (this.OperationType != input.OperationType || (this.OperationType != null && !this.OperationType.Equals(input.OperationType))) return false;
            if (this.OperationTimeBegin != input.OperationTimeBegin || (this.OperationTimeBegin != null && !this.OperationTimeBegin.Equals(input.OperationTimeBegin))) return false;
            if (this.OperationTimeEnd != input.OperationTimeEnd || (this.OperationTimeEnd != null && !this.OperationTimeEnd.Equals(input.OperationTimeEnd))) return false;
            if (this.TransId != input.TransId || (this.TransId != null && !this.TransId.Equals(input.TransId))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.IndirectPartnerId != input.IndirectPartnerId || (this.IndirectPartnerId != null && !this.IndirectPartnerId.Equals(input.IndirectPartnerId))) return false;

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
                if (this.CustomerId != null) hashCode = hashCode * 59 + this.CustomerId.GetHashCode();
                if (this.OperationType != null) hashCode = hashCode * 59 + this.OperationType.GetHashCode();
                if (this.OperationTimeBegin != null) hashCode = hashCode * 59 + this.OperationTimeBegin.GetHashCode();
                if (this.OperationTimeEnd != null) hashCode = hashCode * 59 + this.OperationTimeEnd.GetHashCode();
                if (this.TransId != null) hashCode = hashCode * 59 + this.TransId.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.IndirectPartnerId != null) hashCode = hashCode * 59 + this.IndirectPartnerId.GetHashCode();
                return hashCode;
            }
        }
    }
}
