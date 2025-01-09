using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 接口配置
    /// </summary>
    public class InterfacesConfig 
    {

        /// <summary>
        /// 应用平台
        /// </summary>
        [JsonProperty("apply_platform", NullValueHandling = NullValueHandling.Ignore)]
        public string ApplyPlatform { get; set; }

        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 类型
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 结果
        /// </summary>
        [JsonProperty("results", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Results { get; set; }

        /// <summary>
        /// 分页信息
        /// </summary>
        [JsonProperty("pagination", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, Object> Pagination { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("request", NullValueHandling = NullValueHandling.Ignore)]
        public InterfacesRequest Request { get; set; }

        /// <summary>
        /// 响应
        /// </summary>
        [JsonProperty("response", NullValueHandling = NullValueHandling.Ignore)]
        public string Response { get; set; }

        /// <summary>
        /// 检查结果
        /// </summary>
        [JsonProperty("result_check", NullValueHandling = NullValueHandling.Ignore)]
        public string ResultCheck { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InterfacesConfig {\n");
            sb.Append("  applyPlatform: ").Append(ApplyPlatform).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  results: ").Append(Results).Append("\n");
            sb.Append("  pagination: ").Append(Pagination).Append("\n");
            sb.Append("  request: ").Append(Request).Append("\n");
            sb.Append("  response: ").Append(Response).Append("\n");
            sb.Append("  resultCheck: ").Append(ResultCheck).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as InterfacesConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(InterfacesConfig input)
        {
            if (input == null) return false;
            if (this.ApplyPlatform != input.ApplyPlatform || (this.ApplyPlatform != null && !this.ApplyPlatform.Equals(input.ApplyPlatform))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Results != input.Results || (this.Results != null && input.Results != null && !this.Results.SequenceEqual(input.Results))) return false;
            if (this.Pagination != input.Pagination || (this.Pagination != null && input.Pagination != null && !this.Pagination.SequenceEqual(input.Pagination))) return false;
            if (this.Request != input.Request || (this.Request != null && !this.Request.Equals(input.Request))) return false;
            if (this.Response != input.Response || (this.Response != null && !this.Response.Equals(input.Response))) return false;
            if (this.ResultCheck != input.ResultCheck || (this.ResultCheck != null && !this.ResultCheck.Equals(input.ResultCheck))) return false;

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
                if (this.ApplyPlatform != null) hashCode = hashCode * 59 + this.ApplyPlatform.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Results != null) hashCode = hashCode * 59 + this.Results.GetHashCode();
                if (this.Pagination != null) hashCode = hashCode * 59 + this.Pagination.GetHashCode();
                if (this.Request != null) hashCode = hashCode * 59 + this.Request.GetHashCode();
                if (this.Response != null) hashCode = hashCode * 59 + this.Response.GetHashCode();
                if (this.ResultCheck != null) hashCode = hashCode * 59 + this.ResultCheck.GetHashCode();
                return hashCode;
            }
        }
    }
}
