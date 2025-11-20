using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Ddm.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class PreCheckResult 
    {

        /// <summary>
        /// 检查项名称。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 检查项结果。
        /// </summary>
        [JsonProperty("status", NullValueHandling = NullValueHandling.Ignore)]
        public string Status { get; set; }

        /// <summary>
        /// 检查项提示信息。
        /// </summary>
        [JsonProperty("note", NullValueHandling = NullValueHandling.Ignore)]
        public string Note { get; set; }

        /// <summary>
        /// 处理建议。
        /// </summary>
        [JsonProperty("handling_suggestion", NullValueHandling = NullValueHandling.Ignore)]
        public string HandlingSuggestion { get; set; }

        /// <summary>
        /// 错误信息。
        /// </summary>
        [JsonProperty("error_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 详细错误信息。
        /// </summary>
        [JsonProperty("error_detail_message", NullValueHandling = NullValueHandling.Ignore)]
        public string ErrorDetailMessage { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PreCheckResult {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  status: ").Append(Status).Append("\n");
            sb.Append("  note: ").Append(Note).Append("\n");
            sb.Append("  handlingSuggestion: ").Append(HandlingSuggestion).Append("\n");
            sb.Append("  errorMessage: ").Append(ErrorMessage).Append("\n");
            sb.Append("  errorDetailMessage: ").Append(ErrorDetailMessage).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as PreCheckResult);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(PreCheckResult input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Status != input.Status || (this.Status != null && !this.Status.Equals(input.Status))) return false;
            if (this.Note != input.Note || (this.Note != null && !this.Note.Equals(input.Note))) return false;
            if (this.HandlingSuggestion != input.HandlingSuggestion || (this.HandlingSuggestion != null && !this.HandlingSuggestion.Equals(input.HandlingSuggestion))) return false;
            if (this.ErrorMessage != input.ErrorMessage || (this.ErrorMessage != null && !this.ErrorMessage.Equals(input.ErrorMessage))) return false;
            if (this.ErrorDetailMessage != input.ErrorDetailMessage || (this.ErrorDetailMessage != null && !this.ErrorDetailMessage.Equals(input.ErrorDetailMessage))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Status != null) hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Note != null) hashCode = hashCode * 59 + this.Note.GetHashCode();
                if (this.HandlingSuggestion != null) hashCode = hashCode * 59 + this.HandlingSuggestion.GetHashCode();
                if (this.ErrorMessage != null) hashCode = hashCode * 59 + this.ErrorMessage.GetHashCode();
                if (this.ErrorDetailMessage != null) hashCode = hashCode * 59 + this.ErrorDetailMessage.GetHashCode();
                return hashCode;
            }
        }
    }
}
