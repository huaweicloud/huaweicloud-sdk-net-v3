using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Runtime.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using HuaweiCloud.SDK.Core;

namespace HuaweiCloud.SDK.Dcs.V2.Model
{
    /// <summary>
    /// 
    /// </summary>
    public class RenameCommandResp 
    {

        /// <summary>
        /// 命令command
        /// </summary>
        [JsonProperty("command", NullValueHandling = NullValueHandling.Ignore)]
        public string Command { get; set; }

        /// <summary>
        /// 命令flushall
        /// </summary>
        [JsonProperty("flushall", NullValueHandling = NullValueHandling.Ignore)]
        public string Flushall { get; set; }

        /// <summary>
        /// 命令flushdb
        /// </summary>
        [JsonProperty("flushdb", NullValueHandling = NullValueHandling.Ignore)]
        public string Flushdb { get; set; }

        /// <summary>
        /// 命令hgetall
        /// </summary>
        [JsonProperty("hgetall", NullValueHandling = NullValueHandling.Ignore)]
        public string Hgetall { get; set; }

        /// <summary>
        /// 命令keys
        /// </summary>
        [JsonProperty("keys", NullValueHandling = NullValueHandling.Ignore)]
        public string Keys { get; set; }


        /// <summary>
        /// Get the string
        /// </summary>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class RenameCommandResp {\n");
            sb.Append("  command: ").Append(Command).Append("\n");
            sb.Append("  flushall: ").Append(Flushall).Append("\n");
            sb.Append("  flushdb: ").Append(Flushdb).Append("\n");
            sb.Append("  hgetall: ").Append(Hgetall).Append("\n");
            sb.Append("  keys: ").Append(Keys).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public override bool Equals(object input)
        {
            return this.Equals(input as RenameCommandResp);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        public bool Equals(RenameCommandResp input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Command == input.Command ||
                    (this.Command != null &&
                    this.Command.Equals(input.Command))
                ) && 
                (
                    this.Flushall == input.Flushall ||
                    (this.Flushall != null &&
                    this.Flushall.Equals(input.Flushall))
                ) && 
                (
                    this.Flushdb == input.Flushdb ||
                    (this.Flushdb != null &&
                    this.Flushdb.Equals(input.Flushdb))
                ) && 
                (
                    this.Hgetall == input.Hgetall ||
                    (this.Hgetall != null &&
                    this.Hgetall.Equals(input.Hgetall))
                ) && 
                (
                    this.Keys == input.Keys ||
                    (this.Keys != null &&
                    this.Keys.Equals(input.Keys))
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
                if (this.Command != null)
                    hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Flushall != null)
                    hashCode = hashCode * 59 + this.Flushall.GetHashCode();
                if (this.Flushdb != null)
                    hashCode = hashCode * 59 + this.Flushdb.GetHashCode();
                if (this.Hgetall != null)
                    hashCode = hashCode * 59 + this.Hgetall.GetHashCode();
                if (this.Keys != null)
                    hashCode = hashCode * 59 + this.Keys.GetHashCode();
                return hashCode;
            }
        }
    }
}
