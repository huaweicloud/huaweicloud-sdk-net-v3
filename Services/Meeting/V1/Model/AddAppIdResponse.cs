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
    /// Response Object
    /// </summary>
    public class AddAppIdResponse : SdkResponse
    {

        /// <summary>
        /// 企业应用名称
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// 企业应用ID
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 企业应用appkey
        /// </summary>
        [JsonProperty("app_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AppKey { get; set; }

        /// <summary>
        /// 企业应用描述
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 企业应用创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 最近修改时间
        /// </summary>
        [JsonProperty("last_update_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastUpdateTime { get; set; }

        /// <summary>
        /// 企业应用状态  * 0：正常  * 1：停用 
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public int? Status { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddAppIdResponse {\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  appKey: ").Append(AppKey).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lastUpdateTime: ").Append(LastUpdateTime).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddAppIdResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddAppIdResponse input)
        {
            if (input == null) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.AppKey != input.AppKey || (this.AppKey != null && !this.AppKey.Equals(input.AppKey))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.CreateTime != input.CreateTime || (this.CreateTime != null && !this.CreateTime.Equals(input.CreateTime))) return false;
            if (this.LastUpdateTime != input.LastUpdateTime || (this.LastUpdateTime != null && !this.LastUpdateTime.Equals(input.LastUpdateTime))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;

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
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.AppKey != null) hashCode = hashCode * 59 + this.AppKey.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.CreateTime != null) hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LastUpdateTime != null) hashCode = hashCode * 59 + this.LastUpdateTime.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                return hashCode;
            }
        }
    }
}
