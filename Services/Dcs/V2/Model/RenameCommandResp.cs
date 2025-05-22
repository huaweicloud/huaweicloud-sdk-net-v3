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
        /// 命令hscan
        /// </summary>
        [JsonProperty("hscan", NullValueHandling = NullValueHandling.Ignore)]
        public string Hscan { get; set; }

        /// <summary>
        /// 命令scan
        /// </summary>
        [JsonProperty("scan", NullValueHandling = NullValueHandling.Ignore)]
        public string Scan { get; set; }

        /// <summary>
        /// 命令sscan
        /// </summary>
        [JsonProperty("sscan", NullValueHandling = NullValueHandling.Ignore)]
        public string Sscan { get; set; }

        /// <summary>
        /// 命令zscan
        /// </summary>
        [JsonProperty("zscan", NullValueHandling = NullValueHandling.Ignore)]
        public string Zscan { get; set; }



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
            sb.Append("  hscan: ").Append(Hscan).Append("\n");
            sb.Append("  scan: ").Append(Scan).Append("\n");
            sb.Append("  sscan: ").Append(Sscan).Append("\n");
            sb.Append("  zscan: ").Append(Zscan).Append("\n");
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
            if (input == null) return false;
            if (this.Command != input.Command || (this.Command != null && !this.Command.Equals(input.Command))) return false;
            if (this.Flushall != input.Flushall || (this.Flushall != null && !this.Flushall.Equals(input.Flushall))) return false;
            if (this.Flushdb != input.Flushdb || (this.Flushdb != null && !this.Flushdb.Equals(input.Flushdb))) return false;
            if (this.Hgetall != input.Hgetall || (this.Hgetall != null && !this.Hgetall.Equals(input.Hgetall))) return false;
            if (this.Keys != input.Keys || (this.Keys != null && !this.Keys.Equals(input.Keys))) return false;
            if (this.Hscan != input.Hscan || (this.Hscan != null && !this.Hscan.Equals(input.Hscan))) return false;
            if (this.Scan != input.Scan || (this.Scan != null && !this.Scan.Equals(input.Scan))) return false;
            if (this.Sscan != input.Sscan || (this.Sscan != null && !this.Sscan.Equals(input.Sscan))) return false;
            if (this.Zscan != input.Zscan || (this.Zscan != null && !this.Zscan.Equals(input.Zscan))) return false;

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
                if (this.Command != null) hashCode = hashCode * 59 + this.Command.GetHashCode();
                if (this.Flushall != null) hashCode = hashCode * 59 + this.Flushall.GetHashCode();
                if (this.Flushdb != null) hashCode = hashCode * 59 + this.Flushdb.GetHashCode();
                if (this.Hgetall != null) hashCode = hashCode * 59 + this.Hgetall.GetHashCode();
                if (this.Keys != null) hashCode = hashCode * 59 + this.Keys.GetHashCode();
                if (this.Hscan != null) hashCode = hashCode * 59 + this.Hscan.GetHashCode();
                if (this.Scan != null) hashCode = hashCode * 59 + this.Scan.GetHashCode();
                if (this.Sscan != null) hashCode = hashCode * 59 + this.Sscan.GetHashCode();
                if (this.Zscan != null) hashCode = hashCode * 59 + this.Zscan.GetHashCode();
                return hashCode;
            }
        }
    }
}
