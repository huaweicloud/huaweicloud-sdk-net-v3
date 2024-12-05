using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.GaussDBforNoSQL.V3.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class HotKeysInfoResponseBody 
    {

        /// <summary>
        /// 热Key名。
        /// </summary>
        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        /// <summary>
        /// 热Key类型。
        /// </summary>
        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        /// <summary>
        /// 热Key命令。
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public string Command { get; set; }

        /// <summary>
        /// 热Key QPS。
        /// </summary>
        [JsonProperty("qps", NullValueHandling = NullValueHandling.Ignore)]
        public int? Qps { get; set; }

        /// <summary>
        /// 热key所在的DB。
        /// </summary>
        [JsonProperty("db_id", NullValueHandling = NullValueHandling.Ignore)]
        public int? DbId { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HotKeysInfoResponseBody {\n");
            sb.Append("  name: ").Append(Name).Append("\n");
            sb.Append("  type: ").Append(Type).Append("\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  qps: ").Append(Qps).Append("\n");
            sb.Append("  dbId: ").Append(DbId).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as HotKeysInfoResponseBody);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(HotKeysInfoResponseBody input)
        {
            if (input == null) return false;
            if (this.Name != input.Name || (this.Name != null && !this.Name.Equals(input.Name))) return false;
            if (this.Type != input.Type || (this.Type != null && !this.Type.Equals(input.Type))) return false;
            if (this.Command != input.Command || (this.Command != null && !this.Command.Equals(input.Command))) return false;
            if (this.Qps != input.Qps || (this.Qps != null && !this.Qps.Equals(input.Qps))) return false;
            if (this.DbId != input.DbId || (this.DbId != null && !this.DbId.Equals(input.DbId))) return false;

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
                if (this.Name != null) hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Type != null) hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Command != null) hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Qps != null) hashCode = hashCode * 59 + this.Qps.GetHashCode();
                if (this.DbId != null) hashCode = hashCode * 59 + this.DbId.GetHashCode();
                return hashCode;
            }
        }
    }
}
