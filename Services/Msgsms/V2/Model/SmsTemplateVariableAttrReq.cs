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
    public class SmsTemplateVariableAttrReq 
    {

        /// <summary>
        /// 变量说明，当变量类型为TEXT时，必填
        /// </summary>
        [JsonProperty("variable_desc", NullValueHandling = NullValueHandling.Ignore)]
        public string VariableDesc { get; set; }

        /// <summary>
        /// 变量索引，对应模板内容变量索引
        /// </summary>
        [JsonProperty("variable_index", NullValueHandling = NullValueHandling.Ignore)]
        public int? VariableIndex { get; set; }

        /// <summary>
        /// 变量类型，目前支持：PHONE|CHARDIGIT|DATETIME|MONEY|TEXT|NEWTEXT|LONGTEXT
        /// </summary>
        [JsonProperty("variable_type", NullValueHandling = NullValueHandling.Ignore)]
        public string VariableType { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SmsTemplateVariableAttrReq {\n");
            sb.Append("  variableDesc: ").Append(VariableDesc).Append("\n");
            sb.Append("  variableIndex: ").Append(VariableIndex).Append("\n");
            sb.Append("  variableType: ").Append(VariableType).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SmsTemplateVariableAttrReq);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SmsTemplateVariableAttrReq input)
        {
            if (input == null) return false;
            if (this.VariableDesc != input.VariableDesc || (this.VariableDesc != null && !this.VariableDesc.Equals(input.VariableDesc))) return false;
            if (this.VariableIndex != input.VariableIndex || (this.VariableIndex != null && !this.VariableIndex.Equals(input.VariableIndex))) return false;
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
                if (this.VariableDesc != null) hashCode = hashCode * 59 + this.VariableDesc.GetHashCode();
                if (this.VariableIndex != null) hashCode = hashCode * 59 + this.VariableIndex.GetHashCode();
                if (this.VariableType != null) hashCode = hashCode * 59 + this.VariableType.GetHashCode();
                return hashCode;
            }
        }
    }
}
