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
    /// 是否删除或保留自动备份请求体。
    /// </summary>
    public class DeleteBackupSelectionRequestBody 
    {

        /// <summary>
        /// 选择是否保留自动备份标志
        /// </summary>
        [JsonProperty("selection", NullValueHandling = NullValueHandling.Ignore)]
        public bool? Selection { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeleteBackupSelectionRequestBody {\n");
            sb.Append("  selection: ").Append(Selection).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DeleteBackupSelectionRequestBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DeleteBackupSelectionRequestBody input)
        {
            if (input == null) return false;
            if (this.Selection != input.Selection || (this.Selection != null && !this.Selection.Equals(input.Selection))) return false;

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
                if (this.Selection != null) hashCode = hashCode * 59 + this.Selection.GetHashCode();
                return hashCode;
            }
        }
    }
}
