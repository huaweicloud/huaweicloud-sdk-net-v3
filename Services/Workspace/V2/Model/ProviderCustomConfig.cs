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
    /// 供应商自定义配置，用于指定模型列表接口和认证参数。
    /// </summary>
    public class ProviderCustomConfig 
    {

        /// <summary>
        /// 模型列表接口地址，用于查询供应商远程模型。
        /// </summary>
        [JsonProperty("model_list_api", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelListApi { get; set; }

        /// <summary>
        /// 认证请求头名称。
        /// </summary>
        [JsonProperty("auth_header", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthHeader { get; set; }

        /// <summary>
        /// 认证前缀（如Bearer）。
        /// </summary>
        [JsonProperty("auth_prefix", NullValueHandling = NullValueHandling.Ignore)]
        public string AuthPrefix { get; set; }

        /// <summary>
        /// 供应商模型列表中模型ID字段名。
        /// </summary>
        [JsonProperty("model_id_field", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelIdField { get; set; }

        /// <summary>
        /// 供应商模型列表中模型名称字段名。
        /// </summary>
        [JsonProperty("model_name_field", NullValueHandling = NullValueHandling.Ignore)]
        public string ModelNameField { get; set; }

        /// <summary>
        /// 自定义HTTP请求头，调用供应商API时附加。
        /// </summary>
        [JsonProperty("headers", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Headers { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ProviderCustomConfig {\n");
            sb.Append("  modelListApi: ").Append(ModelListApi).Append("\n");
            sb.Append("  authHeader: ").Append(AuthHeader).Append("\n");
            sb.Append("  authPrefix: ").Append(AuthPrefix).Append("\n");
            sb.Append("  modelIdField: ").Append(ModelIdField).Append("\n");
            sb.Append("  modelNameField: ").Append(ModelNameField).Append("\n");
            sb.Append("  headers: ").Append(Headers).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ProviderCustomConfig);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ProviderCustomConfig input)
        {
            if (input == null) return false;
            if (this.ModelListApi != input.ModelListApi || (this.ModelListApi != null && !this.ModelListApi.Equals(input.ModelListApi))) return false;
            if (this.AuthHeader != input.AuthHeader || (this.AuthHeader != null && !this.AuthHeader.Equals(input.AuthHeader))) return false;
            if (this.AuthPrefix != input.AuthPrefix || (this.AuthPrefix != null && !this.AuthPrefix.Equals(input.AuthPrefix))) return false;
            if (this.ModelIdField != input.ModelIdField || (this.ModelIdField != null && !this.ModelIdField.Equals(input.ModelIdField))) return false;
            if (this.ModelNameField != input.ModelNameField || (this.ModelNameField != null && !this.ModelNameField.Equals(input.ModelNameField))) return false;
            if (this.Headers != input.Headers || (this.Headers != null && input.Headers != null && !this.Headers.SequenceEqual(input.Headers))) return false;

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
                if (this.ModelListApi != null) hashCode = hashCode * 59 + this.ModelListApi.GetHashCode();
                if (this.AuthHeader != null) hashCode = hashCode * 59 + this.AuthHeader.GetHashCode();
                if (this.AuthPrefix != null) hashCode = hashCode * 59 + this.AuthPrefix.GetHashCode();
                if (this.ModelIdField != null) hashCode = hashCode * 59 + this.ModelIdField.GetHashCode();
                if (this.ModelNameField != null) hashCode = hashCode * 59 + this.ModelNameField.GetHashCode();
                if (this.Headers != null) hashCode = hashCode * 59 + this.Headers.GetHashCode();
                return hashCode;
            }
        }
    }
}
