using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResizeInstanceOption 
    {

        /// <summary>
        /// 变更至新规格的资源规格编码。获取方法请参见查询数据库规格中响应参数“flavors.spec_code”的值。
        /// </summary>
        [JsonProperty("target_spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string TargetSpecCode { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeInstanceOption {\n");
            sb.Append("  targetSpecCode: ").Append(TargetSpecCode).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizeInstanceOption);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeInstanceOption input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TargetSpecCode == input.TargetSpecCode ||
                    (this.TargetSpecCode != null &&
                    this.TargetSpecCode.Equals(input.TargetSpecCode))
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
                if (this.TargetSpecCode != null)
                    hashCode = hashCode * 59 + this.TargetSpecCode.GetHashCode();
                return hashCode;
            }
        }
    }
}
