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
    /// 数据库检查结果
    /// </summary>
    public class DBUpgradePrecheck 
    {

        /// <summary>
        /// 检查是否通过，0代表通过，1代表未通过
        /// </summary>
        [JsonProperty("result", NullValueHandling = NullValueHandling.Ignore)]
        public int? Result { get; set; }

        /// <summary>
        /// 检查项
        /// </summary>
        [JsonProperty("checks_performed", NullValueHandling = NullValueHandling.Ignore)]
        public List<DBCheckDetail> ChecksPerformed { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DBUpgradePrecheck {\n");
            sb.Append("  result: ").Append(Result).Append("\n");
            sb.Append("  checksPerformed: ").Append(ChecksPerformed).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as DBUpgradePrecheck);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(DBUpgradePrecheck input)
        {
            if (input == null) return false;
            if (this.Result != input.Result || (this.Result != null && !this.Result.Equals(input.Result))) return false;
            if (this.ChecksPerformed != input.ChecksPerformed || (this.ChecksPerformed != null && input.ChecksPerformed != null && !this.ChecksPerformed.SequenceEqual(input.ChecksPerformed))) return false;

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
                if (this.Result != null) hashCode = hashCode * 59 + this.Result.GetHashCode();
                if (this.ChecksPerformed != null) hashCode = hashCode * 59 + this.ChecksPerformed.GetHashCode();
                return hashCode;
            }
        }
    }
}
