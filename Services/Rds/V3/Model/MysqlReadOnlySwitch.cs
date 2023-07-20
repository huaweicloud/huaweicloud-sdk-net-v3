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
    /// 设置实例只读参数。
    /// </summary>
    public class MysqlReadOnlySwitch 
    {

        /// <summary>
        /// 是否设置为只读权限 - true，表示设置为只读权限 - false，表示解除已设置的只读权限
        /// </summary>
        [JsonProperty("readonly", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Readonly { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MysqlReadOnlySwitch {\n");
            sb.Append("  Readonly: ").Append(Readonly).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as MysqlReadOnlySwitch);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(MysqlReadOnlySwitch input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Readonly == input.Readonly ||
                    (this.Readonly != null &&
                    this.Readonly.Equals(input.Readonly))
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
                if (this.Readonly != null)
                    hashCode = hashCode * 59 + this.Readonly.GetHashCode();
                return hashCode;
            }
        }
    }
}
