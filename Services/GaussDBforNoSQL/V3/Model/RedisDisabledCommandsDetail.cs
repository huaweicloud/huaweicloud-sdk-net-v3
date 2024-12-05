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
    public class RedisDisabledCommandsDetail 
    {

        /// <summary>
        /// key所在的DB。
        /// </summary>
        [JsonProperty("db_id", NullValueHandling = NullValueHandling.Ignore)]
        public string DbId { get; set; }

        /// <summary>
        /// key名。
        /// </summary>
        [JsonProperty("key", NullValueHandling = NullValueHandling.Ignore)]
        public string Key { get; set; }

        /// <summary>
        /// 命令列表。
        /// </summary>
        [JsonProperty("commands", NullValueHandling = NullValueHandling.Ignore)]
        public List<string> Commands { get; set; }



        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RedisDisabledCommandsDetail {\n");
            sb.Append("  dbId: ").Append(DbId).Append("\n");
            sb.Append("  key: ").Append(Key).Append("\n");
            sb.Append("  commands: ").Append(Commands).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RedisDisabledCommandsDetail);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RedisDisabledCommandsDetail input)
        {
            if (input == null) return false;
            if (this.DbId != input.DbId || (this.DbId != null && !this.DbId.Equals(input.DbId))) return false;
            if (this.Key != input.Key || (this.Key != null && !this.Key.Equals(input.Key))) return false;
            if (this.Commands != input.Commands || (this.Commands != null && input.Commands != null && !this.Commands.SequenceEqual(input.Commands))) return false;

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
                if (this.DbId != null) hashCode = hashCode * 59 + this.DbId.GetHashCode();
                if (this.Key != null) hashCode = hashCode * 59 + this.Key.GetHashCode();
                if (this.Commands != null) hashCode = hashCode * 59 + this.Commands.GetHashCode();
                return hashCode;
            }
        }
    }
}
