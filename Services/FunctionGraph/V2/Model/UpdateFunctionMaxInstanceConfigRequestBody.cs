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
    /// 更新函数最大实例数请求体
    /// </summary>
    public class UpdateFunctionMaxInstanceConfigRequestBody 
    {

        /// <summary>
        /// 最大实例数；-1代表该函数实例数无限制，0代表该函数被禁用
        /// </summary>
        [JsonProperty("max_instance_num", NullValueHandling = NullValueHandling.Ignore)]
        public int? MaxInstanceNum { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateFunctionMaxInstanceConfigRequestBody {\n");
            sb.Append("  maxInstanceNum: ").Append(MaxInstanceNum).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateFunctionMaxInstanceConfigRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateFunctionMaxInstanceConfigRequestBody input)
        {
            if (input == null) return false;
            if (this.MaxInstanceNum != input.MaxInstanceNum || (this.MaxInstanceNum != null && !this.MaxInstanceNum.Equals(input.MaxInstanceNum))) return false;

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
                if (this.MaxInstanceNum != null) hashCode = hashCode * 59 + this.MaxInstanceNum.GetHashCode();
                return hashCode;
            }
        }
    }
}
