using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.CodeArtsCheck.V2.Model
{
    /// <summary>
    /// **参数解释：** 自定义参数列表checkParamList的map格式，比如含有自定义参数key为param1，值为value1，则checkParamMap含有字段param1，值为value1。
    /// </summary>
    public class TaskBasicInfoV3CheckParamMap 
    {

        /// <summary>
        /// **参数解释：** 字段的name为自定义参数的Key，字段的值为自定义参数的Value。 **取值范围：** 长度为[1~8192]个字符。
        /// </summary>
        [JsonProperty("param1", NullValueHandling = NullValueHandling.Ignore)]
        public string Param1 { get; set; }

        /// <summary>
        /// **参数解释：** 字段的name为自定义参数的Key，字段的值为自定义参数的Value。 **取值范围：** 长度为[1~8192]个字符。
        /// </summary>
        [JsonProperty("param2", NullValueHandling = NullValueHandling.Ignore)]
        public string Param2 { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskBasicInfoV3CheckParamMap {\n");
            sb.Append("  param1: ").Append(Param1).Append("\n");
            sb.Append("  param2: ").Append(Param2).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaskBasicInfoV3CheckParamMap);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(TaskBasicInfoV3CheckParamMap input)
        {
            if (input == null) return false;
            if (this.Param1 != input.Param1 || (this.Param1 != null && !this.Param1.Equals(input.Param1))) return false;
            if (this.Param2 != input.Param2 || (this.Param2 != null && !this.Param2.Equals(input.Param2))) return false;

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
                if (this.Param1 != null) hashCode = hashCode * 59 + this.Param1.GetHashCode();
                if (this.Param2 != null) hashCode = hashCode * 59 + this.Param2.GetHashCode();
                return hashCode;
            }
        }
    }
}
