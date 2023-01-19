using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Aos.V1.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class EnableAutoRollbackPrimitiveTypeHolder 
    {

        /// <summary>
        /// 自动回滚的标识位，如果不传默认为false，即默认不开启资源栈自动回滚（自动回滚开启后，如果部署失败，则会自动回滚，并返回上一个稳定状态）
        /// </summary>
        [JsonProperty("enable_auto_rollback", NullValueHandling = NullValueHandling.Ignore)]
        public bool? EnableAutoRollback { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EnableAutoRollbackPrimitiveTypeHolder {\n");
            sb.Append("  enableAutoRollback: ").Append(EnableAutoRollback).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as EnableAutoRollbackPrimitiveTypeHolder);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(EnableAutoRollbackPrimitiveTypeHolder input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EnableAutoRollback == input.EnableAutoRollback ||
                    (this.EnableAutoRollback != null &&
                    this.EnableAutoRollback.Equals(input.EnableAutoRollback))
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
                if (this.EnableAutoRollback != null)
                    hashCode = hashCode * 59 + this.EnableAutoRollback.GetHashCode();
                return hashCode;
            }
        }
    }
}
