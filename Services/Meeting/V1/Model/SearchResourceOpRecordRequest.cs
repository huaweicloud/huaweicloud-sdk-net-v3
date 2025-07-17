using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Meeting.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class SearchResourceOpRecordRequest 
    {

        /// <summary>
        /// 请求requestId，用来标识一路请求，用于问题跟踪定位，建议使用UUID，若不携带，则后台自动生成。
        /// </summary>
        [SDKProperty("X-Request-Id", IsHeader = true)]
        [JsonProperty("X-Request-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XRequestId { get; set; }

        /// <summary>
        /// 语言参数，默认为中文zh-CN，英文为en-US。
        /// </summary>
        [SDKProperty("Accept-Language", IsHeader = true)]
        [JsonProperty("Accept-Language", NullValueHandling = NullValueHandling.Ignore)]
        public string AcceptLanguage { get; set; }

        /// <summary>
        /// 查询偏移量,若超过最大数量，则返回最后一页的数据。 默认值：0。 
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询数量。 默认值：10。 
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 搜索条件。
        /// </summary>
        [SDKProperty("searchKey", IsQuery = true)]
        [JsonProperty("searchKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchKey { get; set; }

        /// <summary>
        /// 企业id。
        /// </summary>
        [SDKProperty("corp_id", IsPath = true)]
        [JsonProperty("corp_id", NullValueHandling = NullValueHandling.Ignore)]
        public string CorpId { get; set; }

        /// <summary>
        /// 查询过期时间在该时间戳之后的订单操作记录。
        /// </summary>
        [SDKProperty("startExpireDate", IsQuery = true)]
        [JsonProperty("startExpireDate", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartExpireDate { get; set; }

        /// <summary>
        /// 查询过期时间在该时间戳之前的订单操作记录。
        /// </summary>
        [SDKProperty("endExpireDate", IsQuery = true)]
        [JsonProperty("endExpireDate", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndExpireDate { get; set; }

        /// <summary>
        /// 查询操作时间在该时间戳之后的订单操作记录。
        /// </summary>
        [SDKProperty("startOperateDate", IsQuery = true)]
        [JsonProperty("startOperateDate", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartOperateDate { get; set; }

        /// <summary>
        /// 查询操作时间在该时间戳之前的订单操作记录。
        /// </summary>
        [SDKProperty("endOperateDate", IsQuery = true)]
        [JsonProperty("endOperateDate", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndOperateDate { get; set; }

        /// <summary>
        /// 订单资源类型。
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 当前仅当资源类型为vmr时生效。
        /// </summary>
        [SDKProperty("typeId", IsQuery = true)]
        [JsonProperty("typeId", NullValueHandling = NullValueHandling.Ignore)]
        public string TypeId { get; set; }

        /// <summary>
        /// 操作类型。 - 0：添加 - 1：删除 - 2：修改 - 3：停用 - 4：启用
        /// </summary>
        [SDKProperty("operateType", IsQuery = true)]
        [JsonProperty("operateType", NullValueHandling = NullValueHandling.Ignore)]
        public int? OperateType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchResourceOpRecordRequest {\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("  acceptLanguage: ").Append(AcceptLanguage).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  searchKey: ").Append(SearchKey).Append("\n");
            sb.Append("  corpId: ").Append(CorpId).Append("\n");
            sb.Append("  startExpireDate: ").Append(StartExpireDate).Append("\n");
            sb.Append("  endExpireDate: ").Append(EndExpireDate).Append("\n");
            sb.Append("  startOperateDate: ").Append(StartOperateDate).Append("\n");
            sb.Append("  endOperateDate: ").Append(EndOperateDate).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  typeId: ").Append(TypeId).Append("\n");
            sb.Append("  operateType: ").Append(OperateType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchResourceOpRecordRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchResourceOpRecordRequest input)
        {
            if (input == null) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;
            if (this.AcceptLanguage != input.AcceptLanguage || (this.AcceptLanguage != null && !this.AcceptLanguage.Equals(input.AcceptLanguage))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.SearchKey != input.SearchKey || (this.SearchKey != null && !this.SearchKey.Equals(input.SearchKey))) return false;
            if (this.CorpId != input.CorpId || (this.CorpId != null && !this.CorpId.Equals(input.CorpId))) return false;
            if (this.StartExpireDate != input.StartExpireDate || (this.StartExpireDate != null && !this.StartExpireDate.Equals(input.StartExpireDate))) return false;
            if (this.EndExpireDate != input.EndExpireDate || (this.EndExpireDate != null && !this.EndExpireDate.Equals(input.EndExpireDate))) return false;
            if (this.StartOperateDate != input.StartOperateDate || (this.StartOperateDate != null && !this.StartOperateDate.Equals(input.StartOperateDate))) return false;
            if (this.EndOperateDate != input.EndOperateDate || (this.EndOperateDate != null && !this.EndOperateDate.Equals(input.EndOperateDate))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.TypeId != input.TypeId || (this.TypeId != null && !this.TypeId.Equals(input.TypeId))) return false;
            if (this.OperateType != input.OperateType || (this.OperateType != null && !this.OperateType.Equals(input.OperateType))) return false;

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
                if (this.XRequestId != null) hashCode = hashCode * 59 + this.XRequestId.GetHashCode();
                if (this.AcceptLanguage != null) hashCode = hashCode * 59 + this.AcceptLanguage.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SearchKey != null) hashCode = hashCode * 59 + this.SearchKey.GetHashCode();
                if (this.CorpId != null) hashCode = hashCode * 59 + this.CorpId.GetHashCode();
                if (this.StartExpireDate != null) hashCode = hashCode * 59 + this.StartExpireDate.GetHashCode();
                if (this.EndExpireDate != null) hashCode = hashCode * 59 + this.EndExpireDate.GetHashCode();
                if (this.StartOperateDate != null) hashCode = hashCode * 59 + this.StartOperateDate.GetHashCode();
                if (this.EndOperateDate != null) hashCode = hashCode * 59 + this.EndOperateDate.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.TypeId != null) hashCode = hashCode * 59 + this.TypeId.GetHashCode();
                if (this.OperateType != null) hashCode = hashCode * 59 + this.OperateType.GetHashCode();
                return hashCode;
            }
        }
    }
}
