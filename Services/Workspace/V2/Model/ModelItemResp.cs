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
    /// 模型信息项响应（简化版）。
    /// </summary>
    public class ModelItemResp 
    {

        /// <summary>
        /// 模型id。
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 模型名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 供应商侧模型标识。
        /// </summary>
        [JsonProperty("provider_model_id", NullValueHandling = NullValueHandling.Ignore)]
        public string ProviderModelId { get; set; }

        /// <summary>
        /// 输入类型数组。
        /// </summary>
        [JsonProperty("input", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Input { get; set; }

        /// <summary>
        /// 模型描述。
        /// </summary>
        [JsonProperty("description", NullValueHandling = NullValueHandling.Ignore)]
        public string Description { get; set; }

        /// <summary>
        /// 是否为内置模型。
        /// </summary>
        [JsonProperty("is_builtin", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBuiltin { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ModelItemResp {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  providerModelId: ").Append(ProviderModelId).Append("\n");
            sb.Append("  input: ").Append(Input).Append("\n");
            sb.Append("  description: ").Append(Description).Append("\n");
            sb.Append("  isBuiltin: ").Append(IsBuiltin).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ModelItemResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ModelItemResp input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.ProviderModelId != input.ProviderModelId || (this.ProviderModelId != null && !this.ProviderModelId.Equals(input.ProviderModelId))) return false;
            if (this.Input != input.Input || (this.Input != null && input.Input != null && !this.Input.SequenceEqual(input.Input))) return false;
            if (this.Description != input.Description || (this.Description != null && !this.Description.Equals(input.Description))) return false;
            if (this.IsBuiltin != input.IsBuiltin || (this.IsBuiltin != null && !this.IsBuiltin.Equals(input.IsBuiltin))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ProviderModelId != null) hashCode = hashCode * 59 + this.ProviderModelId.GetHashCode();
                if (this.Input != null) hashCode = hashCode * 59 + this.Input.GetHashCode();
                if (this.Description != null) hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.IsBuiltin != null) hashCode = hashCode * 59 + this.IsBuiltin.GetHashCode();
                return hashCode;
            }
        }
    }
}
