using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Smn.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class AccessPolicy 
    {

        /// <summary>
        /// 访问策略规范版本。目前只支持“2016-09-07”。
        /// </summary>
        [JsonProperty("Version", NullValueHandling = NullValueHandling.Ignore)]
        public string Version { get; set; }

        /// <summary>
        /// 策略的唯一标识。不能为空。
        /// </summary>
        [JsonProperty("Id", NullValueHandling = NullValueHandling.Ignore)]
        public string Id { get; set; }

        /// <summary>
        /// 访问策略是通过Statement语句来定义的。一个访问策略可包含一条或多条Statement语句。通过Statement语句向其他用户或云服务授权对主题的操作。
        /// </summary>
        [JsonProperty("Statement", NullValueHandling = NullValueHandling.Ignore)]
        public List<Statement> Statement { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccessPolicy {\n");
            sb.Append("  version: ").Append(Version).Append("\n");
            sb.Append("  id: ").Append(Id).Append("\n");
            sb.Append("  statement: ").Append(Statement).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as AccessPolicy);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(AccessPolicy input)
        {
            if (input == null) return false;
            if (this.Version != input.Version || (this.Version != null && !this.Version.Equals(input.Version))) return false;
            if (this.Id != input.Id || (this.Id != null && !this.Id.Equals(input.Id))) return false;
            if (this.Statement != input.Statement || (this.Statement != null && input.Statement != null && !this.Statement.SequenceEqual(input.Statement))) return false;

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
                if (this.Version != null) hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Id != null) hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Statement != null) hashCode = hashCode * 59 + this.Statement.GetHashCode();
                return hashCode;
            }
        }
    }
}
