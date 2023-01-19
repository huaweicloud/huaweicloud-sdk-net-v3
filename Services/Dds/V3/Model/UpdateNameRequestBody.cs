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
    /// 
    /// </summary>
    public class UpdateNameRequestBody 
    {

        /// <summary>
        /// 新实例名称。用于表示实例的名称，允许和已有名称重复。取值范围：长度为4~64位，必须以字母开头（A~Z或a~z），区分大小写，可以包含字母、数字（0~9）、中划线（-）或者下划线（_），不能包含其他特殊字符。
        /// </summary>
        [JsonProperty("new_instance_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NewInstanceName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateNameRequestBody {\n");
            sb.Append("  newInstanceName: ").Append(NewInstanceName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateNameRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(UpdateNameRequestBody input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.NewInstanceName == input.NewInstanceName ||
                    (this.NewInstanceName != null &&
                    this.NewInstanceName.Equals(input.NewInstanceName))
                );
        }

        /// <summary>
        /// Get hash code
        /// </summary>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.NewInstanceName != null)
                    hashCode = hashCode * 59 + this.NewInstanceName.GetHashCode();
                return hashCode;
            }
        }
    }
}
