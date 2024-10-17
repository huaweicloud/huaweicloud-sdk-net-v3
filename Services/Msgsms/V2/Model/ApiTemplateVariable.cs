using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Msgsms.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ApiTemplateVariable 
    {

        /// <summary>
        /// 变量id
        /// </summary>
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        /// <summary>
        /// 用户名
        /// </summary>
        [JsonProperty("user_name", NullValueHandling = NullValueHandling.Ignore)]
        public string UserName { get; set; }

        /// <summary>
        /// 模板名称
        /// </summary>
        [JsonProperty("temp_name", NullValueHandling = NullValueHandling.Ignore)]
        public string TempName { get; set; }

        /// <summary>
        /// 变量索引
        /// </summary>
        [JsonProperty("variable_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? VariableIndex { get; set; }

        /// <summary>
        /// 变量类型
        /// </summary>
        [JsonProperty("variable_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VariableType { get; set; }

        /// <summary>
        /// 变量长度
        /// </summary>
        [JsonProperty("variable_length", NullValueHandling = NullValueHandling.Ignore)]
        public int? VariableLength { get; set; }

        /// <summary>
        /// 变量描述
        /// </summary>
        [JsonProperty("variable_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string VariableDesc { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ApiTemplateVariable {\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  userName: ").Append(UserName).Append("\n");
            sb.Append("  tempName: ").Append(TempName).Append("\n");
            sb.Append("  variableIndex: ").Append(VariableIndex).Append("\n");
            sb.Append("  variableType: ").Append(VariableType).Append("\n");
            sb.Append("  variableLength: ").Append(VariableLength).Append("\n");
            sb.Append("  variableDesc: ").Append(VariableDesc).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ApiTemplateVariable);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ApiTemplateVariable input)
        {
            if (input == null) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.UserName != input.UserName || (this.UserName != null && !this.UserName.Equals(input.UserName))) return false;
            if (this.TempName != input.TempName || (this.TempName != null && !this.TempName.Equals(input.TempName))) return false;
            if (this.VariableIndex != input.VariableIndex || (this.VariableIndex != null && !this.VariableIndex.Equals(input.VariableIndex))) return false;
            if (this.VariableType != input.VariableType || (this.VariableType != null && !this.VariableType.Equals(input.VariableType))) return false;
            if (this.VariableLength != input.VariableLength || (this.VariableLength != null && !this.VariableLength.Equals(input.VariableLength))) return false;
            if (this.VariableDesc != input.VariableDesc || (this.VariableDesc != null && !this.VariableDesc.Equals(input.VariableDesc))) return false;

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
                if (this.UserName != null) hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.TempName != null) hashCode = hashCode * 59 + this.TempName.GetHashCode();
                if (this.VariableIndex != null) hashCode = hashCode * 59 + this.VariableIndex.GetHashCode();
                if (this.VariableType != null) hashCode = hashCode * 59 + this.VariableType.GetHashCode();
                if (this.VariableLength != null) hashCode = hashCode * 59 + this.VariableLength.GetHashCode();
                if (this.VariableDesc != null) hashCode = hashCode * 59 + this.VariableDesc.GetHashCode();
                return hashCode;
            }
        }
    }
}
