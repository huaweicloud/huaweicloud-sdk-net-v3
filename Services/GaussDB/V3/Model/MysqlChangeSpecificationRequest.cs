using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDB.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class MysqlChangeSpecificationRequest 
    {

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("resize_flavor", NullValueHandling = NullValueHandling.Ignore)]
        public MysqlResizeFlavor ResizeFlavor { get; set; }

        /// <summary>
        /// 变更包周期实例规格时可指定，表示是否自动从客户的账户中支付。  - true，为自动支付，默认该方式。 - false，为手动支付。
        /// </summary>
        [JsonProperty("is_auto_pay", NullValueHandling = NullValueHandling.Ignore)]
        public string IsAutoPay { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlChangeSpecificationRequest {\n");
            sb.Append("  resizeFlavor: ").Append(ResizeFlavor).Append("\n");
            sb.Append("  isAutoPay: ").Append(IsAutoPay).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlChangeSpecificationRequest);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlChangeSpecificationRequest input)
        {
            if (input == null) return false;
            if (this.ResizeFlavor != input.ResizeFlavor || (this.ResizeFlavor != null && !this.ResizeFlavor.Equals(input.ResizeFlavor))) return false;
            if (this.IsAutoPay != input.IsAutoPay || (this.IsAutoPay != null && !this.IsAutoPay.Equals(input.IsAutoPay))) return false;

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
                if (this.ResizeFlavor != null) hashCode = hashCode * 59 + this.ResizeFlavor.GetHashCode();
                if (this.IsAutoPay != null) hashCode = hashCode * 59 + this.IsAutoPay.GetHashCode();
                return hashCode;
            }
        }
    }
}
