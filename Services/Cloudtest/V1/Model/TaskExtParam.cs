using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Cloudtest.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class TaskExtParam 
    {

        /// <summary>
        /// 是否删除
        /// </summary>
        [JsonProperty("delete", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Delete { get; set; }

        /// <summary>
        /// 参数id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 参数名称
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 是否敏感信息：true-敏感信息，false-非敏感信息
        /// </summary>
        [JsonProperty("sensitiveInfo", NullValueHandling = NullValueHandling.Ignore)]
        public bool? SensitiveInfo { get; set; }

        /// <summary>
        /// 参数值
        /// </summary>
        [JsonProperty("value", NullValueHandling = NullValueHandling.Ignore)]
        public string Value { get; set; }

        /// <summary>
        /// 参数类型
        /// </summary>
        [JsonProperty("variableType", NullValueHandling = NullValueHandling.Ignore)]
        public string VariableType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskExtParam {\n");
            sb.Append("  delete: ").Append(Delete).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  sensitiveInfo: ").Append(SensitiveInfo).Append("\n");
            sb.Append("  value: ").Append(Value).Append("\n");
            sb.Append("  variableType: ").Append(VariableType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskExtParam);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskExtParam input)
        {
            if (input == null) return false;
            if (this.Delete != input.Delete || (this.Delete != null && !this.Delete.Equals(input.Delete))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.SensitiveInfo != input.SensitiveInfo || (this.SensitiveInfo != null && !this.SensitiveInfo.Equals(input.SensitiveInfo))) return false;
            if (this.Value != input.Value || (this.Value != null && !this.Value.Equals(input.Value))) return false;
            if (this.VariableType != input.VariableType || (this.VariableType != null && !this.VariableType.Equals(input.VariableType))) return false;

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
                if (this.Delete != null) hashCode = hashCode * 59 + this.Delete.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.SensitiveInfo != null) hashCode = hashCode * 59 + this.SensitiveInfo.GetHashCode();
                if (this.Value != null) hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.VariableType != null) hashCode = hashCode * 59 + this.VariableType.GetHashCode();
                return hashCode;
            }
        }
    }
}
