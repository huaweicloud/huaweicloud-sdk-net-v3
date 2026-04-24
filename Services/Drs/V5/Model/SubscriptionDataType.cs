using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Drs.V5.Model
{
    /// <summary>
    /// 订阅的数据类型是否包含DDL/DML语句，返回值： true：是。 false：否。
    /// </summary>
    public class SubscriptionDataType 
    {

        /// <summary>
        /// 数据操作语言，取值： true：订阅DML false：不订阅DML
        /// </summary>
        [JsonProperty("is_dml_subscribed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDmlSubscribed { get; set; }

        /// <summary>
        /// 数据定义语言，取值： true：订阅DDL false：不订阅DDL
        /// </summary>
        [JsonProperty("is_ddl_subscribed", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsDdlSubscribed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubscriptionDataType {\n");
            sb.Append("  isDmlSubscribed: ").Append(IsDmlSubscribed).Append("\n");
            sb.Append("  isDdlSubscribed: ").Append(IsDdlSubscribed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubscriptionDataType);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(SubscriptionDataType input)
        {
            if (input == null) return false;
            if (this.IsDmlSubscribed != input.IsDmlSubscribed || (this.IsDmlSubscribed != null && !this.IsDmlSubscribed.Equals(input.IsDmlSubscribed))) return false;
            if (this.IsDdlSubscribed != input.IsDdlSubscribed || (this.IsDdlSubscribed != null && !this.IsDdlSubscribed.Equals(input.IsDdlSubscribed))) return false;

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
                if (this.IsDmlSubscribed != null) hashCode = hashCode * 59 + this.IsDmlSubscribed.GetHashCode();
                if (this.IsDdlSubscribed != null) hashCode = hashCode * 59 + this.IsDdlSubscribed.GetHashCode();
                return hashCode;
            }
        }
    }
}
