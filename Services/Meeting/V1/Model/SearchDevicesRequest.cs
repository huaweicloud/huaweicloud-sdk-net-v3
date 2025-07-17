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
    public class SearchDevicesRequest 
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
        /// 查询偏移量，若超过最大数量，则返回最后一页。
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
        /// 搜索条件。支持名称、SN模糊查询。
        /// </summary>
        [SDKProperty("searchKey", IsQuery = true)]
        [JsonProperty("searchKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchKey { get; set; }

        /// <summary>
        /// 终端型号，枚举类型。当前支持TE系列硬件终端，具体的终端类型可以通过获取所有终端类型接口查询。
        /// </summary>
        [SDKProperty("model", IsQuery = true)]
        [JsonProperty("model", NullValueHandling = NullValueHandling.Ignore)]
        public string Model { get; set; }

        /// <summary>
        /// 部门编码，默认为根部门。 默认值：1。
        /// </summary>
        [SDKProperty("deptCode", IsQuery = true)]
        [JsonProperty("deptCode", NullValueHandling = NullValueHandling.Ignore)]
        public string DeptCode { get; set; }

        /// <summary>
        /// 是否查询子部门。 默认值：true。 
        /// </summary>
        [SDKProperty("enableSubDept", IsQuery = true)]
        [JsonProperty("enableSubDept", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableSubDept { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchDevicesRequest {\n");
            sb.Append("  xRequestId: ").Append(XRequestId).Append("\n");
            sb.Append("  acceptLanguage: ").Append(AcceptLanguage).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  searchKey: ").Append(SearchKey).Append("\n");
            sb.Append("  model: ").Append(Model).Append("\n");
            sb.Append("  deptCode: ").Append(DeptCode).Append("\n");
            sb.Append("  enableSubDept: ").Append(EnableSubDept).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchDevicesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchDevicesRequest input)
        {
            if (input == null) return false;
            if (this.XRequestId != input.XRequestId || (this.XRequestId != null && !this.XRequestId.Equals(input.XRequestId))) return false;
            if (this.AcceptLanguage != input.AcceptLanguage || (this.AcceptLanguage != null && !this.AcceptLanguage.Equals(input.AcceptLanguage))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.SearchKey != input.SearchKey || (this.SearchKey != null && !this.SearchKey.Equals(input.SearchKey))) return false;
            if (this.Model != input.Model || (this.Model != null && !this.Model.Equals(input.Model))) return false;
            if (this.DeptCode != input.DeptCode || (this.DeptCode != null && !this.DeptCode.Equals(input.DeptCode))) return false;
            if (this.EnableSubDept != input.EnableSubDept || (this.EnableSubDept != null && !this.EnableSubDept.Equals(input.EnableSubDept))) return false;

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
                if (this.Model != null) hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.DeptCode != null) hashCode = hashCode * 59 + this.DeptCode.GetHashCode();
                if (this.EnableSubDept != null) hashCode = hashCode * 59 + this.EnableSubDept.GetHashCode();
                return hashCode;
            }
        }
    }
}
