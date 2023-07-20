using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Rds.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class ResizeFlavorObject 
    {

        /// <summary>
        /// 资源规格编码。例如：rds.mysql.m1.xlarge。其中，rds代表RDS产品，mysql代表数据库引擎，m1.xlarge代表性能规格，为高内存类型。带\&quot;rr\&quot;的表示只读实例规格，反之表示单实例和HA实例规格。
        /// </summary>
        [JsonProperty("spec_code", NullValueHandling = NullValueHandling.Ignore)]
        public string SpecCode { get; set; }

        /// <summary>
        /// 变更包周期实例的规格时可指定，表示是否自动从客户的账户中支付。 - true，为自动支付。 - false，为手动支付，默认该方式。
        /// </summary>
        [JsonProperty("is_auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsAutoPay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ResizeFlavorObject {\n");
            sb.Append("  specCode: ").Append(SpecCode).Append("\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as ResizeFlavorObject);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(ResizeFlavorObject input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SpecCode == input.SpecCode ||
                    (this.SpecCode != null &&
                    this.SpecCode.Equals(input.SpecCode))
                ) && 
                (
                    this.IsAutoPay == input.IsAutoPay ||
                    (this.IsAutoPay != null &&
                    this.IsAutoPay.Equals(input.IsAutoPay))
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
                if (this.SpecCode != null)
                    hashCode = hashCode * 59 + this.SpecCode.GetHashCode();
                if (this.IsAutoPay != null)
                    hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                return hashCode;
            }
        }
    }
}
