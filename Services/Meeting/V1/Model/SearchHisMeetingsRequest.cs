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
    public class SearchHisMeetingsRequest 
    {

        /// <summary>
        /// 用户的UUID。 &gt; 该参数将废弃，请勿使用。
        /// </summary>
        [SDKProperty("userUUID", IsQuery = true)]
        [JsonProperty("userUUID", NullValueHandling = NullValueHandling.Ignore)]
        public string UserUUID { get; set; }

        /// <summary>
        /// 查询偏移量。默认为0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 查询数量。默认是20，最大500条。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询条件。会议主题、会议预约人和会议ID等可作为搜索内容。
        /// </summary>
        [SDKProperty("searchKey", IsQuery = true)]
        [JsonProperty("searchKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchKey { get; set; }

        /// <summary>
        /// 是否查询企业下所有用户的历史会议。 * true：查询所有用户的历史会议 * false：仅查询管理员自己的历史会议 &gt; 仅对企业管理员生效。
        /// </summary>
        [SDKProperty("queryAll", IsQuery = true)]
        [JsonProperty("queryAll", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QueryAll { get; set; }

        /// <summary>
        /// 查询的起始时间戳（单位毫秒）。
        /// </summary>
        [SDKProperty("startDate", IsQuery = true)]
        [JsonProperty("startDate", NullValueHandling = NullValueHandling.Ignore)]
        public long? StartDate { get; set; }

        /// <summary>
        /// 查询的截止时间戳（单位毫秒）。
        /// </summary>
        [SDKProperty("endDate", IsQuery = true)]
        [JsonProperty("endDate", NullValueHandling = NullValueHandling.Ignore)]
        public long? EndDate { get; set; }

        /// <summary>
        /// 查询结果排序类型。 * ASC_StartTIME：根据会议开始时间升序排序 * DSC_StartTIME：根据会议开始时间降序排序 * ASC_RecordTYPE：根据是否具有录播文件排序，之后默认按照会议开始时间升序排序 * DSC_RecordTYPE：根据是否含有录播文件排序，之后默认按照会议开始时间降序排序
        /// </summary>
        [SDKProperty("sortType", IsQuery = true)]
        [JsonProperty("sortType", NullValueHandling = NullValueHandling.Ignore)]
        public string SortType { get; set; }

        /// <summary>
        /// 标识是否为第三方portal过来的请求。 &gt; 该参数将废弃，请勿使用。 
        /// </summary>
        [SDKProperty("X-Authorization-Type", IsHeader = true)]
        [JsonProperty("X-Authorization-Type", NullValueHandling = NullValueHandling.Ignore)]
        public string XAuthorizationType { get; set; }

        /// <summary>
        /// 用于区分到哪个HCSO站点鉴权。 &gt; 该参数将废弃，请勿使用。 
        /// </summary>
        [SDKProperty("X-Site-Id", IsHeader = true)]
        [JsonProperty("X-Site-Id", NullValueHandling = NullValueHandling.Ignore)]
        public string XSiteId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SearchHisMeetingsRequest {\n");
            sb.Append("  userUUID: ").Append(UserUUID).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  searchKey: ").Append(SearchKey).Append("\n");
            sb.Append("  queryAll: ").Append(QueryAll).Append("\n");
            sb.Append("  startDate: ").Append(StartDate).Append("\n");
            sb.Append("  endDate: ").Append(EndDate).Append("\n");
            sb.Append("  sortType: ").Append(SortType).Append("\n");
            sb.Append("  xAuthorizationType: ").Append(XAuthorizationType).Append("\n");
            sb.Append("  xSiteId: ").Append(XSiteId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SearchHisMeetingsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchHisMeetingsRequest input)
        {
            if (input == null) return false;
            if (this.UserUUID != input.UserUUID || (this.UserUUID != null && !this.UserUUID.Equals(input.UserUUID))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.SearchKey != input.SearchKey || (this.SearchKey != null && !this.SearchKey.Equals(input.SearchKey))) return false;
            if (this.QueryAll != input.QueryAll || (this.QueryAll != null && !this.QueryAll.Equals(input.QueryAll))) return false;
            if (this.StartDate != input.StartDate || (this.StartDate != null && !this.StartDate.Equals(input.StartDate))) return false;
            if (this.EndDate != input.EndDate || (this.EndDate != null && !this.EndDate.Equals(input.EndDate))) return false;
            if (this.SortType != input.SortType || (this.SortType != null && !this.SortType.Equals(input.SortType))) return false;
            if (this.XAuthorizationType != input.XAuthorizationType || (this.XAuthorizationType != null && !this.XAuthorizationType.Equals(input.XAuthorizationType))) return false;
            if (this.XSiteId != input.XSiteId || (this.XSiteId != null && !this.XSiteId.Equals(input.XSiteId))) return false;

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
                if (this.UserUUID != null) hashCode = hashCode * 59 + this.UserUUID.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.SearchKey != null) hashCode = hashCode * 59 + this.SearchKey.GetHashCode();
                if (this.QueryAll != null) hashCode = hashCode * 59 + this.QueryAll.GetHashCode();
                if (this.StartDate != null) hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.EndDate != null) hashCode = hashCode * 59 + this.EndDate.GetHashCode();
                if (this.SortType != null) hashCode = hashCode * 59 + this.SortType.GetHashCode();
                if (this.XAuthorizationType != null) hashCode = hashCode * 59 + this.XAuthorizationType.GetHashCode();
                if (this.XSiteId != null) hashCode = hashCode * 59 + this.XSiteId.GetHashCode();
                return hashCode;
            }
        }
    }
}
