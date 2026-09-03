using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.ModelArts.V1.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ValidateTrainingJobNameResponse : SdkResponse
    {

        /// <summary>
        /// 训练作业名称是否重复，true表示已存在，false表示不存在。
        /// </summary>
        [JsonProperty("is_duplicate", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDuplicate { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateTrainingJobNameResponse {\n");
            sb.Append("  isDuplicate: ").Append(IsDuplicate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ValidateTrainingJobNameResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ValidateTrainingJobNameResponse input)
        {
            if (input == null) return false;
            if (this.IsDuplicate != input.IsDuplicate || (this.IsDuplicate != null && !this.IsDuplicate.Equals(input.IsDuplicate))) return false;

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
                if (this.IsDuplicate != null) hashCode = hashCode * 59 + this.IsDuplicate.GetHashCode();
                return hashCode;
            }
        }
    }
}
