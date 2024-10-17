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
    public class RestoreTableInfoNew 
    {

        /// <summary>
        /// 旧表名
        /// </summary>
        [JsonProperty("old_name", NullValueHandling = NullValueHandling.Ignore)]
        public string OldName { get; set; }

        /// <summary>
        /// 新表名
        /// </summary>
        [JsonProperty("new_name", NullValueHandling = NullValueHandling.Ignore)]
        public string NewName { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RestoreTableInfoNew {\n");
            sb.Append("  oldName: ").Append(OldName).Append("\n");
            sb.Append("  newName: ").Append(NewName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RestoreTableInfoNew);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RestoreTableInfoNew input)
        {
            if (input == null) return false;
            if (this.OldName != input.OldName || (this.OldName != null && !this.OldName.Equals(input.OldName))) return false;
            if (this.NewName != input.NewName || (this.NewName != null && !this.NewName.Equals(input.NewName))) return false;

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
                if (this.OldName != null) hashCode = hashCode * 59 + this.OldName.GetHashCode();
                if (this.NewName != null) hashCode = hashCode * 59 + this.NewName.GetHashCode();
                return hashCode;
            }
        }
    }
}
