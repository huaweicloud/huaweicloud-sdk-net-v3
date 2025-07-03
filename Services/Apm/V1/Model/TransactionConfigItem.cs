using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Apm.V1.Model
{
    /// <summary>
    /// URL跟踪视图配置。
    /// </summary>
    public class TransactionConfigItem 
    {

        /// <summary>
        /// 配置id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// 应用id。
        /// </summary>
        [JsonProperty("business_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? BusinessId { get; set; }

        /// <summary>
        /// 环境id。
        /// </summary>
        [JsonProperty("env_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? EnvId { get; set; }

        /// <summary>
        /// 请求方式。
        /// </summary>
        [JsonProperty("method", NullValueHandling = NullValueHandling.Ignore)]
        public string Method { get; set; }

        /// <summary>
        /// 环境名称。
        /// </summary>
        [JsonProperty("env_name", NullValueHandling = NullValueHandling.Ignore)]
        public string EnvName { get; set; }

        /// <summary>
        /// region显示英文名称。
        /// </summary>
        [JsonProperty("region", NullValueHandling = NullValueHandling.Ignore)]
        public string Region { get; set; }

        /// <summary>
        /// 类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 应用名称。
        /// </summary>
        [JsonProperty("app_name", NullValueHandling = NullValueHandling.Ignore)]
        public string AppName { get; set; }

        /// <summary>
        /// url地址。
        /// </summary>
        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionConfigItem {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  businessId: ").Append(BusinessId).Append("\n");
            sb.Append("  envId: ").Append(EnvId).Append("\n");
            sb.Append("  method: ").Append(Method).Append("\n");
            sb.Append("  envName: ").Append(EnvName).Append("\n");
            sb.Append("  region: ").Append(Region).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  appName: ").Append(AppName).Append("\n");
            sb.Append("  url: ").Append(Url).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TransactionConfigItem);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TransactionConfigItem input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.BusinessId != input.BusinessId || (this.BusinessId != null && !this.BusinessId.Equals(input.BusinessId))) return false;
            if (this.EnvId != input.EnvId || (this.EnvId != null && !this.EnvId.Equals(input.EnvId))) return false;
            if (this.Method != input.Method || (this.Method != null && !this.Method.Equals(input.Method))) return false;
            if (this.EnvName != input.EnvName || (this.EnvName != null && !this.EnvName.Equals(input.EnvName))) return false;
            if (this.Region != input.Region || (this.Region != null && !this.Region.Equals(input.Region))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.AppName != input.AppName || (this.AppName != null && !this.AppName.Equals(input.AppName))) return false;
            if (this.Url != input.Url || (this.Url != null && !this.Url.Equals(input.Url))) return false;

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
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.BusinessId != null) hashCode = hashCode * 59 + this.BusinessId.GetHashCode();
                if (this.EnvId != null) hashCode = hashCode * 59 + this.EnvId.GetHashCode();
                if (this.Method != null) hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.EnvName != null) hashCode = hashCode * 59 + this.EnvName.GetHashCode();
                if (this.Region != null) hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.AppName != null) hashCode = hashCode * 59 + this.AppName.GetHashCode();
                if (this.Url != null) hashCode = hashCode * 59 + this.Url.GetHashCode();
                return hashCode;
            }
        }
    }
}
