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
    public class SearchMeetingsRequest 
    {

        /// <summary>
        /// 用户的UUID。 &gt; 仅管理员有权限查询本企业其他用户的会议列表；普通帐号该字段无效，只能查询自己的。 
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
        /// 是否查询企业下所有用户的会议记录。默认值为false。 * true：查询所有用户的会议 * false：仅查询管理员自己创建的会议 &gt; 仅对企业管理员生效。
        /// </summary>
        [SDKProperty("queryAll", IsQuery = true)]
        [JsonProperty("queryAll", NullValueHandling = NullValueHandling.Ignore)]
        public bool? QueryAll { get; set; }

        /// <summary>
        /// 查询条件。会议主题、会议预约人和会议ID等可作为搜索内容。长度限制为1-128个字符。
        /// </summary>
        [SDKProperty("searchKey", IsQuery = true)]
        [JsonProperty("searchKey", NullValueHandling = NullValueHandling.Ignore)]
        public string SearchKey { get; set; }

        /// <summary>
        /// 查询时间范围。 - ADAY:  一天 - AWEEK:  一周 - AMONTH:  一个月 - ALL:  查询所有
        /// </summary>
        [SDKProperty("queryConfMode", IsQuery = true)]
        [JsonProperty("queryConfMode", NullValueHandling = NullValueHandling.Ignore)]
        public string QueryConfMode { get; set; }

        /// <summary>
        /// 查询结果排序。 - ASC_StartTIME:  按会议开始时间升序排序 - DSC_StartTIME:  按会议开始时间降序排序
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
            sb.Append("class SearchMeetingsRequest {\n");
            sb.Append("  userUUID: ").Append(UserUUID).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  queryAll: ").Append(QueryAll).Append("\n");
            sb.Append("  searchKey: ").Append(SearchKey).Append("\n");
            sb.Append("  queryConfMode: ").Append(QueryConfMode).Append("\n");
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
            return this.Equals(input as SearchMeetingsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SearchMeetingsRequest input)
        {
            if (input == null) return false;
            if (this.UserUUID != input.UserUUID || (this.UserUUID != null && !this.UserUUID.Equals(input.UserUUID))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.QueryAll != input.QueryAll || (this.QueryAll != null && !this.QueryAll.Equals(input.QueryAll))) return false;
            if (this.SearchKey != input.SearchKey || (this.SearchKey != null && !this.SearchKey.Equals(input.SearchKey))) return false;
            if (this.QueryConfMode != input.QueryConfMode || (this.QueryConfMode != null && !this.QueryConfMode.Equals(input.QueryConfMode))) return false;
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
                if (this.QueryAll != null) hashCode = hashCode * 59 + this.QueryAll.GetHashCode();
                if (this.SearchKey != null) hashCode = hashCode * 59 + this.SearchKey.GetHashCode();
                if (this.QueryConfMode != null) hashCode = hashCode * 59 + this.QueryConfMode.GetHashCode();
                if (this.SortType != null) hashCode = hashCode * 59 + this.SortType.GetHashCode();
                if (this.XAuthorizationType != null) hashCode = hashCode * 59 + this.XAuthorizationType.GetHashCode();
                if (this.XSiteId != null) hashCode = hashCode * 59 + this.XSiteId.GetHashCode();
                return hashCode;
            }
        }
    }
}
