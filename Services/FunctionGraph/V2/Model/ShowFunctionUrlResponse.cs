using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.FunctionGraph.V2.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ShowFunctionUrlResponse : SdkResponse
    {

        /// <summary>
        /// 函数URL鉴权方式
        /// </summary>
        [JsonProperty("auth_type", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("cors", NullValueHandling = NullValueHandling.Ignore)]
        public CorsConfig Cors { get; set; }

        /// <summary>
        /// 函数URL地址
        /// </summary>
        [JsonProperty("function_url", NullValueHandling = NullValueHandling.Ignore)]
        public string FunctionUrl { get; set; }

        /// <summary>
        /// 函数URL创建时间
        /// </summary>
        [JsonProperty("create_time", NullValueHandling = NullValueHandling.Ignore)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 函数URL上次修改时间
        /// </summary>
        [JsonProperty("last_modified_time", NullValueHandling = NullValueHandling.Ignore)]
        public string LastModifiedTime { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ShowFunctionUrlResponse {\n");
            sb.Append("  authType: ").Append(AuthType).Append("\n");
            sb.Append("  cors: ").Append(Cors).Append("\n");
            sb.Append("  functionUrl: ").Append(FunctionUrl).Append("\n");
            sb.Append("  createTime: ").Append(CreateTime).Append("\n");
            sb.Append("  lastModifiedTime: ").Append(LastModifiedTime).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShowFunctionUrlResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ShowFunctionUrlResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuthType == input.AuthType ||
                    (this.AuthType != null &&
                    this.AuthType.Equals(input.AuthType))
                ) && 
                (
                    this.Cors == input.Cors ||
                    (this.Cors != null &&
                    this.Cors.Equals(input.Cors))
                ) && 
                (
                    this.FunctionUrl == input.FunctionUrl ||
                    (this.FunctionUrl != null &&
                    this.FunctionUrl.Equals(input.FunctionUrl))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.LastModifiedTime == input.LastModifiedTime ||
                    (this.LastModifiedTime != null &&
                    this.LastModifiedTime.Equals(input.LastModifiedTime))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AuthType != null)
                    hashCode = hashCode * 59 + this.AuthType.GetHashCode();
                if (this.Cors != null)
                    hashCode = hashCode * 59 + this.Cors.GetHashCode();
                if (this.FunctionUrl != null)
                    hashCode = hashCode * 59 + this.FunctionUrl.GetHashCode();
                if (this.CreateTime != null)
                    hashCode = hashCode * 59 + this.CreateTime.GetHashCode();
                if (this.LastModifiedTime != null)
                    hashCode = hashCode * 59 + this.LastModifiedTime.GetHashCode();
                return hashCode;
            }
        }
    }
}
