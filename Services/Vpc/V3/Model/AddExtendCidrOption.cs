using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Vpc.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AddExtendCidrOption 
    {

        /// <summary>
        /// 功能说明：扩展cidr列表 取值范围：不能包含以下网段，100.64.0.0/10,214.0.0.0/7,198.18.0.0/15,169.254.0.0/16,0.0.0.0/8,127.0.0.0/8,240.0.0.0/4,172.31.0.0/16,192.168.0.0/16  约束：当前只支持添加一个
        /// </summary>
        [JsonProperty("extend_cidrs", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> ExtendCidrs { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AddExtendCidrOption {\n");
            sb.Append("  extendCidrs: ").Append(ExtendCidrs).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AddExtendCidrOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AddExtendCidrOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ExtendCidrs == input.ExtendCidrs ||
                    this.ExtendCidrs != null &&
                    input.ExtendCidrs != null &&
                    this.ExtendCidrs.SequenceEqual(input.ExtendCidrs)
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
                if (this.ExtendCidrs != null)
                    hashCode = hashCode * 59 + this.ExtendCidrs.GetHashCode();
                return hashCode;
            }
        }
    }
}
