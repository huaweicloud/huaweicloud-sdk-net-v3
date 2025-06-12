using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.MetaStudio.V1.Model
{
    /// <summary>
    /// 科大讯飞星火大模型应用配置
    /// </summary>
    public class IflytekSpark 
    {

        /// <summary>
        /// 星火大模型应用ID。
        /// </summary>
        [JsonProperty("app_id", NullValueHandling = NullValueHandling.Ignore)]
        public string AppId { get; set; }

        /// <summary>
        /// 星火大模型应用密钥。
        /// </summary>
        [JsonProperty("app_key", NullValueHandling = NullValueHandling.Ignore)]
        public string AppKey { get; set; }

        /// <summary>
        /// 星火大模型API密钥。
        /// </summary>
        [JsonProperty("api_secret", NullValueHandling = NullValueHandling.Ignore)]
        public string ApiSecret { get; set; }

        /// <summary>
        /// 是否为正式环境
        /// </summary>
        [JsonProperty("is_production", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsProduction { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IflytekSpark {\n");
            sb.Append("  appId: ").Append(AppId).Append("\n");
            sb.Append("  appKey: ").Append(AppKey).Append("\n");
            sb.Append("  apiSecret: ").Append(ApiSecret).Append("\n");
            sb.Append("  isProduction: ").Append(IsProduction).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as IflytekSpark);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(IflytekSpark input)
        {
            if (input == null) return false;
            if (this.AppId != input.AppId || (this.AppId != null && !this.AppId.Equals(input.AppId))) return false;
            if (this.AppKey != input.AppKey || (this.AppKey != null && !this.AppKey.Equals(input.AppKey))) return false;
            if (this.ApiSecret != input.ApiSecret || (this.ApiSecret != null && !this.ApiSecret.Equals(input.ApiSecret))) return false;
            if (this.IsProduction != input.IsProduction || (this.IsProduction != null && !this.IsProduction.Equals(input.IsProduction))) return false;

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
                if (this.AppId != null) hashCode = hashCode * 59 + this.AppId.GetHashCode();
                if (this.AppKey != null) hashCode = hashCode * 59 + this.AppKey.GetHashCode();
                if (this.ApiSecret != null) hashCode = hashCode * 59 + this.ApiSecret.GetHashCode();
                if (this.IsProduction != null) hashCode = hashCode * 59 + this.IsProduction.GetHashCode();
                return hashCode;
            }
        }
    }
}
