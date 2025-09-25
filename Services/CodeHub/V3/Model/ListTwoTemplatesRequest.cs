using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeHub.V3.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListTwoTemplatesRequest 
    {

        /// <summary>
        /// 模板平台类型
        /// </summary>
        [SDKProperty("platform", IsQuery = true)]
        [JsonProperty("platform", NullValueHandling = NullValueHandling.Ignore)]
        public string Platform { get; set; }

        /// <summary>
        /// 语言类型
        /// </summary>
        [SDKProperty("language", IsQuery = true)]
        [JsonProperty("language", NullValueHandling = NullValueHandling.Ignore)]
        public string Language { get; set; }

        /// <summary>
        /// 是否支持流水线
        /// </summary>
        [SDKProperty("pipeline", IsQuery = true)]
        [JsonProperty("pipeline", NullValueHandling = NullValueHandling.Ignore)]
        public string Pipeline { get; set; }

        /// <summary>
        /// 模板分类
        /// </summary>
        [SDKProperty("enter_type", IsQuery = true)]
        [JsonProperty("enter_type", NullValueHandling = NullValueHandling.Ignore)]
        public string EnterType { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [SDKProperty("search", IsQuery = true)]
        [JsonProperty("search", NullValueHandling = NullValueHandling.Ignore)]
        public string Search { get; set; }

        /// <summary>
        /// 模板日期排序
        /// </summary>
        [SDKProperty("date_order", IsQuery = true)]
        [JsonProperty("date_order", NullValueHandling = NullValueHandling.Ignore)]
        public string DateOrder { get; set; }

        /// <summary>
        /// 模板引用次数排序
        /// </summary>
        [SDKProperty("used_time_order", IsQuery = true)]
        [JsonProperty("used_time_order", NullValueHandling = NullValueHandling.Ignore)]
        public string UsedTimeOrder { get; set; }

        /// <summary>
        /// 模板公开类型
        /// </summary>
        [SDKProperty("type", IsQuery = true)]
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 大区名称
        /// </summary>
        [SDKProperty("region", IsQuery = true)]
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 分页页数
        /// </summary>
        [SDKProperty("page_no", IsQuery = true)]
        [JsonProperty("page_no", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageNo { get; set; }

        /// <summary>
        /// 每页数据数
        /// </summary>
        [SDKProperty("page_size", IsQuery = true)]
        [JsonProperty("page_size", NullValueHandling = NullValueHandling.Ignore)]
        public int? PageSize { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListTwoTemplatesRequest {\n");
            sb.Append("  platform: ").Append(Platform).Append("\n");
            sb.Append("  language: ").Append(Language).Append("\n");
            sb.Append("  pipeline: ").Append(Pipeline).Append("\n");
            sb.Append("  enterType: ").Append(EnterType).Append("\n");
            sb.Append("  search: ").Append(Search).Append("\n");
            sb.Append("  dateOrder: ").Append(DateOrder).Append("\n");
            sb.Append("  usedTimeOrder: ").Append(UsedTimeOrder).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  pageNo: ").Append(PageNo).Append("\n");
            sb.Append("  pageSize: ").Append(PageSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListTwoTemplatesRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListTwoTemplatesRequest input)
        {
            if (input == null) return false;
            if (this.Platform != input.Platform || (this.Platform != null && !this.Platform.Equals(input.Platform))) return false;
            if (this.Language != input.Language || (this.Language != null && !this.Language.Equals(input.Language))) return false;
            if (this.Pipeline != input.Pipeline || (this.Pipeline != null && !this.Pipeline.Equals(input.Pipeline))) return false;
            if (this.EnterType != input.EnterType || (this.EnterType != null && !this.EnterType.Equals(input.EnterType))) return false;
            if (this.Search != input.Search || (this.Search != null && !this.Search.Equals(input.Search))) return false;
            if (this.DateOrder != input.DateOrder || (this.DateOrder != null && !this.DateOrder.Equals(input.DateOrder))) return false;
            if (this.UsedTimeOrder != input.UsedTimeOrder || (this.UsedTimeOrder != null && !this.UsedTimeOrder.Equals(input.UsedTimeOrder))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.PageNo != input.PageNo || (this.PageNo != null && !this.PageNo.Equals(input.PageNo))) return false;
            if (this.PageSize != input.PageSize || (this.PageSize != null && !this.PageSize.Equals(input.PageSize))) return false;

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
                if (this.Platform != null) hashCode = hashCode * 59 + this.Platform.GetHashCode();
                if (this.Language != null) hashCode = hashCode * 59 + this.Language.GetHashCode();
                if (this.Pipeline != null) hashCode = hashCode * 59 + this.Pipeline.GetHashCode();
                if (this.EnterType != null) hashCode = hashCode * 59 + this.EnterType.GetHashCode();
                if (this.Search != null) hashCode = hashCode * 59 + this.Search.GetHashCode();
                if (this.DateOrder != null) hashCode = hashCode * 59 + this.DateOrder.GetHashCode();
                if (this.UsedTimeOrder != null) hashCode = hashCode * 59 + this.UsedTimeOrder.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.PageNo != null) hashCode = hashCode * 59 + this.PageNo.GetHashCode();
                if (this.PageSize != null) hashCode = hashCode * 59 + this.PageSize.GetHashCode();
                return hashCode;
            }
        }
    }
}
