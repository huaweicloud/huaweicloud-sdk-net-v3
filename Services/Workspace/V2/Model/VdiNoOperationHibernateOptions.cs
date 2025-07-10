using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Workspace.V2.Model
{
    /// <summary>
    /// 不操作休眠选项。
    /// </summary>
    public class VdiNoOperationHibernateOptions 
    {

        /// <summary>
        /// 策略组ID。
        /// </summary>
        [JsonProperty("no_operation_hibernate_minutes", NullValueHandling = NullValueHandling.Ignore)]
        public int? NoOperationHibernateMinutes { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VdiNoOperationHibernateOptions {\n");
            sb.Append("  noOperationHibernateMinutes: ").Append(NoOperationHibernateMinutes).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as VdiNoOperationHibernateOptions);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(VdiNoOperationHibernateOptions input)
        {
            if (input == null) return false;
            if (this.NoOperationHibernateMinutes != input.NoOperationHibernateMinutes || (this.NoOperationHibernateMinutes != null && !this.NoOperationHibernateMinutes.Equals(input.NoOperationHibernateMinutes))) return false;

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
                if (this.NoOperationHibernateMinutes != null) hashCode = hashCode * 59 + this.NoOperationHibernateMinutes.GetHashCode();
                return hashCode;
            }
        }
    }
}
