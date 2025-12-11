using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dds.V3.Model
{
    /// <summary>
    /// Response Object
    /// </summary>
    public class ValidateConfigurationNameResponse : SdkResponse
    {

        /// <summary>
        /// **参数解释：** 参数组名称是否存在。 **取值范围：** - true：参数组名称存在。 - false：参数组名称不存在。
        /// </summary>
        [JsonProperty("is_existed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsExisted { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ValidateConfigurationNameResponse {\n");
            sb.Append("  isExisted: ").Append(IsExisted).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ValidateConfigurationNameResponse);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ValidateConfigurationNameResponse input)
        {
            if (input == null) return false;
            if (this.IsExisted != input.IsExisted || (this.IsExisted != null && !this.IsExisted.Equals(input.IsExisted))) return false;

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
                if (this.IsExisted != null) hashCode = hashCode * 59 + this.IsExisted.GetHashCode();
                return hashCode;
            }
        }
    }
}
