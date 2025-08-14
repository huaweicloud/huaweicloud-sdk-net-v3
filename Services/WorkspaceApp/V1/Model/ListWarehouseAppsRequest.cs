using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.WorkspaceApp.V1.Model
{
    /// <summary>
    /// Request Object
    /// </summary>
    public class ListWarehouseAppsRequest 
    {

        /// <summary>
        /// 单次查询的大小[1-100]，默认值10。
        /// </summary>
        [SDKProperty("limit", IsQuery = true)]
        [JsonProperty("limit", NullValueHandling = NullValueHandling.Ignore)]
        public int? Limit { get; set; }

        /// <summary>
        /// 查询的偏移量，默认值0。
        /// </summary>
        [SDKProperty("offset", IsQuery = true)]
        [JsonProperty("offset", NullValueHandling = NullValueHandling.Ignore)]
        public int? Offset { get; set; }

        /// <summary>
        /// 审核状态。
        /// </summary>
        [SDKProperty("verify_status", IsQuery = true)]
        [JsonProperty("verify_status", NullValueHandling = NullValueHandling.Ignore)]
        public string VerifyStatus { get; set; }

        /// <summary>
        /// 应用仓库中的应用记录ID。
        /// </summary>
        [SDKProperty("app_id", IsQuery = true)]
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 应用名称。
        /// </summary>
        [SDKProperty("app_name", IsQuery = true)]
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 应用分类： * &#x60;GAME&#x60;-  &#x60;游戏&#x60;。 * &#x60;BUSSINESS_INTELLIGENCE&#x60;- &#x60;商业智能&#x60;。 * &#x60;SECURE_STORAGE&#x60;-  &#x60;安全与存储&#x60;。 * &#x60;MULTIMEDIA_AND_CODING&#x60;- &#x60;多媒体与编解码&#x60;。 * &#x60;PROJECT_MANAGEMENT&#x60;- &#x60;项目管理&#x60;, * &#x60;PRODUCTIVITY_AND_COLLABORATION&#x60;-  &#x60;生产力与协作&#x60;。 * &#x60;WEB_ADN_APPLICATION&#x60;-  &#x60;网页与应用开发&#x60;。 * &#x60;GRAPHIC_DESIGN&#x60;-  &#x60;图形设计&#x60;。 * &#x60;OTHER&#x60;-  &#x60;其它&#x60;。
        /// </summary>
        [SDKProperty("app_category", IsQuery = true)]
        [JsonProperty("app_category", NullValueHandling = NullValueHandling.Ignore)]
        public string AppCategory { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ListWarehouseAppsRequest {\n");
            sb.Append("  limit: ").Append(Limit).Append("\n");
            sb.Append("  offset: ").Append(Offset).Append("\n");
            sb.Append("  verifyStatus: ").Append(VerifyStatus).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  appCategory: ").Append(AppCategory).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ListWarehouseAppsRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ListWarehouseAppsRequest input)
        {
            if (input == null) return false;
            if (this.Limit != input.Limit || (this.Limit != null && !this.Limit.Equals(input.Limit))) return false;
            if (this.Offset != input.Offset || (this.Offset != null && !this.Offset.Equals(input.Offset))) return false;
            if (this.VerifyStatus != input.VerifyStatus || (this.VerifyStatus != null && !this.VerifyStatus.Equals(input.VerifyStatus))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.AppCategory != input.AppCategory || (this.AppCategory != null && !this.AppCategory.Equals(input.AppCategory))) return false;

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
                if (this.Limit != null) hashCode = hashCode * 59 + this.Limit.GetHashCode();
                if (this.Offset != null) hashCode = hashCode * 59 + this.Offset.GetHashCode();
                if (this.VerifyStatus != null) hashCode = hashCode * 59 + this.VerifyStatus.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.AppCategory != null) hashCode = hashCode * 59 + this.AppCategory.GetHashCode();
                return hashCode;
            }
        }
    }
}
